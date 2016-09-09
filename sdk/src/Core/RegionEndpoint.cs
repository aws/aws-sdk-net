﻿/*******************************************************************************
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
using Amazon.Util.Internal;

using ThirdParty.Json.LitJson;

#if UNITY
using UnityEngine;
using Amazon.Runtime.Internal;
#endif

namespace Amazon
{
    /// <summary>
    /// This class contains the endpoints available to the AWS clients.  The static constants representing the 
    /// regions can be used while constructing the AWS client instead of looking up the exact endpoint URL.
    /// </summary>
    public class RegionEndpoint
    {
        // The shared endpoint rules used by other AWS SDKs.
        const string REGIONS_FILE = "Amazon.endpoints.json";
        // The .NET SDK specific customization to support legacy decisions made for endpoints.
        const string REGIONS_CUSTOMIZATIONS_FILE = "Amazon.endpoints.customizations.json";

        const string DEFAULT_RULE = "*/*";

        #region Statics

        static Dictionary<string, JsonData> _documentEndpoints;

        const int MAX_DOWNLOAD_RETRIES = 3;

        static bool loaded = false;
        static readonly object LOCK_OBJECT = new object();

        // Dictionary of regions by system name
        private static Dictionary<string, RegionEndpoint> hashBySystemName = new Dictionary<string, RegionEndpoint>(StringComparer.OrdinalIgnoreCase);

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
        /// The Asia Pacific (Seoul) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APNortheast2 = NewEndpoint("ap-northeast-2", "Asia Pacific (Seoul)");

        /// <summary>
        /// The Asia Pacific (Singapore) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSoutheast1 = NewEndpoint("ap-southeast-1", "Asia Pacific (Singapore)");

        /// <summary>
        /// The Asia Pacific (Sydney) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSoutheast2 = NewEndpoint("ap-southeast-2", "Asia Pacific (Sydney)");

        /// <summary>
        /// The Asia Pacific (Mumbai) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSouth1 = NewEndpoint("ap-south-1", "Asia Pacific (Mumbai)");

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
        public static readonly RegionEndpoint CNNorth1 = NewEndpoint("cn-north-1", "China (Beijing)");

        /// <summary>
        /// Gets the endpoint for a service in a region.
        /// </summary>
        /// <param name="serviceName">The services system name.</param>
        /// <exception cref="System.ArgumentException">Thrown when the request service does not have a valid endpoint in the region.</exception>
        /// <returns></returns>
        public Endpoint GetEndpointForService(string serviceName)
        {
            return GetEndpointForService(serviceName, false);
        }

        /// <summary>
        /// Gets the endpoint for a service in a region, optionally selecting a dualstack compatible endpoint.
        /// </summary>
        /// <param name="serviceName">The services system name.</param>
        /// <param name="dualStack">
        /// If true a dualstack endpoint is returned. It is the user's responsibility to verify that the given service 
        /// supports a dualstack endpoint for the region.
        /// </param>
        /// <exception cref="System.ArgumentException">Thrown when the request service does not have a valid endpoint in the region.</exception>
        /// <returns></returns>
        public Endpoint GetEndpointForService(string serviceName, bool dualStack)
        {
            if (!RegionEndpoint.loaded)
                RegionEndpoint.LoadEndpointDefinitions();

            var rule = GetEndpointRule(serviceName);
            var endpointTemplate = rule["endpoint"].ToString();
            if (dualStack)
            {
                // We need special handling for S3's s3.amazonaws.com endpoint, which doesn't
                // support dualstack (need to transform to s3.dualstack.us-east-1.amazonaws.com).
                // Other endpoints that begin s3-* need to transform to s3.* for dualstack support.
                // S3's 'external' endpoints do not support dualstack and should not be transformed.
                if (serviceName.Equals("s3", StringComparison.OrdinalIgnoreCase))
                {
                    if (endpointTemplate.Equals("s3.amazonaws.com", StringComparison.OrdinalIgnoreCase))
                        endpointTemplate = "s3.dualstack.us-east-1.amazonaws.com";
                    else
                    {
                        var isExternalEndpoint = endpointTemplate.StartsWith("s3-external-", StringComparison.OrdinalIgnoreCase);
                        if (!isExternalEndpoint)
                        {
                            // transform fixed s3-<region> to s3.<region> and then onto s3.dualstack.<region>,
                            // bypassing endpoints that do not start with the expected tags.
                            if (endpointTemplate.StartsWith("s3-", StringComparison.OrdinalIgnoreCase))
                                endpointTemplate = "s3." + endpointTemplate.Substring(3);

                            if (endpointTemplate.StartsWith("s3.", StringComparison.OrdinalIgnoreCase))
                                endpointTemplate = endpointTemplate.Replace("s3.", "s3.dualstack.");
                        }
                    }
                }
                else
                    endpointTemplate = endpointTemplate.Replace("{region}", "dualstack.{region}");
            }

            var hostName = endpointTemplate.Replace("{region}", this.SystemName).Replace("{service}", serviceName);

            string signatureVersion = null;
            if (rule["signature-version"] != null)
                signatureVersion = rule["signature-version"].ToString();

            string authRegion;
            if (rule["auth-region"] != null)
                authRegion = rule["auth-region"].ToString();
            else
                authRegion = Amazon.Util.AWSSDKUtils.DetermineRegion(hostName);

            return new Endpoint(hostName,
                !string.Equals(authRegion, this.SystemName) ? authRegion : null,
                signatureVersion);
        }

        JsonData GetEndpointRule(string serviceName)
        {
            JsonData rule = null;
            if (_documentEndpoints.TryGetValue(string.Format(CultureInfo.InvariantCulture, "{0}/{1}", this.SystemName, serviceName), out rule))
                return rule;

            if (_documentEndpoints.TryGetValue(string.Format(CultureInfo.InvariantCulture, "{0}/*", this.SystemName), out rule))
                return rule;

            if (_documentEndpoints.TryGetValue(string.Format(CultureInfo.InvariantCulture, "*/{0}", serviceName), out rule))
                return rule;

            return _documentEndpoints[DEFAULT_RULE];
        }

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
            get
            {
                if (!RegionEndpoint.loaded)
                    RegionEndpoint.LoadEndpointDefinitions();

                return hashBySystemName.Values;
            }
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
                // explicit namespace to avoid collision with UnityEngine.Logger
                var logger = Amazon.Runtime.Internal.Util.Logger.GetLogger(typeof(RegionEndpoint));
                logger.InfoFormat("Region system name {0} was not found in region data bundled with SDK; assuming new region.", systemName);

                if (systemName.StartsWith("cn-", StringComparison.Ordinal))
                    return NewEndpoint(systemName, "China (Unknown)");
                return NewEndpoint(systemName, "Unknown");
            }

            return region;
        }

        static void LoadEndpointDefinitions()
        {
            lock (LOCK_OBJECT)
            {
                if (RegionEndpoint.loaded)
                    return;

                _documentEndpoints = new Dictionary<string, JsonData>();

                var endpointsPath = AWSConfigs.EndpointDefinition;
                if (string.IsNullOrEmpty(endpointsPath))
                {
#if BCL
                    if (TryLoadEndpointDefinitionsFromAssemblyDir())
                    {
                        RegionEndpoint.loaded = true;
                        return;
                    }
#endif
                    LoadEndpointDefinitionsFromEmbeddedResource();
                }
#if !UNITY
                else if (endpointsPath.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                {
                    LoadEndpointDefinitionFromWeb(endpointsPath);
                }
#endif
#if BCL
                else
                {
                    LoadEndpointDefinitionFromFilePath(endpointsPath);
                }
#endif
                RegionEndpoint.loaded = true;
            }
        }

        static void ReadEndpointFile(Stream stream)
        {
            using (var reader = new StreamReader(stream))
            {
                var root = JsonMapper.ToObject(reader);
                var endpoints = root["endpoints"];
                foreach (var ruleName in endpoints.PropertyNames)
                {
                    _documentEndpoints[ruleName] = endpoints[ruleName];
                }
            }
        }


        static void LoadEndpointDefinitionsFromEmbeddedResource()
        {
            using (var stream = Amazon.Util.Internal.TypeFactory.GetTypeInfo(typeof(RegionEndpoint)).Assembly.GetManifestResourceStream(REGIONS_FILE))
            {
                ReadEndpointFile(stream);
            }
            using (var stream = Amazon.Util.Internal.TypeFactory.GetTypeInfo(typeof(RegionEndpoint)).Assembly.GetManifestResourceStream(REGIONS_CUSTOMIZATIONS_FILE))
            {
                ReadEndpointFile(stream);
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

            using (var stream = File.OpenRead(path))
            {
                ReadEndpointFile(stream);
            }
        }
#endif
#if  !UNITY
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
                        using (var stream = response.GetResponseStream())
                        {
                            ReadEndpointFile(stream);
                            return;
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
#endif
        /// <summary>
        /// This is a testing method and should not be called by production applications.
        /// </summary>
        public static void UnloadEndpointDefinitions()
        {
            lock (LOCK_OBJECT)
            {
                _documentEndpoints.Clear();
                RegionEndpoint.loaded = false;
            }
        }

        #endregion

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

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} ({1})", this.DisplayName, this.SystemName);
        }

        /// <summary>
        /// This class defines an endpoints hostname and which protocols it supports.
        /// </summary>
        public class Endpoint
        {

            internal Endpoint(string hostname, string authregion, string signatureVersionOverride)
            {
                this.Hostname = hostname;
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
                get;
                private set;
            }
        }
    }
}
