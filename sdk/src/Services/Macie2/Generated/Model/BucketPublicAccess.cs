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
    /// Provides information about the permissions settings that determine whether an S3 bucket
    /// is publicly accessible.
    /// </summary>
    public partial class BucketPublicAccess
    {
        private EffectivePermission _effectivePermission;
        private BucketPermissionConfiguration _permissionConfiguration;

        /// <summary>
        /// Gets and sets the property EffectivePermission.  
        /// <para>
        /// Specifies whether the bucket is publicly accessible due to the combination of permissions
        /// settings that apply to the bucket. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// NOT_PUBLIC - The bucket isn't publicly accessible.
        /// </para>
        /// </li> <li>
        /// <para>
        /// PUBLIC - The bucket is publicly accessible.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UNKNOWN - Amazon Macie can't determine whether the bucket is publicly accessible.
        /// </para>
        /// </li></ul>
        /// </summary>
        public EffectivePermission EffectivePermission
        {
            get { return this._effectivePermission; }
            set { this._effectivePermission = value; }
        }

        // Check to see if EffectivePermission property is set
        internal bool IsSetEffectivePermission()
        {
            return this._effectivePermission != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionConfiguration. 
        /// <para>
        /// The account-level and bucket-level permissions settings for the bucket.
        /// </para>
        /// </summary>
        public BucketPermissionConfiguration PermissionConfiguration
        {
            get { return this._permissionConfiguration; }
            set { this._permissionConfiguration = value; }
        }

        // Check to see if PermissionConfiguration property is set
        internal bool IsSetPermissionConfiguration()
        {
            return this._permissionConfiguration != null;
        }

    }
}