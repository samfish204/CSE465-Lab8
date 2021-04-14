

check: check-delegates check-parameters

check-delegates: delegates.output
	cmp delegates.output delegates.expected 

check-parameters: parameters.output
	cmp parameters.output parameters.expected

delegates.output: delegates.exe 
	mono delegates.exe < delegates.input > delegates.output

parameters.output: parameters.exe 
	mono delegates.exe < delegates.input > delegates.output

%.exe : %.cs
	csc $*.cs