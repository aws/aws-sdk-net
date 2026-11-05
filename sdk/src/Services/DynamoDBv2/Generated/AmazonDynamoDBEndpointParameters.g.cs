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
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using Amazon.DynamoDBv2.Internal;

namespace Amazon.DynamoDBv2.Endpoints
{
    /// <summary>
    /// Contains parameters used for resolving DynamoDB endpoints.
    /// <para />
    /// Parameters can be sourced from client config and service operations used by the
    /// internal <see cref="AmazonDynamoDBEndpointProvider"/> and <see cref="AmazonDynamoDBEndpointResolver"/>.
    /// <para />
    /// Can be used by custom Endpoint Providers, <see cref="ClientConfig.EndpointProvider"/>
    /// </summary>
    public class DynamoDBEndpointParameters : EndpointParameters
    {
        /// <summary>
        /// DynamoDBEndpointParameters constructor
        /// </summary>
        public DynamoDBEndpointParameters()
        {
            UseDualStack = false;
            UseFIPS = false;
        }

        /// <summary>
        /// The AWS region used to dispatch the request.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// When true, use the dual-stack endpoint. If the configured endpoint does not support dual-stack, dispatching the request MAY return an error.
        /// </summary>
        public bool? UseDualStack { get; set; }

        /// <summary>
        /// When true, send this request to the FIPS-compliant regional endpoint. If the configured endpoint does not have a FIPS compliant endpoint, dispatching the request will return an error.
        /// </summary>
        public bool? UseFIPS { get; set; }

        /// <summary>
        /// Override the endpoint used to send this request
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// The AWS AccountId used for the request.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// The AccountId Endpoint Mode.
        /// </summary>
        public string AccountIdEndpointMode { get; set; }

        /// <summary>
        /// ResourceArn containing arn of resource
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// ResourceArnList containing list of resource arns
        /// </summary>
        public IEnumerable<string> ResourceArnList { get; set; }

        /// <summary>
        /// Set to true for SearchVectors to route to the Search FQDN
        /// </summary>
        public bool? IsSearchOperation { get; set; }

        /// <summary>
        /// Gets or sets an endpoint parameter by name. Known parameters read and write the typed
        /// properties; any other name falls through to the underlying property bag.
        /// </summary>
        public override object this[string name]
        {
            get => name switch
            {
                "Region" => Region,
                "UseDualStack" => UseDualStack,
                "UseFIPS" => UseFIPS,
                "Endpoint" => Endpoint,
                "AccountId" => AccountId,
                "AccountIdEndpointMode" => AccountIdEndpointMode,
                "ResourceArn" => ResourceArn,
                "ResourceArnList" => ResourceArnList,
                "IsSearchOperation" => IsSearchOperation,
                _ => base[name],
            };
            set
            {
                switch (name)
                {
                    case "Region": Region = (string)value; break;
                    case "UseDualStack": UseDualStack = (bool?)value; break;
                    case "UseFIPS": UseFIPS = (bool?)value; break;
                    case "Endpoint": Endpoint = (string)value; break;
                    case "AccountId": AccountId = (string)value; break;
                    case "AccountIdEndpointMode": AccountIdEndpointMode = (string)value; break;
                    case "ResourceArn": ResourceArn = (string)value; break;
                    case "ResourceArnList": ResourceArnList = (IEnumerable<string>)value; break;
                    case "IsSearchOperation": IsSearchOperation = (bool?)value; break;
                    default: base[name] = value; break;
                }
            }
        }

        /// <inheritdoc/>
        protected override bool ParameterValuesEqual(EndpointParameters other)
        {
            var o = (DynamoDBEndpointParameters)other;
            return Region == o.Region
                && UseDualStack == o.UseDualStack
                && UseFIPS == o.UseFIPS
                && Endpoint == o.Endpoint
                && AccountId == o.AccountId
                && AccountIdEndpointMode == o.AccountIdEndpointMode
                && ResourceArn == o.ResourceArn
                && Equals(ResourceArnList, o.ResourceArnList)
                && IsSearchOperation == o.IsSearchOperation
                && base.ParameterValuesEqual(other);
        }
    }
}
