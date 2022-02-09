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
    /// Adds or replaces the RAM permission for a resource type included in a resource share.
    /// You can have exactly one permission associated with each resource type in the resource
    /// share. You can add a new RAM permission only if there are currently no resources of
    /// that resource type currently in the resource share.
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
        /// Specifies a unique, case-sensitive identifier that you provide to ensure the idempotency
        /// of the request. This lets you safely retry the request without accidentally performing
        /// the same operation a second time. Passing the same value to a later call to an operation
        /// requires that you also pass the same value for all other parameters. We recommend
        /// that you use a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID
        /// type of value.</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't provide this value, then Amazon Web Services generates a random one for
        /// you.
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
        /// Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resoure Name (ARN)</a> of the RAM permission to associate with the resource share.
        /// To find the ARN for a permission, use either the <a>ListPermissions</a> operation
        /// or go to the <a href="https://console.aws.amazon.com/ram/home#Permissions:">Permissions
        /// library</a> page in the RAM console and then choose the name of the permission. The
        /// ARN is displayed on the detail page.
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
        /// Specifies the version of the RAM permission to associate with the resource share.
        /// If you don't specify this parameter, the operation uses the version designated as
        /// the default. You can use the <a>ListPermissionVersions</a> operation to discover the
        /// available versions of a permission.
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
        /// Specifies whether the specified permission should replace or add to the existing permission
        /// associated with the resource share. Use <code>true</code> to replace the current permissions.
        /// Use <code>false</code> to add the permission to the current permission. The default
        /// value is <code>false</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// A resource share can have only one permission per resource type. If a resource share
        /// already has a permission for the specified resource type and you don't set <code>replace</code>
        /// to <code>true</code> then the operation returns an error. This helps prevent accidental
        /// overwriting of a permission.
        /// </para>
        ///  </note>
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
        /// Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resoure Name (ARN)</a> of the resource share to which you want to add or replace permissions.
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