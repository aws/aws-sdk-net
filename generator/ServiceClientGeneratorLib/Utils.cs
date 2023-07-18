using Json.LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
namespace ServiceClientGenerator
{
    public static class Utils
    {
        public static string GetVersion(string fileVersionText)
        {
            var fileVersion = new Version(fileVersionText);
            var version = new Version(fileVersion.Major, fileVersion.Minor);
            var text = version.ToString();
            return text;
        }

        public static int IndexOfNthOccurrence(this string self, char value, int startIndex, int n)
        {
            int index = startIndex;
            for (int i = 0; i < n; i++)
            {
                index = self.IndexOf(value, index) + 1;
                if (index < 0)
                    return index;
            }

            return index;
        }

        public static JsonData SafeGet(this JsonData self, string propertyName)
        {
            JsonData data;
            try
            {
                data = self[propertyName];
            }
            catch
            {
                data = null;
            }

            return data;
        }

        public static string CastToString(this JsonData self)
        {
            //Casting a null JsonData reference to string result in an exception
            if (self == null)
                return null;

            return (string)self;
        }

        public static string NewProjectGuid
        {
            get
            {
                return Guid.NewGuid().ToString("B").ToUpper();
            }
        }

        public static string GetProjectGuid(string projectPath)
        {
            if (!File.Exists(projectPath))
                return NewProjectGuid;
            var xdoc = new XmlDocument();
            xdoc.Load(projectPath);
            var propertyGroups = xdoc.GetElementsByTagName("PropertyGroup");

            int propertyGroupIndex;
            if (string.Equals(Path.GetExtension(projectPath), ".xproj", StringComparison.CurrentCultureIgnoreCase))
                propertyGroupIndex = 1;
            else
                propertyGroupIndex = 0;

            var element = ((XmlElement)propertyGroups[propertyGroupIndex]).GetElementsByTagName("ProjectGuid")[0];

            if (element == null)
                return NewProjectGuid;

            var projectGuid = element.InnerText;
            return projectGuid;
        }

        public static string SafeGetString(this JsonData self, string propertyName)
        {
            var val = self.SafeGet(propertyName);
            if (null == val || !val.IsString)
                return String.Empty;

            return val.ToString();
        }

        public static IDictionary<string, JsonData> GetMap(this JsonData self)
        {
            var result = new Dictionary<string, JsonData>();

            if (self != null || self.IsObject)
            {
                foreach (var key in self.PropertyNames)
                {
                    result[key] = self.SafeGet(key);
                }
            }

            return result;
        }

        public static IDictionary<string, string> GetStringMap(this JsonData self)
        {
            var result = new Dictionary<string, string>();

            if (self != null || self.IsObject)
            {
                foreach (var key in self.PropertyNames)
                {
                    var tmp = self.SafeGet(key);
                    if (tmp.IsString)
                        result[key] = tmp.ToString();
                }
            }

            return result;
        }

        public static Member GetMemberByName(this IList<Member> self, string name)
        {
            return self.Where(m => m.ModeledName.Equals(name, StringComparison.OrdinalIgnoreCase))
                       .SingleOrDefault();
        }

        /// <summary>
        /// Parses the timestampFormat attribute if specified and returns it.
        /// </summary>
        public static TimestampFormat GetTimestampFormat(this JsonData self)
        {
            var value = self[Shape.TimestampFormatKey];
            if (value == null) { return TimestampFormat.None; }

            return Enum.TryParse<TimestampFormat>(value.ToString(), true, out var parsedValue) ?
                parsedValue :
                throw new Exception("Encountered unknown timestampFormat: "+ parsedValue);
        }

        public static string JsonDataToString(JsonData data)
        {
            return (data == null)
                ? null
                : data.ToString();
        }

        public static List<string> GetServiceDirectories(GeneratorOptions options)
        {
            var serviceDirectories = new List<string>();
            if (string.IsNullOrEmpty(options.ServiceModels))
            {
                serviceDirectories.AddRange(Directory.GetDirectories(options.ModelsFolder).OrderBy(d => d));
                serviceDirectories.AddRange(Directory.GetDirectories(options.TestModelsFolder).OrderBy(d => d));
            }
            else
            {
                var services = options.ServiceModels.Split(';');
                // only get specified models folders
                foreach (var service in services)
                {
                    serviceDirectories.AddRange(Directory.GetDirectories(options.ModelsFolder, service).OrderBy(d => d));
                    serviceDirectories.AddRange(Directory.GetDirectories(options.TestModelsFolder, service).OrderBy(d => d));
                }
            }
            return serviceDirectories;
        }

        /// <summary>
        /// Forces the path to use the AltDirectorySeparatorChar even on Windows.
        /// </summary>
        /// <param name="segments">The path segments to join</param>
        /// <returns>The combined path.</returns>
        public static string PathCombineAlt(params string[] segments)
        {
            return ConvertPathAlt(Path.Combine(segments));
        }

        /// <summary>
        /// Converts path characters of Path.DirectorySeparatorChar to Path.AltDirectorySeparatorChar.
        /// </summary>
        /// <param name="path">The path to convert to use Path.AltDirectorySeparatorChar characters.</param>
        /// <returns>The converted path.</returns>
        public static string ConvertPathAlt(string path)
        {
            return path.Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
        }
    }
}
