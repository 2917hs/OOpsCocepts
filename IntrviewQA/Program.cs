// See https://aka.ms/new-console-template for more information
using IntrviewQA;

Console.WriteLine("Hello, World!");

PrivateConstructor privateConstructor = new PrivateConstructor();
//private memebers are not accesible
//privateConstructor.age = 10;
privateConstructor.name = "Hasan";

BaseClass bc = new BaseClass();
bc.ChildClass1Method();

//will not be called because we made it new, so try creating object of ChildClass2
BaseClass cc1 = new ChildClass1();
cc1.ChildClass1Method();
ChildClass1 cc1New = new ChildClass1();
cc1New.ChildClass1Method();

BaseClass cc2 = new ChildClass2();
cc2.ChildClass1Method();

RefAndOut ro = new RefAndOut();
//value assignment before the call is mandatory for ref
int age = 5;
string name = "siddiqui";
ro.RefMethod(ref age, out name);
System.Console.WriteLine($"ref age {age} - {name}");
name = "siddiqui";
ro.OutMethod(out age, ref name);
System.Console.WriteLine($"out age {age} - {name}");

ConstReadonlyStatic crs = new ConstReadonlyStatic();
crs.SetVariables();

