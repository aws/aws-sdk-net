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
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;

namespace Amazon.Runtime.Endpoints
{
    /// <summary>
    /// Endpoint to be used when calling service operation.
    /// </summary>
    public class Endpoint
    {
        /// <summary>
        /// Constructor used by custorm EndpointProvider
        /// </summary>
        public Endpoint(string url) : this(url, null, null)
        {
        }

        /// <summary>
        /// Constructor used by code-generated EndpointProvider
        /// </summary>
        public Endpoint(string url, string attributesJson, string headersJson)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            
            URL = url;

            if (!string.IsNullOrEmpty(attributesJson))
            {
                using JsonDocument doc = JsonDocument.Parse(attributesJson);
                var attributes = doc.RootElement;
                Attributes = PropertyBag.FromJsonElement(attributes);
            }

            if (!string.IsNullOrEmpty(headersJson))
            {
                using JsonDocument doc = JsonDocument.Parse(headersJson);
                var headers = doc.RootElement;
                Headers = new Dictionary<string, IList<string>>();
                foreach (JsonProperty key in headers.EnumerateObject())
                {
                    var headerValues = new List<string>();
                    if (headers.TryGetProperty(key.Name, out JsonElement value) && value.ValueKind == JsonValueKind.Array)
                    {
                        foreach (JsonElement item in value.EnumerateArray())
                        {
                            headerValues.Add(item.GetString());
                        }
                    }
                    Headers.Add(key.Name, headerValues);
                }
            }
        }

        /// <summary>
        /// Endpoint's url 
        /// </summary>
        public string URL { get; set; }

        private IPropertyBag _attributes;
        private IReadOnlyList<AuthScheme> _authSchemes;
        private bool _authSchemesSynthesized;

        // Guards the one-time synthesis of Attributes["authSchemes"]. Created on first use so endpoints
        // whose Attributes are never read allocate no lock.
        private object _synthesisLock;

        /// <summary>
        /// Custom endpoint attributes. When typed <see cref="AuthSchemes"/> are set, reading this
        /// builds an "authSchemes" entry in the same shape the rules-based provider produces.
        /// </summary>
        public IPropertyBag Attributes
        {
            get
            {
                if (_authSchemes != null && !_authSchemesSynthesized)
                {
                    SynthesizeAuthSchemes();
                }
                return _attributes;
            }
            set
            {
                _attributes = value;
                _authSchemesSynthesized = false;
            }
        }

        /// <summary>
        /// Internal fast-path accessor returning the raw attributes bag, or null when none was set.
        /// </summary>
        internal IPropertyBag RawAttributesOrNull => _attributes;

        /// <summary>
        /// Custom endpoint headers
        /// </summary>
        public IDictionary<string, IList<string>> Headers { get; set; }

        /// <summary>
        /// Typed auth schemes resolved by BDD providers. Preferred over Attributes["authSchemes"].
        /// </summary>
        public IReadOnlyList<AuthScheme> AuthSchemes
        {
            get => _authSchemes;
            set
            {
                _authSchemes = value;
                _authSchemesSynthesized = false;
            }
        }

        private void SynthesizeAuthSchemes()
        {
            lock (LazyInitializer.EnsureInitialized(ref _synthesisLock, () => new object()))
            {
                if (_authSchemesSynthesized || _authSchemes == null)
                {
                    return;
                }

                var bag = _attributes ?? new PropertyBag();
                // A provider-supplied list (e.g. from attributesJson) is authoritative; don't overwrite it.
                if (bag["authSchemes"] == null)
                {
                    var list = new List<object>(_authSchemes.Count);
                    foreach (var scheme in _authSchemes)
                    {
                        list.Add(ToPropertyBag(scheme));
                    }
                    bag["authSchemes"] = list;
                }
                _attributes = bag;
                _authSchemesSynthesized = true;
            }
        }

        private static PropertyBag ToPropertyBag(AuthScheme scheme)
        {
            var bag = new PropertyBag();
            bag["name"] = scheme.Name;
            if (scheme.SigningName != null) bag["signingName"] = scheme.SigningName;
            if (scheme.SigningRegion != null) bag["signingRegion"] = scheme.SigningRegion;
            if (scheme.SigningRegionSet != null) bag["signingRegionSet"] = new List<object>(scheme.SigningRegionSet);
            if (scheme.DisableDoubleEncoding is bool disable) bag["disableDoubleEncoding"] = disable;
            return bag;
        }
    }
}
