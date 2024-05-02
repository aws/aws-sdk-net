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
    /// Container for the parameters to the SetDefaultSenderId operation.
    /// Sets default sender ID on a configuration set.
    /// 
    ///  
    /// <para>
    /// When sending a text message to a destination country that supports sender IDs, the
    /// default sender ID on the configuration set specified will be used if no dedicated
    /// origination phone numbers or registered sender IDs are available in your account.
    /// </para>
    /// </summary>
    public partial class SetDefaultSenderIdRequest : AmazonPinpointSMSVoiceV2Request
    {
        private string _configurationSetName;
        private string _senderId;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The configuration set to updated with a new default SenderId. This field can be the
        /// ConsigurationSetName or ConfigurationSetArn.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConfigurationSetName
        {
            get { return this._configurationSetName; }
            set { this._configurationSetName = value; }
        }

        // Check to see if ConfigurationSetName property is set
        internal bool IsSetConfigurationSetName()
        {
            return this._configurationSetName != null;
        }

        /// <summary>
        /// Gets and sets the property SenderId. 
        /// <para>
        /// The current sender ID for the configuration set. When sending a text message to a
        /// destination country which supports SenderIds, the default sender ID on the configuration
        /// set specified on <a>SendTextMessage</a> will be used if no dedicated origination phone
        /// numbers or registered SenderIds are available in your account, instead of a generic
        /// sender ID, such as 'NOTICE'.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=11)]
        public string SenderId
        {
            get { return this._senderId; }
            set { this._senderId = value; }
        }

        // Check to see if SenderId property is set
        internal bool IsSetSenderId()
        {
            return this._senderId != null;
        }

    }
}