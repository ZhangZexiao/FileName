using System.Linq;
namespace FileName
{
	class Program
	{
		[System.STAThread]
		static void Main(string[]args)
		{
			System.Windows.Clipboard.SetText(System.IO.Path.GetInvalidFileNameChars().Aggregate(args[0],(fileName,invalidChar)=>fileName.Replace(invalidChar,'-')));
		}
	}
}
