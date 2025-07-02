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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */

using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;

namespace Amazon.S3Control.Endpoints
{
    /// <summary>
    /// Contains parameters used for resolving S3Control endpoints
    /// Parameters can be sourced from client config and service operations
    /// Used by internal S3ControlEndpointProvider and S3ControlEndpointResolver
    /// Can be used by custom EndpointProvider, see ClientConfig.EndpointProvider
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
        /// Region parameter
        /// </summary>
        public string Region 
        { 
            get { return (string)this["Region"]; }
            set { this["Region"] = value; } 
        }

        /// <summary>
        /// UseFIPS parameter
        /// </summary>
        public bool? UseFIPS 
        { 
            get { return (bool?)this["UseFIPS"]; }
            set { this["UseFIPS"] = value; } 
        }

        /// <summary>
        /// UseDualStack parameter
        /// </summary>
        public bool? UseDualStack 
        { 
            get { return (bool?)this["UseDualStack"]; }
            set { this["UseDualStack"] = value; } 
        }

        /// <summary>
        /// Endpoint parameter
        /// </summary>
        public string Endpoint 
        { 
            get { return (string)this["Endpoint"]; }
            set { this["Endpoint"] = value; } 
        }

        /// <summary>
        /// AccountId parameter
        /// </summary>
        public string AccountId 
        { 
            get { return (string)this["AccountId"]; }
            set { this["AccountId"] = value; } 
        }

        /// <summary>
        /// RequiresAccountId parameter
        /// </summary>
        public bool? RequiresAccountId 
        { 
            get { return (bool?)this["RequiresAccountId"]; }
            set { this["RequiresAccountId"] = value; } 
        }

        /// <summary>
        /// OutpostId parameter
        /// </summary>
        public string OutpostId 
        { 
            get { return (string)this["OutpostId"]; }
            set { this["OutpostId"] = value; } 
        }

        /// <summary>
        /// Bucket parameter
        /// </summary>
        public string Bucket 
        { 
            get { return (string)this["Bucket"]; }
            set { this["Bucket"] = value; } 
        }

        /// <summary>
        /// AccessPointName parameter
        /// </summary>
        public string AccessPointName 
        { 
            get { return (string)this["AccessPointName"]; }
            set { this["AccessPointName"] = value; } 
        }

        /// <summary>
        /// UseArnRegion parameter
        /// </summary>
        public bool? UseArnRegion 
        { 
            get { return (bool?)this["UseArnRegion"]; }
            set { this["UseArnRegion"] = value; } 
        }

        /// <summary>
        /// ResourceArn parameter
        /// </summary>
        public string ResourceArn 
        { 
            get { return (string)this["ResourceArn"]; }
            set { this["ResourceArn"] = value; } 
        }

        /// <summary>
        /// UseS3ExpressControlEndpoint parameter
        /// </summary>
        public bool? UseS3ExpressControlEndpoint 
        { 
            get { return (bool?)this["UseS3ExpressControlEndpoint"]; }
            set { this["UseS3ExpressControlEndpoint"] = value; } 
        }
    }
}