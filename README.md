Mettle
=======

Mettle is a firmware debug tool that will show the inner workings of your Arduino or any other micro controller project. There are tools to display analog values, Digital state, State machine operation with real time updates and a way to display model specific messages.

No longer are your debug messages just dumped to a terminal with no organization or structure.
The firmware still sends debug messages in plain human readable text. It can send any text you want at any time. But when you want to display a value, state etc you put it in a tag. 

A tag consists of a beginning character, '>' A module name, a comma, a tag name, another comma, data, then an ending character, '<'. 

An example is; <br>
 \>Modulename,Tagname,TagData<

or better; <br>
 \>Main System, BodyTemp,986< 

Note that all numbers are integers

This is the test/demo app for the Mettle Lib where all the custom control code is

To use Mettle;
1. copy Mettlelib into your project.
2. Add a reference to it.
3. add a using MettleLib statement to your form
4. Call open in response to the user electing start in your application
