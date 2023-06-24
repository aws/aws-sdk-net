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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Information related to a given configuration set in your Amazon Web Services account.
    /// </summary>
    public partial class ConfigurationSetInformation
    {
        private string _configurationSetArn;
        private string _configurationSetName;
        private DateTime? _createdTimestamp;
        private MessageType _defaultMessageType;
        private string _defaultSenderId;
        private List<EventDestination> _eventDestinations = new List<EventDestination>();

        /// <summary>
        /// Gets and sets the property ConfigurationSetArn. 
        /// <para>
        /// The Resource Name (ARN) of the ConfigurationSet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConfigurationSetArn
        {
            get { return this._configurationSetArn; }
            set { this._configurationSetArn = value; }
        }

        // Check to see if ConfigurationSetArn property is set
        internal bool IsSetConfigurationSetArn()
        {
            return this._configurationSetArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the ConfigurationSet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the ConfigurationSet was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultMessageType. 
        /// <para>
        /// The type of message. Valid values are TRANSACTIONAL for messages that are critical
        /// or time-sensitive and PROMOTIONAL for messages that aren't critical or time-sensitive.
        /// </para>
        /// </summary>
        public MessageType DefaultMessageType
        {
            get { return this._defaultMessageType; }
            set { this._defaultMessageType = value; }
        }

        // Check to see if DefaultMessageType property is set
        internal bool IsSetDefaultMessageType()
        {
            return this._defaultMessageType != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultSenderId. 
        /// <para>
        /// The default sender ID used by the ConfigurationSet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=11)]
        public string DefaultSenderId
        {
            get { return this._defaultSenderId; }
            set { this._defaultSenderId = value; }
        }

        // Check to see if DefaultSenderId property is set
        internal bool IsSetDefaultSenderId()
        {
            return this._defaultSenderId != null;
        }

        /// <summary>
        /// Gets and sets the property EventDestinations. 
        /// <para>
        /// An array of EventDestination objects that describe any events to log and where to
        /// log them.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EventDestination> EventDestinations
        {
            get { return this._eventDestinations; }
            set { this._eventDestinations = value; }
        }

        // Check to see if EventDestinations property is set
        internal bool IsSetEventDestinations()
        {
            return this._eventDestinations != null && this._eventDestinations.Count > 0; 
        }

    }
}