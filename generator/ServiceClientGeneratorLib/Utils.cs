using Json.LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static List<string> GetExtensionDirectories(GeneratorOptions options)
        {
            var extensionDirectories = new List<string>();
            extensionDirectories.AddRange(Directory.GetDirectories(options.ExtensionsSrcFolder).OrderBy(d => d));
            return extensionDirectories;
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

        private static readonly Regex JMESMapRegex = new Regex(@"keys\(([^)]*)\)", RegexOptions.Compiled);
        
        /// <summary>
        /// Converts a JMESPath expression into a corresponding C# code path
        /// based on a provided top-level shape. This method handles nested members,
        /// wildcard expressions, and map keys within the JMESPath.
        /// </summary>
        /// <param name="jmesPath">The JMESPath expression to be converted.</param>
        /// <param name="topShape">The top-level shape that serves as the starting point for the conversion.</param>
        /// <returns>
        /// A string representing the equivalent C# code path based on the provided shape.
        /// Returns null if any part of the JMESPath cannot be matched to the given shape.
        /// </returns>
        public static string JMESPathToNativeValue(string jmesPath, Shape topShape)
        {
            // Base case: If the path is empty, return empty
            if (string.IsNullOrEmpty(jmesPath))
            {
                return string.Empty;
            }

            var nestedMembers = SplitJMESPath(jmesPath);
            var mainPathBuilder = new StringBuilder();
            var closingPathBuilder = new StringBuilder();
            var currentShape = topShape;

            foreach (var originalNestedMember in nestedMembers)
            {
                if (mainPathBuilder.Length > 0)
                {
                    mainPathBuilder.Append("?.");
                }

                var nestedMember = originalNestedMember;

                // Handle wildcard expressions
                if (nestedMember == "[*]" || nestedMember == "*")
                {
                    if (nestedMember == "[*]") // List wildcard expression
                    {
                        currentShape = currentShape.ModelListShape;
                        mainPathBuilder.Append("Select(element => element");
                    }
                    else if (nestedMember == "*") // Map wildcard expression
                    {
                        currentShape = currentShape.ValueShape;
                        mainPathBuilder.Append("Values.Select(element => element");
                    }

                    // Append closing parenthesis to close the Select call
                    closingPathBuilder.Append(")");
                    continue;
                }

                // Check for flattening operator []
                if (nestedMember == "[]")
                {
                    // Flatten the nested lists into a single list using LINQ SelectMany
                    mainPathBuilder.Append($"SelectMany(element => element).Where(element => element != null)");
                    continue;
                }

                // Check for array index expressions
                if (nestedMember.StartsWith("[") && nestedMember.EndsWith("]")
                    && int.TryParse(nestedMember.Substring(1, nestedMember.Length - 2), out int index)) // Extract the index from the brackets
                {
                    mainPathBuilder.Append($"ElementAtOrDefault({index})");
                    continue;
                }

                // Check for multi-select list expressions (before regex map matching)
                if (nestedMember.StartsWith("[") && nestedMember.EndsWith("]"))
                {
                    // Strip off the outer brackets and split the inner expressions
                    var multiSelectExpressions = SplitMultiSelectExpression(nestedMember.Substring(1, nestedMember.Length - 2));

                    // Skip element. since we will create an array rather than selecting a property of the element
                    if (mainPathBuilder.ToString().EndsWith("element?."))
                        mainPathBuilder.Length -= "element?.".Length;

                    mainPathBuilder.Append("new [] { ");
                    for (int i = 0; i < multiSelectExpressions.Count; i++)
                    {
                        string expr = multiSelectExpressions[i];
                        var expressionValue = JMESPathToNativeValue(expr, currentShape);

                        // Append the expression as part of the new anonymous object
                        mainPathBuilder.Append($"element?.{expressionValue}");

                        if (i < multiSelectExpressions.Count - 1)
                        {
                            mainPathBuilder.Append(", ");
                        }
                    }
                    mainPathBuilder.Append(" }").Append(closingPathBuilder);
                    closingPathBuilder.Clear();
                    continue; // Skip the regex match as we've handled multi-select separately
                }

                var mapMatch = JMESMapRegex.Match(nestedMember);
                if (mapMatch.Success)
                {
                    nestedMember = mapMatch.Groups[1].Value;
                }

                var currentMember = currentShape.Members.FirstOrDefault(x => string.Equals(x.ModeledName, nestedMember));
                if (currentMember == null)
                {
                    return null;
                }

                mainPathBuilder.Append(currentMember.PropertyName);

                if (mapMatch.Success)
                {
                    mainPathBuilder.Append("?.Keys.ToList()");
                }

                currentShape = currentMember.Shape;
            }

            // Combine the constructed code path and any closing code path and return the result
            return mainPathBuilder.ToString() + closingPathBuilder.ToString();
        }

        /// <summary>
        /// Splits a JMESPath expression into its individual components, skipping nested structures like arrays.
        /// Given the input: "listOfUnions[*][string, object.key][]"
        /// The output will be: [ "listOfUnions", "[*]", "[string, object.key]", "[]" ]
        /// </summary>
        /// <param name="input">The JMESPath expression to be split.</param>
        /// <returns>A list of individual path segments extracted from the expression.</returns>
        public static List<string> SplitJMESPath(string input)
        {
            var parts = new List<string>();
            var currentPart = "";
            bool insideArray = false;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == '[')
                {
                    // Start of an array, push the current part (if any) and start a new one
                    if (!insideArray)
                    {
                        if (!string.IsNullOrEmpty(currentPart))
                        {
                            parts.Add(currentPart);
                        }
                        currentPart = "["; // Begin the array part
                        insideArray = true;
                    }
                    else
                    {
                        // Inside an array but we are encountering a nested bracket
                        currentPart += currentChar;
                    }
                }
                else if (currentChar == ']')
                {
                    // End of an array
                    currentPart += currentChar;
                    if (insideArray)
                    {
                        parts.Add(currentPart);
                        currentPart = ""; // Reset the current part
                        insideArray = false; // Exiting the array
                    }
                }
                else if ((currentChar == '.' || currentChar == '*') && !insideArray)
                {
                    // Split on "." or "*" if we're outside of an array
                    if (!string.IsNullOrEmpty(currentPart))
                    {
                        parts.Add(currentPart);
                        currentPart = "";
                    }
                    if (currentChar == '*')
                        parts.Add("*"); // Add "*" separately if it's the asterisk symbol
                }
                else
                {
                    // Add the current character to the ongoing part
                    currentPart += currentChar;
                }
            }

            // Add any remaining part after the loop
            if (!string.IsNullOrEmpty(currentPart))
            {
                parts.Add(currentPart);
            }

            return parts;
        }

        /// <summary>
        /// Splits a multi-select expression (e.g., "foo, bar[0], bar.baz") into individual expressions.
        /// </summary>
        /// <param name="expression">The multi-select expression to be split (without the enclosing brackets).</param>
        /// <returns>A list of individual expressions from the multi-select expression.</returns>
        public static List<string> SplitMultiSelectExpression(string expression)
        {
            var parts = new List<string>();
            var currentPart = "";
            int bracketCount = 0;

            // Iterate over each character in the expression
            for (int i = 0; i < expression.Length; i++)
            {
                char currentChar = expression[i];

                // Track the number of opening and closing brackets to handle nested arrays/objects
                if (currentChar == '[')
                {
                    bracketCount++;
                }
                else if (currentChar == ']')
                {
                    bracketCount--;
                }

                // If we are at a comma outside of any array/object brackets, split the expression
                if (currentChar == ',' && bracketCount == 0)
                {
                    parts.Add(currentPart.Trim());
                    currentPart = ""; // Reset for the next expression
                }
                else
                {
                    currentPart += currentChar; // Continue building the current expression part
                }
            }

            // Add the last part (after the final comma or the end of the string)
            if (!string.IsNullOrEmpty(currentPart))
            {
                parts.Add(currentPart.Trim());
            }

            return parts;
        }
    }
}
