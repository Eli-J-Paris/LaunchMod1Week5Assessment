# Mod 1 Week 5 Assessment

## Questions (10 Points Possible)
1. What would happen if you try to use a variable that is not in scope?
  You would get an error message. The variable defined outside of a certain scope is only known within that scope and is not known about else where.
2. Describe the three As of a test:  
A -   Arange: Is all about getting your variables and objects of a class set up for the test
A -   Act: Is what you are doing to those variables and objects. E.g Running a method that you are testing for that specific test.
A -   Assert: Is the act of checking what is expected and what is actually provided from the "Act" step.

3. What is the difference between `public` and `private` access modifiers?
Public: Means that the code can be accessed and manipulated outside of the class.
Private: Means that the code can only be manipulated inside of the class.

4. A method should:  (**Select all that apply**) <br/>
(A) Make changes to an object  
(B) Return some information about an object  
(C) Make changes to an object and return information about the object.  
(D) None of the Above. 

(A),(B),&(C): 


5. How did you determine what to answer for the question above?

A Method has two main patterns Command and Query. A method that follows the command pattern will change information about an object. While a method that follows the query pattern will "request" information that the method can provide.


## Exercise (10 Points Possible)

Clone your forked copy of this repository into Visual Studio.  

In this solution, there is a User project with a single User class.  The class works, but it needs some additional effort to be great! One thing that is missing is tests; your job is to write the tests that will confirm the functionality of the class. Write one test for the constructor, and at least one test for each of the other 4 methods. As you write the tests, you might find some refactoring opportunities; update the user class with any refactors you deem necessary and add a comment describing why you made that refactor.  The only rule is that all the existing methods must still exist when you are finished!


## Submission

When finished:
* Commit your changes in Visual Studio
* Push up to GitHub
* DM a link to your forked repository to your instructors
