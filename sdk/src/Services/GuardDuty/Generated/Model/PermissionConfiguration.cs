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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about how permissions are configured for the S3 bucket.
    /// </summary>
    public partial class PermissionConfiguration
    {
        private AccountLevelPermissions _accountLevelPermissions;
        private BucketLevelPermissions _bucketLevelPermissions;

        /// <summary>
        /// Gets and sets the property AccountLevelPermissions. 
        /// <para>
        /// Contains information about the account level permissions on the S3 bucket.
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
        /// Contains information about the bucket level permissions for the S3 bucket.
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