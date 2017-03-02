using System;
using System.Threading.Tasks;

namespace Northwinder
{
	public interface ILocalCache
	{
		Task<string> LoadText(string filename);
		void SaveText(string text, string filename);
	}
}
