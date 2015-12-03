using Json.LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

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

        public static int IndexOfNthOccurence(this string self, char value, int startIndex, int n)
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


        public static string NewProjectGuid
        {
            get
            {
                return Guid.NewGuid().ToString("B").ToUpper();
            }
        }

        public static string GetProjectGuid(string projectPath)
        {
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
                throw new ApplicationException("Failed to find project guid for existing project: " + projectPath);

            var projectGuid = element.InnerText;
            return projectGuid;
        }
    }
}
