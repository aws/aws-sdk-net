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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */

using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;

namespace Amazon.S3.Endpoints
{
    /// <summary>
    /// Contains parameters used for resolving S3 endpoints
    /// Parameters can be sourced from client config and service operations
    /// Used by internal S3EndpointProvider and S3EndpointResolver
    /// Can be used by custom EndpointProvider, see ClientConfig.EndpointProvider
    /// </summary>
    public class S3EndpointParameters : EndpointParameters
    {
        /// <summary>
        /// S3EndpointParameters constructor
        /// </summary>
        public S3EndpointParameters()
        {
            UseFIPS = false;
            UseDualStack = false;
            ForcePathStyle = false;
            Accelerate = false;
            UseGlobalEndpoint = false;
            DisableMultiRegionAccessPoints = false;
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
        /// ForcePathStyle parameter
        /// </summary>
        public bool? ForcePathStyle 
        { 
            get { return (bool?)this["ForcePathStyle"]; }
            set { this["ForcePathStyle"] = value; } 
        }

        /// <summary>
        /// Accelerate parameter
        /// </summary>
        public bool? Accelerate 
        { 
            get { return (bool?)this["Accelerate"]; }
            set { this["Accelerate"] = value; } 
        }

        /// <summary>
        /// UseGlobalEndpoint parameter
        /// </summary>
        public bool? UseGlobalEndpoint 
        { 
            get { return (bool?)this["UseGlobalEndpoint"]; }
            set { this["UseGlobalEndpoint"] = value; } 
        }

        /// <summary>
        /// UseObjectLambdaEndpoint parameter
        /// </summary>
        public bool? UseObjectLambdaEndpoint 
        { 
            get { return (bool?)this["UseObjectLambdaEndpoint"]; }
            set { this["UseObjectLambdaEndpoint"] = value; } 
        }

        /// <summary>
        /// Key parameter
        /// </summary>
        public string Key 
        { 
            get { return (string)this["Key"]; }
            set { this["Key"] = value; } 
        }

        /// <summary>
        /// Prefix parameter
        /// </summary>
        public string Prefix 
        { 
            get { return (string)this["Prefix"]; }
            set { this["Prefix"] = value; } 
        }

        /// <summary>
        /// CopySource parameter
        /// </summary>
        public string CopySource 
        { 
            get { return (string)this["CopySource"]; }
            set { this["CopySource"] = value; } 
        }

        /// <summary>
        /// DisableAccessPoints parameter
        /// </summary>
        public bool? DisableAccessPoints 
        { 
            get { return (bool?)this["DisableAccessPoints"]; }
            set { this["DisableAccessPoints"] = value; } 
        }

        /// <summary>
        /// DisableMultiRegionAccessPoints parameter
        /// </summary>
        public bool? DisableMultiRegionAccessPoints 
        { 
            get { return (bool?)this["DisableMultiRegionAccessPoints"]; }
            set { this["DisableMultiRegionAccessPoints"] = value; } 
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
        /// UseS3ExpressControlEndpoint parameter
        /// </summary>
        public bool? UseS3ExpressControlEndpoint 
        { 
            get { return (bool?)this["UseS3ExpressControlEndpoint"]; }
            set { this["UseS3ExpressControlEndpoint"] = value; } 
        }

        /// <summary>
        /// DisableS3ExpressSessionAuth parameter
        /// </summary>
        public bool? DisableS3ExpressSessionAuth 
        { 
            get { return (bool?)this["DisableS3ExpressSessionAuth"]; }
            set { this["DisableS3ExpressSessionAuth"] = value; } 
        }
    }
}