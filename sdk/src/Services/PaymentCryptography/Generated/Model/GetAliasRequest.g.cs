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
    /// Container for the parameters to the GetAlias operation. Gets the Amazon Web Services
    /// Payment Cryptography key associated with the alias. <para> <b>Cross-account use:</b>
    /// This operation can't be used across different Amazon Web Services accounts. </para>
    /// <para> <b>Related operations:</b> </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateAlias.html">CreateAlias</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DeleteAlias.html">DeleteAlias</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ListAliases.html">ListAliases</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_UpdateAlias.html">UpdateAlias</a>
    /// </para> </li> </ul>
    /// </summary>
    public partial class GetAliasRequest : AmazonPaymentCryptographyRequest
    {
        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The alias of the Amazon Web Services Payment Cryptography key.
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
