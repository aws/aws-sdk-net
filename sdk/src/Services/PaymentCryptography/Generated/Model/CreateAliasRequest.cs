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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAlias operation.
    /// Creates an <i>alias</i>, or a friendly name, for an Amazon Web Services Payment Cryptography
    /// key. You can use an alias to identify a key in the console and when you call cryptographic
    /// operations such as <a href="https://docs.aws.amazon.com/payment-cryptography/latest/DataAPIReference/API_EncryptData.html">EncryptData</a>
    /// or <a href="https://docs.aws.amazon.com/payment-cryptography/latest/DataAPIReference/API_DecryptData.html">DecryptData</a>.
    /// 
    ///  
    /// <para>
    /// You can associate the alias with any key in the same Amazon Web Services Region. Each
    /// alias is associated with only one key at a time, but a key can have multiple aliases.
    /// You can't create an alias without a key. The alias must be unique in the account and
    /// Amazon Web Services Region, but you can create another alias with the same name in
    /// a different Amazon Web Services Region.
    /// </para>
    ///  
    /// <para>
    /// To change the key that's associated with the alias, call <a>UpdateAlias</a>. To delete
    /// the alias, call <a>DeleteAlias</a>. These operations don't affect the underlying key.
    /// To get the alias that you created, call <a>ListAliases</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
    /// Services accounts.
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
    ///  <a>GetAlias</a> 
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
    /// </summary>
    public partial class CreateAliasRequest : AmazonPaymentCryptographyRequest
    {
        private string _aliasName;
        private string _keyArn;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// A friendly name that you can use to refer a key. An alias must begin with <code>alias/</code>
        /// followed by a name, for example <code>alias/ExampleAlias</code>. It can contain only
        /// alphanumeric characters, forward slashes (/), underscores (_), and dashes (-).
        /// </para>
        ///  <important> 
        /// <para>
        /// Don't include confidential or sensitive information in this field. This field may
        /// be displayed in plaintext in CloudTrail logs and other output.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=256)]
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
        /// Gets and sets the property KeyArn. 
        /// <para>
        /// The <code>KeyARN</code> of the key to associate with the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=70, Max=150)]
        public string KeyArn
        {
            get { return this._keyArn; }
            set { this._keyArn = value; }
        }

        // Check to see if KeyArn property is set
        internal bool IsSetKeyArn()
        {
            return this._keyArn != null;
        }

    }
}