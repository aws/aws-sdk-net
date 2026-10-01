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
    /// Provides information about the account-level and bucket-level permissions settings
    /// for an S3 bucket.
    /// </summary>
    public partial class BucketPermissionConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccountLevelPermissions. 
        /// <para>
        /// The account-level permissions settings that apply to the bucket.
        /// </para>
        /// </summary>
        public AccountLevelPermissions AccountLevelPermissions { get; set; }

        /// <summary>
        /// Checks to see if the AccountLevelPermissions property is set.
        /// </summary>
        internal bool IsSetAccountLevelPermissions() => this.AccountLevelPermissions != null;

        /// <summary>
        /// Gets and sets the property BucketLevelPermissions. 
        /// <para>
        /// The bucket-level permissions settings for the bucket.
        /// </para>
        /// </summary>
        public BucketLevelPermissions BucketLevelPermissions { get; set; }

        /// <summary>
        /// Checks to see if the BucketLevelPermissions property is set.
        /// </summary>
        internal bool IsSetBucketLevelPermissions() => this.BucketLevelPermissions != null;
    }
}
