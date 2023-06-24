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
 * Do not modify this file. This file is generated from the kendra-ranking-2022-10-19.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.KendraRanking.Internal
{
    /// <summary>
    /// Amazon KendraRanking endpoint provider.
    /// Resolves endpoint for given set of KendraRankingEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonKendraRankingEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for KendraRankingEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["Region"] == null)
                throw new AmazonClientException("Region parameter must be set for endpoint resolution");
            if (parameters["UseFIPS"] == null)
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");

            var refs = new Dictionary<string, object>()
            {
                ["Region"] = parameters["Region"],
                ["UseFIPS"] = parameters["UseFIPS"],
                ["Endpoint"] = parameters["Endpoint"],
            };
            if ((refs["PartitionResult"] = Partition((string)refs["Region"])) != null)
            {
                if (IsSet(refs["Endpoint"]))
                {
                    if (Equals(refs["UseFIPS"], true))
                    {
                        throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
                    }
                    return new Endpoint((string)refs["Endpoint"], InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                }
                if (Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                {
                    if (Equals(refs["UseFIPS"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")))
                        {
                            return new Endpoint(Interpolate(@"https://kendra-ranking-fips.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                    }
                    return new Endpoint(Interpolate(@"https://kendra-ranking.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                }
                if (Equals(refs["UseFIPS"], true))
                {
                    if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")))
                    {
                        return new Endpoint(Interpolate(@"https://kendra-ranking-fips.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                }
                return new Endpoint(Interpolate(@"https://kendra-ranking.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}