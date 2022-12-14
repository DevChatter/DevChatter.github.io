using Statiq.YouTube;
const string keyName = "GOOGLEAPIKEY";
string value = "";

await Bootstrapper
  .Factory
  .CreateWeb(args)
  // .BuildPipeline("YouTube", builder =>
  // {
  //    var configApiKey = Config.FromSetting<string>(keyName).ThrowIfNull(keyName);
  //    builder.WithInputConfig(configApiKey);
  //    string apiKey = builder.Settings[keyName]?.ToString() ?? "";

  //    builder.WithProcessModules();

  //    var readYouTube = new ReadYouTube(apiKey)
  //        .WithRequest(apiKey,
  //            (_, service) => service.Videos.List("title,description,url"));

  //    builder.WithInputModules(readYouTube);
  //    builder.WithOutputWriteFiles();
  // })
  .RunAsync();
