﻿using System.Drawing;
using System.IO;
using Application.Driver;
using Application.Helper.UserActions;
using OpenQA.Selenium;

namespace Application.Helper.Helpers
{
    public class ImageHelper : DependentActions
    {
        public void ClickOnBibliographyImage()
        {
            const string targetImagePath = Constants.ImageTemplateFilesLocations.ImageTemplatesPath + "Bibliography.png";
            Sleep(10);
            Screenshot screenshotString = ScreenshotManager.GetScreenshot();
            MemoryStream streamBitmap = new MemoryStream(screenshotString.AsByteArray);
            Bitmap sourceImage = new Bitmap(Image.FromStream(streamBitmap));
            Point coordinate = ImageSearchEngine.ImageCoordinateFinder.GetTargetImagePosition(sourceImage, targetImagePath);
            ClickByCoordinates(coordinate.X + 1, coordinate.Y + 1);
        }
    }
}
