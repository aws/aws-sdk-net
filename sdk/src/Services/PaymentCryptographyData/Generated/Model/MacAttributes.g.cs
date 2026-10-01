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
    /// Parameters that are required for DUKPT, HMAC, or EMV MAC generation or verification.
    /// </summary>
    public partial class MacAttributes
    {
        /// <summary>
        /// Gets and sets the property Algorithm. 
        /// <para>
        /// The encryption algorithm for MAC generation or verification.
        /// </para>
        /// </summary>
        public MacAlgorithm Algorithm { get; set; }

        /// <summary>
        /// Checks to see if the Algorithm property is set.
        /// </summary>
        internal bool IsSetAlgorithm() => this.Algorithm != null;

        /// <summary>
        /// Gets and sets the property DukptCmac. 
        /// <para>
        /// Parameters that are required for MAC generation or verification using DUKPT CMAC algorithm.
        /// </para>
        /// </summary>
        public MacAlgorithmDukpt DukptCmac { get; set; }

        /// <summary>
        /// Checks to see if the DukptCmac property is set.
        /// </summary>
        internal bool IsSetDukptCmac() => this.DukptCmac != null;

        /// <summary>
        /// Gets and sets the property DukptIso9797Algorithm1. 
        /// <para>
        /// Parameters that are required for MAC generation or verification using DUKPT ISO 9797
        /// algorithm1.
        /// </para>
        /// </summary>
        public MacAlgorithmDukpt DukptIso9797Algorithm1 { get; set; }

        /// <summary>
        /// Checks to see if the DukptIso9797Algorithm1 property is set.
        /// </summary>
        internal bool IsSetDukptIso9797Algorithm1() => this.DukptIso9797Algorithm1 != null;

        /// <summary>
        /// Gets and sets the property DukptIso9797Algorithm3. 
        /// <para>
        /// Parameters that are required for MAC generation or verification using DUKPT ISO 9797
        /// algorithm3.
        /// </para>
        /// </summary>
        public MacAlgorithmDukpt DukptIso9797Algorithm3 { get; set; }

        /// <summary>
        /// Checks to see if the DukptIso9797Algorithm3 property is set.
        /// </summary>
        internal bool IsSetDukptIso9797Algorithm3() => this.DukptIso9797Algorithm3 != null;

        /// <summary>
        /// Gets and sets the property EmvMac. 
        /// <para>
        /// Parameters that are required for MAC generation or verification using EMV MAC algorithm.
        /// </para>
        /// </summary>
        public MacAlgorithmEmv EmvMac { get; set; }

        /// <summary>
        /// Checks to see if the EmvMac property is set.
        /// </summary>
        internal bool IsSetEmvMac() => this.EmvMac != null;
    }
}
