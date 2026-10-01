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

namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Card data parameters that are required to generate a Card Security Code (CSC2) for
    /// an AMEX payment card.
    /// </summary>
    public partial class AmexCardSecurityCodeVersion2
    {
        /// <summary>
        /// Gets and sets the property CardExpiryDate. 
        /// <para>
        /// The expiry date of a payment card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 4, Max = 4)]
        public string CardExpiryDate { get; set; }

        /// <summary>
        /// Checks to see if the CardExpiryDate property is set.
        /// </summary>
        internal bool IsSetCardExpiryDate() => this.CardExpiryDate != null;

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// The service code of the AMEX payment card. This is different from the Card Security
        /// Code (CSC).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 3, Max = 3)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCode property is set.
        /// </summary>
        internal bool IsSetServiceCode() => this.ServiceCode != null;
    }
}
