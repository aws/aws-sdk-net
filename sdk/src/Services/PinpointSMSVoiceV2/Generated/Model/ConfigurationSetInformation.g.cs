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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Information related to a given configuration set in your Amazon Web Services account.
    /// </summary>
    public partial class ConfigurationSetInformation
    {
        /// <summary>
        /// Gets and sets the property ConfigurationSetArn. 
        /// <para>
        /// The Resource Name (ARN) of the ConfigurationSet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConfigurationSetArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSetArn property is set.
        /// </summary>
        internal bool IsSetConfigurationSetArn() => this.ConfigurationSetArn != null;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the ConfigurationSet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ConfigurationSetName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSetName property is set.
        /// </summary>
        internal bool IsSetConfigurationSetName() => this.ConfigurationSetName != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the ConfigurationSet was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultMessageFeedbackEnabled. 
        /// <para>
        /// True if message feedback is enabled.
        /// </para>
        /// </summary>
        public bool? DefaultMessageFeedbackEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DefaultMessageFeedbackEnabled property is set.
        /// </summary>
        internal bool IsSetDefaultMessageFeedbackEnabled() => this.DefaultMessageFeedbackEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultMessageType. 
        /// <para>
        /// The type of message. Valid values are TRANSACTIONAL for messages that are critical
        /// or time-sensitive and PROMOTIONAL for messages that aren't critical or time-sensitive.
        /// </para>
        /// </summary>
        public MessageType DefaultMessageType { get; set; }

        /// <summary>
        /// Checks to see if the DefaultMessageType property is set.
        /// </summary>
        internal bool IsSetDefaultMessageType() => this.DefaultMessageType != null;

        /// <summary>
        /// Gets and sets the property DefaultSenderId. 
        /// <para>
        /// The default sender ID used by the ConfigurationSet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 11)]
        public string DefaultSenderId { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSenderId property is set.
        /// </summary>
        internal bool IsSetDefaultSenderId() => this.DefaultSenderId != null;

        /// <summary>
        /// Gets and sets the property EventDestinations. 
        /// <para>
        /// An array of EventDestination objects that describe any events to log and where to
        /// log them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<EventDestination> EventDestinations { get; set; } = AWSConfigs.InitializeCollections ? new List<EventDestination>() : null;

        /// <summary>
        /// Checks to see if the EventDestinations property is set.
        /// </summary>
        internal bool IsSetEventDestinations() => this.EventDestinations != null && (this.EventDestinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProtectConfigurationId. 
        /// <para>
        /// The unique identifier for the protect configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ProtectConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the ProtectConfigurationId property is set.
        /// </summary>
        internal bool IsSetProtectConfigurationId() => this.ProtectConfigurationId != null;
    }
}
