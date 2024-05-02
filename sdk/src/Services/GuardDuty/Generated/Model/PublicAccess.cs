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
    /// Describes the public access policies that apply to the S3 bucket.
    /// </summary>
    public partial class PublicAccess
    {
        private string _effectivePermission;
        private PermissionConfiguration _permissionConfiguration;

        /// <summary>
        /// Gets and sets the property EffectivePermission. 
        /// <para>
        /// Describes the effective permission on this bucket after factoring all attached policies.
        /// </para>
        /// </summary>
        public string EffectivePermission
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
        /// Contains information about how permissions are configured for the S3 bucket.
        /// </para>
        /// </summary>
        public PermissionConfiguration PermissionConfiguration
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