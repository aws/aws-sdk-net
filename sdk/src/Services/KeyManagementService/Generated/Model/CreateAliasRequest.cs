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
    /// Creates a display name for a customer managed customer master key (CMK). You can use
    /// an alias to identify a CMK in cryptographic operations, such as <a>Encrypt</a> and
    /// <a>GenerateDataKey</a>. You can change the CMK associated with the alias at any time.
    /// 
    ///  
    /// <para>
    /// Aliases are easier to remember than key IDs. They can also help to simplify your applications.
    /// For example, if you use an alias in your code, you can change the CMK your code uses
    /// by associating a given alias with a different CMK. 
    /// </para>
    ///  
    /// <para>
    /// To run the same code in multiple AWS regions, use an alias in your code, such as <code>alias/ApplicationKey</code>.
    /// Then, in each AWS Region, create an <code>alias/ApplicationKey</code> alias that is
    /// associated with a CMK in that Region. When you run your code, it uses the <code>alias/ApplicationKey</code>
    /// CMK for that AWS Region without any Region-specific code.
    /// </para>
    ///  
    /// <para>
    /// This operation does not return a response. To get the alias that you created, use
    /// the <a>ListAliases</a> operation.
    /// </para>
    ///  
    /// <para>
    /// To use aliases successfully, be aware of the following information.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Each alias points to only one CMK at a time, although a single CMK can have multiple
    /// aliases. The alias and its associated CMK must be in the same AWS account and Region.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can associate an alias with any customer managed CMK in the same AWS account and
    /// Region. However, you do not have permission to associate an alias with an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">AWS
    /// managed CMK</a> or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-cmk">AWS
    /// owned CMK</a>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To change the CMK associated with an alias, use the <a>UpdateAlias</a> operation.
    /// The current CMK and the new CMK must be the same type (both symmetric or both asymmetric)
    /// and they must have the same key usage (<code>ENCRYPT_DECRYPT</code> or <code>SIGN_VERIFY</code>).
    /// This restriction prevents cryptographic errors in code that uses aliases.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The alias name must begin with <code>alias/</code> followed by a name, such as <code>alias/ExampleAlias</code>.
    /// It can contain only alphanumeric characters, forward slashes (/), underscores (_),
    /// and dashes (-). The alias name cannot begin with <code>alias/aws/</code>. The <code>alias/aws/</code>
    /// prefix is reserved for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">AWS
    /// managed CMKs</a>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The alias name must be unique within an AWS Region. However, you can use the same
    /// alias name in multiple Regions of the same AWS account. Each instance of the alias
    /// is associated with a CMK in its Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After you create an alias, you cannot change its alias name. However, you can use
    /// the <a>DeleteAlias</a> operation to delete the alias and then create a new alias with
    /// the desired name.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can use an alias name or alias ARN to identify a CMK in AWS KMS cryptographic
    /// operations and in the <a>DescribeKey</a> operation. However, you cannot use alias
    /// names or alias ARNs in API operations that manage CMKs, such as <a>DisableKey</a>
    /// or <a>GetKeyPolicy</a>. For information about the valid CMK identifiers for each AWS
    /// KMS API operation, see the descriptions of the <code>KeyId</code> parameter in the
    /// API operation documentation.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Because an alias is not a property of a CMK, you can delete and change the aliases
    /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
    /// the <a>DescribeKey</a> operation. To get the aliases and alias ARNs of CMKs in each
    /// AWS account and Region, use the <a>ListAliases</a> operation.
    /// </para>
    ///  
    /// <para>
    /// The CMK that you use for this operation must be in a compatible key state. For details,
    /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
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
        /// Specifies the alias name. This value must begin with <code>alias/</code> followed
        /// by a name, such as <code>alias/ExampleAlias</code>. The alias name cannot begin with
        /// <code>alias/aws/</code>. The <code>alias/aws/</code> prefix is reserved for AWS managed
        /// CMKs.
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
        /// Identifies the CMK to which the alias refers. Specify the key ID or the Amazon Resource
        /// Name (ARN) of the CMK. You cannot specify another alias. For help finding the key
        /// ID and ARN, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/viewing-keys.html#find-cmk-id-arn">Finding
        /// the Key ID and ARN</a> in the <i>AWS Key Management Service Developer Guide</i>.
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