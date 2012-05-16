/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSnapshotSchedule operation.
    /// <para>This operation updates a snapshot schedule configured for a gateway volume.</para> <para>The default snapshot schedule for volume is
    /// once every 24 hours, starting at the creation time of the volume. You can use this API to change the snaphot schedule configured for the
    /// volume.</para> <para>In the request you must identify the gateway volume whose snapshot schedule you want to update, and the schedule
    /// information, including when you want the snapshot to begin on a day and the frequency (in hours) of snapshots.</para>
    /// </summary>
    /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.UpdateSnapshotSchedule"/>
    public class UpdateSnapshotScheduleRequest : AmazonWebServiceRequest
    {
        private string volumeARN;
        private int? startAt;
        private int? recurrenceInHours;
        private string description;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the volume. Use the <a>ListVolumes</a> operation to return a list of gateway volumes.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VolumeARN
        {
            get { return this.volumeARN; }
            set { this.volumeARN = value; }
        }

        /// <summary>
        /// Sets the VolumeARN property
        /// </summary>
        /// <param name="volumeARN">The value to set for the VolumeARN property </param>
        /// <returns>this instance</returns>
        public UpdateSnapshotScheduleRequest WithVolumeARN(string volumeARN)
        {
            this.volumeARN = volumeARN;
            return this;
        }
            

        // Check to see if VolumeARN property is set
        internal bool IsSetVolumeARN()
        {
            return this.volumeARN != null;       
        }

        /// <summary>
        /// The hour of the day at which the snapshot schedule begins. Length: 2 <i>Valid Values</i>: An integer between 0 and 23, representing the hour
        /// of day.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - 23</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int StartAt
        {
            get { return this.startAt ?? default(int); }
            set { this.startAt = value; }
        }

        /// <summary>
        /// Sets the StartAt property
        /// </summary>
        /// <param name="startAt">The value to set for the StartAt property </param>
        /// <returns>this instance</returns>
        public UpdateSnapshotScheduleRequest WithStartAt(int startAt)
        {
            this.startAt = startAt;
            return this;
        }
            

        // Check to see if StartAt property is set
        internal bool IsSetStartAt()
        {
            return this.startAt.HasValue;       
        }

        /// <summary>
        /// Frequency of snapshots. Specify the number of hours between snapshots. <i>Valid Values</i>: <c>1</c>, <c>2</c>, <c>4</c>, <c>8</c>,
        /// <c>12</c>, <c>24</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 24</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int RecurrenceInHours
        {
            get { return this.recurrenceInHours ?? default(int); }
            set { this.recurrenceInHours = value; }
        }

        /// <summary>
        /// Sets the RecurrenceInHours property
        /// </summary>
        /// <param name="recurrenceInHours">The value to set for the RecurrenceInHours property </param>
        /// <returns>this instance</returns>
        public UpdateSnapshotScheduleRequest WithRecurrenceInHours(int recurrenceInHours)
        {
            this.recurrenceInHours = recurrenceInHours;
            return this;
        }
            

        // Check to see if RecurrenceInHours property is set
        internal bool IsSetRecurrenceInHours()
        {
            return this.recurrenceInHours.HasValue;       
        }

        /// <summary>
        /// Optional description of the snapshot that overwrites the existing description. Length: up to 255 characters.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        public UpdateSnapshotScheduleRequest WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;       
        }
    }
}
    
