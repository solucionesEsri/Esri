using System;
using System.IO;
using System.Threading.Tasks;
using Northwinder.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(LocalCache))]
namespace Northwinder.Droid
{
	class LocalCache : ILocalCache
	{
		private static string DocumentsPath
		{
			get { return Environment.GetFolderPath(Environment.SpecialFolder.Personal); }
		}

		public async Task<string> LoadText(string filename)
		{
			string path = Path.Combine(DocumentsPath, filename);
			using (StreamReader sr = File.OpenText(path))
				return await sr.ReadToEndAsync();
		}

		public async void SaveText(string text, string filename)
		{
			string path = Path.Combine(DocumentsPath, filename);
			using (StreamWriter sw = File.CreateText(path))
			{
				await sw.WriteAsync(text);
			}
		}
	}
}