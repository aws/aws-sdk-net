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
using Amazon.CertificateManager.Endpoints;

namespace Amazon.CertificateManager.Internal
{
    /// <summary>
    /// Amazon CertificateManager endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="CertificateManagerEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonCertificateManagerEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonCertificateManagerEndpointProvider.Context>
    {
        private sealed class Context
        {
            public CertificateManagerEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }

            public Context(CertificateManagerEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAX14QEAAAADAAAAAQAAAAQF9eEKAAAAAgAAAAkAAAAFAAAAAwAAAAcAAAAGAAAABQX14QgF9eEJAAAABQX14QUAAAAIAAAABgX14QYF9eEHAAAAAwAAAAwAAAAKAAAABAX14QMAAAALAAAABgX14QMF9eEEAAAABAX14QIAAAANAAAABgX14QIF9eEE");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for CertificateManagerEndpointParameters.
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters["Region"] == null)
            {
                throw new AmazonClientException("Region parameter must be set for endpoint resolution");
            }
            if (parameters["UseFIPS"] == null)
            {
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");
            }
            if (parameters["UseDualStack"] == null)
            {
                throw new AmazonClientException("UseDualStack parameter must be set for endpoint resolution");
            }
            if (parameters["ServiceType"] == null)
            {
                throw new AmazonClientException("ServiceType parameter must be set for endpoint resolution");
            }

            var typed = (CertificateManagerEndpointParameters)parameters;
            var context = new Context(typed);
            var result = BddEvaluator.Evaluate(Nodes, Root, this, context);
            switch (result)
            {
                case 0:
                    throw new AmazonClientException("Cannot resolve endpoint");
                case 1:
                    return new Endpoint($"{context.Parameters.Endpoint}");
                case 2:
                    throw new AmazonClientException("FIPS endpoints are not available for ACME operations");
                case 3:
                    return new Endpoint($"https://acm-acme.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 4:
                    throw new AmazonClientException("ACME operations are only available in the aws and aws-us-gov partitions");
                case 5:
                    return new Endpoint($"https://acm-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 6:
                    return new Endpoint($"https://acm.{context.Parameters.Region}.amazonaws.com");
                case 7:
                    return new Endpoint($"https://acm-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 8:
                    return new Endpoint($"https://acm.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 9:
                    return new Endpoint($"https://acm.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 10:
                    throw new AmazonClientException("Region must be set to resolve an endpoint.");
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
                    return (context.PartitionResult = Partition((string)context.Parameters.Region)) != null;
                case 2:
                    return Equals(context.Parameters.ServiceType, "ACM-ACME");
                case 3:
                    return Equals(context.Parameters.UseFIPS, true);
                case 4:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws");
                case 5:
                    return Equals(context.Parameters.UseDualStack, true);
                case 6:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-us-gov");
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
