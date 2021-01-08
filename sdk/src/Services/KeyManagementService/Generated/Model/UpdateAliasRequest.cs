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
    /// Container for the parameters to the UpdateAlias operation.
    /// Associates an existing AWS KMS alias with a different customer master key (CMK). Each
    /// alias is associated with only one CMK at a time, although a CMK can have multiple
    /// aliases. The alias and the CMK must be in the same AWS account and region.
    /// 
    ///  
    /// <para>
    /// The current and new CMK must be the same type (both symmetric or both asymmetric),
    /// and they must have the same key usage (<code>ENCRYPT_DECRYPT</code> or <code>SIGN_VERIFY</code>).
    /// This restriction prevents errors in code that uses aliases. If you must assign an
    /// alias to a different type of CMK, use <a>DeleteAlias</a> to delete the old alias and
    /// <a>CreateAlias</a> to create a new alias.
    /// </para>
    ///  
    /// <para>
    /// You cannot use <code>UpdateAlias</code> to change an alias name. To change an alias
    /// name, use <a>DeleteAlias</a> to delete the old alias and <a>CreateAlias</a> to create
    /// a new alias.
    /// </para>
    ///  
    /// <para>
    /// Because an alias is not a property of a CMK, you can create, update, and delete the
    /// aliases of a CMK without affecting the CMK. Also, aliases do not appear in the response
    /// from the <a>DescribeKey</a> operation. To get the aliases of all CMKs in the account,
    /// use the <a>ListAliases</a> operation. 
    /// </para>
    ///  
    /// <para>
    /// The CMK that you use for this operation must be in a compatible key state. For details,
    /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
    /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
    /// Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: No. You cannot perform this operation on a CMK in a different
    /// AWS account. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
    /// on the alias (IAM policy).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
    /// on the current CMK (key policy).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
    /// on the new CMK (key policy).
    /// </para>
    ///  </li> </ul> 
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
    ///  <a>ListAliases</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateAliasRequest : AmazonKeyManagementServiceRequest
    {
        private string _aliasName;
        private string _targetKeyId;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// Identifies the alias that is changing its CMK. This value must begin with <code>alias/</code>
        /// followed by the alias name, such as <code>alias/ExampleAlias</code>. You cannot use
        /// UpdateAlias to change the alias name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Identifies the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed CMK</a> to associate with the alias. You don't have permission to associate
        /// an alias with an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">AWS
        /// managed CMK</a>.
        /// </para>
        ///  
        /// <para>
        /// The CMK must be in the same AWS account and Region as the alias. Also, the new target
        /// CMK must be the same type as the current target CMK (both symmetric or both asymmetric)
        /// and they must have the same key usage. 
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
        ///  
        /// <para>
        /// To verify that the alias is mapped to the correct CMK, use <a>ListAliases</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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