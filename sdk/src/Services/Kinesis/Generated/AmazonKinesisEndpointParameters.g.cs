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
using Amazon.Kinesis.Internal;

namespace Amazon.Kinesis.Endpoints
{
    /// <summary>
    /// Contains parameters used for resolving Kinesis endpoints.
    /// <para />
    /// Parameters can be sourced from client config and service operations used by the
    /// internal <see cref="AmazonKinesisEndpointProvider"/> and <see cref="AmazonKinesisEndpointResolver"/>.
    /// <para />
    /// Can be used by custom Endpoint Providers, <see cref="ClientConfig.EndpointProvider"/>
    /// </summary>
    public class KinesisEndpointParameters : EndpointParameters
    {
        /// <summary>
        /// KinesisEndpointParameters constructor
        /// </summary>
        public KinesisEndpointParameters()
        {
            UseDualStack = false;
            UseFIPS = false;
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
        /// When true, use the dual-stack endpoint. If the configured endpoint does not support dual-stack, dispatching the request MAY return an error.
        /// </summary>
        public bool? UseDualStack
        {
            get => (bool?)this["UseDualStack"];
            set => this["UseDualStack"] = value;
        }

        /// <summary>
        /// When true, send this request to the FIPS-compliant regional endpoint. If the configured endpoint does not have a FIPS compliant endpoint, dispatching the request will return an error.
        /// </summary>
        public bool? UseFIPS
        {
            get => (bool?)this["UseFIPS"];
            set => this["UseFIPS"] = value;
        }

        /// <summary>
        /// Override the endpoint used to send this request
        /// </summary>
        public string Endpoint
        {
            get => (string)this["Endpoint"];
            set => this["Endpoint"] = value;
        }

        /// <summary>
        /// Internal parameter to distinguish between Control/Data plane API and accordingly generate control/data plane endpoint
        /// </summary>
        public string OperationType
        {
            get => (string)this["OperationType"];
            set => this["OperationType"] = value;
        }

        /// <summary>
        /// The unique identifier of the Kinesis stream
        /// </summary>
        public string StreamId
        {
            get => (string)this["StreamId"];
            set => this["StreamId"] = value;
        }

        /// <summary>
        /// The ARN of the Kinesis stream
        /// </summary>
        public string StreamARN
        {
            get => (string)this["StreamARN"];
            set => this["StreamARN"] = value;
        }

        /// <summary>
        /// The ARN of the Kinesis consumer
        /// </summary>
        public string ConsumerARN
        {
            get => (string)this["ConsumerARN"];
            set => this["ConsumerARN"] = value;
        }

        /// <summary>
        /// The ARN of the Kinesis resource
        /// </summary>
        public string ResourceARN
        {
            get => (string)this["ResourceARN"];
            set => this["ResourceARN"] = value;
        }

        /// <summary>
        /// The ARN of the Kinesis data channel
        /// </summary>
        public string ChannelARN
        {
            get => (string)this["ChannelARN"];
            set => this["ChannelARN"] = value;
        }

        /// <summary>
        /// The AWS AccountId used for the request.
        /// </summary>
        public string AccountId
        {
            get => (string)this["AccountId"];
            set => this["AccountId"] = value;
        }

        /// <summary>
        /// The AccountId Endpoint Mode.
        /// </summary>
        public string AccountIdEndpointMode
        {
            get => (string)this["AccountIdEndpointMode"];
            set => this["AccountIdEndpointMode"] = value;
        }
    }
}
