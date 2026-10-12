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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// <i>This data type is no longer supported.</i> Applies only to SMS multi-factor authentication
    /// (MFA) configurations. Does not apply to time-based one-time password (TOTP) software
    /// token MFA configurations.
    /// </summary>
    public partial class MFAOptionType
    {
        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The attribute name of the MFA option type. The only valid value is <c>phone_number</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string AttributeName { get; set; }

        /// <summary>
        /// Checks to see if the AttributeName property is set.
        /// </summary>
        internal bool IsSetAttributeName() => this.AttributeName != null;

        /// <summary>
        /// Gets and sets the property DeliveryMedium. 
        /// <para>
        /// The delivery medium to send the MFA code. You can use this parameter to set only the
        /// <c>SMS</c> delivery medium value.
        /// </para>
        /// </summary>
        public DeliveryMediumType DeliveryMedium { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryMedium property is set.
        /// </summary>
        internal bool IsSetDeliveryMedium() => this.DeliveryMedium != null;
    }
}
