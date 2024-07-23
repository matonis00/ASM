.code
ASMFuncUInt proc

;loading pixels to XMM0 and XMM1 - Pixels
movdqu XMM0, [RCX]    ;pixele 1, 2, 3, 4 =>  XMM0
movdqu XMM1, [RCX+16] ;pixele 5, 6, 7, 8 =>  XMM1

;creating mask of color to change in XMM2 - maskOfColorToChange
xor RBX, RBX		  ;clearing RBX	
mov EBX, EDX		  ;moving to EBX value of this color from EDX
rol RBX, 32			  ;shifting RBX, so now we hava it in upper 4-bajts of RBX
mov EAX , EDX		  ;moving to EAX value of this color from EDX
add RAX, RBX		  ;adding value of RBX to RAX in result we got RAX with value of desire color in both uper and lower 4-bajts
movq MM4, RAX		  ;moving our 8-bajt mask to MM4
movq2dq XMM2,MM4	  ;moving our 8-bajt mask from MM4 to lower 8-bajts XMM2
movq2dq XMM3,MM4      ;moving our 8-bajt mask form MM4 to lower 8-bajts XMM3
pslldq XMM2, 8        ;shifting XMM2, so now we hava it in upper 8-bajts of XMM2
PADDQ XMM2,XMM3		  ;adding value of XMM3 to XMM2 in result we got XMM2 with value of desire color in both uper and lower 8-bajts

;creating mask of color to set in XMM3 - maskOfColorToSet
xor RBX, RBX		  ;clearing RBX	
mov EBX, R8D		  ;moving to EBX value of this color from R8D
rol RBX, 32			  ;shifting RBX, so now we hava it in upper 4-bajts of RBX
mov EAX , R8D		  ;moving to EAX value of this color from R8D
add RAX, RBX		  ;adding value of RBX to RAX in result we got RAX with value of desire color in both uper and lower 4-bajts
movq MM4, RAX	 	  ;moving our 8-bajt mask to MM4
movq2dq XMM3,MM4	  ;moving our 8-bajt mask from MM4 to lower 8-bajts XMM3
movq2dq XMM4,MM4	  ;moving our 8-bajt mask form MM4 to lower 8-bajts XMM4
pslldq XMM3, 8		  ;shifting XMM3, so now we hava it in upper 8-bajts of XMM3
PADDQ XMM3,XMM4  	  ;adding value of XMM4 to XMM3 in result we got XMM3 with value of desire color in both uper and lower 8-bajts

;operation of checking the color and changing it if it match the chosen one
movupd XMM4, XMM0	  ;moving value of first four pixels to XMM4
pcmpeqd  XMM4, XMM2	  ;comparing value of XMM4(Pixels) with XMM2(maskOfColorToChange) in result XMM4 now we have in each 8bajts FFFFFFFF if it match the mask, 00000000 if it didn't
movupd XMM5, XMM4	  ;moving result of comparison to XMM5
andpd XMM4, XMM3	  ;execute logigal AND on XMM4 and XMM3 in result 8bajts colors that match maskOfColorToChange(was FFFFFFFF) was set to color from maskOfColorToSet
andnpd XMM5,XMM0      ;execute logigal NOTAND on XMM5 and XMM0 in result 8bajts colors that not match maskOfColorToChange(was 00000000) was set to color from before(Pixels)
paddq XMM4, XMM5      ;adding both resutls from XMM4 and XMM5 in restult getting 4 pixels with changed corectly colors
movupd XMM0, XMM4     ;moving value of first four pixels back to XMM0

;operation of checking the color and changing it if it match the chosen one
movupd XMM4, XMM1	  ;moving value of last four pixels to XMM4
pcmpeqd  XMM4, XMM2	  ;comparing value of XMM4(Pixels) with XMM2(maskOfColorToChange) in result XMM4 now we have in each 8bajts FFFFFFFF if it match the mask, 00000000 if it didn't
movupd XMM5, XMM4	  ;moving result of comparison to XMM5
andpd XMM4, XMM3	  ;execute logigal AND on XMM4 and XMM3 in result 8bajts colors that match maskOfColorToChange(was FFFFFFFF) was set to color from maskOfColorToSet
andnpd XMM5,XMM1 	  ;execute logigal NOTAND on XMM5 and XMM1 in result 8bajts colors that not match maskOfColorToChange(was 00000000) was set to color from before(Pixels)
paddq XMM4, XMM5	  ;adding both resutls from XMM4 and XMM5 in restult getting 4 pixels with changed corectly colors
movupd XMM1, XMM4	  ;moving value of last four pixels back to XMM1

;saving restuls back to memory/array
movdqu [RCX], XMM0     ;pixele 1, 2, 3, 4 from XMM0 =>  memory/array[0-3]
movdqu [RCX+16] ,XMM1  ;pixele 5, 6, 7, 8 from XMM1 =>  memory/array[4-7]
ret
ASMFuncUInt endp

end