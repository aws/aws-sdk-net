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
    /// Container for the parameters to the PromoteResourceShareCreatedFromPolicy operation.
    /// When you attach a resource-based policy to a resource, RAM automatically creates a
    /// resource share of <c>featureSet</c>=<c>CREATED_FROM_POLICY</c> with a managed permission
    /// that has the same IAM permissions as the original resource-based policy. However,
    /// this type of managed permission is visible to only the resource share owner, and the
    /// associated resource share can't be modified by using RAM.
    /// 
    ///  
    /// <para>
    /// This operation promotes the resource share to a <c>STANDARD</c> resource share that
    /// is fully manageable in RAM. When you promote a resource share, you can then manage
    /// the resource share in RAM and it becomes visible to all of the principals you shared
    /// it with.
    /// </para>
    ///  <important> 
    /// <para>
    /// Before you perform this operation, you should first run <a>PromotePermissionCreatedFromPolicy</a>to
    /// ensure that you have an appropriate customer managed permission that can be associated
    /// with this resource share after its is promoted. If this operation can't find a managed
    /// permission that exactly matches the existing <c>CREATED_FROM_POLICY</c> permission,
    /// then this operation fails.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PromoteResourceShareCreatedFromPolicyRequest : AmazonRAMRequest
    {
        private string _resourceShareArn;

        /// <summary>
        /// Gets and sets the property ResourceShareArn. 
        /// <para>
        /// Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the resource share to promote.
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