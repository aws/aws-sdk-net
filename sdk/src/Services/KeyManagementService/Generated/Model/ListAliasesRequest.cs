/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the ListAliases operation.
    /// Gets a list of aliases in the caller's AWS account and region. You cannot list aliases
    /// in other accounts. For more information about aliases, see <a>CreateAlias</a>.
    /// 
    ///  
    /// <para>
    /// By default, the ListAliases command returns all aliases in the account and region.
    /// To get only the aliases that point to a particular customer master key (CMK), use
    /// the <code>KeyId</code> parameter.
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
    /// not count against your <a href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html#aliases-limit">AWS
    /// KMS aliases limit</a>.
    /// </para>
    /// </summary>
    public partial class ListAliasesRequest : AmazonKeyManagementServiceRequest
    {
        private string _keyId;
        private int? _limit;
        private string _marker;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Lists only aliases that refer to the specified CMK. The value of this parameter can
        /// be the ID or Amazon Resource Name (ARN) of a CMK in the caller's account and region.
        /// You cannot use an alias name or alias ARN in this value.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If you omit it, <code>ListAliases</code> returns all aliases
        /// in the account and region.
        /// </para>
        /// </summary>
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