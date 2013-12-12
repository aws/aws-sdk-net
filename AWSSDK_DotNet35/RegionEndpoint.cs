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
        const string EMBEDDED_RESOURCE_OF_REGIONS_FILE = "AWSSDK.endpoints.xml";
        const string CLOUDFRONT_LOCATION_OF_REGIONS_FILE = "https://d3s62xsdspbbg2.cloudfront.net/endpoints.xml";
        const string S3_LOCATION_OF_REGIONS_FILE = "https://aws-sdk-configurations.s3.amazonaws.com/endpoints.xml";

        const int MAX_DOWNLOAD_RETRIES = 3;

        #region Statics

        // Dictionary of regions by system name
        private static Dictionary<string, RegionEndpoint> hashBySystemName = new Dictionary<string, RegionEndpoint>();

        static bool loadedFromWeb = false;
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
        /// The South America (Sao Paulo)endpoint.
        /// </summary>
        public static readonly RegionEndpoint SAEast1 = NewEndpoint("sa-east-1", "South America (Sao Paulo)");

        /// <summary>
        /// The US GovCloud West (Oregon)endpoint.
        /// </summary>
        public static readonly RegionEndpoint USGovCloudWest1 = NewEndpoint("us-gov-west-1", "US GovCloud West (Oregon)");

        // Creates a new RegionEndpoint and stores it in the hash
        private static RegionEndpoint NewEndpoint(string systemName, string displayName)
        {
            var regionEndpoint = new RegionEndpoint(systemName, displayName);
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
                RegionEndpoint.LoadEndpointDefinitionFromEmbeddedResource();

            RegionEndpoint region = null;
            if (!hashBySystemName.TryGetValue(systemName.ToLower(CultureInfo.InvariantCulture), out region))
            {
                // If the region is not found check to see if downloading the latest definitions from the web
                // contains a definition for the region.
                if (!RegionEndpoint.loadedFromWeb)
                {
                    LoadEndpointDefinitionFromWeb();
                    return GetBySystemName(systemName);
                }

                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "No region found for name {0}.", systemName), "systemName");
            }

            return region;
        }

        static void LoadEndpointDefinitionFromEmbeddedResource()
        {
            Assembly assembly = Amazon.Util.TypeFactory.GetTypeInfo(typeof(RegionEndpoint)).Assembly;
            using (StreamReader reader = new StreamReader(assembly.GetManifestResourceStream(EMBEDDED_RESOURCE_OF_REGIONS_FILE)))
            {
                LoadEndpointDefinitions(reader);
            }
        }

        static void LoadEndpointDefinitionFromWeb()
        {
            int retries = 0;
            while (retries < MAX_DOWNLOAD_RETRIES)
            {
                try
                {
                    HttpWebResponse response = null;
                    try
                    {
                        HttpWebRequest request = WebRequest.Create(CLOUDFRONT_LOCATION_OF_REGIONS_FILE) as HttpWebRequest;
                        var asynResult = request.BeginGetResponse(null, null);
                        response = request.EndGetResponse(asynResult) as HttpWebResponse;
                    }
                    catch (Exception)
                    {
                        HttpWebRequest request = WebRequest.Create(S3_LOCATION_OF_REGIONS_FILE) as HttpWebRequest;
                        var asynResult = request.BeginGetResponse(null, null);
                        response = request.EndGetResponse(asynResult) as HttpWebResponse;
                    }

                    using (response)
                    {
                        using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                        {
                            lock (LOCK_OBJECT)
                            {
                                // If we are loading the latest definition from online then unload the currently loaded definition that is old.
                                UnloadEndpointDefinitions();

                                LoadEndpointDefinitions(reader);
                                loadedFromWeb = true;
                                return;
                            }
                        }
                    }
                }
                catch (WebException e)
                {
                    retries++;
                    if (retries == MAX_DOWNLOAD_RETRIES)
                        throw new AmazonServiceException("Error downloading regions definition file.", e);
                }

                int delay = (int)(Math.Pow(4, retries) * 100);
                delay = Math.Min(delay, 30 * 1000);
                Amazon.Util.AWSSDKUtils.Sleep(delay);
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

                    RegionEndpoint region = null;
                    // This version of the SDK doesn't have a constant yet for the new region
                    // so go ahead and add a new region that users can lookup by it's system name.
                    if (!RegionEndpoint.hashBySystemName.TryGetValue(regionSystemName, out region))
                    {
                        region = new RegionEndpoint(regionSystemName, regionSystemName);
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



                        if (region.endpoints == null)
                            region.endpoints = new Dictionary<string, Endpoint>();

                        region.endpoints.Add(serviceName, new Endpoint(hostname, https, http));
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
                RegionEndpoint.LoadEndpointDefinitionFromEmbeddedResource();

            Endpoint endpoint = null;
            if (!this.endpoints.TryGetValue(serviceName, out endpoint))
            {
                // If the endpoint is not found check to see if downloading the latest definitions from the web
                // contains a definition for the endpoint.
                if (!RegionEndpoint.loadedFromWeb)
                {
                    LoadEndpointDefinitionFromWeb();
                    return GetEndpointForService(serviceName);
                }

                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "No endpoint found for service {0} for region {1}.", serviceName, this.DisplayName), "serviceName");
            }

            return endpoint;
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

            internal Endpoint(string hostname, bool https, bool http)
            {
                this.Hostname = hostname;
                this.HTTPS = https;
                this.HTTP = http;
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

            public override string ToString()
            {
                return this.Hostname;
            }
        }
    }
}
