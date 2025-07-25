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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAlias operation.
    /// Creates a friendly name for a KMS key. 
    /// 
    ///  <note> 
    /// <para>
    /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
    /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">ABAC
    /// for KMS</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can use an alias to identify a KMS key in the KMS console, in the <a>DescribeKey</a>
    /// operation and in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-cryptography.html#cryptographic-operations">cryptographic
    /// operations</a>, such as <a>Encrypt</a> and <a>GenerateDataKey</a>. You can also change
    /// the KMS key that's associated with the alias (<a>UpdateAlias</a>) or delete the alias
    /// (<a>DeleteAlias</a>) at any time. These operations don't affect the underlying KMS
    /// key. 
    /// </para>
    ///  
    /// <para>
    /// You can associate the alias with any customer managed key in the same Amazon Web Services
    /// Region. Each alias is associated with only one KMS key at a time, but a KMS key can
    /// have multiple aliases. A valid KMS key is required. You can't create an alias without
    /// a KMS key.
    /// </para>
    ///  
    /// <para>
    /// The alias must be unique in the account and Region, but you can have aliases with
    /// the same name in different Regions. For detailed information about aliases, see <a
    /// href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html">Aliases
    /// in KMS</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This operation does not return a response. To get the alias that you created, use
    /// the <a>ListAliases</a> operation.
    /// </para>
    ///  
    /// <para>
    /// The KMS key that you use for this operation must be in a compatible key state. For
    /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
    /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: No. You cannot perform this operation on an alias in a
    /// different Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateAlias</a>
    /// on the alias (IAM policy).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateAlias</a>
    /// on the KMS key (key policy).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/alias-access.html">Controlling
    /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DeleteAlias</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListAliases</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateAlias</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
    /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>.
    /// </para>
    /// </summary>
    public partial class CreateAliasRequest : AmazonKeyManagementServiceRequest
    {
        private string _aliasName;
        private string _targetKeyId;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// Specifies the alias name. This value must begin with <c>alias/</c> followed by a name,
        /// such as <c>alias/ExampleAlias</c>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include confidential or sensitive information in this field. This field may
        /// be displayed in plaintext in CloudTrail logs and other output.
        /// </para>
        ///  </important> 
        /// <para>
        /// The <c>AliasName</c> value must be string of 1-256 characters. It can contain only
        /// alphanumeric characters, forward slashes (/), underscores (_), and dashes (-). The
        /// alias name cannot begin with <c>alias/aws/</c>. The <c>alias/aws/</c> prefix is reserved
        /// for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon
        /// Web Services managed keys</a>.
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
        /// Associates the alias with the specified <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-mgn-key">customer
        /// managed key</a>. The KMS key must be in the same Amazon Web Services Region. 
        /// </para>
        ///  
        /// <para>
        /// A valid key ID is required. If you supply a null or empty string value, this operation
        /// returns an error.
        /// </para>
        ///  
        /// <para>
        /// For help finding the key ID and ARN, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/find-cmk-id-arn.html">Find
        /// the key ID and key ARN</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        ///  
        /// <para>
        /// Specify the key ID or key ARN of the KMS key.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.
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