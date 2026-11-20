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
using Amazon.CostExplorer.Endpoints;

namespace Amazon.CostExplorer.Internal
{
    /// <summary>
    /// Amazon CostExplorer endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="CostExplorerEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonCostExplorerEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonCostExplorerEndpointProvider.Context>
    {
        private sealed class Context
        {
            public CostExplorerEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }

            public Context(CostExplorerEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAAAABQAAAADAAAAAQAAAAQF9eESAAAAAgAAAAUF9eESAAAAAwAAABAAAAAGAAAABQAAAAwAAAAHAAAABgX14QYAAAAIAAAABwX14QcAAAAJAAAACAX14QgAAAAKAAAACwX14QkAAAALAAAADAX14QoF9eERAAAACQX14QQAAAANAAAACgX14QUAAAAOAAAADAX14QoAAAAPAAAADQX14Q8F9eEQAAAABAAAABIAAAARAAAABQX14QwF9eEOAAAABQAAABMF9eENAAAADQX14QsF9eEMAAAAAwX14QEAAAAVAAAABQX14QIF9eED");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for CostExplorerEndpointParameters.
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

            var typed = (CostExplorerEndpointParameters)parameters;
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
                    return new Endpoint("https://ce.us-east-1.api.aws")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-east-1", null, null) },
                    };
                case 5:
                    return new Endpoint("https://ce.cn-northwest-1.api.amazonwebservices.com.cn")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "cn-northwest-1", null, null) },
                    };
                case 6:
                    return new Endpoint("https://ce.us-iso-east-1.c2s.ic.gov")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-iso-east-1", null, null) },
                    };
                case 7:
                    return new Endpoint("https://ce.us-isob-east-1.sc2s.sgov.gov")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-isob-east-1", null, null) },
                    };
                case 8:
                    return new Endpoint("https://ce.eu-isoe-west-1.cloud.adc-e.uk")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "eu-isoe-west-1", null, null) },
                    };
                case 9:
                    return new Endpoint("https://ce.us-isof-south-1.csp.hci.ic.gov")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "us-isof-south-1", null, null) },
                    };
                case 10:
                    return new Endpoint("https://ce.eusc-de-east-1.api.amazonwebservices.eu")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, "eusc-de-east-1", null, null) },
                    };
                case 11:
                    return new Endpoint($"https://ce-fips.{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, $"{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}", null, null) },
                    };
                case 12:
                    throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                case 13:
                    return new Endpoint($"https://ce-fips.{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, $"{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}", null, null) },
                    };
                case 14:
                    throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                case 15:
                    return new Endpoint($"https://ce.{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, $"{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}", null, null) },
                    };
                case 16:
                    throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                case 17:
                    return new Endpoint($"https://ce.{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", null, $"{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}", null, null) },
                    };
                case 18:
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
                    return Equals(context.Parameters.UseFIPS, true);
                case 4:
                    return Equals(GetAttr(context.PartitionResult, "supportsFIPS"), true);
                case 5:
                    return Equals(context.Parameters.UseDualStack, true);
                case 6:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso");
                case 7:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso-b");
                case 8:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso-e");
                case 9:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws");
                case 10:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-cn");
                case 11:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso-f");
                case 12:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-eusc");
                case 13:
                    return Equals(GetAttr(context.PartitionResult, "supportsDualStack"), true);
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
