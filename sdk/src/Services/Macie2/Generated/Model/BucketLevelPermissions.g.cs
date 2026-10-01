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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the bucket-level permissions settings for an S3 bucket.
    /// </summary>
    public partial class BucketLevelPermissions
    {
        /// <summary>
        /// Gets and sets the property AccessControlList. 
        /// <para>
        /// The permissions settings of the access control list (ACL) for the bucket. This value
        /// is null if an ACL hasn't been defined for the bucket.
        /// </para>
        /// </summary>
        public AccessControlList AccessControlList { get; set; }

        /// <summary>
        /// Checks to see if the AccessControlList property is set.
        /// </summary>
        internal bool IsSetAccessControlList() => this.AccessControlList != null;

        /// <summary>
        /// Gets and sets the property BlockPublicAccess. 
        /// <para>
        /// The block public access settings for the bucket.
        /// </para>
        /// </summary>
        public BlockPublicAccess BlockPublicAccess { get; set; }

        /// <summary>
        /// Checks to see if the BlockPublicAccess property is set.
        /// </summary>
        internal bool IsSetBlockPublicAccess() => this.BlockPublicAccess != null;

        /// <summary>
        /// Gets and sets the property BucketPolicy. 
        /// <para>
        /// The permissions settings of the bucket policy for the bucket. This value is null if
        /// a bucket policy hasn't been defined for the bucket.
        /// </para>
        /// </summary>
        public BucketPolicy BucketPolicy { get; set; }

        /// <summary>
        /// Checks to see if the BucketPolicy property is set.
        /// </summary>
        internal bool IsSetBucketPolicy() => this.BucketPolicy != null;
    }
}
