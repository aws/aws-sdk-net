using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace SDKDocGenerator
{
    public class ExampleMetadataParser
    {
        private const string FragmentOutputDirectory = "ExampleFragments";
        private const string BaseCodeLibraryUrl = "https://docs.aws.amazon.com/code-library/latest/ug/dotnet_4";        
        public static string ExampleFragmentsFullPath { get; private set; } = string.Empty;        

        public static void GenerateExampleFragments(string examplesMetaJsonFile)
        {
            string tempPath = Path.GetTempPath();
            ExampleFragmentsFullPath = Path.Combine(tempPath, $"{FragmentOutputDirectory}-{Guid.NewGuid().ToString()}");
            
            try
            {
                if (!File.Exists(examplesMetaJsonFile))
                {                    
                    throw new Exception($"Example metadata file not found at {examplesMetaJsonFile}.");
                }

                Directory.CreateDirectory(ExampleFragmentsFullPath);
                Console.WriteLine($"Created temporary directory for example fragments: {ExampleFragmentsFullPath}");

                Console.WriteLine($"Reading example metadata from {examplesMetaJsonFile}");

                var jsonOptions = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
                    PropertyNameCaseInsensitive = true
                };

                ExampleMeta meta;
                using (var stream = File.OpenRead(examplesMetaJsonFile))
                {
                    meta = JsonSerializer.Deserialize<ExampleMeta>(stream, jsonOptions);
                }

                VerifyExampleMetaData(meta);

                (var examplesBySdkId, var serviceNameBySdkIdLookup) = ParseExamples(meta);
                WriteFragments(examplesBySdkId, serviceNameBySdkIdLookup, ExampleFragmentsFullPath, meta);
            }
            catch (Exception ex)
            {
                // If anything goes wrong creating example fragments do not allow the doc generation to
                // fail. Clean up the example fragments temporary directory and write out a file
                // indicating that Code Example generation failed. This will allow the calling system
                // to process the failure without the doc generation failing. This is the desired output
                // because any errors in the example_meta.json file must be corrected by the owners of
                // the file.
                Console.WriteLine($"Continuing without examples. Failed to generate example fragments: {ex.Message}");
                File.WriteAllText("examples_failure.txt", $"Failed to generate example fragments: {ex}");
                CleanupExampleFragments();
            }            
        }

        private static void VerifyExampleMetaData(ExampleMeta meta)
        {
            if (meta == null)
            {
                throw new Exception("Failed to parse example metadata.");
            }

            if (meta.Examples == null || meta.Examples.Count == 0)
            {
                throw new Exception("Examples could not be found.");
            }

            if (meta.Services == null || meta.Services.Count == 0)
            {
                throw new Exception("Example services could not be found.");
            }
        }

        private static (Dictionary<string, List<ExampleDoc>>, Dictionary<string, string>) ParseExamples(ExampleMeta meta)
        {
            var examplesBySdkId = new Dictionary<string, List<ExampleDoc>>();
            var serviceNameBySdkIdLookup = new Dictionary<string, string>();

            foreach (var example in meta.Examples.Values)
            {
                if (!IsDotNetExample(example))
                    continue;

                foreach (var serviceName in example.Services.Keys)
                {
                    var sdkId = meta.GetSdkId(serviceName);
                    if (string.IsNullOrEmpty(sdkId))
                        continue;

                    var sanitizedSdkId = SanitizeStringForClassName(sdkId);

                    if (!example.DocFilenames.ServicePages.TryGetValue(serviceName, out var link))
                        continue;

                    var exampleDoc = new ExampleDoc
                    {
                        SdkId = sanitizedSdkId,
                        Category = example.Category ?? "Other",
                        Title = SanitizeTitle(example.Title),
                        Link = link
                    };

                    if (!examplesBySdkId.ContainsKey(sanitizedSdkId))
                        examplesBySdkId[sanitizedSdkId] = new List<ExampleDoc>();

                    examplesBySdkId[sanitizedSdkId].Add(exampleDoc);

                    if(!serviceNameBySdkIdLookup.ContainsKey(sanitizedSdkId))
                    {
                        serviceNameBySdkIdLookup[sanitizedSdkId] = serviceName;
                    }
                }
            }

            return (examplesBySdkId, serviceNameBySdkIdLookup);
        }

        private static bool IsDotNetExample(Example example)
        {

            return example.Languages.Values.Any(lang =>
                lang.Name.Equals(".NET", StringComparison.OrdinalIgnoreCase) ||
                lang.Name.Equals("C#", StringComparison.OrdinalIgnoreCase) ||
                lang.Name.Equals("CSharp", StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Capitalizes the first character of a string, used to create proper naming for services, attributes, and operations
        /// </summary>
        public static string ToUpperFirstCharacter(string s)
        {
            var txt = s.Substring(0, 1).ToUpperInvariant();
            if (s.Length > 1)
                txt += s.Substring(1);
            return txt;
        }

        public static string SanitizeStringForClassName(string name)
        {
            if (null == name)
                return null;

            string className = name;
            className = className.Replace("AWS", "");
            className = className.Replace("Amazon", "");

            // concatenate all the words by removing whitespace.
            className = System.Text.RegularExpressions.Regex.Replace(className, @"[^a-zA-Z0-9]", "");

            return ToUpperFirstCharacter(className);
        }


        private static string SanitizeTitle(string title)
        {
            return title.Replace("<code>", "").Replace("</code>", "");
        }

        private static void WriteFragments(Dictionary<string, List<ExampleDoc>> examplesBySdkId,
            Dictionary<string, string> serviceNameBySdkIdLookup,
            string fragmentDir, ExampleMeta meta)
        {
            foreach (var kvp in examplesBySdkId)
            {
                var sdkId = kvp.Key;
                var examples = kvp.Value;
                var serviceName = serviceNameBySdkIdLookup[sdkId];

                var fragmentPath = Path.Combine(fragmentDir, $"{sdkId}.fragment.html");

                using (var writer = new StreamWriter(fragmentPath))
                {
                    WriteServiceExamples(writer, sdkId, serviceName, examples, meta);
                }

                Console.WriteLine($"Wrote {examples.Count} examples for {sdkId}");
            }
        }

        public static void CleanupExampleFragments()
        {
            if (!string.IsNullOrEmpty(ExampleFragmentsFullPath) && Directory.Exists(ExampleFragmentsFullPath))
            {
                try
                {
                    Directory.Delete(ExampleFragmentsFullPath, true);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Could not delete the {ExampleFragmentsFullPath} directory to clean up the [ServiceName].fragment.html files. Message={ex.Message}");
                }
            }
        }

        private static void WriteServiceExamples(StreamWriter writer, string sdkId, string serviceName,
            List<ExampleDoc> examples, ExampleMeta meta)
        {
            var rootLink = $"{BaseCodeLibraryUrl}_{serviceName}_code_examples.html";

            writer.WriteLine("<div>");
            writer.WriteLine($"<p class=\"paragraph\">Explore code examples in the <a href=\"{rootLink}\" target=\"_blank\">AWS SDK Code Examples Code Library</a>.</p>");

            var categorizedExamples = examples.GroupBy(e => e.Category).ToList();

            var singleExamples = categorizedExamples
                .Where(g => g.Count() == 1)
                .SelectMany(g => g)
                .ToList();

            if (singleExamples.Any())
            {
                writer.WriteLine("<ul>");
                foreach (var example in singleExamples.OrderBy(e => e.Title))
                {
                    writer.WriteLine($"<li><p class=\"paragraph\"><a href=\"{example.Link}\" target=\"_blank\">{example.Title}</a></p></li>");
                }
                writer.WriteLine("</ul>");
            }

            foreach (var category in categorizedExamples.Where(g => g.Count() > 1))
            {
                writer.WriteLine($"<h3 class=\"\">{category.Key}</h3>");
                writer.WriteLine("<ul>");
                foreach (var example in category.OrderBy(e => e.Title))
                {
                    writer.WriteLine($"<li><p class=\"paragraph\"><a href=\"{example.Link}\" target=\"_blank\">{example.Title}</a></p></li>");
                }
                writer.WriteLine("</ul>");
            }

            writer.WriteLine("</div>");
        }
    }

    public class ExampleMeta
    {
        [JsonPropertyName("services")]
        public Dictionary<string, Service> Services { get; set; }

        [JsonPropertyName("examples")]
        public Dictionary<string, Example> Examples { get; set; }

        public string GetSdkId(string serviceName)
        {
            return Services.TryGetValue(serviceName, out var service) ? service.SdkId : null;
        }
    }

    public class Service
    {
        [JsonPropertyName("sdk_id")]
        public string SdkId { get; set; }
    }

    public class Example
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("languages")]
        public Dictionary<string, Language> Languages { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("services")]
        public Dictionary<string, ExampleService> Services { get; set; }

        [JsonPropertyName("doc_filenames")]
        public DocFilenames DocFilenames { get; set; }
    }

    public class Language
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("versions")]
        public List<LanguageVersion> Versions { get; set; }
    }

    public class LanguageVersion
    {
        [JsonPropertyName("sdk_version")]
        public int SdkVersion { get; set; }
    }

    public class ExampleService
    {
        [JsonPropertyName("__set__")]
        public List<string> Operations { get; set; }
    }

    public class DocFilenames
    {
        [JsonPropertyName("service_pages")]
        public Dictionary<string, string> ServicePages { get; set; }
    }

    public class ExampleDoc
    {
        public string SdkId { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
    }
}