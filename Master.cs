using System;
Using namespace Project;
public class Master
{

 public string Mastername
 {
 set;get;
 }
 public void Disply(){
	 Console.WriteLine("Enter Master Name:");
	 Mastername=Console.ReadLine();
 Console.WriteLine("Mr"+Mastername);
 }
 
 }
