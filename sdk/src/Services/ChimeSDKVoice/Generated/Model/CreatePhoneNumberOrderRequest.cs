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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
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
namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePhoneNumberOrder operation.
    /// Creates an order for phone numbers to be provisioned. For numbers outside the U.S.,
    /// you must use the Amazon Chime SDK SIP media application dial-in product type.
    /// </summary>
    public partial class CreatePhoneNumberOrderRequest : AmazonChimeSDKVoiceRequest
    {
        private List<string> _e164PhoneNumbers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private PhoneNumberProductType _productType;

        /// <summary>
        /// Gets and sets the property E164PhoneNumbers. 
        /// <para>
        /// List of phone numbers, in E.164 format.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> E164PhoneNumbers
        {
            get { return this._e164PhoneNumbers; }
            set { this._e164PhoneNumbers = value; }
        }

        // Check to see if E164PhoneNumbers property is set
        internal bool IsSetE164PhoneNumbers()
        {
            return this._e164PhoneNumbers != null && (this._e164PhoneNumbers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name assigned to one or more phone numbers.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProductType. 
        /// <para>
        /// The phone number product type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PhoneNumberProductType ProductType
        {
            get { return this._productType; }
            set { this._productType = value; }
        }

        // Check to see if ProductType property is set
        internal bool IsSetProductType()
        {
            return this._productType != null;
        }

    }
}