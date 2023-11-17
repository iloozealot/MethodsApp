

using Methods;

//for (int i = 0; i < 10; i++)
//{
//    SampleMethods.SayHi();
//}

//DRY - Don't Repeat Yourself
//SOLID - SRP - Single Responsibility Principle "Something should do one thing."


//string name = SampleMethods.GetUsersName();

//SampleMethods.SayHi(name);

//double result = MathShortcuts.Add(5, 3);
//Console.WriteLine($"The result is { result }");

//double[] vals = new double[] { 2, 5, 6, 21, 52, 98 };
//MathShortcuts.AddAll(vals);

//SampleMethods.SayGoodbye();

// Discard Character (_)
(string firstName, _) = SampleMethods.GetFullName();

Console.WriteLine($"First Name: {firstName}");
//Console.WriteLine($"Last Name: {lastName}");

//string ageText = "33";
//bool isValidAge = int.TryParse(ageText, out int age);