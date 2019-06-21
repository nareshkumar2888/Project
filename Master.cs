using System;
Using namespace Project;
public class Master
{

 public string Mastername
 {
 set;get;
 }
  public String Designation{
	 set;get;
 }
 public void Disply(){
	 Console.WriteLine("Enter Master Name:");
	 Mastername=Console.ReadLine();
 Console.WriteLine("Mr"+Mastername);
  Console.WriteLine("Enter Your Designation:");
Designation=Console.ReadLine();
Console.WriteLine(Mastername,Designation);
 }
 
 }
