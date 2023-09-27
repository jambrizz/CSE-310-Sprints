using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

public class Company
{
	//private string _menu = "MenuFeature.txt";
	private List<string> employees = new List<string>();
	public void runCompanyApp()
	{
        //string path = _menu;
		string path = "\\MenuFeature.txt";
		string[] lines = File.ReadAllLines(path);
		foreach (string line in lines)
		{
			Console.WriteLine(line);
		}
    }
}
