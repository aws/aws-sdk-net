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
    /// Container for the parameters to the DeletePermissionVersion operation.
    /// Deletes one version of a customer managed permission. The version you specify must
    /// not be attached to any resource share and must not be the default version for the
    /// permission.
    /// 
    ///  
    /// <para>
    /// If a customer managed permission has the maximum of 5 versions, then you must delete
    /// at least one version before you can create another.
    /// </para>
    /// </summary>
    public partial class DeletePermissionVersionRequest : AmazonRAMRequest
    {
        private string _clientToken;
        private string _permissionArn;
        private int? _permissionVersion;

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
        /// If you retry the operation with the same <code>ClientToken</code>, but with different
        /// parameters, the retry fails with an <code>IdempotentParameterMismatch</code> error.
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
        /// Resource Name (ARN)</a> of the permission with the version you want to delete.
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
        /// Specifies the version number to delete.
        /// </para>
        ///  
        /// <para>
        /// You can't delete the default version for a customer managed permission.
        /// </para>
        ///  
        /// <para>
        /// You can't delete a version if it's the only version of the permission. You must either
        /// first create another version, or delete the permission completely.
        /// </para>
        ///  
        /// <para>
        /// You can't delete a version if it is attached to any resource shares. If the version
        /// is the default, you must first use <a>SetDefaultPermissionVersion</a> to set a different
        /// version as the default for the customer managed permission, and then use <a>AssociateResourceSharePermission</a>
        /// to update your resource shares to use the new default version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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