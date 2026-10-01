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
    /// The attributes values used for Amex and Visa derivation methods.
    /// </summary>
    public partial class VisaAmexDerivationOutputs
    {
        /// <summary>
        /// Gets and sets the property AuthorizationRequestKeyArn. 
        /// <para>
        /// The <c>keyArn</c> of the issuer master key for cryptogram (IMK-AC) used by the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 70, Max = 150)]
        public string AuthorizationRequestKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationRequestKeyArn property is set.
        /// </summary>
        internal bool IsSetAuthorizationRequestKeyArn() => this.AuthorizationRequestKeyArn != null;

        /// <summary>
        /// Gets and sets the property AuthorizationRequestKeyCheckValue. 
        /// <para>
        /// The key check value (KCV) of the issuer master key for cryptogram (IMK-AC) used by
        /// the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 16)]
        public string AuthorizationRequestKeyCheckValue { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationRequestKeyCheckValue property is set.
        /// </summary>
        internal bool IsSetAuthorizationRequestKeyCheckValue() => this.AuthorizationRequestKeyCheckValue != null;

        /// <summary>
        /// Gets and sets the property CurrentPinPekArn. 
        /// <para>
        /// The <c>keyArn</c> of the current PIN PEK.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 70, Max = 150)]
        public string CurrentPinPekArn { get; set; }

        /// <summary>
        /// Checks to see if the CurrentPinPekArn property is set.
        /// </summary>
        internal bool IsSetCurrentPinPekArn() => this.CurrentPinPekArn != null;

        /// <summary>
        /// Gets and sets the property CurrentPinPekKeyCheckValue. 
        /// <para>
        /// The key check value (KCV) of the current PIN PEK.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 16)]
        public string CurrentPinPekKeyCheckValue { get; set; }

        /// <summary>
        /// Checks to see if the CurrentPinPekKeyCheckValue property is set.
        /// </summary>
        internal bool IsSetCurrentPinPekKeyCheckValue() => this.CurrentPinPekKeyCheckValue != null;
    }
}
