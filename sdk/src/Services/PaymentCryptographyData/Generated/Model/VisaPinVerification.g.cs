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
    /// Parameters that are required to generate or verify Visa PIN.
    /// </summary>
    public partial class VisaPinVerification
    {
        /// <summary>
        /// Gets and sets the property PinVerificationKeyIndex. 
        /// <para>
        /// The value for PIN verification index. It is used in the Visa PIN algorithm to calculate
        /// the PVV (PIN Verification Value).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 6)]
        public int? PinVerificationKeyIndex { get; set; }

        /// <summary>
        /// Checks to see if the PinVerificationKeyIndex property is set.
        /// </summary>
        internal bool IsSetPinVerificationKeyIndex() => this.PinVerificationKeyIndex.HasValue;

        /// <summary>
        /// Gets and sets the property VerificationValue. 
        /// <para>
        /// Parameters that are required to generate or verify Visa PVV (PIN Verification Value).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 4, Max = 12)]
        public string VerificationValue { get; set; }

        /// <summary>
        /// Checks to see if the VerificationValue property is set.
        /// </summary>
        internal bool IsSetVerificationValue() => this.VerificationValue != null;
    }
}
