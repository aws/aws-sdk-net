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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMissionProfile operation.
    /// Updates a mission profile.
    /// 
    ///  
    /// <para>
    /// Updating a mission profile will not update the execution parameters for existing future
    /// contacts.
    /// </para>
    /// </summary>
    public partial class UpdateMissionProfileRequest : AmazonGroundStationRequest
    {
        private int? _contactPostPassDurationSeconds;
        private int? _contactPrePassDurationSeconds;
        private List<List<string>> _dataflowEdges = new List<List<string>>();
        private int? _minimumViableContactDurationSeconds;
        private string _missionProfileId;
        private string _name;
        private KmsKey _streamsKmsKey;
        private string _streamsKmsRole;
        private string _trackingConfigArn;

        /// <summary>
        /// Gets and sets the property ContactPostPassDurationSeconds. 
        /// <para>
        /// Amount of time after a contact ends that you’d like to receive a CloudWatch event
        /// indicating the pass has finished.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=21600)]
        public int ContactPostPassDurationSeconds
        {
            get { return this._contactPostPassDurationSeconds.GetValueOrDefault(); }
            set { this._contactPostPassDurationSeconds = value; }
        }

        // Check to see if ContactPostPassDurationSeconds property is set
        internal bool IsSetContactPostPassDurationSeconds()
        {
            return this._contactPostPassDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContactPrePassDurationSeconds. 
        /// <para>
        /// Amount of time after a contact ends that you’d like to receive a CloudWatch event
        /// indicating the pass has finished.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=21600)]
        public int ContactPrePassDurationSeconds
        {
            get { return this._contactPrePassDurationSeconds.GetValueOrDefault(); }
            set { this._contactPrePassDurationSeconds = value; }
        }

        // Check to see if ContactPrePassDurationSeconds property is set
        internal bool IsSetContactPrePassDurationSeconds()
        {
            return this._contactPrePassDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataflowEdges. 
        /// <para>
        /// A list of lists of ARNs. Each list of ARNs is an edge, with a <i>from</i> <code>Config</code>
        /// and a <i>to</i> <code>Config</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<List<string>> DataflowEdges
        {
            get { return this._dataflowEdges; }
            set { this._dataflowEdges = value; }
        }

        // Check to see if DataflowEdges property is set
        internal bool IsSetDataflowEdges()
        {
            return this._dataflowEdges != null && this._dataflowEdges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MinimumViableContactDurationSeconds. 
        /// <para>
        /// Smallest amount of time in seconds that you’d like to see for an available contact.
        /// AWS Ground Station will not present you with contacts shorter than this duration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=21600)]
        public int MinimumViableContactDurationSeconds
        {
            get { return this._minimumViableContactDurationSeconds.GetValueOrDefault(); }
            set { this._minimumViableContactDurationSeconds = value; }
        }

        // Check to see if MinimumViableContactDurationSeconds property is set
        internal bool IsSetMinimumViableContactDurationSeconds()
        {
            return this._minimumViableContactDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MissionProfileId. 
        /// <para>
        /// UUID of a mission profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string MissionProfileId
        {
            get { return this._missionProfileId; }
            set { this._missionProfileId = value; }
        }

        // Check to see if MissionProfileId property is set
        internal bool IsSetMissionProfileId()
        {
            return this._missionProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of a mission profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property StreamsKmsKey. 
        /// <para>
        /// KMS key to use for encrypting streams.
        /// </para>
        /// </summary>
        public KmsKey StreamsKmsKey
        {
            get { return this._streamsKmsKey; }
            set { this._streamsKmsKey = value; }
        }

        // Check to see if StreamsKmsKey property is set
        internal bool IsSetStreamsKmsKey()
        {
            return this._streamsKmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property StreamsKmsRole. 
        /// <para>
        /// Role to use for encrypting streams with KMS key.
        /// </para>
        /// </summary>
        public string StreamsKmsRole
        {
            get { return this._streamsKmsRole; }
            set { this._streamsKmsRole = value; }
        }

        // Check to see if StreamsKmsRole property is set
        internal bool IsSetStreamsKmsRole()
        {
            return this._streamsKmsRole != null;
        }

        /// <summary>
        /// Gets and sets the property TrackingConfigArn. 
        /// <para>
        /// ARN of a tracking <code>Config</code>.
        /// </para>
        /// </summary>
        public string TrackingConfigArn
        {
            get { return this._trackingConfigArn; }
            set { this._trackingConfigArn = value; }
        }

        // Check to see if TrackingConfigArn property is set
        internal bool IsSetTrackingConfigArn()
        {
            return this._trackingConfigArn != null;
        }

    }
}