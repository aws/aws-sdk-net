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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RAM.Model
{
    /// <summary>
    /// Container for the parameters to the ReplacePermissionAssociations operation.
    /// Updates all resource shares that use a managed permission to a different managed permission.
    /// This operation always applies the default version of the target managed permission.
    /// You can optionally specify that the update applies to only resource shares that currently
    /// use a specified version. This enables you to update to the latest version, without
    /// changing the which managed permission is used.
    /// 
    ///  
    /// <para>
    /// You can use this operation to update all of your resource shares to use the current
    /// default version of the permission by specifying the same value for the <c>fromPermissionArn</c>
    /// and <c>toPermissionArn</c> parameters.
    /// </para>
    ///  
    /// <para>
    /// You can use the optional <c>fromPermissionVersion</c> parameter to update only those
    /// resources that use a specified version of the managed permission to the new managed
    /// permission.
    /// </para>
    ///  <important> 
    /// <para>
    /// To successfully perform this operation, you must have permission to update the resource-based
    /// policy on all affected resource types.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ReplacePermissionAssociationsRequest : AmazonRAMRequest
    {
        private string _clientToken;
        private string _fromPermissionArn;
        private int? _fromPermissionVersion;
        private string _toPermissionArn;

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
        /// Gets and sets the property FromPermissionArn. 
        /// <para>
        /// Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the managed permission that you want to replace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FromPermissionArn
        {
            get { return this._fromPermissionArn; }
            set { this._fromPermissionArn = value; }
        }

        // Check to see if FromPermissionArn property is set
        internal bool IsSetFromPermissionArn()
        {
            return this._fromPermissionArn != null;
        }

        /// <summary>
        /// Gets and sets the property FromPermissionVersion. 
        /// <para>
        /// Specifies that you want to updated the permissions for only those resource shares
        /// that use the specified version of the managed permission.
        /// </para>
        /// </summary>
        public int? FromPermissionVersion
        {
            get { return this._fromPermissionVersion; }
            set { this._fromPermissionVersion = value; }
        }

        // Check to see if FromPermissionVersion property is set
        internal bool IsSetFromPermissionVersion()
        {
            return this._fromPermissionVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ToPermissionArn. 
        /// <para>
        /// Specifies the ARN of the managed permission that you want to associate with resource
        /// shares in place of the one specified by <c>fromPerssionArn</c> and <c>fromPermissionVersion</c>.
        /// </para>
        ///  
        /// <para>
        /// The operation always associates the version that is currently the default for the
        /// specified managed permission.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ToPermissionArn
        {
            get { return this._toPermissionArn; }
            set { this._toPermissionArn = value; }
        }

        // Check to see if ToPermissionArn property is set
        internal bool IsSetToPermissionArn()
        {
            return this._toPermissionArn != null;
        }

    }
}