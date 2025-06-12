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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSnapshotSchedule operation.
    /// Updates a snapshot schedule configured for a gateway volume. This operation is only
    /// supported in the cached volume and stored volume gateway types.
    /// 
    ///  
    /// <para>
    /// The default snapshot schedule for volume is once every 24 hours, starting at the creation
    /// time of the volume. You can use this API to change the snapshot schedule configured
    /// for the volume.
    /// </para>
    ///  
    /// <para>
    /// In the request you must identify the gateway volume whose snapshot schedule you want
    /// to update, and the schedule information, including when you want the snapshot to begin
    /// on a day and the frequency (in hours) of snapshots.
    /// </para>
    /// </summary>
    public partial class UpdateSnapshotScheduleRequest : AmazonStorageGatewayRequest
    {
        private string _description;
        private int? _recurrenceInHours;
        private int? _startAt;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _volumeARN;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Optional description of the snapshot that overwrites the existing description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property RecurrenceInHours. 
        /// <para>
        /// Frequency of snapshots. Specify the number of hours between snapshots.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=24)]
        public int? RecurrenceInHours
        {
            get { return this._recurrenceInHours; }
            set { this._recurrenceInHours = value; }
        }

        // Check to see if RecurrenceInHours property is set
        internal bool IsSetRecurrenceInHours()
        {
            return this._recurrenceInHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartAt. 
        /// <para>
        /// The hour of the day at which the snapshot schedule begins represented as <i>hh</i>,
        /// where <i>hh</i> is the hour (0 to 23). The hour of the day is in the time zone of
        /// the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=23)]
        public int? StartAt
        {
            get { return this._startAt; }
            set { this._startAt = value; }
        }

        // Check to see if StartAt property is set
        internal bool IsSetStartAt()
        {
            return this._startAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags that can be assigned to a snapshot. Each tag is a key-value
        /// pair.
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid characters for key and value are letters, spaces, and numbers representable
        /// in UTF-8 format, and the following special characters: + - = . _ : / @. The maximum
        /// length of a tag's key is 128 characters, and the maximum length for a tag's value
        /// is 256.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
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
        /// Gets and sets the property VolumeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the volume. Use the <a>ListVolumes</a> operation
        /// to return a list of gateway volumes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string VolumeARN
        {
            get { return this._volumeARN; }
            set { this._volumeARN = value; }
        }

        // Check to see if VolumeARN property is set
        internal bool IsSetVolumeARN()
        {
            return this._volumeARN != null;
        }

    }
}