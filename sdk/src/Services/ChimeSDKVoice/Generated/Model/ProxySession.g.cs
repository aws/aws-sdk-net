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
    /// The proxy session for an Amazon Chime SDK Voice Connector.
    /// </summary>
    public partial class ProxySession
    {
        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The proxy session capabilities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Capabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null && (this.Capabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The created time stamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EndedTimestamp. 
        /// <para>
        /// The ended time stamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? EndedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EndedTimestamp property is set.
        /// </summary>
        internal bool IsSetEndedTimestamp() => this.EndedTimestamp.HasValue;

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
        /// The proxy session name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
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
        /// Gets and sets the property Participants. 
        /// <para>
        /// The proxy session participants.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Participant> Participants { get; set; } = AWSConfigs.InitializeCollections ? new List<Participant>() : null;

        /// <summary>
        /// Checks to see if the Participants property is set.
        /// </summary>
        internal bool IsSetParticipants() => this.Participants != null && (this.Participants.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProxySessionId. 
        /// <para>
        /// The proxy session ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ProxySessionId { get; set; }

        /// <summary>
        /// Checks to see if the ProxySessionId property is set.
        /// </summary>
        internal bool IsSetProxySessionId() => this.ProxySessionId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The proxy session status.
        /// </para>
        /// </summary>
        public ProxySessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The updated time stamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property VoiceConnectorId. 
        /// <para>
        /// The Voice Connector ID.
        /// </para>
        /// </summary>
        public string VoiceConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the VoiceConnectorId property is set.
        /// </summary>
        internal bool IsSetVoiceConnectorId() => this.VoiceConnectorId != null;
    }
}
