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
    /// Parameters that are required for ARPC response generation using method2 after ARQC
    /// verification is successful.
    /// </summary>
    public partial class CryptogramVerificationArpcMethod2
    {
        /// <summary>
        /// Gets and sets the property CardStatusUpdate. 
        /// <para>
        /// The data indicating whether the issuer approves or declines an online transaction
        /// using an EMV chip card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 8)]
        public string CardStatusUpdate { get; set; }

        /// <summary>
        /// Checks to see if the CardStatusUpdate property is set.
        /// </summary>
        internal bool IsSetCardStatusUpdate() => this.CardStatusUpdate != null;

        /// <summary>
        /// Gets and sets the property ProprietaryAuthenticationData. 
        /// <para>
        /// The proprietary authentication data used by issuer for communication during online
        /// transaction using an EMV chip card.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 16)]
        public string ProprietaryAuthenticationData { get; set; }

        /// <summary>
        /// Checks to see if the ProprietaryAuthenticationData property is set.
        /// </summary>
        internal bool IsSetProprietaryAuthenticationData() => this.ProprietaryAuthenticationData != null;
    }
}
