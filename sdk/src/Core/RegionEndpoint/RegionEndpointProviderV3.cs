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
using Amazon.Runtime;
using Amazon.Runtime.Internal.Auth;
using System;
using System.Collections.Generic;
using System.IO;
using ThirdParty.Json.LitJson;

#if UNITY
using UnityEngine;
using Amazon.Runtime.Internal;
#endif

namespace Amazon.Internal
{
    public class RegionEndpointV3 : IRegionEndpoint
    {
        private Dictionary<string, Amazon.RegionEndpoint.Endpoint> _serviceMap = new Dictionary<string, RegionEndpoint.Endpoint>();

        public string RegionName { get; private set; }
        public string DisplayName { get; private set; }
        public string PartitionName
        {
            get
            {
                return (string)_partitionJsonData["partition"];
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

        public RegionEndpoint.Endpoint GetEndpointForService(string serviceName)
        {
            RegionEndpoint.Endpoint endpointObject = null;

            lock(_serviceMap)
            {
                if (!_servicesLoaded)
                {
                    ParseAllServices();
                    _servicesLoaded = true;
                }

                _serviceMap.TryGetValue(serviceName, out endpointObject);
            }
            return endpointObject;
        }

        private void ParseAllServices()
        {
            foreach (string serviceName in _servicesJsonData.PropertyNames)
            {
                AddServiceToMap(_servicesJsonData[serviceName], serviceName);
            }
        }

        private void AddServiceToMap(JsonData service, string serviceName)
        {
            string partitionEndpoint = service["partitionEndpoint"] != null ? (string)service["partitionEndpoint"] : "";
            bool isRegionalized = service["isRegionalized"] != null ? (bool)service["isRegionalized"] : true;

            string serviceEndpoint = RegionName;

            if (!isRegionalized && !string.IsNullOrEmpty(partitionEndpoint))
            {
                serviceEndpoint = partitionEndpoint;
            }

            JsonData regionEndpoint = service["endpoints"][serviceEndpoint];
            if (regionEndpoint == null)
            {
                return;
            }

            JsonData result = new JsonData();
            MergeJsonData(result, regionEndpoint);
            MergeJsonData(result, service["defaults"]);
            MergeJsonData(result, _partitionJsonData["defaults"]);

            CreateEndpointAndAddToServiceMap(result, RegionName, serviceName);
        }

        private static void MergeJsonData(JsonData target, JsonData source)
        {
            if (source == null || target == null)
            {
                return;
            }
            foreach (var propertyName in source.PropertyNames)
            {
                if (target[propertyName] == null)
                {
                    target[propertyName] = source[propertyName];
                }
            }
        }

        private void CreateEndpointAndAddToServiceMap(JsonData result, string regionName, string serviceName)
        {
            string template = (string)result["hostname"];
            string hostname = template.Replace("{service}", serviceName)
                                 .Replace("{region}", regionName)
                                 .Replace("{dnsSuffix}", (string)_partitionJsonData["dnsSuffix"]);

            string authRegion = null;
            string customService = null;
            JsonData credentialScope = result["credentialScope"];
            if (credentialScope != null)
            {
                authRegion = DetermineAuthRegion(credentialScope);
                // This is a workaround until we overhaul how the SDK consumes the v3 endpoint structure
                // and customize the signing based on the metadata in the endpoint structure.
                // There are points in SDK where we retrieve endpoints via service name such as "execute-api".
                // Since we are building a cache, just add the custom service entry.
                if (credentialScope["service"] != null && string.Compare((string)credentialScope["service"], serviceName, StringComparison.OrdinalIgnoreCase) != 0)
                {
                    customService = (string)credentialScope["service"];
                }
            }

            RegionEndpoint.Endpoint endpoint = new RegionEndpoint.Endpoint(hostname, authRegion, null);

            _serviceMap.Add(serviceName, endpoint);
            if (!string.IsNullOrEmpty(customService) && !_serviceMap.ContainsKey(customService))
            {
                _serviceMap.Add(customService, endpoint);
            }
        }

        private static string DetermineAuthRegion(JsonData credentialScope)
        {
            string authRegion = null;
            if (credentialScope["region"] != null)
            {
                authRegion = (string) credentialScope["region"];
            }
            return authRegion;
        }
    }

    public class RegionEndpointProviderV3 : IRegionEndpointProvider
    {
#if CORECLR
        private const string ENDPOINT_JSON_RESOURCE = "Core.endpoints.json";
#else
        private const string ENDPOINT_JSON_RESOURCE = "Amazon.endpoints.json";
#endif
        private JsonData _root;
        private Dictionary<string, IRegionEndpoint> _regionEndpointMap = new Dictionary<string, IRegionEndpoint>();
        private object _regionEndpointMapLock = new object();

        public RegionEndpointProviderV3()
        {
            using (var stream = Amazon.Util.Internal.TypeFactory.GetTypeInfo(typeof(RegionEndpointProviderV3)).Assembly.GetManifestResourceStream(ENDPOINT_JSON_RESOURCE))
            using (StreamReader reader = new StreamReader(stream))
            {
                _root = JsonMapper.ToObject(reader);
            }
        }

        public RegionEndpointProviderV3(JsonData root)
        {
            _root = root;
        }

        private object _allRegionEndpointsLock = new object();
        private IEnumerable<IRegionEndpoint> _allRegionEndpoints;
        public IEnumerable<IRegionEndpoint> AllRegionEndpoints
        {
            get
            {
                lock (_allRegionEndpointsLock)
                lock (_regionEndpointMapLock)
                {
                    if (_allRegionEndpoints == null)
                    {
                        JsonData partitions = _root["partitions"];
                        List<IRegionEndpoint> endpoints = new List<IRegionEndpoint>();
                        foreach (JsonData partition in partitions)
                        {
                            JsonData regions = partition["regions"];
                            foreach (string regionName in regions.PropertyNames)
                            {
                                IRegionEndpoint endpoint = new RegionEndpointV3(regionName, (string)regions[regionName]["descriptions"], partition, partition["services"]);
                                _regionEndpointMap.Add(regionName, endpoint);
                                endpoints.Add(endpoint);
                            }
                        }

                        _allRegionEndpoints = endpoints;
                    }
                }
                return _allRegionEndpoints;
            }
        }

        public IRegionEndpoint GetRegionEndpoint(string regionName)
        {
            try
            {
                lock (_regionEndpointMapLock)
                {
                    IRegionEndpoint endpoint;
                    if (_regionEndpointMap.TryGetValue(regionName, out endpoint))
                    {
                        return endpoint;
                    }
                    else
                    {

                        JsonData partitions = _root["partitions"];
                        foreach (JsonData partition in partitions)
                        {
                            JsonData region = partition["regions"][regionName];
                            if (region != null)
                            {
                                endpoint = new RegionEndpointV3(regionName, (string)region["description"], partition, partition["services"]);
                                _regionEndpointMap.Add(regionName, endpoint);
                                return endpoint;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new AmazonClientException("Invalid endpoint.json format.");
            }

            throw new AmazonClientException("Invalid region name.");
        }
    }
}
