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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Mounts an Amazon S3 bucket in the AgentCore Runtime with Mountpoint for Amazon S3.
    /// Files under the mount path map to objects in the bucket.
    /// </summary>
    public partial class S3BucketMountConfiguration
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the S3 bucket to mount. You can specify a general purpose bucket or a
        /// directory bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property MountPath. 
        /// <para>
        /// The mount path for the S3 bucket inside the AgentCore Runtime. The path must be under
        /// <c>/mnt</c> with exactly one subdirectory level (for example, <c>/mnt/data</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 200)]
        public string MountPath { get; set; }

        /// <summary>
        /// Checks to see if the MountPath property is set.
        /// </summary>
        internal bool IsSetMountPath() => this.MountPath != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The key prefix to mount. Only objects under this prefix are visible at the mount path.
        /// To give each session its own prefix, include <c>{runtimeSessionId}</c> (for example,
        /// <c>data/{runtimeSessionId}/</c>). If you omit the prefix, the whole bucket is mounted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property S3BucketOwner. 
        /// <para>
        /// The AWS account ID that must own the bucket. If you omit it, the bucket must be owned
        /// by the account that owns the AgentCore Runtime.
        /// </para>
        /// </summary>
        public string S3BucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketOwner property is set.
        /// </summary>
        internal bool IsSetS3BucketOwner() => this.S3BucketOwner != null;

        /// <summary>
        /// Gets and sets the property S3BucketRegion. 
        /// <para>
        /// The AWS Region of the S3 bucket. If you omit it, the bucket must be in the same Region
        /// as the AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string S3BucketRegion { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketRegion property is set.
        /// </summary>
        internal bool IsSetS3BucketRegion() => this.S3BucketRegion != null;
    }
}
