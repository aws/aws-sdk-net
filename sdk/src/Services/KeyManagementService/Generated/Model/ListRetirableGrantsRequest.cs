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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the ListRetirableGrants operation.
    /// Returns all grants in which the specified principal is the <code>RetiringPrincipal</code>
    /// in the grant. 
    /// 
    ///  
    /// <para>
    /// You can specify any principal in your AWS account. The grants that are returned include
    /// grants for CMKs in your AWS account and other AWS accounts.
    /// </para>
    ///  
    /// <para>
    /// You might use this operation to determine which grants you may retire. To retire a
    /// grant, use the <a>RetireGrant</a> operation.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: You must specify a principal in your AWS account. However,
    /// this operation can return grants in any AWS account. You do not need <code>kms:ListRetirableGrants</code>
    /// permission (or any other additional permission) in any AWS account other than your
    /// own.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListRetirableGrants</a>
    /// (IAM policy) in your AWS account.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateGrant</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListGrants</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>RetireGrant</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>RevokeGrant</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListRetirableGrantsRequest : AmazonKeyManagementServiceRequest
    {
        private int? _limit;
        private string _marker;
        private string _retiringPrincipal;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Use this parameter to specify the maximum number of items to return. When this value
        /// is present, AWS KMS does not return more than the specified number of items, but it
        /// might return fewer.
        /// </para>
        ///  
        /// <para>
        /// This value is optional. If you include a value, it must be between 1 and 100, inclusive.
        /// If you do not include a value, it defaults to 50.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter in a subsequent request after you receive a response with truncated
        /// results. Set it to the value of <code>NextMarker</code> from the truncated response
        /// you just received.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property RetiringPrincipal. 
        /// <para>
        /// The retiring principal for which to list grants. Enter a principal in your AWS account.
        /// </para>
        ///  
        /// <para>
        /// To specify the retiring principal, use the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of an AWS principal. Valid AWS principals include AWS accounts
        /// (root), IAM users, federated users, and assumed role users. For examples of the ARN
        /// syntax for specifying a principal, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">AWS
        /// Identity and Access Management (IAM)</a> in the Example ARNs section of the <i>Amazon
        /// Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string RetiringPrincipal
        {
            get { return this._retiringPrincipal; }
            set { this._retiringPrincipal = value; }
        }

        // Check to see if RetiringPrincipal property is set
        internal bool IsSetRetiringPrincipal()
        {
            return this._retiringPrincipal != null;
        }

    }
}