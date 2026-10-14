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
using Amazon.EventBridgeV2.Internal;

namespace Amazon.EventBridgeV2.Endpoints
{
    /// <summary>
    /// Contains parameters used for resolving EventBridgeV2 endpoints.
    /// <para />
    /// Parameters can be sourced from client config and service operations used by the
    /// internal <see cref="AmazonEventBridgeV2EndpointProvider"/> and <see cref="AmazonEventBridgeV2EndpointResolver"/>.
    /// <para />
    /// Can be used by custom Endpoint Providers, <see cref="ClientConfig.EndpointProvider"/>
    /// </summary>
    public class EventBridgeV2EndpointParameters : EndpointParameters
    {
        /// <summary>
        /// EventBridgeV2EndpointParameters constructor
        /// </summary>
        public EventBridgeV2EndpointParameters()
        {
            UseFIPS = false;
            UseDualStack = false;
        }

        /// <summary>
        /// The AWS region used to dispatch the request.
        /// </summary>
        public string Region
        {
            get => (string)this["Region"];
            set => this["Region"] = value;
        }

        /// <summary>
        /// Override the endpoint used to send this request.
        /// </summary>
        public string Endpoint
        {
            get => (string)this["Endpoint"];
            set => this["Endpoint"] = value;
        }

        /// <summary>
        /// When true, send this request to the FIPS-compliant regional endpoint.
        /// </summary>
        public bool? UseFIPS
        {
            get => (bool?)this["UseFIPS"];
            set => this["UseFIPS"] = value;
        }

        /// <summary>
        /// When true, use the dual-stack endpoint.
        /// </summary>
        public bool? UseDualStack
        {
            get => (bool?)this["UseDualStack"];
            set => this["UseDualStack"] = value;
        }

        /// <summary>
        /// The AWS account ID used for the request, sourced from the caller's credentials.
        /// </summary>
        public string AccountId
        {
            get => (string)this["AccountId"];
            set => this["AccountId"] = value;
        }

        /// <summary>
        /// The bus ARN from the request, bound via @contextParam. Its account is the bus owner and takes precedence over the credentials-sourced account for cell routing (cross-account calls).
        /// </summary>
        public string EventBusArn
        {
            get => (string)this["EventBusArn"];
            set => this["EventBusArn"] = value;
        }

        /// <summary>
        /// The behavior for account ID based endpoint routing: preferred, disabled, or required.
        /// </summary>
        public string AccountIdEndpointMode
        {
            get => (string)this["AccountIdEndpointMode"];
            set => this["AccountIdEndpointMode"] = value;
        }
    }
}
