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
    /// Container for the parameters to the CreateAlias operation.
    /// Creates a display name for a customer master key (CMK). You can use an alias to identify
    /// a CMK in selected operations, such as <a>Encrypt</a> and <a>GenerateDataKey</a>. 
    /// 
    ///  
    /// <para>
    /// Each CMK can have multiple aliases, but each alias points to only one CMK. The alias
    /// name must be unique in the AWS account and region. To simplify code that runs in multiple
    /// regions, use the same alias name, but point it to a different CMK in each region.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Because an alias is not a property of a CMK, you can delete and change the aliases
    /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
    /// the <a>DescribeKey</a> operation. To get the aliases of all CMKs, use the <a>ListAliases</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// An alias must start with the word <code>alias</code> followed by a forward slash (<code>alias/</code>).
    /// The alias name can contain only alphanumeric characters, forward slashes (/), underscores
    /// (_), and dashes (-). Alias names cannot begin with <code>aws</code>; that alias name
    /// prefix is reserved by Amazon Web Services (AWS).
    /// </para>
    ///  
    /// <para>
    /// The alias and the CMK it is mapped to must be in the same AWS account and the same
    /// region. You cannot perform this operation on an alias in a different AWS account.
    /// </para>
    ///  
    /// <para>
    /// To map an existing alias to a different CMK, call <a>UpdateAlias</a>.
    /// </para>
    ///  
    /// <para>
    /// The result of this operation varies with the key state of the CMK. For details, see
    /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
    /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
    /// Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateAliasRequest : AmazonKeyManagementServiceRequest
    {
        private string _aliasName;
        private string _targetKeyId;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// String that contains the display name. The name must start with the word "alias" followed
        /// by a forward slash (alias/). Aliases that begin with "alias/AWS" are reserved.
        /// </para>
        /// </summary>
        public string AliasName
        {
            get { return this._aliasName; }
            set { this._aliasName = value; }
        }

        // Check to see if AliasName property is set
        internal bool IsSetAliasName()
        {
            return this._aliasName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetKeyId. 
        /// <para>
        /// Identifies the CMK for which you are creating the alias. This value cannot be an alias.
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
        public string TargetKeyId
        {
            get { return this._targetKeyId; }
            set { this._targetKeyId = value; }
        }

        // Check to see if TargetKeyId property is set
        internal bool IsSetTargetKeyId()
        {
            return this._targetKeyId != null;
        }

    }
}