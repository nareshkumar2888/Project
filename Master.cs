using System;
Using namespace Project;
public class Master
{

 public string Mastername
 {
 set;get;
 }
<<<<<<< HEAD
 public String Designation{
=======
  public String Designation{
>>>>>>> Decorate_Name
	 set;get;
 }
 public void Disply(){
	 Console.WriteLine("Enter Master Name:");
	 Mastername=Console.ReadLine();
 Console.WriteLine("Mr"+Mastername);
<<<<<<< HEAD
 Console.WriteLine("Enter Your Designation:");
=======
  Console.WriteLine("Enter Your Designation:");
>>>>>>> Decorate_Name
Designation=Console.ReadLine();
Console.WriteLine(Mastername,Designation);
 }
 
 }
