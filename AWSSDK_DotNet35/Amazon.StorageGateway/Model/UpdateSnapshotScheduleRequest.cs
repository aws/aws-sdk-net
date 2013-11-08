/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// once every 24 hours, starting at the creation time of the volume. You can use this API to change the snapshot schedule configured for the
    /// volume.</para> <para>In the request you must identify the gateway volume whose snapshot schedule you want to update, and the schedule
    /// information, including when you want the snapshot to begin on a day and the frequency (in hours) of snapshots.</para>
    /// </summary>
    public partial class UpdateSnapshotScheduleRequest : AmazonStorageGatewayRequest
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

        // Check to see if VolumeARN property is set
        internal bool IsSetVolumeARN()
        {
            return this.volumeARN != null;
        }

        /// <summary>
        /// The hour of the day at which the snapshot schedule begins represented as <i>hh</i>, where <i>hh</i> is the hour (0 to 23). The hour of the
        /// day is in the time zone of the gateway.
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

        // Check to see if StartAt property is set
        internal bool IsSetStartAt()
        {
            return this.startAt.HasValue;
        }

        /// <summary>
        /// Frequency of snapshots. Specify the number of hours between snapshots.
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

        // Check to see if RecurrenceInHours property is set
        internal bool IsSetRecurrenceInHours()
        {
            return this.recurrenceInHours.HasValue;
        }

        /// <summary>
        /// Optional description of the snapshot that overwrites the existing description.
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

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

    }
}
    
