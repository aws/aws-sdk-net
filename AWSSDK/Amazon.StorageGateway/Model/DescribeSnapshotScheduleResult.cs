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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>A JSON object containing the following fields:</para>
    /// <ul>
    /// <li> DescribeSnapshotScheduleOutput$Description </li>
    /// <li> DescribeSnapshotScheduleOutput$RecurrenceInHours </li>
    /// <li> DescribeSnapshotScheduleOutput$StartAt </li>
    /// <li> DescribeSnapshotScheduleOutput$Timezone </li>
    /// <li> DescribeSnapshotScheduleOutput$VolumeARN </li>
    /// 
    /// </ul>
    /// </summary>
    public class DescribeSnapshotScheduleResult  
    {
        
        private string volumeARN;
        private int? startAt;
        private int? recurrenceInHours;
        private string description;
        private string timezone;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the volume that was specified in the request.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSnapshotScheduleResult WithVolumeARN(string volumeARN)
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

        /// <summary>
        /// Sets the StartAt property
        /// </summary>
        /// <param name="startAt">The value to set for the StartAt property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSnapshotScheduleResult WithStartAt(int startAt)
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
        /// The number of hours between snapshots.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSnapshotScheduleResult WithRecurrenceInHours(int recurrenceInHours)
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
        /// The snapshot description.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSnapshotScheduleResult WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;       
        }

        /// <summary>
        /// One of the <a>GatewayTimezone</a> values that indicates the time zone of the gateway.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>GMT-12:00, GMT-11:00, GMT-10:00, GMT-9:00, GMT-8:00, GMT-7:00, GMT-6:00, GMT-5:00, GMT-4:00, GMT-3:30, GMT-3:00, GMT-2:00, GMT-1:00, GMT, GMT+1:00, GMT+2:00, GMT+3:00, GMT+3:30, GMT+4:00, GMT+4:30, GMT+5:00, GMT+5:30, GMT+5:45, GMT+6:00, GMT+7:00, GMT+8:00, GMT+9:00, GMT+9:30, GMT+10:00, GMT+11:00, GMT+12:00</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Timezone
        {
            get { return this.timezone; }
            set { this.timezone = value; }
        }

        /// <summary>
        /// Sets the Timezone property
        /// </summary>
        /// <param name="timezone">The value to set for the Timezone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSnapshotScheduleResult WithTimezone(string timezone)
        {
            this.timezone = timezone;
            return this;
        }
            

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this.timezone != null;       
        }
    }
}
