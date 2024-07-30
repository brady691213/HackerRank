using System.Diagnostics;
using ConsoleApp1;
using Shouldly;

List<int> nums = [1, 2, 2, 3, 4, 5, 6];

var expected = Tests.ReadIntList(@"C:\Users\brady\projects\JavaScriptCourses\ConsoleApp1\test\output\output00.txt");

var input = Tests.ReadIntList(@"C:\Users\brady\projects\JavaScriptCourses\ConsoleApp1\test\input\input00.txt", true);
var actual = Funcs.FreqArray(input);

actual.ShouldBe(expected);
