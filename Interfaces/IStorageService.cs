﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace api.Interfaces
{
	public interface IStorageService
	{
        Task<string> SaveFile(IFormFile file);
        FileStreamResult GetFile(string name);
    }
}

