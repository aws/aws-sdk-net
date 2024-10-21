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
    /// The attributes values used for Amex and Visa derivation methods.
    /// </summary>
    public partial class VisaAmexDerivationOutputs
    {
        private string _authorizationRequestKeyArn;
        private string _authorizationRequestKeyCheckValue;
        private string _currentPinPekArn;
        private string _currentPinPekKeyCheckValue;

        /// <summary>
        /// Gets and sets the property AuthorizationRequestKeyArn. 
        /// <para>
        /// The <c>keyArn</c> of the issuer master key for cryptogram (IMK-AC) used by the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=70, Max=150)]
        public string AuthorizationRequestKeyArn
        {
            get { return this._authorizationRequestKeyArn; }
            set { this._authorizationRequestKeyArn = value; }
        }

        // Check to see if AuthorizationRequestKeyArn property is set
        internal bool IsSetAuthorizationRequestKeyArn()
        {
            return this._authorizationRequestKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationRequestKeyCheckValue. 
        /// <para>
        /// The key check value (KCV) of the issuer master key for cryptogram (IMK-AC) used by
        /// the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=16)]
        public string AuthorizationRequestKeyCheckValue
        {
            get { return this._authorizationRequestKeyCheckValue; }
            set { this._authorizationRequestKeyCheckValue = value; }
        }

        // Check to see if AuthorizationRequestKeyCheckValue property is set
        internal bool IsSetAuthorizationRequestKeyCheckValue()
        {
            return this._authorizationRequestKeyCheckValue != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentPinPekArn. 
        /// <para>
        /// The <c>keyArn</c> of the current PIN PEK.
        /// </para>
        /// </summary>
        [AWSProperty(Min=70, Max=150)]
        public string CurrentPinPekArn
        {
            get { return this._currentPinPekArn; }
            set { this._currentPinPekArn = value; }
        }

        // Check to see if CurrentPinPekArn property is set
        internal bool IsSetCurrentPinPekArn()
        {
            return this._currentPinPekArn != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentPinPekKeyCheckValue. 
        /// <para>
        /// The key check value (KCV) of the current PIN PEK.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=16)]
        public string CurrentPinPekKeyCheckValue
        {
            get { return this._currentPinPekKeyCheckValue; }
            set { this._currentPinPekKeyCheckValue = value; }
        }

        // Check to see if CurrentPinPekKeyCheckValue property is set
        internal bool IsSetCurrentPinPekKeyCheckValue()
        {
            return this._currentPinPekKeyCheckValue != null;
        }

    }
}