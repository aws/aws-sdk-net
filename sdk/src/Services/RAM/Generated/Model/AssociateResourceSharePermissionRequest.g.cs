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

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateResourceSharePermission operation. Adds
    /// or replaces the RAM permission for a resource type included in a resource share. You
    /// can have exactly one permission associated with each resource type in the resource
    /// share. You can add a new RAM permission only if there are currently no resources of
    /// that resource type currently in the resource share.
    /// </summary>
    public partial class AssociateResourceSharePermissionRequest : AmazonRAMRequest
    {
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
        ///  
        /// <para>
        /// If you retry the operation with the same <c>ClientToken</c>, but with different parameters,
        /// the retry fails with an <c>IdempotentParameterMismatch</c> error.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property PermissionArn. 
        /// <para>
        /// Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the RAM permission to associate with the resource share.
        /// To find the ARN for a permission, use either the <a>ListPermissions</a> operation
        /// or go to the <a href="https://console.aws.amazon.com/ram/home#Permissions:">Permissions
        /// library</a> page in the RAM console and then choose the name of the permission. The
        /// ARN is displayed on the detail page.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PermissionArn { get; set; }

        /// <summary>
        /// Checks to see if the PermissionArn property is set.
        /// </summary>
        internal bool IsSetPermissionArn() => this.PermissionArn != null;

        /// <summary>
        /// Gets and sets the property PermissionVersion. 
        /// <para>
        /// Specifies the version of the RAM permission to associate with the resource share.
        /// You can specify <i>only</i> the version that is currently set as the default version
        /// for the permission. If you also set the <c>replace</c> pararameter to <c>true</c>,
        /// then this operation updates an outdated version of the permission to the current default
        /// version.
        /// </para>
        ///  <note> 
        /// <para>
        /// You don't need to specify this parameter because the default behavior is to use the
        /// version that is currently set as the default version for the permission. This parameter
        /// is supported for backwards compatibility.
        /// </para>
        ///  </note>
        /// </summary>
        public int? PermissionVersion { get; set; }

        /// <summary>
        /// Checks to see if the PermissionVersion property is set.
        /// </summary>
        internal bool IsSetPermissionVersion() => this.PermissionVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Replace. 
        /// <para>
        /// Specifies whether the specified permission should replace the existing permission
        /// associated with the resource share. Use <c>true</c> to replace the current permissions.
        /// Use <c>false</c> to add the permission to a resource share that currently doesn't
        /// have a permission. The default value is <c>false</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// A resource share can have only one permission per resource type. If a resource share
        /// already has a permission for the specified resource type and you don't set <c>replace</c>
        /// to <c>true</c> then the operation returns an error. This helps prevent accidental
        /// overwriting of a permission.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? Replace { get; set; }

        /// <summary>
        /// Checks to see if the Replace property is set.
        /// </summary>
        internal bool IsSetReplace() => this.Replace.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceShareArn. 
        /// <para>
        /// Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the resource share to which you want to add or replace
        /// permissions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceShareArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceShareArn property is set.
        /// </summary>
        internal bool IsSetResourceShareArn() => this.ResourceShareArn != null;
    }
}
