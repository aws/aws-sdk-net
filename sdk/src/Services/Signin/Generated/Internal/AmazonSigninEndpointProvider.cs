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
 * Do not modify this file. This file is generated from the signin-2023-01-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.Signin.Internal
{
    /// <summary>
    /// Amazon Signin endpoint provider.
    /// Resolves endpoint for given set of SigninEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonSigninEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for SigninEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["UseDualStack"] == null)
                throw new AmazonClientException("UseDualStack parameter must be set for endpoint resolution");
            if (parameters["UseFIPS"] == null)
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");

            var refs = new Dictionary<string, object>()
            {
                ["UseDualStack"] = parameters["UseDualStack"],
                ["UseFIPS"] = parameters["UseFIPS"],
                ["Endpoint"] = parameters["Endpoint"],
                ["Region"] = parameters["Region"],
                ["IsControlPlane"] = parameters["IsControlPlane"],
                ["IsOAuthEndpoint"] = parameters["IsOAuthEndpoint"],
            };
            if (IsSet(refs["IsControlPlane"]) && Equals(refs["IsControlPlane"], true) && IsSet(refs["Region"]) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null)
            {
                if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws"))
                {
                    return new Endpoint(Interpolate(@"https://signin.{Region}.api.aws", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingName"":""signin"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                }
                if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws-cn"))
                {
                    return new Endpoint(Interpolate(@"https://signin.{Region}.api.amazonwebservices.com.cn", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingName"":""signin"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                }
                return new Endpoint(Interpolate(@"https://signin.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingName"":""signin"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["IsOAuthEndpoint"]) && Equals(refs["IsOAuthEndpoint"], true) && Equals(refs["UseFIPS"], true))
            {
                throw new AmazonClientException("FIPS endpoints are not supported for OAuth operations. Disable FIPS or use a non-OAuth operation.");
            }
            if (IsSet(refs["IsOAuthEndpoint"]) && Equals(refs["IsOAuthEndpoint"], true) && IsSet(refs["Region"]) && !IsSet(refs["Endpoint"]) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null && Equals(GetAttr(refs["PartitionResult"], "name"), "aws"))
            {
                return new Endpoint(Interpolate(@"https://{Region}.oauth.signin.aws", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingName"":""signin"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null && Equals(GetAttr(refs["PartitionResult"], "name"), "aws"))
            {
                return new Endpoint(Interpolate(@"https://{Region}.signin.aws.amazon.com", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null && Equals(GetAttr(refs["PartitionResult"], "name"), "aws-cn"))
            {
                return new Endpoint(Interpolate(@"https://{Region}.signin.amazonaws.cn", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null && Equals(GetAttr(refs["PartitionResult"], "name"), "aws-us-gov"))
            {
                return new Endpoint(Interpolate(@"https://{Region}.signin.amazonaws-us-gov.com", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null && Equals(GetAttr(refs["PartitionResult"], "name"), "aws-iso"))
            {
                return new Endpoint(Interpolate(@"https://{Region}.signin.c2shome.ic.gov", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null && Equals(GetAttr(refs["PartitionResult"], "name"), "aws-iso-b"))
            {
                return new Endpoint(Interpolate(@"https://{Region}.signin.sc2shome.sgov.gov", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null && Equals(GetAttr(refs["PartitionResult"], "name"), "aws-iso-f"))
            {
                return new Endpoint(Interpolate(@"https://{Region}.signin.csphome.hci.ic.gov", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null && Equals(GetAttr(refs["PartitionResult"], "name"), "aws-iso-e"))
            {
                return new Endpoint(Interpolate(@"https://{Region}.signin.csphome.adc-e.uk", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null && Equals(GetAttr(refs["PartitionResult"], "name"), "aws-eusc"))
            {
                return new Endpoint(Interpolate(@"https://{Region}.signin.amazonaws-eusc.eu", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], false) && Equals(refs["Region"], "us-gov-west-1"))
            {
                return new Endpoint("https://signin-fips.amazonaws-us-gov.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], false) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null && Equals(GetAttr(refs["PartitionResult"], "name"), "aws-us-gov"))
            {
                return new Endpoint(Interpolate(@"https://{Region}.signin-fips.amazonaws-us-gov.com", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null)
            {
                return new Endpoint(Interpolate(@"https://{Region}.signin.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Endpoint"]))
            {
                if (Equals(refs["UseFIPS"], true))
                {
                    throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
                }
                if (Equals(refs["UseDualStack"], true))
                {
                    throw new AmazonClientException("Invalid Configuration: Dualstack and custom endpoint are not supported");
                }
                return new Endpoint((string)refs["Endpoint"], InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]))
            {
                if ((refs["PartitionResult"] = Partition((string)refs["Region"])) != null)
                {
                    if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws") && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false))
                    {
                        return new Endpoint(Interpolate(@"https://{Region}.signin.aws.amazon.com", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws-cn") && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false))
                    {
                        return new Endpoint(Interpolate(@"https://{Region}.signin.amazonaws.cn", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws-us-gov") && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false))
                    {
                        return new Endpoint(Interpolate(@"https://{Region}.signin.amazonaws-us-gov.com", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")) && Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                        {
                            return new Endpoint(Interpolate(@"https://signin-fips.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                    }
                    if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], false))
                    {
                        if (Equals(GetAttr(refs["PartitionResult"], "supportsFIPS"), true))
                        {
                            return new Endpoint(Interpolate(@"https://signin-fips.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                    }
                    if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                        {
                            return new Endpoint(Interpolate(@"https://signin.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                    }
                    return new Endpoint(Interpolate(@"https://signin.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                }
            }
            throw new AmazonClientException("Invalid Configuration: Missing Region");

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}