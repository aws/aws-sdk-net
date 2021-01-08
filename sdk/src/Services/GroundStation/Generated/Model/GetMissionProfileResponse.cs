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
    /// 
    /// </summary>
    public partial class GetMissionProfileResponse : AmazonWebServiceResponse
    {
        private int? _contactPostPassDurationSeconds;
        private int? _contactPrePassDurationSeconds;
        private List<List<string>> _dataflowEdges = new List<List<string>>();
        private int? _minimumViableContactDurationSeconds;
        private string _missionProfileArn;
        private string _missionProfileId;
        private string _name;
        private string _region;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _trackingConfigArn;

        /// <summary>
        /// Gets and sets the property ContactPostPassDurationSeconds. 
        /// <para>
        /// Amount of time after a contact ends that you’d like to receive a CloudWatch event
        /// indicating the pass has finished.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=21600)]
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
        /// Amount of time prior to contact start you’d like to receive a CloudWatch event indicating
        /// an upcoming pass.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=21600)]
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
        /// Gets and sets the property MissionProfileArn. 
        /// <para>
        /// ARN of a mission profile.
        /// </para>
        /// </summary>
        public string MissionProfileArn
        {
            get { return this._missionProfileArn; }
            set { this._missionProfileArn = value; }
        }

        // Check to see if MissionProfileArn property is set
        internal bool IsSetMissionProfileArn()
        {
            return this._missionProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property MissionProfileId. 
        /// <para>
        /// UUID of a mission profile.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Region. 
        /// <para>
        /// Region of a mission profile.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to a mission profile.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
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