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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
        private AccountLevelPermissions _accountLevelPermissions;
        private BucketLevelPermissions _bucketLevelPermissions;

        /// <summary>
        /// Gets and sets the property AccountLevelPermissions. 
        /// <para>
        /// The account-level permissions settings that apply to the bucket.
        /// </para>
        /// </summary>
        public AccountLevelPermissions AccountLevelPermissions
        {
            get { return this._accountLevelPermissions; }
            set { this._accountLevelPermissions = value; }
        }

        // Check to see if AccountLevelPermissions property is set
        internal bool IsSetAccountLevelPermissions()
        {
            return this._accountLevelPermissions != null;
        }

        /// <summary>
        /// Gets and sets the property BucketLevelPermissions. 
        /// <para>
        /// The bucket-level permissions settings for the bucket.
        /// </para>
        /// </summary>
        public BucketLevelPermissions BucketLevelPermissions
        {
            get { return this._bucketLevelPermissions; }
            set { this._bucketLevelPermissions = value; }
        }

        // Check to see if BucketLevelPermissions property is set
        internal bool IsSetBucketLevelPermissions()
        {
            return this._bucketLevelPermissions != null;
        }

    }
}