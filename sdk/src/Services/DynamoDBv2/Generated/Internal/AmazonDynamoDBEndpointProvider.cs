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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.DynamoDBv2.Internal
{
    /// <summary>
    /// Amazon DynamoDB endpoint provider.
    /// Resolves endpoint for given set of DynamoDBEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonDynamoDBEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for DynamoDBEndpointParameters
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
                ["Region"] = parameters["Region"],
                ["UseDualStack"] = parameters["UseDualStack"],
                ["UseFIPS"] = parameters["UseFIPS"],
                ["Endpoint"] = parameters["Endpoint"],
                ["AccountId"] = parameters["AccountId"],
                ["AccountIdEndpointMode"] = parameters["AccountIdEndpointMode"],
                ["ResourceArn"] = parameters["ResourceArn"],
                ["ResourceArnList"] = parameters["ResourceArnList"],
            };
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
                return new Endpoint(Interpolate(@"{Endpoint}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]))
            {
                if ((refs["PartitionResult"] = Partition((string)refs["Region"])) != null)
                {
                    if (Equals(refs["Region"], "local"))
                    {
                        if (Equals(refs["UseFIPS"], true))
                        {
                            throw new AmazonClientException("Invalid Configuration: FIPS and local endpoint are not supported");
                        }
                        if (Equals(refs["UseDualStack"], true))
                        {
                            throw new AmazonClientException("Invalid Configuration: Dualstack and local endpoint are not supported");
                        }
                        return new Endpoint("http://localhost:8000", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingName"":""dynamodb"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true))
                    {
                        if (Equals(GetAttr(refs["PartitionResult"], "supportsFIPS"), true) && Equals(GetAttr(refs["PartitionResult"], "supportsDualStack"), true))
                        {
                            if (IsSet(refs["AccountIdEndpointMode"]) && Equals(refs["AccountIdEndpointMode"], "required"))
                            {
                                throw new AmazonClientException("Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported");
                            }
                            return new Endpoint(Interpolate(@"https://dynamodb-fips.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                    }
                    if (Equals(refs["UseFIPS"], true))
                    {
                        if (Equals(GetAttr(refs["PartitionResult"], "supportsFIPS"), true))
                        {
                            if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws-us-gov"))
                            {
                                if (IsSet(refs["AccountIdEndpointMode"]) && Equals(refs["AccountIdEndpointMode"], "required"))
                                {
                                    throw new AmazonClientException("Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported");
                                }
                                return new Endpoint(Interpolate(@"https://dynamodb.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                            }
                            if (IsSet(refs["AccountIdEndpointMode"]) && Equals(refs["AccountIdEndpointMode"], "required"))
                            {
                                throw new AmazonClientException("Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported");
                            }
                            return new Endpoint(Interpolate(@"https://dynamodb-fips.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                    }
                    if (Equals(refs["UseDualStack"], true))
                    {
                        if (Equals(GetAttr(refs["PartitionResult"], "supportsDualStack"), true))
                        {
                            if (IsSet(refs["AccountIdEndpointMode"]) && Equals(refs["AccountIdEndpointMode"], "required"))
                            {
                                if (!Equals(refs["UseFIPS"], true))
                                {
                                    throw new AmazonClientException("Invalid Configuration: AccountIdEndpointMode is required and DualStack is enabled, but DualStack account endpoints are not supported");
                                }
                                throw new AmazonClientException("Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported");
                            }
                            return new Endpoint(Interpolate(@"https://dynamodb.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                    }
                    if (IsSet(refs["AccountIdEndpointMode"]) && !Equals(refs["AccountIdEndpointMode"], "disabled") && Equals(GetAttr(refs["PartitionResult"], "name"), "aws") && !Equals(refs["UseFIPS"], true) && !Equals(refs["UseDualStack"], true) && IsSet(refs["ResourceArn"]) && (refs["ParsedArn"] = ParseArn((string)refs["ResourceArn"])) != null && Equals(GetAttr(refs["ParsedArn"], "service"), "dynamodb") && IsValidHostLabel((string)GetAttr(refs["ParsedArn"], "region"), false) && Equals(GetAttr(refs["ParsedArn"], "region"), Interpolate(@"{Region}", refs)) && IsValidHostLabel((string)GetAttr(refs["ParsedArn"], "accountId"), false))
                    {
                        return new Endpoint(Interpolate(@"https://{ParsedArn#accountId}.ddb.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (IsSet(refs["AccountIdEndpointMode"]) && !Equals(refs["AccountIdEndpointMode"], "disabled") && Equals(GetAttr(refs["PartitionResult"], "name"), "aws") && !Equals(refs["UseFIPS"], true) && !Equals(refs["UseDualStack"], true) && IsSet(refs["ResourceArnList"]) && (refs["FirstArn"] = GetAttr(refs["ResourceArnList"], "[0]")) != null && (refs["ParsedArn"] = ParseArn((string)refs["FirstArn"])) != null && Equals(GetAttr(refs["ParsedArn"], "service"), "dynamodb") && IsValidHostLabel((string)GetAttr(refs["ParsedArn"], "region"), false) && Equals(GetAttr(refs["ParsedArn"], "region"), Interpolate(@"{Region}", refs)) && IsValidHostLabel((string)GetAttr(refs["ParsedArn"], "accountId"), false))
                    {
                        return new Endpoint(Interpolate(@"https://{ParsedArn#accountId}.ddb.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (IsSet(refs["AccountIdEndpointMode"]) && !Equals(refs["AccountIdEndpointMode"], "disabled") && Equals(GetAttr(refs["PartitionResult"], "name"), "aws") && !Equals(refs["UseFIPS"], true) && !Equals(refs["UseDualStack"], true) && IsSet(refs["AccountId"]))
                    {
                        if (IsValidHostLabel((string)refs["AccountId"], false))
                        {
                            return new Endpoint(Interpolate(@"https://{AccountId}.ddb.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("Credentials-sourced account ID parameter is invalid");
                    }
                    if (IsSet(refs["AccountIdEndpointMode"]) && Equals(refs["AccountIdEndpointMode"], "required"))
                    {
                        if (!Equals(refs["UseFIPS"], true))
                        {
                            if (!Equals(refs["UseDualStack"], true))
                            {
                                if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws"))
                                {
                                    throw new AmazonClientException("AccountIdEndpointMode is required but no AccountID was provided or able to be loaded");
                                }
                                throw new AmazonClientException("Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition");
                            }
                            throw new AmazonClientException("Invalid Configuration: AccountIdEndpointMode is required and DualStack is enabled, but DualStack account endpoints are not supported");
                        }
                        throw new AmazonClientException("Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported");
                    }
                    return new Endpoint(Interpolate(@"https://dynamodb.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                }
            }
            throw new AmazonClientException("Invalid Configuration: Missing Region");

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}