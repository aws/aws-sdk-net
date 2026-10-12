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
    /// This is the response object from the DeleteConfigurationSet operation.
    /// </summary>
    public partial class DeleteConfigurationSetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConfigurationSetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the deleted configuration set.
        /// </para>
        /// </summary>
        public string ConfigurationSetArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSetArn property is set.
        /// </summary>
        internal bool IsSetConfigurationSetArn() => this.ConfigurationSetArn != null;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the deleted configuration set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ConfigurationSetName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSetName property is set.
        /// </summary>
        internal bool IsSetConfigurationSetName() => this.ConfigurationSetName != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time that the deleted configuration set was created in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultMessageFeedbackEnabled. 
        /// <para>
        /// True if the configuration set has message feedback enabled. By default this is set
        /// to false. 
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
        /// The default message type of the configuration set that was deleted.
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
        /// The default Sender ID of the configuration set that was deleted.
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
        /// An array of any EventDestination objects that were associated with the deleted configuration
        /// set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EventDestination> EventDestinations { get; set; } = AWSConfigs.InitializeCollections ? new List<EventDestination>() : null;

        /// <summary>
        /// Checks to see if the EventDestinations property is set.
        /// </summary>
        internal bool IsSetEventDestinations() => this.EventDestinations != null && (this.EventDestinations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
