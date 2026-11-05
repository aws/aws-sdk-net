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
        /// Internal parameter to distinguish between Control/Data plane API and accordingly generate control/data plane endpoint
        /// </summary>
        public string OperationType { get; set; }

        /// <summary>
        /// The unique identifier of the Kinesis stream
        /// </summary>
        public string StreamId { get; set; }

        /// <summary>
        /// The ARN of the Kinesis stream
        /// </summary>
        public string StreamARN { get; set; }

        /// <summary>
        /// The ARN of the Kinesis consumer
        /// </summary>
        public string ConsumerARN { get; set; }

        /// <summary>
        /// The ARN of the Kinesis resource
        /// </summary>
        public string ResourceARN { get; set; }

        /// <summary>
        /// The ARN of the Kinesis data channel
        /// </summary>
        public string ChannelARN { get; set; }

        /// <summary>
        /// The AWS AccountId used for the request.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// The AccountId Endpoint Mode.
        /// </summary>
        public string AccountIdEndpointMode { get; set; }

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
                "OperationType" => OperationType,
                "StreamId" => StreamId,
                "StreamARN" => StreamARN,
                "ConsumerARN" => ConsumerARN,
                "ResourceARN" => ResourceARN,
                "ChannelARN" => ChannelARN,
                "AccountId" => AccountId,
                "AccountIdEndpointMode" => AccountIdEndpointMode,
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
                    case "OperationType": OperationType = (string)value; break;
                    case "StreamId": StreamId = (string)value; break;
                    case "StreamARN": StreamARN = (string)value; break;
                    case "ConsumerARN": ConsumerARN = (string)value; break;
                    case "ResourceARN": ResourceARN = (string)value; break;
                    case "ChannelARN": ChannelARN = (string)value; break;
                    case "AccountId": AccountId = (string)value; break;
                    case "AccountIdEndpointMode": AccountIdEndpointMode = (string)value; break;
                    default: base[name] = value; break;
                }
            }
        }

        /// <inheritdoc/>
        protected override bool ParameterValuesEqual(EndpointParameters other)
        {
            var o = (KinesisEndpointParameters)other;
            return Region == o.Region
                && UseDualStack == o.UseDualStack
                && UseFIPS == o.UseFIPS
                && Endpoint == o.Endpoint
                && OperationType == o.OperationType
                && StreamId == o.StreamId
                && StreamARN == o.StreamARN
                && ConsumerARN == o.ConsumerARN
                && ResourceARN == o.ResourceARN
                && ChannelARN == o.ChannelARN
                && AccountId == o.AccountId
                && AccountIdEndpointMode == o.AccountIdEndpointMode
                && base.ParameterValuesEqual(other);
        }
    }
}
