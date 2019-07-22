# BXFinAssessment
Brilliance technology group Web Developer coding assessment
[About Test]
 Overview
o Implement the following RESTful endpoints.
o Submit
 Your GitHub
 Or any public cloud storage or zip and email

 Technical Environment
o Asp.NET Core / Or Asp.NET Web API
o Visual Studio 2017 compatible
 Assessment Point
o Precise Input &amp; Output
o Efficient C# Array data manipulation
o Try to finish under 1 hour (Max 2 hours)
 Coding Guide
o No unit-testing / No documentation
o Apply simple structure with
 ArrayCalcController
 IProductService / ProductService

[Questions]
 Question 1
o Browser Input
/api/arraycalc/reverse?productIds=1&amp;productIds=2&amp;productIds=3&amp;productIds=4&amp;prod
uctIds=5
o Browser Result
[5,4,3,2,1]
o Condition
 Implement with pure array manipulation
 Don’t use Array.reverse() method
 Don’t use Linq

 Question 2
o Browser Input
/api/arraycalc/deletepart?position=3&amp;productIds=1&amp;productIds=2&amp;productIds=3&amp;prod
uctIds=4&amp;productIds=5
o Browser Result
[1,2,4,5]
o Condition
 Implement with pure array manipulation
 Don’t use RemoveAt
 Don’t use Linq
