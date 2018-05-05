﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
            app.Tap(x => x.Marked("TransalateButton"));
            app.WaitForElement(c => c.Text("hello"), timeout: TimeSpan.FromSeconds(30), timeoutMessage: "Please try again...");
            app.Tap(x => x.Button("ok"));
            app.Back();
        }
    }
}

