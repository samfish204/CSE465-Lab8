

check: check-delegates check-parameters

check-delegates: delegates.output
	cmp delegates.output delegates.expected 

check-parameters: parameters.output
	cmp parameters.output parameters.expected

%.output: %.exe 
	mono $*.exe < $*.input > $*.output

%.exe : %.cs
	csc $*.cs