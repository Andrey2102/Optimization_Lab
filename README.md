# Optimization_Lab

# Lab 5 Optimization of memory

# Task code without optimization:

![Task](https://github.com/Andrey2102/Optimization_Lab/blob/main/Task.PNG)

# Task code after first optimization:

![Opt1](https://github.com/Andrey2102/Optimization_Lab/blob/main/opt1.PNG)

Why the work sped up: the program did not execute the nested loop twice, but completed all the tasks in one.

# Task code after second optimization:

![Opt2](https://github.com/Andrey2102/Optimization_Lab/blob/main/opt2.PNG)

Why the work sped up: On my architecture, matrix traversal by columns, in most cases, is slower than by rows.

# Results

![Res](https://github.com/Andrey2102/Optimization_Lab/blob/main/Result.PNG)
