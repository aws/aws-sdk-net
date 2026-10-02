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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the CarrierLookup operation.
    /// Returns information about a destination phone number, including whether the number
    /// type and whether it is valid, the carrier, and more.
    /// </summary>
    public partial class CarrierLookupRequest : AmazonPinpointSMSVoiceV2Request
    {
        private bool? _enableCleansing;
        private string _phoneNumber;

        /// <summary>
        /// Gets and sets the property EnableCleansing. 
        /// <para>
        /// Specifies whether the service cleanses the phone number that you provide. When set
        /// to <c>true</c>, the service normalizes the phone number according to the destination
        /// country's national numbering plan and dialing rules. The service returns the cleansed
        /// number in E.164 format in the <c>E164PhoneNumber</c> field and returns the number
        /// that you provided in the <c>OriginalPhoneNumber</c> field.
        /// </para>
        /// </summary>
        public bool? EnableCleansing
        {
            get { return this._enableCleansing; }
            set { this._enableCleansing = value; }
        }

        // Check to see if EnableCleansing property is set
        internal bool IsSetEnableCleansing()
        {
            return this._enableCleansing.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number that you want to retrieve information about. You can provide the
        /// phone number in various formats including special characters such as parentheses,
        /// brackets, spaces, hyphens, periods, and commas. The service automatically converts
        /// the input to E164 format for processing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }

        // Check to see if PhoneNumber property is set
        internal bool IsSetPhoneNumber()
        {
            return this._phoneNumber != null;
        }

    }
}