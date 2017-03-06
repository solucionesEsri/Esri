using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using Northwinder.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(LocalCache))]
namespace Northwinder.Droid
{
    public class LocalCache : ILocalCache
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
            using (StreamWriter sw = File.CreateText(path)) {
                await sw.WriteAsync(text);
            }
        }
    }
}