/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using ThirdParty.Json.LitJson;

namespace Amazon.Internal
{
    [Obsolete("This class is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint.")]
    public class RegionEndpointV3 : IRegionEndpoint
    {
        private ServiceMap _serviceMap = new ServiceMap();
        public string RegionName { get; private set; }
        public string DisplayName { get; private set; }
        public string PartitionName
        {
            get
            {
                return (string)_partitionJsonData["partition"];
            }
        }

        public string PartitionDnsSuffix
        {
            get
            {
                return (string)_partitionJsonData["dnsSuffix"];
            }
        }

        private JsonData _partitionJsonData;
        private JsonData _servicesJsonData;
        private bool _servicesLoaded = false;

        public RegionEndpointV3(string regionName, string displayName, JsonData partition, JsonData services)
        {
            RegionName = regionName;
            DisplayName = displayName;

            _partitionJsonData = partition;
            _servicesJsonData = services;
        }

        /// <summary>
        /// Retrieves the endpoint for the given service in the current region
        /// </summary>
        /// <param name="serviceName">Name of the service in endpoints.json</param>
        /// <param name="dualStack">Whether to retrieve the dual-stack variant</param>
        /// <returns>Matching endpoint from endpoints.json, or a computed endpoint if possible</returns>
        [Obsolete("Use GetEndpointForService(string serviceName, GetEndpointForServiceOptions options) instead", error: false)]
        public RegionEndpoint.Endpoint GetEndpointForService(string serviceName, bool dualStack)
        {
            return GetEndpointForService(serviceName, new GetEndpointForServiceOptions { DualStack = dualStack });
        }

        /// <summary>
        /// Retrieves the endpoint for the given service in the current region
        /// </summary>
        /// <param name="serviceName">Name of the service in endpoints.json</param>
        /// <param name="options"> Specify additional requirements on the <see cref="RegionEndpoint.Endpoint"/> to be returned.</param>
        /// <returns>Matching endpoint from endpoints.json, or a computed endpoint if possible</returns>
        public RegionEndpoint.Endpoint GetEndpointForService(string serviceName, GetEndpointForServiceOptions options)
        {
            var variants = BuildVariantHashSet(options);
            return GetEndpointForService(serviceName, variants);
        }

        /// <summary>
        /// Retrieves the endpoint for the given service in the current region
        /// </summary>
        /// <param name="serviceName">Name of the service in endpoints.json</param>
        /// <param name="variants">Set of tags describing an endpoint variant</param>
        /// <returns>Matching endpoint from endpoints.json, or a computed endpoint if possible</returns>
        public RegionEndpoint.Endpoint GetEndpointForService(string serviceName, HashSet<string> variants)
        {
            RegionEndpoint.Endpoint endpointObject = null;

            // lock on _partitionJsonData because:
            // a) ParseAllServices() will mutate _partitionJsonData, so it needs to be run inside a critical section.
            // b) RegionEndpointV3 objects are exclusively built by RegionEndpointProviderV3, which will
            //    constructor inject the _same instance_ of _servicesJsonData and _partitionJsonData into all 
            //    RegionEndpointProviderV3.
            // c) This provides thread-safety if multiple RegionEndpointV3 instances were to be initialized at 
            //    the same time: https://github.com/aws/aws-sdk-net/issues/1939
            lock (_partitionJsonData)
            {
                if (!_servicesLoaded)
                {
                    ParseAllServices();
                    _servicesLoaded = true;
                }

                if (!_serviceMap.TryGetEndpoint(serviceName, variants, out endpointObject))
                {
                    // For all current variants (dual-stack and FIPS) SDKs cannot
                    // fall back to normal endpoints and must raise an error.
                    if (variants?.Count > 0)
                    {
                        throw new AmazonClientException($"Requested endpoint for {serviceName} with variants [{string.Join(", ", variants.ToArray())}] could not be found.");
                    }
                    // Do a fallback of creating an unknown endpoint based on the
                    // current region's hostname template.
                    endpointObject = CreateUnknownEndpoint(serviceName);
                }
            }
            return endpointObject;
        }

        private RegionEndpoint.Endpoint CreateUnknownEndpoint(string serviceName)
        {
            string template = (string)_partitionJsonData["defaults"]["hostname"];

            string dnsSuffix = (string)_partitionJsonData["dnsSuffix"];
            string hostname = template.Replace("{service}", serviceName)
                                 .Replace("{region}", RegionName)
                                 .Replace("{dnsSuffix}", dnsSuffix);

            return new RegionEndpoint.Endpoint(hostname, null, null, dnsSuffix, deprecated: false);
        }

        private void ParseAllServices()
        {
            foreach (string serviceName in _servicesJsonData.PropertyNames)
            {
                if (_servicesJsonData[serviceName] != null && _servicesJsonData[serviceName].Count > 0)
                {
                    AddServiceToMap(_servicesJsonData[serviceName], serviceName);
                }
            }
        }

        private void AddServiceToMap(JsonData service, string serviceName)
        {
            var partitionEndpoint = service["partitionEndpoint"] != null ? (string)service["partitionEndpoint"] : "";
            var isRegionalized = service["isRegionalized"] != null ? (bool)service["isRegionalized"] : true;
            var regionKey = RegionName;

            // Use the partition's default endpoint if the service is not regionalized, like Route53, and there is no
            // endpoint defined for the this service name.
            if (!isRegionalized && service["endpoints"][regionKey] == null && !string.IsNullOrEmpty(partitionEndpoint))
            {
                regionKey = partitionEndpoint;
            }

            var regionEndpoint = service["endpoints"][regionKey];
            var mergedEndpoint = new JsonData();
            var variantJsonData = new Dictionary<HashSet<string>, JsonData>(HashSet<string>.CreateSetComparer());

            // Create the merged endpoint definitions for both the normal endpoint and variants
            MergeJsonData(mergedEndpoint, regionEndpoint, variantJsonData); // first prioritizing the service+region object
            MergeJsonData(mergedEndpoint, service["defaults"], variantJsonData); // then service-level defaults
            MergeJsonData(mergedEndpoint, _partitionJsonData["defaults"], variantJsonData); // then partition-level defaults

            // Preserve existing behavior of short circuiting the normal endpoint if there isn't a region-specific entry
            if (regionEndpoint != null)
            {
                AddNormalEndpointToServiceMap(mergedEndpoint, RegionName, serviceName);
            }

            AddVariantEndpointsToServiceMap(mergedEndpoint, RegionName, serviceName, variantJsonData);
        }

        private static void MergeJsonData(JsonData target, JsonData source, Dictionary<HashSet<string>, JsonData> variants)
        {
            if (source == null || target == null)
            {
                return;
            }

            foreach (var propertyName in source.PropertyNames)
            {
                if (propertyName != "variants")
                {
                    if (target[propertyName] == null)
                    {
                        target[propertyName] = source[propertyName];
                    }
                }
                else // Variants need special handling because they are identified by the "tags" within the
                {    // variant object. First build the key, and then merge the rest of the json properties for a given variant.
                    foreach (JsonData variant in source["variants"])
                    {
                        var tagsKey = new HashSet<string>();
                        foreach (JsonData label in variant["tags"])
                        {
                            tagsKey.Add((string)label);
                        }

                        if (variants.ContainsKey(tagsKey))
                        {
                            // We've encountered this variant at a lower level in the hierarchy
                            // so only merge properties which are still null
                            foreach (var variantProperty in variant.PropertyNames)
                            {
                                if (variants[tagsKey][variantProperty] == null)
                                {
                                    variants[tagsKey][variantProperty] = variant[variantProperty];
                                }
                            }
                        }
                        else // First time encountering this variant, so merge the entire object
                        {
                            variants[tagsKey] = variant;
                        }
                    }
                }
            }
        }

        private void AddNormalEndpointToServiceMap(JsonData mergedEndpoint, string regionName, string serviceName)
        {
            string template = (string)mergedEndpoint["hostname"];
            string dnsSuffix = (string)_partitionJsonData["dnsSuffix"];
            string hostname = template.Replace("{service}", serviceName)
                                 .Replace("{region}", regionName)
                                 .Replace("{dnsSuffix}", dnsSuffix);


            string authRegion = null;
            JsonData credentialScope = mergedEndpoint["credentialScope"];
            if (credentialScope != null)
            {
                authRegion = DetermineAuthRegion(credentialScope);
            }

            JsonData deprecatedJson = mergedEndpoint["deprecated"];
            var deprecated = deprecatedJson?.IsBoolean == true ? (bool) deprecatedJson : false;

            var signatureOverride = DetermineSignatureOverride(mergedEndpoint, serviceName);

            RegionEndpoint.Endpoint endpoint = new RegionEndpoint.Endpoint(hostname, authRegion, signatureOverride, dnsSuffix, deprecated);
            _serviceMap.Add(serviceName, endpoint);

        }

        private void AddVariantEndpointsToServiceMap(JsonData mergedEndpoint, string regionName, string serviceName, Dictionary<HashSet<string>, JsonData> mergedVariants)
        {
            string authRegion = null;
            JsonData credentialScope = mergedEndpoint["credentialScope"];
            if (credentialScope != null)
            {
                authRegion = DetermineAuthRegion(credentialScope);
            }

            JsonData deprecatedJson = mergedEndpoint["deprecated"];
            var deprecated = deprecatedJson?.IsBoolean == true ? (bool)deprecatedJson : false;

            string signatureOverride = DetermineSignatureOverride(mergedEndpoint, serviceName);

            foreach (var tagsKey in mergedVariants.Keys)
            {
                var variantHostnameTemplate = (string)mergedVariants[tagsKey]["hostname"];
                if (string.IsNullOrEmpty(variantHostnameTemplate))
                {
                    throw new AmazonClientException($"Unable to determine the hostname for {serviceName} with variants [{string.Join(", ", tagsKey.ToArray())}].");
                }

                if (variantHostnameTemplate.Contains("{region}") && string.IsNullOrEmpty(regionName))
                {
                    throw new AmazonClientException($"Unable to determine the region for {serviceName} with variants [{string.Join(", ", tagsKey.ToArray())}].");
                }

                var variantDnsSuffix = mergedVariants[tagsKey]["dnsSuffix"] != null ? (string)mergedVariants[tagsKey]["dnsSuffix"] : (string)_partitionJsonData["dnsSuffix"];
                if (variantHostnameTemplate.Contains("{dnsSuffix}") && string.IsNullOrEmpty(variantDnsSuffix))
                {
                    throw new AmazonClientException($"Unable to determine the dnsSuffix for {serviceName} with variants [{string.Join(", ", tagsKey.ToArray())}].");
                }

                var variantHostname = variantHostnameTemplate.Replace("{service}", serviceName)
                                     .Replace("{region}", regionName)
                                     .Replace("{dnsSuffix}", variantDnsSuffix);

                _serviceMap.Add(serviceName, new RegionEndpoint.Endpoint(variantHostname, authRegion, signatureOverride, variantDnsSuffix, deprecated), tagsKey);
            }
        }

        private static string DetermineSignatureOverride(JsonData defaults, string serviceName)
        {
            if (string.Equals(serviceName, "s3", StringComparison.OrdinalIgnoreCase))
            {
                bool supportsSigV2 = false;
                foreach (JsonData element in defaults["signatureVersions"])
                {
                    string sig = (string)element;
                    if (string.Equals(sig, "s3", StringComparison.OrdinalIgnoreCase))
                    {
                        supportsSigV2 = true;
                        break;
                    }
                }
                return (supportsSigV2 ? "2" : "4");
            }

            return null;
        }

        private static string DetermineAuthRegion(JsonData credentialScope)
        {
            string authRegion = null;
            if (credentialScope["region"] != null)
            {
                authRegion = (string)credentialScope["region"];
            }
            return authRegion;
        }

        /// <summary>
        /// Builds the set used to identify a specific endpoint variant
        /// </summary>
        /// <param name="dualStack">Whether to use a dualstack (IPv6 enabled) endpoint</param>
        /// <param name="fips">Whether to use a FIPS-compliant endpoint</param>
        /// <returns>Set used to identify the combined variant in endpoints.json</returns>
        private static HashSet<string> BuildVariantHashSet(GetEndpointForServiceOptions options)
        {
            options = options ?? new GetEndpointForServiceOptions();

            if (!options.DualStack && !options.FIPS)
            {
                return null;
            }

            var variants = new HashSet<string>();

            if (options.DualStack)
            {
                variants.Add("dualstack");
            }
            if (options.FIPS)
            {
                variants.Add("fips");
            }

            return variants;
        }

        class ServiceMap
        {
            /// <summary>
            /// Stores the plain endpoints for each service in the current region
            /// </summary>
            private Dictionary<string, RegionEndpoint.Endpoint> _serviceMap = new Dictionary<string, RegionEndpoint.Endpoint>();

            /// <summary>
            /// Stores the variants for each service in the current region, identified by the set of variant tags.
            /// </summary>
            private Dictionary<string, Dictionary<HashSet<string>, RegionEndpoint.Endpoint>> _variantMap = new Dictionary<string, Dictionary<HashSet<string>, RegionEndpoint.Endpoint>>();

            public bool ContainsKey(string serviceName)
            {
                return _serviceMap.ContainsKey(serviceName);
            }

            public void Add(string serviceName, RegionEndpoint.Endpoint endpoint, HashSet<string> variants = null)
            {
                if (variants == null || variants.Count == 0)
                {
                    _serviceMap.Add(serviceName, endpoint);
                }
                else
                {
                    if (!_variantMap.ContainsKey(serviceName) || _variantMap[serviceName] == null)
                    {
                        _variantMap.Add(serviceName, new Dictionary<HashSet<string>, RegionEndpoint.Endpoint>(HashSet<string>.CreateSetComparer()));
                    }
                    _variantMap[serviceName].Add(variants, endpoint);
                }
            }

            public bool TryGetEndpoint(string serviceName, HashSet<string> variants, out RegionEndpoint.Endpoint endpoint)
            {
                if (variants == null || variants.Count == 0)
                {
                    return _serviceMap.TryGetValue(serviceName, out endpoint);
                }
                else
                {
                    if (!_variantMap.ContainsKey(serviceName))
                    {
                        endpoint = default(RegionEndpoint.Endpoint);
                        return false;
                    }
                    else
                    {
                        return _variantMap[serviceName].TryGetValue(variants, out endpoint);
                    }
                }
            }
        }
    }

    [Obsolete("This class is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint.")]
    public class RegionEndpointProviderV3 : IRegionEndpointProvider, IDisposable
    {
#if NETSTANDARD
        private const string ENDPOINT_JSON_RESOURCE = "Core.endpoints.json";
#else
        private const string ENDPOINT_JSON_RESOURCE = "Amazon.endpoints.json";
#endif
        private const string ENDPOINT_JSON = "endpoints.json";

        private JsonData _root;
        private Dictionary<string, IRegionEndpoint> _regionEndpointMap = new Dictionary<string, IRegionEndpoint>();
        private Dictionary<string, IRegionEndpoint> _nonStandardRegionNameToObjectMap = new Dictionary<string, IRegionEndpoint>();


        private ReaderWriterLockSlim _readerWriterLock = new ReaderWriterLockSlim();

        public RegionEndpointProviderV3()
        {
            using (var stream = GetEndpointJsonSourceStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                _root = JsonMapper.ToObject(reader);
            }
        }

        public RegionEndpointProviderV3(JsonData root)
        {
            _root = root;
        }

        private static Stream GetEndpointJsonSourceStream()
        {
            //
            // If the endpoints.json file has been provided next to the assembly:
            //
            string assemblyLocation = typeof(RegionEndpointProviderV3).Assembly.Location;
            if (!string.IsNullOrEmpty(assemblyLocation))
            {
                string endpointsPath = Path.Combine(Path.GetDirectoryName(assemblyLocation), ENDPOINT_JSON);
                if (File.Exists(endpointsPath))
                {
                    return File.Open(endpointsPath, FileMode.Open, FileAccess.Read);
                }
            }

            //
            // Default to endpoints.json file provided in the resource manifest:
            //
            return Amazon.Util.Internal.TypeFactory.GetTypeInfo(typeof(RegionEndpointProviderV3)).Assembly.GetManifestResourceStream(ENDPOINT_JSON_RESOURCE);
        }

        private IEnumerable<IRegionEndpoint> _allRegionEndpoints;
        public IEnumerable<IRegionEndpoint> AllRegionEndpoints
        {
            get
            {
                if (_allRegionEndpoints == null)
                {
                    try
                    {
                        _readerWriterLock.EnterWriteLock();

                        if (_allRegionEndpoints == null)
                        {
                            JsonData partitions = _root["partitions"];
                            List<IRegionEndpoint> endpoints = new List<IRegionEndpoint>();
                            foreach (JsonData partition in partitions)
                            {
                                JsonData regions = partition["regions"];
                                foreach (string regionName in regions.PropertyNames)
                                {
                                    IRegionEndpoint endpoint;
                                    if (!_regionEndpointMap.TryGetValue(regionName, out endpoint))
                                    {
                                        endpoint = new RegionEndpointV3(regionName, (string)regions[regionName]["description"], partition, partition["services"]);
                                        _regionEndpointMap.Add(regionName, endpoint);
                                    }
                                    endpoints.Add(endpoint);
                                }
                            }

                            _allRegionEndpoints = endpoints;
                        }
                    }
                    finally
                    {
                        if (_readerWriterLock.IsWriteLockHeld)
                        {
                            _readerWriterLock.ExitWriteLock();
                        }
                    }
                }

                return _allRegionEndpoints;
            }
        }

        private object _allRegionRegexLock = new object();
        private IEnumerable<string> _allRegionRegex;
        public IEnumerable<string> AllRegionRegex
        {
            get
            {
                if (_allRegionRegex == null)
                {
                    try
                    {
                        _readerWriterLock.EnterWriteLock();

                        if (_allRegionRegex == null)
                        {
                            JsonData partitions = _root["partitions"];
                            var allRegionRegex = new List<string>();
                            foreach (JsonData partition in partitions)
                            {
                                var regionRegex = (string)partition["regionRegex"];
                                allRegionRegex.Add(regionRegex);
                            }

                            _allRegionRegex = allRegionRegex;
                        }
                    }
                    finally
                    {
                        if (_readerWriterLock.IsWriteLockHeld)
                        {
                            _readerWriterLock.ExitWriteLock();
                        }
                    }
                }

                return _allRegionRegex;
            }
        }

        private static string GetUnknownRegionDescription(string regionName)
        {
            if (regionName.StartsWith("cn-", StringComparison.OrdinalIgnoreCase) ||
                regionName.EndsWith("cn-global", StringComparison.OrdinalIgnoreCase))
            {
                return "China (Unknown)";
            }
            else
            {
                return "Unknown";
            }
        }

        private static bool IsRegionInPartition(string regionName, JsonData partition, out string description)
        {
            JsonData regionsData = partition["regions"];
            string regionPattern = (string)partition["regionRegex"];

            // see if the region name is a real region 
            if (regionsData[regionName] != null)
            {
                description = (string)regionsData[regionName]["description"];
                return true;
            }

            // see if the region is global region by concatenating the partition and "-global" to construct the global name 
            // for the partition
            else if (regionName.Equals(string.Concat((string)partition["partition"], "-global"), StringComparison.OrdinalIgnoreCase))
            {
                description = "Global";
                return true;
            }

            // no region key in the entry, but it matches the pattern in this partition.
            // we can try to construct an endpoint based on the heuristics described in endpoints.json
            else if (new Regex(regionPattern).Match(regionName).Success)
            {
                description = GetUnknownRegionDescription(regionName);
                return true;
            }

            else
            {
                description = GetUnknownRegionDescription(regionName);
                return false;
            }
        }

        public IRegionEndpoint GetRegionEndpoint(string regionName)
        {
            try
            {
                try
                {
                    _readerWriterLock.EnterReadLock();

                    IRegionEndpoint endpoint;
                    if (_regionEndpointMap.TryGetValue(regionName, out endpoint))
                    {
                        return endpoint;
                    }
                }
                finally
                {
                    if (_readerWriterLock.IsReadLockHeld)
                    {
                        _readerWriterLock.ExitReadLock();
                    }
                }

                try
                {
                    _readerWriterLock.EnterWriteLock();

                    IRegionEndpoint endpoint;
                    // Check again to see if region is in cache in case another thread got the write lock before and filled the cache.
                    if (_regionEndpointMap.TryGetValue(regionName, out endpoint))
                    {
                        return endpoint;
                    }

                    JsonData partitions = _root["partitions"];
                    foreach (JsonData partition in partitions)
                    {
                        string description;
                        if (IsRegionInPartition(regionName, partition, out description))
                        {
                            endpoint = new RegionEndpointV3(regionName, description, partition, partition["services"]);
                            _regionEndpointMap.Add(regionName, endpoint);
                            return endpoint;
                        }
                    }
                }
                finally
                {
                    if (_readerWriterLock.IsWriteLockHeld)
                    {
                        _readerWriterLock.ExitWriteLock();
                    }
                }
            }
            catch (Exception)
            {
                throw new AmazonClientException("Invalid endpoint.json format.");
            }

            return GetNonstandardRegionEndpoint(regionName);
        }

        /// <summary>
        /// This region name is non-standard.  Search the whole endpoints.json file to
        /// determine the partition this region is in.
        /// </summary>
        private IRegionEndpoint GetNonstandardRegionEndpoint(string regionName)
        {
            try
            {
                _readerWriterLock.EnterReadLock();

                IRegionEndpoint regionEndpoint;
                if (_nonStandardRegionNameToObjectMap.TryGetValue(regionName, out regionEndpoint))
                {
                    return regionEndpoint;
                }
            }
            finally
            {
                if (_readerWriterLock.IsReadLockHeld)
                {
                    _readerWriterLock.ExitReadLock();
                }
            }

            try
            {
                _readerWriterLock.EnterWriteLock();

                IRegionEndpoint regionEndpoint;
                // Check again to see if region is in cache in case another thread got the write lock before and filled the cache.
                if (_nonStandardRegionNameToObjectMap.TryGetValue(regionName, out regionEndpoint))
                {
                    return regionEndpoint;
                }

                // default to "aws" partition
                JsonData partitionData = _root["partitions"][0];
                string regionDescription = GetUnknownRegionDescription(regionName);
                JsonData servicesData = partitionData["services"];
                bool foundContainingPartition = false;

                const string validRegionRegexStr = @"^[a-zA-Z0-9]([a-zA-Z0-9\-]*[a-zA-Z0-9])?$";
                var match = Regex.Match(regionName, validRegionRegexStr, RegexOptions.Compiled);

                foreach (JsonData partition in _root["partitions"])
                {
                    JsonData partitionServices = partition["services"];
                    foreach (string service in partitionServices.PropertyNames)
                    {
                        if (partitionServices[service] != null && partitionServices[service].Count > 0)
                        {
                            JsonData serviceData = partitionServices[service];
                            if (serviceData != null && serviceData["endpoints"][regionName] != null)
                            {
                                partitionData = partition;
                                servicesData = partitionServices;
                                foundContainingPartition = true;
                                break;
                            }
                        }
                    }
                }
                if (!foundContainingPartition && !match.Success)
                {
                    throw new ArgumentException("Invalid region endpoint provided");
                }
                regionEndpoint = new RegionEndpointV3(regionName, regionDescription, partitionData, servicesData);
                _nonStandardRegionNameToObjectMap.Add(regionName, regionEndpoint);
                return regionEndpoint;
            }
            finally
            {
                if (_readerWriterLock.IsWriteLockHeld)
                {
                    _readerWriterLock.ExitWriteLock();
                }
            }
        }
        private static JsonData _emptyDictionaryJsonData = JsonMapper.ToObject("{}");
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _readerWriterLock.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Returns the DNS suffix for the given partition, or
        /// an empty string if a matching partition was not found in endpoints.json
        /// </summary>
        /// <param name="partition">partition</param>
        /// <returns>DNS suffix for the given partition, empty string if a matching partition was not found</returns>
        public string GetDnsSuffixForPartition(string partition)
        {
            foreach (JsonData currentPartition in _root["partitions"])
            {
                if ((string)currentPartition["partition"] == partition)
                {
                    return (string)currentPartition["dnsSuffix"];
                }
            }
            return "";
        }
    }
}
