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
    /// The parameter values of the current PIN to be changed on the EMV chip card.
    /// </summary>
    public partial class CurrentPinAttributes
    {
        /// <summary>
        /// Gets and sets the property CurrentEncryptedPinBlock. 
        /// <para>
        /// The encrypted pinblock of the current pin stored on the chip card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 16, Max = 16)]
        public string CurrentEncryptedPinBlock { get; set; }

        /// <summary>
        /// Checks to see if the CurrentEncryptedPinBlock property is set.
        /// </summary>
        internal bool IsSetCurrentEncryptedPinBlock() => this.CurrentEncryptedPinBlock != null;

        /// <summary>
        /// Gets and sets the property CurrentPinPekIdentifier. 
        /// <para>
        /// The <c>keyArn</c> of the current PIN PEK.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 322)]
        public string CurrentPinPekIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CurrentPinPekIdentifier property is set.
        /// </summary>
        internal bool IsSetCurrentPinPekIdentifier() => this.CurrentPinPekIdentifier != null;
    }
}
