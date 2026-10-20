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

namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// Configuration parameters for where in an S3 bucket to place the harvested content
    /// </summary>
    public partial class S3Destination
    {
        /// <summary>
        /// Gets and sets the property BucketName. The name of an S3 bucket within which harvested
        /// content will be exported
        /// </summary>
        [AWSProperty(Required = true)]
        public string BucketName { get; set; }

        /// <summary>
        /// Checks to see if the BucketName property is set.
        /// </summary>
        internal bool IsSetBucketName() => this.BucketName != null;

        /// <summary>
        /// Gets and sets the property ManifestKey. The key in the specified S3 bucket where the
        /// harvested top-level manifest will be placed.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ManifestKey { get; set; }

        /// <summary>
        /// Checks to see if the ManifestKey property is set.
        /// </summary>
        internal bool IsSetManifestKey() => this.ManifestKey != null;

        /// <summary>
        /// Gets and sets the property RoleArn. The IAM role used to write to the specified S3
        /// bucket
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
