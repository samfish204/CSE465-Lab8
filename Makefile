
check: check-delegates check-parameters
	@echo Success

check-delegates: delegates.output
	cmp delegates.output delegates.expected 

check-parameters: parameters.output
	cmp parameters.output parameters.expected

%.output: %.exe 
	mono $*.exe < $*.input > $*.output

%.exe : %.cs
	csc $*.cs

update:
 	git pull https://gitlab.csi.miamioh.edu/cse465/instructor/lab-09 master
