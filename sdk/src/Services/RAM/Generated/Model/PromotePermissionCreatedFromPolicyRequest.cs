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
    /// Container for the parameters to the PromotePermissionCreatedFromPolicy operation.
    /// When you attach a resource-based policy to a resource, RAM automatically creates a
    /// resource share of <c>featureSet</c>=<c>CREATED_FROM_POLICY</c> with a managed permission
    /// that has the same IAM permissions as the original resource-based policy. However,
    /// this type of managed permission is visible to only the resource share owner, and the
    /// associated resource share can't be modified by using RAM.
    /// 
    ///  
    /// <para>
    /// This operation creates a separate, fully manageable customer managed permission that
    /// has the same IAM permissions as the original resource-based policy. You can associate
    /// this customer managed permission to any resource shares.
    /// </para>
    ///  
    /// <para>
    /// Before you use <a>PromoteResourceShareCreatedFromPolicy</a>, you should first run
    /// this operation to ensure that you have an appropriate customer managed permission
    /// that can be associated with the promoted resource share.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// The original <c>CREATED_FROM_POLICY</c> policy isn't deleted, and resource shares
    /// using that original policy aren't automatically updated.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can't modify a <c>CREATED_FROM_POLICY</c> resource share so you can't associate
    /// the new customer managed permission by using <c>ReplacePermsissionAssociations</c>.
    /// However, if you use <a>PromoteResourceShareCreatedFromPolicy</a>, that operation automatically
    /// associates the fully manageable customer managed permission to the newly promoted
    /// <c>STANDARD</c> resource share.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After you promote a resource share, if the original <c>CREATED_FROM_POLICY</c> managed
    /// permission has no other associations to A resource share, then RAM automatically deletes
    /// it.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class PromotePermissionCreatedFromPolicyRequest : AmazonRAMRequest
    {
        private string _clientToken;
        private string _name;
        private string _permissionArn;

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
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies a name for the promoted customer managed permission.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionArn. 
        /// <para>
        /// Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the <c>CREATED_FROM_POLICY</c> permission that you want
        /// to promote. You can get this <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> by calling the <a>ListResourceSharePermissions</a> operation.
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

    }
}