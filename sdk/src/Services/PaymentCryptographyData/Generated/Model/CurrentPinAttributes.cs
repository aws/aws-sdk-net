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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
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
        private string _currentEncryptedPinBlock;
        private string _currentPinPekIdentifier;

        /// <summary>
        /// Gets and sets the property CurrentEncryptedPinBlock. 
        /// <para>
        /// The encrypted pinblock of the current pin stored on the chip card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=16, Max=16)]
        public string CurrentEncryptedPinBlock
        {
            get { return this._currentEncryptedPinBlock; }
            set { this._currentEncryptedPinBlock = value; }
        }

        // Check to see if CurrentEncryptedPinBlock property is set
        internal bool IsSetCurrentEncryptedPinBlock()
        {
            return this._currentEncryptedPinBlock != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentPinPekIdentifier. 
        /// <para>
        /// The <c>keyArn</c> of the current PIN PEK.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string CurrentPinPekIdentifier
        {
            get { return this._currentPinPekIdentifier; }
            set { this._currentPinPekIdentifier = value; }
        }

        // Check to see if CurrentPinPekIdentifier property is set
        internal bool IsSetCurrentPinPekIdentifier()
        {
            return this._currentPinPekIdentifier != null;
        }

    }
}