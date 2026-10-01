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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProxySession operation. Creates a proxy
    /// session for the specified Amazon Chime SDK Voice Connector for the specified participant
    /// phone numbers. <important> <para> End of support notice: On April 7, 2026, AWS will
    /// end support for Amazon Chime SDK proxy sessions. </para> </important>
    /// </summary>
    public partial class CreateProxySessionRequest : AmazonChimeSDKVoiceRequest
    {
        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The proxy session's capabilities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Capabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null && (this.Capabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExpiryMinutes. 
        /// <para>
        /// The number of minutes allowed for the proxy session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? ExpiryMinutes { get; set; }

        /// <summary>
        /// Checks to see if the ExpiryMinutes property is set.
        /// </summary>
        internal bool IsSetExpiryMinutes() => this.ExpiryMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property GeoMatchLevel. 
        /// <para>
        /// The preference for matching the country or area code of the proxy phone number with
        /// that of the first participant.
        /// </para>
        /// </summary>
        public GeoMatchLevel GeoMatchLevel { get; set; }

        /// <summary>
        /// Checks to see if the GeoMatchLevel property is set.
        /// </summary>
        internal bool IsSetGeoMatchLevel() => this.GeoMatchLevel != null;

        /// <summary>
        /// Gets and sets the property GeoMatchParams. 
        /// <para>
        /// The country and area code for the proxy phone number.
        /// </para>
        /// </summary>
        public GeoMatchParams GeoMatchParams { get; set; }

        /// <summary>
        /// Checks to see if the GeoMatchParams property is set.
        /// </summary>
        internal bool IsSetGeoMatchParams() => this.GeoMatchParams != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the proxy session.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NumberSelectionBehavior. 
        /// <para>
        /// The preference for proxy phone number reuse, or stickiness, between the same participants
        /// across sessions.
        /// </para>
        /// </summary>
        public NumberSelectionBehavior NumberSelectionBehavior { get; set; }

        /// <summary>
        /// Checks to see if the NumberSelectionBehavior property is set.
        /// </summary>
        internal bool IsSetNumberSelectionBehavior() => this.NumberSelectionBehavior != null;

        /// <summary>
        /// Gets and sets the property ParticipantPhoneNumbers. 
        /// <para>
        /// The participant phone numbers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
        public List<string> ParticipantPhoneNumbers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ParticipantPhoneNumbers property is set.
        /// </summary>
        internal bool IsSetParticipantPhoneNumbers() => this.ParticipantPhoneNumbers != null && (this.ParticipantPhoneNumbers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VoiceConnectorId. 
        /// <para>
        /// The Voice Connector ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VoiceConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the VoiceConnectorId property is set.
        /// </summary>
        internal bool IsSetVoiceConnectorId() => this.VoiceConnectorId != null;
    }
}
