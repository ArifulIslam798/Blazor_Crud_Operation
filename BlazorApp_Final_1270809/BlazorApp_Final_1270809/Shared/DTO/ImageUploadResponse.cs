﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp_Final_1270809.Shared.DTO
{
    public class ImageUploadResponse
    {
        public string FileName { get; set; } = default!;
        public string StoredFileName { get; set; } = default!;
    }
}
