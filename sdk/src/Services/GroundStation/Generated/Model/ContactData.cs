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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Data describing a contact.
    /// </summary>
    public partial class ContactData
    {
        private string _contactId;
        private ContactStatus _contactStatus;
        private DateTime? _endTime;
        private string _errorMessage;
        private string _groundStation;
        private Elevation _maximumElevation;
        private string _missionProfileArn;
        private DateTime? _postPassEndTime;
        private DateTime? _prePassStartTime;
        private string _region;
        private string _satelliteArn;
        private DateTime? _startTime;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _visibilityEndTime;
        private DateTime? _visibilityStartTime;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// UUID of a contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property ContactStatus. 
        /// <para>
        /// Status of a contact.
        /// </para>
        /// </summary>
        public ContactStatus ContactStatus
        {
            get { return this._contactStatus; }
            set { this._contactStatus = value; }
        }

        // Check to see if ContactStatus property is set
        internal bool IsSetContactStatus()
        {
            return this._contactStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// End time of a contact in UTC.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Error message of a contact.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property GroundStation. 
        /// <para>
        /// Name of a ground station.
        /// </para>
        /// </summary>
        public string GroundStation
        {
            get { return this._groundStation; }
            set { this._groundStation = value; }
        }

        // Check to see if GroundStation property is set
        internal bool IsSetGroundStation()
        {
            return this._groundStation != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumElevation. 
        /// <para>
        /// Maximum elevation angle of a contact.
        /// </para>
        /// </summary>
        public Elevation MaximumElevation
        {
            get { return this._maximumElevation; }
            set { this._maximumElevation = value; }
        }

        // Check to see if MaximumElevation property is set
        internal bool IsSetMaximumElevation()
        {
            return this._maximumElevation != null;
        }

        /// <summary>
        /// Gets and sets the property MissionProfileArn. 
        /// <para>
        /// ARN of a mission profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=89, Max=138)]
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
        /// Gets and sets the property PostPassEndTime. 
        /// <para>
        /// Amount of time after a contact ends that you’d like to receive a CloudWatch event
        /// indicating the pass has finished.
        /// </para>
        /// </summary>
        public DateTime? PostPassEndTime
        {
            get { return this._postPassEndTime; }
            set { this._postPassEndTime = value; }
        }

        // Check to see if PostPassEndTime property is set
        internal bool IsSetPostPassEndTime()
        {
            return this._postPassEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrePassStartTime. 
        /// <para>
        /// Amount of time prior to contact start you’d like to receive a CloudWatch event indicating
        /// an upcoming pass.
        /// </para>
        /// </summary>
        public DateTime? PrePassStartTime
        {
            get { return this._prePassStartTime; }
            set { this._prePassStartTime = value; }
        }

        // Check to see if PrePassStartTime property is set
        internal bool IsSetPrePassStartTime()
        {
            return this._prePassStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Region of a contact.
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
        /// Gets and sets the property SatelliteArn. 
        /// <para>
        /// ARN of a satellite.
        /// </para>
        /// </summary>
        [AWSProperty(Min=82, Max=132)]
        public string SatelliteArn
        {
            get { return this._satelliteArn; }
            set { this._satelliteArn = value; }
        }

        // Check to see if SatelliteArn property is set
        internal bool IsSetSatelliteArn()
        {
            return this._satelliteArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Start time of a contact in UTC.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to a contact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VisibilityEndTime. 
        /// <para>
        ///  Projected time in UTC your satellite will set below the <a href="https://docs.aws.amazon.com/ground-station/latest/ug/site-masks.html">receive
        /// mask</a>. This time is based on the satellite's current active ephemeris for future
        /// contacts and the ephemeris that was active during contact execution for completed
        /// contacts. <i>This field is not present for contacts with a <c>SCHEDULING</c> or <c>SCHEDULED</c>
        /// status.</i> 
        /// </para>
        /// </summary>
        public DateTime? VisibilityEndTime
        {
            get { return this._visibilityEndTime; }
            set { this._visibilityEndTime = value; }
        }

        // Check to see if VisibilityEndTime property is set
        internal bool IsSetVisibilityEndTime()
        {
            return this._visibilityEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VisibilityStartTime. 
        /// <para>
        ///  Projected time in UTC your satellite will rise above the <a href="https://docs.aws.amazon.com/ground-station/latest/ug/site-masks.html">receive
        /// mask</a>. This time is based on the satellite's current active ephemeris for future
        /// contacts and the ephemeris that was active during contact execution for completed
        /// contacts. <i>This field is not present for contacts with a <c>SCHEDULING</c> or <c>SCHEDULED</c>
        /// status.</i> 
        /// </para>
        /// </summary>
        public DateTime? VisibilityStartTime
        {
            get { return this._visibilityStartTime; }
            set { this._visibilityStartTime = value; }
        }

        // Check to see if VisibilityStartTime property is set
        internal bool IsSetVisibilityStartTime()
        {
            return this._visibilityStartTime.HasValue; 
        }

    }
}