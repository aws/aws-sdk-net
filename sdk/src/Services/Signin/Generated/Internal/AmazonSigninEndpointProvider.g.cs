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
using Amazon.Signin.Endpoints;

namespace Amazon.Signin.Internal
{
    /// <summary>
    /// Amazon Signin endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="SigninEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonSigninEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonSigninEndpointProvider.Context>
    {
        private sealed class Context
        {
            public SigninEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }

            public Context(SigninEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAAAAAYAAAADAAAAAgAAACQAAAAEAAAABAAAAAUF9eEbAAAABgX14QQF9eEbAAAAAQAAAB0AAAAHAAAAAgAAACQAAAAIAAAAAwAAAAkAAAAfAAAABAAAABYAAAAKAAAABQAAABMAAAALAAAABwAAABUAAAAMAAAACAX14QcAAAANAAAACgX14QgAAAAOAAAADAX14QkAAAAPAAAADQX14QoAAAAQAAAADgX14QsAAAARAAAADwX14QwAAAASAAAAEAX14Q0F9eEQAAAABgX14QUAAAAUAAAABwAAABUF9eEGAAAAEQX14RgF9eEZAAAABgX14QQAAAAXAAAABwAAABsAAAAYAAAACQX14Q4AAAAZAAAACgX14Q8AAAAaAAAACwX14RYF9eEXAAAACwAAABwF9eEVAAAAEQX14RQF9eEVAAAAAgAAACMAAAAeAAAAAwAAACcAAAAfAAAABAAAACAF9eEbAAAABgX14QQAAAAhAAAABwX14RsAAAAiAAAACQX14Q4F9eEbAAAAAwAAACcAAAAkAAAABAAAACYAAAAlAAAABwX14RIF9eETAAAABgX14QQF9eERAAAABQX14QEAAAAoAAAACAX14QIF9eED");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for SigninEndpointParameters.
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

            var typed = (SigninEndpointParameters)parameters;
            var context = new Context(typed);
            var result = BddEvaluator.Evaluate(Nodes, Root, this, context);
            switch (result)
            {
                case 0:
                    throw new AmazonClientException("Cannot resolve endpoint");
                case 1:
                    return new Endpoint($"https://signin.{context.Parameters.Region}.api.aws")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "signin", $"{context.Parameters.Region}", null, null) },
                    };
                case 2:
                    return new Endpoint($"https://signin.{context.Parameters.Region}.api.amazonwebservices.com.cn")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "signin", $"{context.Parameters.Region}", null, null) },
                    };
                case 3:
                    return new Endpoint($"https://signin.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "signin", $"{context.Parameters.Region}", null, null) },
                    };
                case 4:
                    throw new AmazonClientException("FIPS endpoints are not supported for OAuth operations. Disable FIPS or use a non-OAuth operation.");
                case 5:
                    return new Endpoint($"https://{context.Parameters.Region}.oauth.signin.aws")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "signin", $"{context.Parameters.Region}", null, null) },
                    };
                case 6:
                    return new Endpoint($"https://{context.Parameters.Region}.signin.aws.amazon.com");
                case 7:
                    return new Endpoint($"https://{context.Parameters.Region}.signin.amazonaws.cn");
                case 8:
                    return new Endpoint($"https://{context.Parameters.Region}.signin.amazonaws-us-gov.com");
                case 9:
                    return new Endpoint($"https://{context.Parameters.Region}.signin.c2shome.ic.gov");
                case 10:
                    return new Endpoint($"https://{context.Parameters.Region}.signin.sc2shome.sgov.gov");
                case 11:
                    return new Endpoint($"https://{context.Parameters.Region}.signin.csphome.hci.ic.gov");
                case 12:
                    return new Endpoint($"https://{context.Parameters.Region}.signin.csphome.adc-e.uk");
                case 13:
                    return new Endpoint($"https://{context.Parameters.Region}.signin.amazonaws-eusc.eu");
                case 14:
                    return new Endpoint("https://signin-fips.amazonaws-us-gov.com");
                case 15:
                    return new Endpoint($"https://{context.Parameters.Region}.signin-fips.amazonaws-us-gov.com");
                case 16:
                    return new Endpoint($"https://{context.Parameters.Region}.signin.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 17:
                    throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
                case 18:
                    throw new AmazonClientException("Invalid Configuration: Dualstack and custom endpoint are not supported");
                case 19:
                    return new Endpoint((string)context.Parameters.Endpoint);
                case 20:
                    return new Endpoint($"https://signin-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 21:
                    throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                case 22:
                    return new Endpoint($"https://signin-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 23:
                    throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                case 24:
                    return new Endpoint($"https://signin.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 25:
                    throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                case 26:
                    return new Endpoint($"https://signin.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 27:
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
                    return IsSet(context.Parameters.Region);
                case 1:
                    return Equals((context.Parameters.IsControlPlane ?? false), true);
                case 2:
                    return IsSet(context.Parameters.Endpoint);
                case 3:
                    return (context.PartitionResult = Partition((string)context.Parameters.Region)) != null;
                case 4:
                    return Equals(context.Parameters.UseFIPS, true);
                case 5:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws");
                case 6:
                    return Equals((context.Parameters.IsOAuthEndpoint ?? false), true);
                case 7:
                    return Equals(context.Parameters.UseDualStack, true);
                case 8:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-cn");
                case 9:
                    return Equals(context.Parameters.Region, "us-gov-west-1");
                case 10:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-us-gov");
                case 11:
                    return Equals(GetAttr(context.PartitionResult, "supportsFIPS"), true);
                case 12:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso");
                case 13:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso-b");
                case 14:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso-f");
                case 15:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso-e");
                case 16:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-eusc");
                case 17:
                    return Equals(GetAttr(context.PartitionResult, "supportsDualStack"), true);
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
