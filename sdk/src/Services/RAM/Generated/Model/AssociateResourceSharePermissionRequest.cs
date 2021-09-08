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
    /// Container for the parameters to the AssociateResourceSharePermission operation.
    /// Associates a permission with a resource share.
    /// </summary>
    public partial class AssociateResourceSharePermissionRequest : AmazonRAMRequest
    {
        private string _clientToken;
        private string _permissionArn;
        private int? _permissionVersion;
        private bool? _replace;
        private string _resourceShareArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the RAM permission to associate with the resource
        /// share.
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
        /// The version of the RAM permissions to associate with the resource share.
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

        /// <summary>
        /// Gets and sets the property Replace. 
        /// <para>
        /// Indicates whether the permission should replace the permissions that are currently
        /// associated with the resource share. Use <code>true</code> to replace the current permissions.
        /// Use <code>false</code> to add the permission to the current permission.
        /// </para>
        /// </summary>
        public bool Replace
        {
            get { return this._replace.GetValueOrDefault(); }
            set { this._replace = value; }
        }

        // Check to see if Replace property is set
        internal bool IsSetReplace()
        {
            return this._replace.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceShareArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource share.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceShareArn
        {
            get { return this._resourceShareArn; }
            set { this._resourceShareArn = value; }
        }

        // Check to see if ResourceShareArn property is set
        internal bool IsSetResourceShareArn()
        {
            return this._resourceShareArn != null;
        }

    }
}