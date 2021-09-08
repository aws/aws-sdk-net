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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Container for the parameters to the GetPermission operation.
    /// Gets the contents of an RAM permission in JSON format.
    /// </summary>
    public partial class GetPermissionRequest : AmazonRAMRequest
    {
        private string _permissionArn;
        private int? _permissionVersion;

        /// <summary>
        /// Gets and sets the property PermissionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the permission.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PermissionArn
        {
            get { return this._permissionArn; }
            set { this._permissionArn = value; }
        }

        // Check to see if PermissionArn property is set
        internal bool IsSetPermissionArn()
        {
            return this._permissionArn != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionVersion. 
        /// <para>
        /// The identifier for the version of the permission.
        /// </para>
        /// </summary>
        public int PermissionVersion
        {
            get { return this._permissionVersion.GetValueOrDefault(); }
            set { this._permissionVersion = value; }
        }

        // Check to see if PermissionVersion property is set
        internal bool IsSetPermissionVersion()
        {
            return this._permissionVersion.HasValue; 
        }

    }
}