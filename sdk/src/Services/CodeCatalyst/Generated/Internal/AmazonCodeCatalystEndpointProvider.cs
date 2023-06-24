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

/*
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.CodeCatalyst.Internal
{
    /// <summary>
    /// Amazon CodeCatalyst endpoint provider.
    /// Resolves endpoint for given set of CodeCatalystEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonCodeCatalystEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for CodeCatalystEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["UseFIPS"] == null)
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");

            var refs = new Dictionary<string, object>()
            {
                ["UseFIPS"] = parameters["UseFIPS"],
                ["Region"] = parameters["Region"],
                ["Endpoint"] = parameters["Endpoint"],
            };
            if (IsSet(refs["Endpoint"]))
            {
                return new Endpoint((string)refs["Endpoint"], InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (!IsSet(refs["Region"]) && (refs["PartitionResult"] = Partition("us-west-2")) != null)
            {
                if (Equals(refs["UseFIPS"], true))
                {
                    if (Equals(GetAttr(refs["PartitionResult"], "supportsFIPS"), false))
                    {
                        throw new AmazonClientException("Partition does not support FIPS.");
                    }
                    return new Endpoint(Interpolate(@"https://codecatalyst-fips.global.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                }
                return new Endpoint(Interpolate(@"https://codecatalyst.global.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null)
            {
                if (Equals(refs["UseFIPS"], true))
                {
                    if (Equals(GetAttr(refs["PartitionResult"], "supportsFIPS"), false))
                    {
                        throw new AmazonClientException("Partition does not support FIPS.");
                    }
                    return new Endpoint(Interpolate(@"https://codecatalyst-fips.global.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                }
                return new Endpoint(Interpolate(@"https://codecatalyst.global.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}