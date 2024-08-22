﻿using GameZone.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameZone.ViewModels
{
    public class CreateGameFormViewModel : GameFormViewModel
    {


        

        [AllowedExtensions(FileSettings.AllowedExtensions),
          MaxFileSize(FileSettings.MaxFileSizeInBytes)]
        public IFormFile Cover { get; set; } = default!;
    }
}
