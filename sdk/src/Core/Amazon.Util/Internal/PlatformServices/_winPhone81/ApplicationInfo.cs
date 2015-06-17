using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Windows.Storage;

namespace Amazon.Util.Internal.PlatformServices
{
    public class ApplicationInfo : IApplicationInfo
    {

        IDictionary<string, string> properties;

        public ApplicationInfo()
        {
            properties = new Dictionary<string, string>();
            var appManifest = XDocument.Load("WMAppManifest.xml");
            using (var rdr = appManifest.CreateReader(ReaderOptions.None))
            {
                rdr.ReadToDescendant("App");
                if (!rdr.IsStartElement())
                {
                    throw new System.FormatException(
                       "App tag not found in WMAppManifest.xml ");
                }
                rdr.MoveToFirstAttribute();
                while (rdr.MoveToNextAttribute())
                {
                    properties.Add(rdr.Name, rdr.Value);
                }
            }
        }

        public string AppTitle
        {
            get
            {
                return properties["Title"];
            }
        }

        public string AppVersionName
        {
            get
            {
                return properties["Version"];
            }
        }

        public string AppVersionCode
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string PackageName
        {
            get
            {
                throw new NotImplementedException();
            }
        }


        
        public string SpecialFolder
        {
            get
            {
                return ApplicationData.Current.LocalFolder.Path;
            }
        }

    }
}