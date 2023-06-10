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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.Kinesis.Internal
{
    /// <summary>
    /// Amazon Kinesis endpoint provider.
    /// Resolves endpoint for given set of KinesisEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonKinesisEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for KinesisEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["Region"] == null)
                throw new AmazonClientException("Region parameter must be set for endpoint resolution");
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
                ["StreamARN"] = parameters["StreamARN"],
                ["OperationType"] = parameters["OperationType"],
                ["ConsumerARN"] = parameters["ConsumerARN"],
            };
            if ((refs["PartitionResult"] = Partition((string)refs["Region"])) != null)
            {
                if (IsSet(refs["StreamARN"]) && !IsSet(refs["Endpoint"]) && !Equals(GetAttr(refs["PartitionResult"], "name"), "aws-iso") && !Equals(GetAttr(refs["PartitionResult"], "name"), "aws-iso-b"))
                {
                    if ((refs["arn"] = ParseArn((string)refs["StreamARN"])) != null)
                    {
                        if (IsValidHostLabel((string)GetAttr(refs["arn"], "accountId"), false))
                        {
                            if (IsValidHostLabel((string)GetAttr(refs["arn"], "region"), false))
                            {
                                if (Equals(GetAttr(refs["arn"], "service"), "kinesis"))
                                {
                                    if ((refs["arnType"] = GetAttr(refs["arn"], "resourceId[0]")) != null && !Equals(refs["arnType"], ""))
                                    {
                                        if (Equals(refs["arnType"], "stream"))
                                        {
                                            if (Equals(GetAttr(refs["PartitionResult"], "name"), Interpolate(@"{arn#partition}", refs)))
                                            {
                                                if (IsSet(refs["OperationType"]))
                                                {
                                                    if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true))
                                                    {
                                                        if (Equals(GetAttr(refs["PartitionResult"], "supportsFIPS"), true))
                                                        {
                                                            if (Equals(GetAttr(refs["PartitionResult"], "supportsDualStack"), true))
                                                            {
                                                                return new Endpoint(Interpolate(@"https://{arn#accountId}.{OperationType}-kinesis-fips.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                                                            }
                                                            throw new AmazonClientException("DualStack is enabled, but this partition does not support DualStack.");
                                                        }
                                                        throw new AmazonClientException("FIPS is enabled, but this partition does not support FIPS.");
                                                    }
                                                    if (Equals(refs["UseFIPS"], true))
                                                    {
                                                        if (Equals(GetAttr(refs["PartitionResult"], "supportsFIPS"), true))
                                                        {
                                                            return new Endpoint(Interpolate(@"https://{arn#accountId}.{OperationType}-kinesis-fips.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                                                        }
                                                        throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                                                    }
                                                    if (Equals(refs["UseDualStack"], true))
                                                    {
                                                        if (Equals(GetAttr(refs["PartitionResult"], "supportsDualStack"), true))
                                                        {
                                                            return new Endpoint(Interpolate(@"https://{arn#accountId}.{OperationType}-kinesis.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                                                        }
                                                        throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                                                    }
                                                    return new Endpoint(Interpolate(@"https://{arn#accountId}.{OperationType}-kinesis.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                                                }
                                                throw new AmazonClientException("Operation Type is not set. Please contact service team for resolution.");
                                            }
                                            throw new AmazonClientException(Interpolate(@"Partition: {arn#partition} from ARN doesn't match with partition name: {PartitionResult#name}.", refs));
                                        }
                                        throw new AmazonClientException(Interpolate(@"Invalid ARN: Kinesis ARNs don't support `{arnType}` arn types.", refs));
                                    }
                                    throw new AmazonClientException("Invalid ARN: No ARN type specified");
                                }
                                throw new AmazonClientException(Interpolate(@"Invalid ARN: The ARN was not for the Kinesis service, found: {arn#service}.", refs));
                            }
                            throw new AmazonClientException("Invalid ARN: Invalid region.");
                        }
                        throw new AmazonClientException("Invalid ARN: Invalid account id.");
                    }
                    throw new AmazonClientException("Invalid ARN: Failed to parse ARN.");
                }
                if (IsSet(refs["ConsumerARN"]) && !IsSet(refs["Endpoint"]) && !Equals(GetAttr(refs["PartitionResult"], "name"), "aws-iso") && !Equals(GetAttr(refs["PartitionResult"], "name"), "aws-iso-b"))
                {
                    if ((refs["arn"] = ParseArn((string)refs["ConsumerARN"])) != null)
                    {
                        if (IsValidHostLabel((string)GetAttr(refs["arn"], "accountId"), false))
                        {
                            if (IsValidHostLabel((string)GetAttr(refs["arn"], "region"), false))
                            {
                                if (Equals(GetAttr(refs["arn"], "service"), "kinesis"))
                                {
                                    if ((refs["arnType"] = GetAttr(refs["arn"], "resourceId[0]")) != null && !Equals(refs["arnType"], ""))
                                    {
                                        if (Equals(refs["arnType"], "stream"))
                                        {
                                            if (Equals(GetAttr(refs["PartitionResult"], "name"), Interpolate(@"{arn#partition}", refs)))
                                            {
                                                if (IsSet(refs["OperationType"]))
                                                {
                                                    if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true))
                                                    {
                                                        if (Equals(GetAttr(refs["PartitionResult"], "supportsFIPS"), true))
                                                        {
                                                            if (Equals(GetAttr(refs["PartitionResult"], "supportsDualStack"), true))
                                                            {
                                                                return new Endpoint(Interpolate(@"https://{arn#accountId}.{OperationType}-kinesis-fips.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                                                            }
                                                            throw new AmazonClientException("DualStack is enabled, but this partition does not support DualStack.");
                                                        }
                                                        throw new AmazonClientException("FIPS is enabled, but this partition does not support FIPS.");
                                                    }
                                                    if (Equals(refs["UseFIPS"], true))
                                                    {
                                                        if (Equals(GetAttr(refs["PartitionResult"], "supportsFIPS"), true))
                                                        {
                                                            return new Endpoint(Interpolate(@"https://{arn#accountId}.{OperationType}-kinesis-fips.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                                                        }
                                                        throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                                                    }
                                                    if (Equals(refs["UseDualStack"], true))
                                                    {
                                                        if (Equals(GetAttr(refs["PartitionResult"], "supportsDualStack"), true))
                                                        {
                                                            return new Endpoint(Interpolate(@"https://{arn#accountId}.{OperationType}-kinesis.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                                                        }
                                                        throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                                                    }
                                                    return new Endpoint(Interpolate(@"https://{arn#accountId}.{OperationType}-kinesis.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                                                }
                                                throw new AmazonClientException("Operation Type is not set. Please contact service team for resolution.");
                                            }
                                            throw new AmazonClientException(Interpolate(@"Partition: {arn#partition} from ARN doesn't match with partition name: {PartitionResult#name}.", refs));
                                        }
                                        throw new AmazonClientException(Interpolate(@"Invalid ARN: Kinesis ARNs don't support `{arnType}` arn types.", refs));
                                    }
                                    throw new AmazonClientException("Invalid ARN: No ARN type specified");
                                }
                                throw new AmazonClientException(Interpolate(@"Invalid ARN: The ARN was not for the Kinesis service, found: {arn#service}.", refs));
                            }
                            throw new AmazonClientException("Invalid ARN: Invalid region.");
                        }
                        throw new AmazonClientException("Invalid ARN: Invalid account id.");
                    }
                    throw new AmazonClientException("Invalid ARN: Failed to parse ARN.");
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
                if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true))
                {
                    if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")) && Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                    {
                        return new Endpoint(Interpolate(@"https://kinesis-fips.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                }
                if (Equals(refs["UseFIPS"], true))
                {
                    if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")))
                    {
                        if (Equals("aws-us-gov", GetAttr(refs["PartitionResult"], "name")))
                        {
                            return new Endpoint(Interpolate(@"https://kinesis.{Region}.amazonaws.com", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                        }
                        return new Endpoint(Interpolate(@"https://kinesis-fips.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                }
                if (Equals(refs["UseDualStack"], true))
                {
                    if (Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                    {
                        return new Endpoint(Interpolate(@"https://kinesis.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                }
                if (Equals(refs["Region"], "us-gov-east-1"))
                {
                    return new Endpoint("https://kinesis.us-gov-east-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                }
                if (Equals(refs["Region"], "us-gov-west-1"))
                {
                    return new Endpoint("https://kinesis.us-gov-west-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                }
                return new Endpoint(Interpolate(@"https://kinesis.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}