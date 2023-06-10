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
    /// Container for the parameters to the DeleteAlias operation.
    /// Deletes the alias, but doesn't affect the underlying key.
    /// 
    ///  
    /// <para>
    /// Each key can have multiple aliases. To get the aliases of all keys, use the <a>ListAliases</a>
    /// operation. To change the alias of a key, first use <a>DeleteAlias</a> to delete the
    /// current alias and then use <a>CreateAlias</a> to create a new alias. To associate
    /// an existing alias with a different key, call <a>UpdateAlias</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
    /// Services accounts.
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
    public partial class DeleteAliasRequest : AmazonPaymentCryptographyRequest
    {
        private string _aliasName;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// A friendly name that you can use to refer Amazon Web Services Payment Cryptography
        /// key. This value must begin with <code>alias/</code> followed by a name, such as <code>alias/ExampleAlias</code>.
        /// </para>
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

    }
}