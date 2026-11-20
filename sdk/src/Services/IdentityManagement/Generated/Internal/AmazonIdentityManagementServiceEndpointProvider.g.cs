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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;
using Amazon.Runtime.Internal.Endpoints;
using Amazon.Runtime.Internal.Endpoints.StandardLibrary;
using Amazon.IdentityManagement.Endpoints;

namespace Amazon.IdentityManagement.Internal
{
    /// <summary>
    /// Amazon IdentityManagementService endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="IdentityManagementServiceEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonIdentityManagementServiceEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonIdentityManagementServiceEndpointProvider.Context>
    {
        private sealed class Context
        {
            public IdentityManagementServiceEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }

            public Context(IdentityManagementServiceEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAAAACoAAAADAAAAAQAAAAQF9eEpAAAAAgAAAAUF9eEpAAAAAwAAACcAAAAGAAAABAAAACQAAAAHAAAABQAAACMAAAAIAAAABgAAACAAAAAJAAAABwAAABQAAAAKAAAACAAAAA8AAAALAAAACQX14RIAAAAMAAAACgX14RYAAAANAAAACwX14RoAAAAOAAAADAX14R4F9eEoAAAACQX14RQAAAAQAAAACgX14RgAAAARAAAACwX14RwAAAASAAAADAX14SAAAAATAAAADQX14SYF9eEnAAAACAAAABoAAAAVAAAACQX14RMAAAAWAAAACgX14RcAAAAXAAAACwX14RsAAAAYAAAADAX14R8AAAAZAAAADgX14SQF9eElAAAACQX14RUAAAAbAAAACgX14RkAAAAcAAAACwX14R0AAAAdAAAADAX14SEAAAAeAAAADQAAAB8F9eEjAAAADgX14SIF9eEjAAAABwAAACIAAAAhAAAACAX14RAF9eEOAAAACAX14REF9eEPAAAACAX14QwF9eENAAAABwAAACYAAAAlAAAACAX14QgF9eEKAAAACAX14QkF9eELAAAABwAAACkAAAAoAAAACAX14QYF9eEEAAAACAX14QcF9eEFAAAABwX14QEAAAArAAAACAX14QIF9eED");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for IdentityManagementServiceEndpointParameters.
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters["UseDualStack"] == null)
            {
                throw new AmazonClientException("UseDualStack parameter must be set for endpoint resolution");
            }
            if (parameters["UseFIPS"] == null)
            {
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");
            }

            var typed = (IdentityManagementServiceEndpointParameters)parameters;
            var context = new Context(typed);
            var result = BddEvaluator.Evaluate(Nodes, Root, this, context);
            switch (result)
            {
                case 0:
                    throw new AmazonClientException("Cannot resolve endpoint");
                case 1:
                    throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
                case 2:
                    throw new AmazonClientException("Invalid Configuration: Dualstack and custom endpoint are not supported");
                case 3:
                    return new Endpoint((string)context.Parameters.Endpoint);
                case 4:
                    return new Endpoint("https://iam.amazonaws.com")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-east-1", null, null) },
                    };
                case 5:
                    return new Endpoint("https://iam-fips.amazonaws.com")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-east-1", null, null) },
                    };
                case 6:
                    return new Endpoint("https://iam.global.api.aws")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-east-1", null, null) },
                    };
                case 7:
                    return new Endpoint("https://iam-fips.global.api.aws")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-east-1", null, null) },
                    };
                case 8:
                    return new Endpoint("https://iam.global.api.amazonwebservices.com.cn")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "cn-north-1", null, null) },
                    };
                case 9:
                    return new Endpoint("https://iam-fips.api.amazonwebservices.com.cn")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "cn-north-1", null, null) },
                    };
                case 10:
                    return new Endpoint("https://iam.cn-north-1.amazonaws.com.cn")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "cn-north-1", null, null) },
                    };
                case 11:
                    return new Endpoint("https://iam-fips.amazonaws.com.cn")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "cn-north-1", null, null) },
                    };
                case 12:
                    return new Endpoint("https://iam.us-gov.api.aws")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-gov-west-1", null, null) },
                    };
                case 13:
                    return new Endpoint("https://iam.us-gov.amazonaws.com")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-gov-west-1", null, null) },
                    };
                case 14:
                    return new Endpoint("https://iam.us-iso-east-1.c2s.ic.gov")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-iso-east-1", null, null) },
                    };
                case 15:
                    return new Endpoint("https://iam-fips.us-iso-east-1.c2s.ic.gov")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-iso-east-1", null, null) },
                    };
                case 16:
                    return new Endpoint("https://iam.api.aws.ic.gov")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-iso-east-1", null, null) },
                    };
                case 17:
                    return new Endpoint("https://iam-fips.api.aws.ic.gov")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-iso-east-1", null, null) },
                    };
                case 18:
                    return new Endpoint("https://iam.us-isob-east-1.sc2s.sgov.gov")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-isob-east-1", null, null) },
                    };
                case 19:
                    return new Endpoint("https://iam-fips.us-isob-east-1.sc2s.sgov.gov")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-isob-east-1", null, null) },
                    };
                case 20:
                    return new Endpoint("https://iam.api.aws.scloud")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-isob-east-1", null, null) },
                    };
                case 21:
                    return new Endpoint("https://iam-fips.api.aws.scloud")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-isob-east-1", null, null) },
                    };
                case 22:
                    return new Endpoint("https://iam.eu-isoe-west-1.cloud.adc-e.uk")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "eu-isoe-west-1", null, null) },
                    };
                case 23:
                    return new Endpoint("https://iam-fips.cloud.adc-e.uk")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "eu-isoe-west-1", null, null) },
                    };
                case 24:
                    return new Endpoint("https://iam.api.cloud-aws.adc-e.uk")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "eu-isoe-west-1", null, null) },
                    };
                case 25:
                    return new Endpoint("https://iam-fips.api.cloud-aws.adc-e.uk")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "eu-isoe-west-1", null, null) },
                    };
                case 26:
                    return new Endpoint("https://iam.us-isof-south-1.csp.hci.ic.gov")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-isof-south-1", null, null) },
                    };
                case 27:
                    return new Endpoint("https://iam-fips.csp.hci.ic.gov")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-isof-south-1", null, null) },
                    };
                case 28:
                    return new Endpoint("https://iam.api.aws.hci.ic.gov")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-isof-south-1", null, null) },
                    };
                case 29:
                    return new Endpoint("https://iam-fips.api.aws.hci.ic.gov")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-isof-south-1", null, null) },
                    };
                case 30:
                    return new Endpoint("https://iam.eusc-de-east-1.amazonaws.eu")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "eusc-de-east-1", null, null) },
                    };
                case 31:
                    return new Endpoint("https://iam-fips.amazonaws.eu")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "eusc-de-east-1", null, null) },
                    };
                case 32:
                    return new Endpoint("https://iam.global.api.amazonwebservices.eu")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "eusc-de-east-1", null, null) },
                    };
                case 33:
                    return new Endpoint("https://iam-fips.api.amazonwebservices.eu")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "eusc-de-east-1", null, null) },
                    };
                case 34:
                    return new Endpoint($"https://iam-fips.{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, $"{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}", null, null) },
                    };
                case 35:
                    throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                case 36:
                    return new Endpoint($"https://iam-fips.{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, $"{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}", null, null) },
                    };
                case 37:
                    throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                case 38:
                    return new Endpoint($"https://iam.{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, $"{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}", null, null) },
                    };
                case 39:
                    throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                case 40:
                    return new Endpoint($"https://iam.{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, $"{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}", null, null) },
                    };
                case 41:
                    throw new AmazonClientException("Invalid Configuration: Missing Region");
                default:
                    throw new AmazonClientException("Cannot resolve endpoint");
            }
        }

        /// <summary>
        /// Evaluates the BDD condition at <paramref name="conditionIndex"/> against the context.
        /// </summary>
        bool IBddConditionEvaluator<Context>.EvaluateCondition(int conditionIndex, Context context)
        {
            switch (conditionIndex)
            {
                case 0:
                    return IsSet(context.Parameters.Endpoint);
                case 1:
                    return IsSet(context.Parameters.Region);
                case 2:
                    return (context.PartitionResult = Partition((string)context.Parameters.Region)) != null;
                case 3:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws");
                case 4:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-cn");
                case 5:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-us-gov");
                case 6:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso");
                case 7:
                    return Equals(context.Parameters.UseFIPS, true);
                case 8:
                    return Equals(context.Parameters.UseDualStack, true);
                case 9:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso-b");
                case 10:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso-e");
                case 11:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso-f");
                case 12:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-eusc");
                case 13:
                    return Equals(GetAttr(context.PartitionResult, "supportsDualStack"), true);
                case 14:
                    return Equals(GetAttr(context.PartitionResult, "supportsFIPS"), true);
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
