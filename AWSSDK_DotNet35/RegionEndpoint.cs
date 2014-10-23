/*******************************************************************************
 *  Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Linq;

using Amazon.Runtime;
using System.Globalization;
using Amazon.Runtime.Internal.Util;

namespace Amazon
{
    /// <summary>
    /// This class contains the endpoints available to the AWS clients.  The static constants representing the 
    /// regions can be used while constructing the AWS client instead of looking up the exact endpoint URL.
    /// </summary>
    public class RegionEndpoint
    {
        const string REGIONS_FILE = "AWSSDK.endpoints.xml";

        const int MAX_DOWNLOAD_RETRIES = 3;

        #region Statics

        // Dictionary of regions by system name
        private static Dictionary<string, RegionEndpoint> hashBySystemName = new Dictionary<string, RegionEndpoint>(StringComparer.OrdinalIgnoreCase);

        static bool loaded = false;
        static readonly object LOCK_OBJECT = new object();

        /// <summary>
        /// The US East (Virginia) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USEast1 = NewEndpoint("us-east-1", "US East (Virginia)");

        /// <summary>
        /// The US West (N. California) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USWest1 = NewEndpoint("us-west-1", "US West (N. California)");

        /// <summary>
        /// The US West (Oregon) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USWest2 = NewEndpoint("us-west-2", "US West (Oregon)");

        /// <summary>
        /// The EU West (Ireland) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUWest1 = NewEndpoint("eu-west-1", "EU West (Ireland)");

        /// <summary>
        /// The EU Central (Frankfurt) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUCentral1 = NewEndpoint("eu-central-1", "EU Central (Frankfurt)");

        /// <summary>
        /// The Asia Pacific (Tokyo) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APNortheast1 = NewEndpoint("ap-northeast-1", "Asia Pacific (Tokyo)");

        /// <summary>
        /// The Asia Pacific (Singapore) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSoutheast1 = NewEndpoint("ap-southeast-1", "Asia Pacific (Singapore)");

        /// <summary>
        /// The Asia Pacific (Sydney) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSoutheast2 = NewEndpoint("ap-southeast-2", "Asia Pacific (Sydney)");

        /// <summary>
        /// The South America (Sao Paulo) endpoint.
        /// </summary>
        public static readonly RegionEndpoint SAEast1 = NewEndpoint("sa-east-1", "South America (Sao Paulo)");

        /// <summary>
        /// The US GovCloud West (Oregon) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USGovCloudWest1 = NewEndpoint("us-gov-west-1", "US GovCloud West (Oregon)");

        /// <summary>
        /// The China (Beijing) endpoint.
        /// </summary>
        public static readonly RegionEndpoint CNNorth1 = NewEndpoint("cn-north-1", "China (Beijing)", "amazonaws.com.cn");

        // Creates a new RegionEndpoint and stores it in the hash
        private static RegionEndpoint NewEndpoint(string systemName, string displayName)
        {
            var regionEndpoint = new RegionEndpoint(systemName, displayName);
            hashBySystemName.Add(regionEndpoint.SystemName, regionEndpoint);
            return regionEndpoint;
        }

        // Creates a new RegionEndpoint and stores it in the hash, uses a non-standard domain
        private static RegionEndpoint NewEndpoint(string systemName, string displayName, string domain)
        {
            var regionEndpoint = new RegionEndpoint(systemName, displayName);
            regionEndpoint.regionDomain = domain;
            hashBySystemName.Add(regionEndpoint.SystemName, regionEndpoint);
            return regionEndpoint;
        }

        /// <summary>
        /// Enumerate through all the regions.
        /// </summary>
        public static IEnumerable<RegionEndpoint> EnumerableAllRegions
        {
            get { return hashBySystemName.Values; }
        }

        /// <summary>
        /// Gets the region based on its system name like "us-west-1"
        /// </summary>
        /// <param name="systemName">The system name of the service like "us-west-1"</param>
        /// <returns></returns>
        public static RegionEndpoint GetBySystemName(string systemName)
        {
            if (!RegionEndpoint.loaded)
                RegionEndpoint.LoadEndpointDefinitions();

            RegionEndpoint region = null;
            if (!hashBySystemName.TryGetValue(systemName, out region))
            {
                if (systemName.StartsWith("cn-", StringComparison.Ordinal))
                    return NewEndpoint(systemName, "China (Unknown)", "amazonaws.com.cn");
                return NewEndpoint(systemName, "Unknown");
            }

            return region;
        }

        static void LoadEndpointDefinitions()
        {
            var endpointsPath = AWSConfigs.EndpointDefinition;
            if (string.IsNullOrEmpty(endpointsPath))
            {
#if BCL
                if (TryLoadEndpointDefinitionsFromAssemblyDir())
                {
                    return;
                }
#endif
                LoadEndpointDefinitionsFromEmbeddedResource();
            }
            else if (endpointsPath.StartsWith("http", StringComparison.OrdinalIgnoreCase))
            {
                LoadEndpointDefinitionFromWeb(endpointsPath);
            }
#if BCL
            else
            {
                LoadEndpointDefinitionFromFilePath(endpointsPath);
            }
#endif
        }

        static void LoadEndpointDefinitionsFromEmbeddedResource()
        {
            Assembly assembly = Amazon.Util.TypeFactory.GetTypeInfo(typeof(RegionEndpoint)).Assembly;
            using (StreamReader reader = new StreamReader(assembly.GetManifestResourceStream(REGIONS_FILE)))
            {
                LoadEndpointDefinitions(reader);
            }
        }

#if BCL
        static bool TryLoadEndpointDefinitionsFromAssemblyDir()
        {
            string endpointsFile;
            try
            {
                var assembly = typeof(Amazon.RegionEndpoint).Assembly;
                var codeBase = assembly.CodeBase;
                if (string.IsNullOrEmpty(codeBase))
                    return false;

                var uri = new Uri(codeBase);
                var dirPath = Path.GetDirectoryName(uri.LocalPath);
                var dirInfo = new DirectoryInfo(dirPath);
                if (!dirInfo.Exists)
                    return false;

                var files = dirInfo.GetFiles(REGIONS_FILE, SearchOption.TopDirectoryOnly);
                if (files.Length != 1)
                    return false;

                endpointsFile = files[0].FullName;
            }
            catch
            {
                endpointsFile = null;
            }

            if (string.IsNullOrEmpty(endpointsFile))
                return false;

            LoadEndpointDefinitionFromFilePath(endpointsFile);
            return true;
        }

        static void LoadEndpointDefinitionFromFilePath(string path)
        {
            if (!System.IO.File.Exists(path))
                throw new AmazonServiceException(string.Format(CultureInfo.InvariantCulture, "Local endpoint configuration file {0} override was not found.", path));

            using (StreamReader reader = new StreamReader(path))
            {
                LoadEndpointDefinitions(reader);
            }
        }
#endif

        static void LoadEndpointDefinitionFromWeb(string url)
        {
            int retries = 0;
            while (retries < MAX_DOWNLOAD_RETRIES)
            {
                try
                {
                    HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                    var asynResult = request.BeginGetResponse(null, null);
                    HttpWebResponse response = request.EndGetResponse(asynResult) as HttpWebResponse;

                    using (response)
                    {
                        using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                        {
                            lock (LOCK_OBJECT)
                            {
                                LoadEndpointDefinitions(reader);
                                return;
                            }
                        }
                    }
                }
                catch (WebException e)
                {
                    retries++;
                    if (retries == MAX_DOWNLOAD_RETRIES)
                        throw new AmazonServiceException(string.Format(CultureInfo.InvariantCulture, "Error downloading regions definition file from {0}.", url), e);
                }

                int delay = (int)(Math.Pow(4, retries) * 100);
                delay = Math.Min(delay, 30 * 1000);
                Util.AWSSDKUtils.Sleep(delay);
            }
        }

        /// <summary>
        /// Parse the endpoint definition.  This method is only meant to be called directly for testing purposes.
        /// </summary>
        /// <param name="reader">A reader of the endpoint definitions</param>
        public static void LoadEndpointDefinitions(TextReader reader)
        {
            if (loaded)
            {
                return;
            }

            lock (LOCK_OBJECT)
            {
                if (loaded)
                    return;

                XDocument xmlDoc = XDocument.Load(reader);

                var xmlRegions = xmlDoc.Descendants("Regions").Descendants("Region");
                foreach (XElement xmlRegion in xmlRegions)
                {
                    var regionSystemName = xmlRegion.Element("Name").Value;

                    var regionDomainNode = xmlRegion.Element("Domain");

                    RegionEndpoint region = null;
                    // This version of the SDK doesn't have a constant yet for the new region
                    // so go ahead and add a new region that users can lookup by it's system name.
                    if (!RegionEndpoint.hashBySystemName.TryGetValue(regionSystemName, out region))
                    {
                        region = new RegionEndpoint(regionSystemName, regionSystemName);
                        if (regionDomainNode != null)
                            region.regionDomain = regionDomainNode.Value;
                        RegionEndpoint.hashBySystemName[regionSystemName] = region;
                    }

                    var xmlEndpoints = xmlRegion.Descendants("Endpoint");
                    foreach (XElement xmlEndpoint in xmlEndpoints)
                    {
                        var serviceName = xmlEndpoint.Element("ServiceName").Value;
                        var hostname = xmlEndpoint.Element("Hostname").Value;

                        bool https = false;
                        if (xmlEndpoint.Element("Https") is XElement)
                            https = bool.Parse(xmlEndpoint.Element("Https").Value);

                        bool http = false;
                        if (xmlEndpoint.Element("Http") is XElement)
                            http = bool.Parse(xmlEndpoint.Element("Http").Value);

                        string authregion = null;
                        if (xmlEndpoint.Element("AuthRegion") is XElement)
                            authregion = xmlEndpoint.Element("AuthRegion").Value;

                        string signatureOverride = null;
                        if (xmlEndpoint.Element("SignatureVersionOverride") is XElement)
                            signatureOverride = xmlEndpoint.Element("SignatureVersionOverride").Value;

                        if (region.endpoints == null)
                            region.endpoints = new Dictionary<string, Endpoint>();

                        region.endpoints.Add(serviceName, new Endpoint(hostname, https, http, authregion, signatureOverride));
                    }
                }

                loaded = true;
            }
        }

        /// <summary>
        /// This is a testing method and should not be called by production applications.
        /// </summary>
        public static void UnloadEndpointDefinitions()
        {
            lock (LOCK_OBJECT)
            {
                foreach (var region in RegionEndpoint.EnumerableAllRegions)
                {
                    region.endpoints = null;
                }

                RegionEndpoint.loaded = false;
            }
        }

        #endregion

        string regionDomain = "amazonaws.com";
        Dictionary<string, Endpoint> endpoints;
        private RegionEndpoint(string systemName, string displayName)
        {
            this.SystemName = systemName;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Gets the system name of a region.
        /// </summary>
        public string SystemName
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the display name of a region.
        /// </summary>
        public string DisplayName
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the endpoint for a service in a region.
        /// </summary>
        /// <param name="serviceName">The services system name.</param>
        /// <exception cref="System.ArgumentException">Thrown when the request service does not have a valid endpoint in the region.</exception>
        /// <returns></returns>
        public Endpoint GetEndpointForService(string serviceName)
        {
            if (!RegionEndpoint.loaded)
                RegionEndpoint.LoadEndpointDefinitions();

            Endpoint endpoint = null;
            if (this.endpoints ==null || !this.endpoints.TryGetValue(serviceName, out endpoint))
            {
                endpoint = GuessEndpointForService(serviceName);
            }

            return endpoint;
        }

        public Endpoint GuessEndpointForService(string serviceName)
        {
            return new Endpoint(String.Format(CultureInfo.InvariantCulture, "{0}.{1}.{2}", serviceName, SystemName, regionDomain), true, false);
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} ({1})", this.DisplayName, this.SystemName);
        }

        /// <summary>
        /// This class defines an endpoints hostname and which protocols it supports.
        /// </summary>
        public class Endpoint
        {

            internal Endpoint(string hostname, bool https, bool http, string authregion = null, string signatureVersionOverride = null)
            {
                this.Hostname = hostname;
                this.HTTPS = https;
                this.HTTP = http;
                this.AuthRegion = authregion;
                this.SignatureVersionOverride = signatureVersionOverride;
            }

            /// <summary>
            /// Gets the hostname for the service.
            /// </summary>
            public string Hostname
            {
                get;
                private set;
            }

            /// <summary>
            /// Returns true of the service endpoint supports HTTPS.
            /// </summary>
            public bool HTTPS
            {
                get;
                private set;
            }

            /// <summary>
            /// Returns true of the service endpoint supports HTTP.
            /// </summary>
            public bool HTTP
            {
                get;
                private set;
            }

            /// <summary>
            /// The authentication region to be used in request signing.
            /// </summary>
            public string AuthRegion
            {
                get;
                private set;
            }

            public override string ToString()
            {
                return this.Hostname;
            }

            /// <summary>
            /// Overrides the default signing protocol for an
            /// endpoint. Typically used to force Signature V4
            /// for services that can support multiple signing
            /// protocols.
            /// </summary>
            public string SignatureVersionOverride
            {
                get; private set;
            }
        }
    }
}
