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
    /// Container for the parameters to the DescribeKey operation.
    /// Provides detailed information about a customer master key (CMK). You can run <code>DescribeKey</code>
    /// on a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
    /// managed CMK</a> or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">AWS
    /// managed CMK</a>.
    /// 
    ///  
    /// <para>
    /// This detailed information includes the key ARN, creation date (and deletion date,
    /// if applicable), the key state, and the origin and expiration date (if any) of the
    /// key material. For CMKs in custom key stores, it includes information about the custom
    /// key store, such as the key store ID and the AWS CloudHSM cluster ID. It includes fields,
    /// like <code>KeySpec</code>, that help you distinguish symmetric from asymmetric CMKs.
    /// It also provides information that is particularly important to asymmetric CMKs, such
    /// as the key usage (encryption or signing) and the encryption algorithms or signing
    /// algorithms that the CMK supports.
    /// </para>
    ///  
    /// <para>
    ///  <code>DescribeKey</code> does not return the following information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Aliases associated with the CMK. To get this information, use <a>ListAliases</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Whether automatic key rotation is enabled on the CMK. To get this information, use
    /// <a>GetKeyRotationStatus</a>. Also, some key states prevent a CMK from being automatically
    /// rotated. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#rotate-keys-how-it-works">How
    /// Automatic Key Rotation Works</a> in <i>AWS Key Management Service Developer Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Tags on the CMK. To get this information, use <a>ListResourceTags</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Key policies and grants on the CMK. To get this information, use <a>GetKeyPolicy</a>
    /// and <a>ListGrants</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you call the <code>DescribeKey</code> operation on a <i>predefined AWS alias</i>,
    /// that is, an AWS alias with no key ID, AWS KMS creates an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">AWS
    /// managed CMK</a>. Then, it associates the alias with the new CMK, and returns the <code>KeyId</code>
    /// and <code>Arn</code> of the new CMK in the response.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: Yes. To perform this operation with a CMK in a different
    /// AWS account, specify the key ARN or alias ARN in the value of the <code>KeyId</code>
    /// parameter.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DescribeKey</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>GetKeyPolicy</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetKeyRotationStatus</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListAliases</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListGrants</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListKeys</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListResourceTags</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListRetirableGrants</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeKeyRequest : AmazonKeyManagementServiceRequest
    {
        private List<string> _grantTokens = new List<string>();
        private string _keyId;

        /// <summary>
        /// Gets and sets the property GrantTokens. 
        /// <para>
        /// A list of grant tokens.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token">Grant
        /// Tokens</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> GrantTokens
        {
            get { return this._grantTokens; }
            set { this._grantTokens = value; }
        }

        // Check to see if GrantTokens property is set
        internal bool IsSetGrantTokens()
        {
            return this._grantTokens != null && this._grantTokens.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Describes the specified customer master key (CMK). 
        /// </para>
        ///  
        /// <para>
        /// If you specify a predefined AWS alias (an AWS alias with no key ID), KMS associates
        /// the alias with an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">AWS
        /// managed CMK</a> and returns its <code>KeyId</code> and <code>Arn</code> in the response.
        /// </para>
        ///  
        /// <para>
        /// To specify a CMK, use its key ID, Amazon Resource Name (ARN), alias name, or alias
        /// ARN. When using an alias name, prefix it with <code>"alias/"</code>. To specify a
        /// CMK in a different AWS account, you must use the key ARN or alias ARN.
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
        ///  </li> <li> 
        /// <para>
        /// Alias name: <code>alias/ExampleAlias</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN: <code>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// To get the alias name and alias ARN, use <a>ListAliases</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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

    }
}