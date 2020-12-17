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
    /// Container for the parameters to the ListAliases operation.
    /// Gets a list of aliases in the caller's AWS account and region. For more information
    /// about aliases, see <a>CreateAlias</a>.
    /// 
    ///  
    /// <para>
    /// By default, the <code>ListAliases</code> operation returns all aliases in the account
    /// and region. To get only the aliases associated with a particular customer master key
    /// (CMK), use the <code>KeyId</code> parameter.
    /// </para>
    ///  
    /// <para>
    /// The <code>ListAliases</code> response can include aliases that you created and associated
    /// with your customer managed CMKs, and aliases that AWS created and associated with
    /// AWS managed CMKs in your account. You can recognize AWS aliases because their names
    /// have the format <code>aws/&lt;service-name&gt;</code>, such as <code>aws/dynamodb</code>.
    /// </para>
    ///  
    /// <para>
    /// The response might also include aliases that have no <code>TargetKeyId</code> field.
    /// These are predefined aliases that AWS has created but has not yet associated with
    /// a CMK. Aliases that AWS creates in your account, including predefined aliases, do
    /// not count against your <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#aliases-limit">AWS
    /// KMS aliases quota</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: No. <code>ListAliases</code> does not return aliases in
    /// other AWS accounts.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListAliases</a>
    /// (IAM policy)
    /// </para>
    ///  
    /// <para>
    /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
    /// access to aliases</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateAlias</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteAlias</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateAlias</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListAliasesRequest : AmazonKeyManagementServiceRequest
    {
        private string _keyId;
        private int? _limit;
        private string _marker;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Lists only aliases that are associated with the specified CMK. Enter a CMK in your
        /// AWS account. 
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If you omit it, <code>ListAliases</code> returns all aliases
        /// in the account and Region.
        /// </para>
        ///  
        /// <para>
        /// Specify the key ID or the Amazon Resource Name (ARN) of the CMK.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

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

    }
}