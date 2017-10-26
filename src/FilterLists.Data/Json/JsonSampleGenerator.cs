﻿using System;
using System.Diagnostics;
using System.IO;
using FilterLists.Data.Models.Implementations;
using Newtonsoft.Json.Linq;

namespace FilterLists.Data.Json
{
    public static class JsonSampleGenerator
    {
        [Conditional("DEBUG")]
        public static void WriteSampleToFile()
        {
            File.WriteAllText(
                Path.GetFullPath(Path.Combine(AppContext.BaseDirectory + @"\", @"..\..\..\..\..\data\")) +
                "ListSample.json", GetSampleList().ToString());
        }

        private static JObject GetSampleList()
        {
            return (JObject) JToken.FromObject(new FilterList
            {
                Author = "John Doe",
                Description = "A sample list to filter out advertisements.",
                DescriptionSourceUrl = "https://mysample.list",
                DonateUrl = "https://mysample.list/donate/",
                Email = "contact@mysample.list",
                ForumUrl = "https://mysample.list/forum/",
                HomeUrl = "https://mysample.list/",
                IssuesUrl = "https://github.com/mysamplelist/issues",
                Name = "My Sample Filter List",
                ViewUrl = "https://mysample.list/list.txt"
            });
        }
    }
}