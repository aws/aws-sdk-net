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
    /// Container for the parameters to the CreateSipMediaApplicationCall operation.
    /// Creates an outbound call to a phone number from the phone number specified in the
    /// request, and it invokes the endpoint of the specified <c>sipMediaApplicationId</c>.
    /// </summary>
    public partial class CreateSipMediaApplicationCallRequest : AmazonChimeSDKVoiceRequest
    {
        private Dictionary<string, string> _argumentsMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _fromPhoneNumber;
        private Dictionary<string, string> _sipHeaders = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _sipMediaApplicationId;
        private string _toPhoneNumber;

        /// <summary>
        /// Gets and sets the property ArgumentsMap. 
        /// <para>
        /// Context passed to a CreateSipMediaApplication API call. For example, you could pass
        /// key-value pairs such as: <c>"FirstName": "John", "LastName": "Doe"</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public Dictionary<string, string> ArgumentsMap
        {
            get { return this._argumentsMap; }
            set { this._argumentsMap = value; }
        }

        // Check to see if ArgumentsMap property is set
        internal bool IsSetArgumentsMap()
        {
            return this._argumentsMap != null && (this._argumentsMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FromPhoneNumber. 
        /// <para>
        /// The phone number that a user calls from. This is a phone number in your Amazon Chime
        /// SDK phone number inventory.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string FromPhoneNumber
        {
            get { return this._fromPhoneNumber; }
            set { this._fromPhoneNumber = value; }
        }

        // Check to see if FromPhoneNumber property is set
        internal bool IsSetFromPhoneNumber()
        {
            return this._fromPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property SipHeaders. 
        /// <para>
        /// The SIP headers added to an outbound call leg.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public Dictionary<string, string> SipHeaders
        {
            get { return this._sipHeaders; }
            set { this._sipHeaders = value; }
        }

        // Check to see if SipHeaders property is set
        internal bool IsSetSipHeaders()
        {
            return this._sipHeaders != null && (this._sipHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SipMediaApplicationId. 
        /// <para>
        /// The ID of the SIP media application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SipMediaApplicationId
        {
            get { return this._sipMediaApplicationId; }
            set { this._sipMediaApplicationId = value; }
        }

        // Check to see if SipMediaApplicationId property is set
        internal bool IsSetSipMediaApplicationId()
        {
            return this._sipMediaApplicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ToPhoneNumber. 
        /// <para>
        /// The phone number that the service should call.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string ToPhoneNumber
        {
            get { return this._toPhoneNumber; }
            set { this._toPhoneNumber = value; }
        }

        // Check to see if ToPhoneNumber property is set
        internal bool IsSetToPhoneNumber()
        {
            return this._toPhoneNumber != null;
        }

    }
}