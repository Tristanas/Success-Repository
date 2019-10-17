# About:
This is a repository, which consists code written during the examination.
Within an hour I was able to come up with a simple and not very efficient solution.
Might be a good idea to solve the problems with this project in the future.

## Task
Take 2 arguments, that signify the start and the end of an interval. Print all primary numbers that are in the interval.
Solve the problem in an OOP manner.

## Problems with the project:

### The algorithm is inefficient
There are 3 solutions to the problem: 
 * Eratostenes sieve, 
 * Generating a list of prime numbers and checking bigger numbers based on it,
 * Checking each number by dividing it with 2 and odd numbers, smaller (or equal) than the square root of the tested number.

I used the last one and tested the number with odd numbers that are smaller than the number, but not its square root. I should calculate first, which algorithm would be more efficient and then use the one that was the best.

### Flawed project and file naming
The names of projects and files may not fit their purpose and content. Also they can be shortened without reducing the meaningfulness.

### Lots of code in the Program class
Usually the Program class should include only the operations, which are required to start a program. I put half of the logic in it. Not very object-oriented.

