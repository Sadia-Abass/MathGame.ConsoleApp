using MathGame.ConsoleApp;
using System.ComponentModel.Design;
using static System.Formats.Asn1.AsnWriter;

var menu = new Menu();
var date = DateTime.UtcNow;

List<string> games = new List<string>();

string name = Helpers.GetName();

menu.ShowMenu(name, date);

