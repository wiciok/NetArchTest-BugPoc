# NetArchTest-BugPof
Proof-of-concept of bug in NetArchTest library

https://github.com/BenMorris/NetArchTest

## How to run

- dotnet test NetArchTest-bug.sln
or
- run all tests from VisualStudio

Two tests should fail.
Then, please uncomment line in class Z, which should cause one test to pass.
