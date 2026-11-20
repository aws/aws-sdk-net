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
using Amazon.S3Control.Internal;

namespace Amazon.S3Control.Endpoints
{
    /// <summary>
    /// Contains parameters used for resolving S3Control endpoints.
    /// <para />
    /// Parameters can be sourced from client config and service operations used by the
    /// internal <see cref="AmazonS3ControlEndpointProvider"/> and <see cref="AmazonS3ControlEndpointResolver"/>.
    /// <para />
    /// Can be used by custom Endpoint Providers, <see cref="ClientConfig.EndpointProvider"/>
    /// </summary>
    public class S3ControlEndpointParameters : EndpointParameters
    {
        /// <summary>
        /// S3ControlEndpointParameters constructor
        /// </summary>
        public S3ControlEndpointParameters()
        {
            UseFIPS = false;
            UseDualStack = false;
        }

        /// <summary>
        /// The AWS region used to dispatch the request.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// When true, send this request to the FIPS-compliant regional endpoint. If the configured endpoint does not have a FIPS compliant endpoint, dispatching the request will return an error.
        /// </summary>
        public bool? UseFIPS { get; set; }

        /// <summary>
        /// When true, use the dual-stack endpoint. If the configured endpoint does not support dual-stack, dispatching the request MAY return an error.
        /// </summary>
        public bool? UseDualStack { get; set; }

        /// <summary>
        /// Override the endpoint used to send this request
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// The Account ID used to send the request. This is an optional parameter that will be set automatically for operations that require it.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Internal parameter for operations that require account id host prefix.
        /// </summary>
        public bool? RequiresAccountId { get; set; }

        /// <summary>
        /// The Outpost ID.  Some operations have an optional OutpostId which should be used in endpoint construction.
        /// </summary>
        public string OutpostId { get; set; }

        /// <summary>
        /// The S3 bucket used to send the request. This is an optional parameter that will be set automatically for operations that are scoped to an S3 bucket.
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// The S3 AccessPointName used to send the request. This is an optional parameter that will be set automatically for operations that are scoped to an S3 AccessPoint.
        /// </summary>
        public string AccessPointName { get; set; }

        /// <summary>
        /// When an Access Point ARN is provided and this flag is enabled, the SDK MUST use the ARN's region when constructing the endpoint instead of the client's configured region.
        /// </summary>
        public bool? UseArnRegion { get; set; }

        /// <summary>
        /// The resource ARN included in the request.  Only set on TagResource, UntagResourceand ListTagsForResource
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Internal parameter to indicate whether S3Express operation should use control plane, (ex. ListDirectoryAccessPoints)
        /// </summary>
        public bool? UseS3ExpressControlEndpoint { get; set; }

        /// <summary>
        /// Gets or sets an endpoint parameter by name. Known parameters read and write the typed
        /// properties; any other name falls through to the underlying property bag.
        /// </summary>
        public override object this[string name]
        {
            get => name switch
            {
                "Region" => Region,
                "UseFIPS" => UseFIPS,
                "UseDualStack" => UseDualStack,
                "Endpoint" => Endpoint,
                "AccountId" => AccountId,
                "RequiresAccountId" => RequiresAccountId,
                "OutpostId" => OutpostId,
                "Bucket" => Bucket,
                "AccessPointName" => AccessPointName,
                "UseArnRegion" => UseArnRegion,
                "ResourceArn" => ResourceArn,
                "UseS3ExpressControlEndpoint" => UseS3ExpressControlEndpoint,
                _ => base[name],
            };
            set
            {
                switch (name)
                {
                    case "Region": Region = (string)value; break;
                    case "UseFIPS": UseFIPS = (bool?)value; break;
                    case "UseDualStack": UseDualStack = (bool?)value; break;
                    case "Endpoint": Endpoint = (string)value; break;
                    case "AccountId": AccountId = (string)value; break;
                    case "RequiresAccountId": RequiresAccountId = (bool?)value; break;
                    case "OutpostId": OutpostId = (string)value; break;
                    case "Bucket": Bucket = (string)value; break;
                    case "AccessPointName": AccessPointName = (string)value; break;
                    case "UseArnRegion": UseArnRegion = (bool?)value; break;
                    case "ResourceArn": ResourceArn = (string)value; break;
                    case "UseS3ExpressControlEndpoint": UseS3ExpressControlEndpoint = (bool?)value; break;
                    default: base[name] = value; break;
                }
            }
        }

        /// <inheritdoc/>
        protected override bool ParameterValuesEqual(EndpointParameters other)
        {
            var o = (S3ControlEndpointParameters)other;
            return Region == o.Region
                && UseFIPS == o.UseFIPS
                && UseDualStack == o.UseDualStack
                && Endpoint == o.Endpoint
                && AccountId == o.AccountId
                && RequiresAccountId == o.RequiresAccountId
                && OutpostId == o.OutpostId
                && Bucket == o.Bucket
                && AccessPointName == o.AccessPointName
                && UseArnRegion == o.UseArnRegion
                && ResourceArn == o.ResourceArn
                && UseS3ExpressControlEndpoint == o.UseS3ExpressControlEndpoint
                && base.ParameterValuesEqual(other);
        }
    }
}
