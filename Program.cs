
using Processor.Inheritance;
using Processor.Interfaces;

//#1 WITH INHERITANCE
var upperCase = new UpCase();
var lowerCase = new DownCase();
var spitter = new SplitterMark();

var swap = new Processor.Inheritance.StringSwapper();
var adapter = new Processor.Inheritance.ProcessorAdapter(swap);

Tester.Process(upperCase, "king");
Tester.Process(lowerCase, "KING");
Tester.Process(spitter, "two kings");
Tester.Process(adapter, "amama");


//# 2 WITH INTERFACE
var upperCaseString = new StringUpCase();
var lowerCaseeString = new StringDownCase();
var spittereString = new StringSplitterMark();

IStringSwapper swap2 = new Processor.Interfaces.StringSwapper();
var adpater2 = new Processor.Interfaces.ProcessorAdapter(swap2);

Tester2.Process(upperCaseString, "king");
Tester2.Process(lowerCaseeString, "KING");
Tester2.Process(spittereString, "two kings");
Tester2.Process(adpater2, "Ahalan");

