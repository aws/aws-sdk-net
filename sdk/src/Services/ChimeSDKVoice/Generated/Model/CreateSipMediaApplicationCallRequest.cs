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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSipMediaApplicationCall operation.
    /// 
    /// </summary>
    public partial class CreateSipMediaApplicationCallRequest : AmazonChimeSDKVoiceRequest
    {
        private Dictionary<string, string> _argumentsMap = new Dictionary<string, string>();
        private string _fromPhoneNumber;
        private Dictionary<string, string> _sipHeaders = new Dictionary<string, string>();
        private string _sipMediaApplicationId;
        private string _toPhoneNumber;

        /// <summary>
        /// Gets and sets the property ArgumentsMap.
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
            return this._argumentsMap != null && this._argumentsMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FromPhoneNumber.
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
            return this._sipHeaders != null && this._sipHeaders.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SipMediaApplicationId.
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