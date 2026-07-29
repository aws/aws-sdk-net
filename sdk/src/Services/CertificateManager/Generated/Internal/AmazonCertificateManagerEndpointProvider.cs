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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.CertificateManager.Internal
{
    /// <summary>
    /// Amazon CertificateManager endpoint provider.
    /// Resolves endpoint for given set of CertificateManagerEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonCertificateManagerEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for CertificateManagerEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["Region"] == null)
                throw new AmazonClientException("Region parameter must be set for endpoint resolution");
            if (parameters["UseFIPS"] == null)
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");
            if (parameters["UseDualStack"] == null)
                throw new AmazonClientException("UseDualStack parameter must be set for endpoint resolution");
            if (parameters["ServiceType"] == null)
                throw new AmazonClientException("ServiceType parameter must be set for endpoint resolution");

            var refs = new Dictionary<string, object>()
            {
                ["Region"] = parameters["Region"],
                ["Endpoint"] = parameters["Endpoint"],
                ["UseFIPS"] = parameters["UseFIPS"],
                ["UseDualStack"] = parameters["UseDualStack"],
                ["ServiceType"] = parameters["ServiceType"],
            };
            if (IsSet(refs["Endpoint"]))
            {
                return new Endpoint(Interpolate(@"{Endpoint}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if ((refs["PartitionResult"] = Partition((string)refs["Region"])) != null)
            {
                if (Equals(refs["ServiceType"], "ACM-ACME"))
                {
                    if (IsSet(refs["Endpoint"]))
                    {
                        return new Endpoint(Interpolate(@"{Endpoint}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws"))
                    {
                        if (Equals(refs["UseFIPS"], true))
                        {
                            throw new AmazonClientException("FIPS endpoints are not available for ACME operations");
                        }
                        return new Endpoint(Interpolate(@"https://acm-acme.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    throw new AmazonClientException("ACME operations are only available in commercial AWS partitions");
                }
                if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true))
                {
                    return new Endpoint(Interpolate(@"https://acm-fips.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                }
                if (Equals(refs["UseFIPS"], true))
                {
                    if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws-us-gov"))
                    {
                        return new Endpoint(Interpolate(@"https://acm.{Region}.amazonaws.com", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    return new Endpoint(Interpolate(@"https://acm-fips.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                }
                if (Equals(refs["UseDualStack"], true))
                {
                    return new Endpoint(Interpolate(@"https://acm.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                }
                return new Endpoint(Interpolate(@"https://acm.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            throw new AmazonClientException("Region must be set to resolve an endpoint.");

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}