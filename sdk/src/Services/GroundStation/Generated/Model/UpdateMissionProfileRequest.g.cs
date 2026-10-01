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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMissionProfile operation. Updates a mission
    /// profile. <para> Updating a mission profile will not update the execution parameters
    /// for existing future contacts. </para>
    /// </summary>
    public partial class UpdateMissionProfileRequest : AmazonGroundStationRequest
    {
        /// <summary>
        /// Gets and sets the property ContactPostPassDurationSeconds. 
        /// <para>
        /// Amount of time after a contact ends that you'd like to receive a Ground Station Contact
        /// State Change event indicating the pass has finished.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 21600)]
        public int? ContactPostPassDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ContactPostPassDurationSeconds property is set.
        /// </summary>
        internal bool IsSetContactPostPassDurationSeconds() => this.ContactPostPassDurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ContactPrePassDurationSeconds. 
        /// <para>
        /// Amount of time after a contact ends that you'd like to receive a Ground Station Contact
        /// State Change event indicating the pass has finished.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 21600)]
        public int? ContactPrePassDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ContactPrePassDurationSeconds property is set.
        /// </summary>
        internal bool IsSetContactPrePassDurationSeconds() => this.ContactPrePassDurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property DataflowEdges. 
        /// <para>
        /// A list of lists of ARNs. Each list of ARNs is an edge, with a <i>from</i> <c> Config</c>
        /// and a <i>to</i> <c>Config</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public List<List<string>> DataflowEdges { get; set; } = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;

        /// <summary>
        /// Checks to see if the DataflowEdges property is set.
        /// </summary>
        internal bool IsSetDataflowEdges() => this.DataflowEdges != null && (this.DataflowEdges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MinimumViableContactDurationSeconds. 
        /// <para>
        /// Smallest amount of time in seconds that you'd like to see for an available contact.
        /// AWS Ground Station will not present you with contacts shorter than this duration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 21600)]
        public int? MinimumViableContactDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MinimumViableContactDurationSeconds property is set.
        /// </summary>
        internal bool IsSetMinimumViableContactDurationSeconds() => this.MinimumViableContactDurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MissionProfileId. 
        /// <para>
        /// UUID of a mission profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MissionProfileId { get; set; }

        /// <summary>
        /// Checks to see if the MissionProfileId property is set.
        /// </summary>
        internal bool IsSetMissionProfileId() => this.MissionProfileId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of a mission profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property StreamsKmsKey. 
        /// <para>
        /// KMS key to use for encrypting streams.
        /// </para>
        /// </summary>
        public KmsKey StreamsKmsKey { get; set; }

        /// <summary>
        /// Checks to see if the StreamsKmsKey property is set.
        /// </summary>
        internal bool IsSetStreamsKmsKey() => this.StreamsKmsKey != null;

        /// <summary>
        /// Gets and sets the property StreamsKmsRole. 
        /// <para>
        /// Role to use for encrypting streams with KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 30, Max = 165)]
        public string StreamsKmsRole { get; set; }

        /// <summary>
        /// Checks to see if the StreamsKmsRole property is set.
        /// </summary>
        internal bool IsSetStreamsKmsRole() => this.StreamsKmsRole != null;

        /// <summary>
        /// Gets and sets the property TelemetrySinkConfigArn. 
        /// <para>
        /// ARN of a telemetry sink <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 82, Max = 424)]
        public string TelemetrySinkConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the TelemetrySinkConfigArn property is set.
        /// </summary>
        internal bool IsSetTelemetrySinkConfigArn() => this.TelemetrySinkConfigArn != null;

        /// <summary>
        /// Gets and sets the property TrackingConfigArn. 
        /// <para>
        /// ARN of a tracking <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 82, Max = 424)]
        public string TrackingConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the TrackingConfigArn property is set.
        /// </summary>
        internal bool IsSetTrackingConfigArn() => this.TrackingConfigArn != null;
    }
}
