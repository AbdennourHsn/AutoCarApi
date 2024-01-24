using System;
using Microsoft.AspNetCore.Mvc;

namespace api.Interfaces
{
	public interface IStorageService
	{
		string SaveFile();
        FileStreamResult GetFile(string name);
    }
}

