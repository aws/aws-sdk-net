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
    /// This is the response object from the DescribeContact operation.
    /// </summary>
    public partial class DescribeContactResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// UUID of a contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property ContactStatus. 
        /// <para>
        /// Status of a contact.
        /// </para>
        /// </summary>
        public ContactStatus ContactStatus { get; set; }

        /// <summary>
        /// Checks to see if the ContactStatus property is set.
        /// </summary>
        internal bool IsSetContactStatus() => this.ContactStatus != null;

        /// <summary>
        /// Gets and sets the property DataflowList. 
        /// <para>
        /// List describing source and destination details for each dataflow edge.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataflowDetail> DataflowList { get; set; } = AWSConfigs.InitializeCollections ? new List<DataflowDetail>() : null;

        /// <summary>
        /// Checks to see if the DataflowList property is set.
        /// </summary>
        internal bool IsSetDataflowList() => this.DataflowList != null && (this.DataflowList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// End time of a contact in UTC.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Ephemeris. 
        /// <para>
        /// The ephemeris that determines antenna pointing directions for the contact.
        /// </para>
        /// </summary>
        public EphemerisResponseData Ephemeris { get; set; }

        /// <summary>
        /// Checks to see if the Ephemeris property is set.
        /// </summary>
        internal bool IsSetEphemeris() => this.Ephemeris != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Error message for a contact.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property GroundStation. 
        /// <para>
        /// Ground station for a contact.
        /// </para>
        /// </summary>
        public string GroundStation { get; set; }

        /// <summary>
        /// Checks to see if the GroundStation property is set.
        /// </summary>
        internal bool IsSetGroundStation() => this.GroundStation != null;

        /// <summary>
        /// Gets and sets the property MaximumElevation. 
        /// <para>
        /// Maximum elevation angle of a contact.
        /// </para>
        /// </summary>
        public Elevation MaximumElevation { get; set; }

        /// <summary>
        /// Checks to see if the MaximumElevation property is set.
        /// </summary>
        internal bool IsSetMaximumElevation() => this.MaximumElevation != null;

        /// <summary>
        /// Gets and sets the property MissionProfileArn. 
        /// <para>
        /// ARN of a mission profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 89, Max = 138)]
        public string MissionProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the MissionProfileArn property is set.
        /// </summary>
        internal bool IsSetMissionProfileArn() => this.MissionProfileArn != null;

        /// <summary>
        /// Gets and sets the property PostPassEndTime. 
        /// <para>
        /// End time in UTC of the post-pass period, at which you receive a CloudWatch event indicating
        /// the pass has finished.
        /// </para>
        /// </summary>
        public DateTime? PostPassEndTime { get; set; }

        /// <summary>
        /// Checks to see if the PostPassEndTime property is set.
        /// </summary>
        internal bool IsSetPostPassEndTime() => this.PostPassEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property PrePassStartTime. 
        /// <para>
        /// Start time in UTC of the pre-pass period, at which you receive a CloudWatch event
        /// indicating an upcoming pass.
        /// </para>
        /// </summary>
        public DateTime? PrePassStartTime { get; set; }

        /// <summary>
        /// Checks to see if the PrePassStartTime property is set.
        /// </summary>
        internal bool IsSetPrePassStartTime() => this.PrePassStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Region where the <c>ReserveContact</c> API was called to schedule this contact.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property SatelliteArn. 
        /// <para>
        /// ARN of a satellite.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 82, Max = 132)]
        public string SatelliteArn { get; set; }

        /// <summary>
        /// Checks to see if the SatelliteArn property is set.
        /// </summary>
        internal bool IsSetSatelliteArn() => this.SatelliteArn != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Start time of a contact in UTC.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to a contact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrackingOverrides. 
        /// <para>
        /// Tracking configuration overrides specified when the contact was reserved.
        /// </para>
        /// </summary>
        public TrackingOverrides TrackingOverrides { get; set; }

        /// <summary>
        /// Checks to see if the TrackingOverrides property is set.
        /// </summary>
        internal bool IsSetTrackingOverrides() => this.TrackingOverrides != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version information for a contact.
        /// </para>
        /// </summary>
        public ContactVersion Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;

        /// <summary>
        /// Gets and sets the property VisibilityEndTime. 
        /// <para>
        ///  Projected time in UTC your satellite will set below the <a href="https://docs.aws.amazon.com/ground-station/latest/ug/site-masks.html">receive
        /// mask</a>. This time is based on the satellite's current active ephemeris for future
        /// contacts and the ephemeris that was active during contact execution for completed
        /// contacts.
        /// </para>
        /// </summary>
        public DateTime? VisibilityEndTime { get; set; }

        /// <summary>
        /// Checks to see if the VisibilityEndTime property is set.
        /// </summary>
        internal bool IsSetVisibilityEndTime() => this.VisibilityEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property VisibilityStartTime. 
        /// <para>
        ///  Projected time in UTC your satellite will rise above the <a href="https://docs.aws.amazon.com/ground-station/latest/ug/site-masks.html">receive
        /// mask</a>. This time is based on the satellite's current active ephemeris for future
        /// contacts and the ephemeris that was active during contact execution for completed
        /// contacts.
        /// </para>
        /// </summary>
        public DateTime? VisibilityStartTime { get; set; }

        /// <summary>
        /// Checks to see if the VisibilityStartTime property is set.
        /// </summary>
        internal bool IsSetVisibilityStartTime() => this.VisibilityStartTime.HasValue;
    }
}
