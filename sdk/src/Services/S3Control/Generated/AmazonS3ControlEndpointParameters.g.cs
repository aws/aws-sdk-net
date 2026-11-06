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
        public string Region
        {
            get => (string)this["Region"];
            set => this["Region"] = value;
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
        /// When true, use the dual-stack endpoint. If the configured endpoint does not support dual-stack, dispatching the request MAY return an error.
        /// </summary>
        public bool? UseDualStack
        {
            get => (bool?)this["UseDualStack"];
            set => this["UseDualStack"] = value;
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
        /// The Account ID used to send the request. This is an optional parameter that will be set automatically for operations that require it.
        /// </summary>
        public string AccountId
        {
            get => (string)this["AccountId"];
            set => this["AccountId"] = value;
        }

        /// <summary>
        /// Internal parameter for operations that require account id host prefix.
        /// </summary>
        public bool? RequiresAccountId
        {
            get => (bool?)this["RequiresAccountId"];
            set => this["RequiresAccountId"] = value;
        }

        /// <summary>
        /// The Outpost ID.  Some operations have an optional OutpostId which should be used in endpoint construction.
        /// </summary>
        public string OutpostId
        {
            get => (string)this["OutpostId"];
            set => this["OutpostId"] = value;
        }

        /// <summary>
        /// The S3 bucket used to send the request. This is an optional parameter that will be set automatically for operations that are scoped to an S3 bucket.
        /// </summary>
        public string Bucket
        {
            get => (string)this["Bucket"];
            set => this["Bucket"] = value;
        }

        /// <summary>
        /// The S3 AccessPointName used to send the request. This is an optional parameter that will be set automatically for operations that are scoped to an S3 AccessPoint.
        /// </summary>
        public string AccessPointName
        {
            get => (string)this["AccessPointName"];
            set => this["AccessPointName"] = value;
        }

        /// <summary>
        /// When an Access Point ARN is provided and this flag is enabled, the SDK MUST use the ARN's region when constructing the endpoint instead of the client's configured region.
        /// </summary>
        public bool? UseArnRegion
        {
            get => (bool?)this["UseArnRegion"];
            set => this["UseArnRegion"] = value;
        }

        /// <summary>
        /// The resource ARN included in the request.  Only set on TagResource, UntagResourceand ListTagsForResource
        /// </summary>
        public string ResourceArn
        {
            get => (string)this["ResourceArn"];
            set => this["ResourceArn"] = value;
        }

        /// <summary>
        /// Internal parameter to indicate whether S3Express operation should use control plane, (ex. ListDirectoryAccessPoints)
        /// </summary>
        public bool? UseS3ExpressControlEndpoint
        {
            get => (bool?)this["UseS3ExpressControlEndpoint"];
            set => this["UseS3ExpressControlEndpoint"] = value;
        }
    }
}
