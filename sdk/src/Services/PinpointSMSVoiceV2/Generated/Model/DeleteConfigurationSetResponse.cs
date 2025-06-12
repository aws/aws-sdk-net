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
    /// This is the response object from the DeleteConfigurationSet operation.
    /// </summary>
    public partial class DeleteConfigurationSetResponse : AmazonWebServiceResponse
    {
        private string _configurationSetArn;
        private string _configurationSetName;
        private DateTime? _createdTimestamp;
        private bool? _defaultMessageFeedbackEnabled;
        private MessageType _defaultMessageType;
        private string _defaultSenderId;
        private List<EventDestination> _eventDestinations = AWSConfigs.InitializeCollections ? new List<EventDestination>() : null;

        /// <summary>
        /// Gets and sets the property ConfigurationSetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the deleted configuration set.
        /// </para>
        /// </summary>
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
        /// The name of the deleted configuration set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// The time that the deleted configuration set was created in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultMessageFeedbackEnabled. 
        /// <para>
        /// True if the configuration set has message feedback enabled. By default this is set
        /// to false. 
        /// </para>
        /// </summary>
        public bool? DefaultMessageFeedbackEnabled
        {
            get { return this._defaultMessageFeedbackEnabled; }
            set { this._defaultMessageFeedbackEnabled = value; }
        }

        // Check to see if DefaultMessageFeedbackEnabled property is set
        internal bool IsSetDefaultMessageFeedbackEnabled()
        {
            return this._defaultMessageFeedbackEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultMessageType. 
        /// <para>
        /// The default message type of the configuration set that was deleted.
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
        /// The default Sender ID of the configuration set that was deleted.
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
        /// An array of any EventDestination objects that were associated with the deleted configuration
        /// set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EventDestination> EventDestinations
        {
            get { return this._eventDestinations; }
            set { this._eventDestinations = value; }
        }

        // Check to see if EventDestinations property is set
        internal bool IsSetEventDestinations()
        {
            return this._eventDestinations != null && (this._eventDestinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}