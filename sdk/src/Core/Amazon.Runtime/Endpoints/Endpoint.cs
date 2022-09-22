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
using ThirdParty.Json.LitJson;

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
                var attributes = JsonMapper.ToObject(attributesJson);
                Attributes = PropertyBag.FromJsonData(attributes);
            }

            if (!string.IsNullOrEmpty(headersJson))
            {
                var headers = JsonMapper.ToObject(headersJson);
                Headers = new Dictionary<string, IList<string>>();
                foreach (var key in headers.PropertyNames)
                {
                    var headerValues = new List<string>();
                    var values = headers[key];
                    if (values != null && values.IsArray)
                    {
                        foreach (JsonData value in values)
                        {
                            headerValues.Add((string)value);
                        }
                    }
                    Headers.Add(key, headerValues);
                }
            }
        }

        /// <summary>
        /// Endpoint's url 
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// Custom endpoint attributes
        /// </summary>
        public IPropertyBag Attributes { get; set; }

        /// <summary>
        /// Custom endpoint headers
        /// </summary>
        public IDictionary<string, IList<string>> Headers { get; set; }
    }
}
