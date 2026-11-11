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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Describes the versioning state of an Amazon S3 on Outposts bucket. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketVersioning.html">PutBucketVersioning</a>.
    /// </summary>
    public partial class VersioningConfiguration
    {
        /// <summary>
        /// Gets and sets the property MFADelete. 
        /// <para>
        /// Specifies whether MFA delete is enabled or disabled in the bucket versioning configuration
        /// for the S3 on Outposts bucket.
        /// </para>
        /// </summary>
        public MFADelete MFADelete { get; set; }

        /// <summary>
        /// Checks to see if the MFADelete property is set.
        /// </summary>
        internal bool IsSetMFADelete() => this.MFADelete != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Sets the versioning state of the S3 on Outposts bucket.
        /// </para>
        /// </summary>
        public BucketVersioningStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
