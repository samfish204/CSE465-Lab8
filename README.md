# Lab 9

**Topics:**
 - Parameter passing in C# (`ref`, `out`)
 - Delegates

## Description
- Complete the implementation of `parameters.cs` so that the output matches the expected results. This will invove specifing the parameter passing modes in a few places. 
- Complete the implementation of `delegates.cs` so that the output matches the expected results. This will involve implementing a `Map` function in C#, ad `FoldLeft` function, and it will involve using _Multicast_ delegates to process a list of numbers. 

## Checking Your Results
You can check your results by typing 
```
make check
```
You can check individual parts by typing
```
make check-parameters
```
or
```
make check-delegates
```

You can see the output of a program by typing
```
make delegates.output
icdiff delegates.output delegates.expected
``` 
> NOTE:  This will require you have already installed icdiff
>  ```
>  apt update 
>  apt install icdiff
>  ```
>

# Submitting
1. Make sure you are up to date with the master branch of instructor repository
   ```
   git pull  https://gitlab.csi.miamioh.edu/cse465/instructor/lab-09.git master
   ```
2. Make sure you pass the checks
   ```
   make check
   ```
3. Make sure you have committed and pushed your latest local changes
   ```
   git add -u
   git commit -m "Final submission"
   git push
   ```
4. Submit the URL of you repository to canvas
