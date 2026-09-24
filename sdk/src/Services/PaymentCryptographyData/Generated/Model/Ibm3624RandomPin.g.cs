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
    /// Parameters that are required to generate or verify Ibm3624 random PIN.
    /// </summary>
    public partial class Ibm3624RandomPin
    {
        /// <summary>
        /// Gets and sets the property DecimalizationTable. 
        /// <para>
        /// The decimalization table to use for IBM 3624 PIN algorithm. The table is used to convert
        /// the algorithm intermediate result from hexadecimal characters to decimal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 16, Max = 16)]
        public string DecimalizationTable { get; set; }

        /// <summary>
        /// Checks to see if the DecimalizationTable property is set.
        /// </summary>
        internal bool IsSetDecimalizationTable() => this.DecimalizationTable != null;

        /// <summary>
        /// Gets and sets the property PinValidationData. 
        /// <para>
        /// The unique data for cardholder identification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 4, Max = 16)]
        public string PinValidationData { get; set; }

        /// <summary>
        /// Checks to see if the PinValidationData property is set.
        /// </summary>
        internal bool IsSetPinValidationData() => this.PinValidationData != null;

        /// <summary>
        /// Gets and sets the property PinValidationDataPadCharacter. 
        /// <para>
        /// The padding character for validation data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public string PinValidationDataPadCharacter { get; set; }

        /// <summary>
        /// Checks to see if the PinValidationDataPadCharacter property is set.
        /// </summary>
        internal bool IsSetPinValidationDataPadCharacter() => this.PinValidationDataPadCharacter != null;
    }
}
