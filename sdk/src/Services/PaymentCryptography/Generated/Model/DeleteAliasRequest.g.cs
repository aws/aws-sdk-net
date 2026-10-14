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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAlias operation. Deletes the alias, but
    /// doesn't affect the underlying key. <para> Each key can have multiple aliases. To get
    /// the aliases of all keys, use the <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_UpdateAlias.html">UpdateAlias</a>
    /// operation. To change the alias of a key, first use <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DeleteAlias.html">DeleteAlias</a>
    /// to delete the current alias and then use <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateAlias.html">CreateAlias</a>
    /// to create a new alias. To associate an existing alias with a different key, call <a
    /// href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_UpdateAlias.html">UpdateAlias</a>.
    /// </para> <para> <b>Cross-account use:</b> This operation can't be used across different
    /// Amazon Web Services accounts. </para> <para> <b>Related operations:</b> </para> <ul>
    /// <li> <para> <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateAlias.html">CreateAlias</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetAlias.html">GetAlias</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ListAliases.html">ListAliases</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_UpdateAlias.html">UpdateAlias</a>
    /// </para> </li> </ul>
    /// </summary>
    public partial class DeleteAliasRequest : AmazonPaymentCryptographyRequest
    {
        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// A friendly name that you can use to refer Amazon Web Services Payment Cryptography
        /// key. This value must begin with <c>alias/</c> followed by a name, such as <c>alias/ExampleAlias</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 256)]
        public string AliasName { get; set; }

        /// <summary>
        /// Checks to see if the AliasName property is set.
        /// </summary>
        internal bool IsSetAliasName() => this.AliasName != null;
    }
}
