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
 * Do not modify this file. This file is generated from the workspaces-thin-client-2023-08-22.normal.json service model.
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
namespace Amazon.WorkSpacesThinClient.Model
{
    /// <summary>
    /// Describes the maintenance window for a thin client device.
    /// </summary>
    public partial class MaintenanceWindow
    {
        private ApplyTimeOf _applyTimeOf;
        private List<string> _daysOfTheWeek = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _endTimeHour;
        private int? _endTimeMinute;
        private int? _startTimeHour;
        private int? _startTimeMinute;
        private MaintenanceWindowType _type;

        /// <summary>
        /// Gets and sets the property ApplyTimeOf. 
        /// <para>
        /// The option to set the maintenance window during the device local time or Universal
        /// Coordinated Time (UTC).
        /// </para>
        /// </summary>
        public ApplyTimeOf ApplyTimeOf
        {
            get { return this._applyTimeOf; }
            set { this._applyTimeOf = value; }
        }

        // Check to see if ApplyTimeOf property is set
        internal bool IsSetApplyTimeOf()
        {
            return this._applyTimeOf != null;
        }

        /// <summary>
        /// Gets and sets the property DaysOfTheWeek. 
        /// <para>
        /// The days of the week during which the maintenance window is open.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public List<string> DaysOfTheWeek
        {
            get { return this._daysOfTheWeek; }
            set { this._daysOfTheWeek = value; }
        }

        // Check to see if DaysOfTheWeek property is set
        internal bool IsSetDaysOfTheWeek()
        {
            return this._daysOfTheWeek != null && (this._daysOfTheWeek.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndTimeHour. 
        /// <para>
        /// The hour for the maintenance window end (<c>00</c>-<c>23</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=23)]
        public int? EndTimeHour
        {
            get { return this._endTimeHour; }
            set { this._endTimeHour = value; }
        }

        // Check to see if EndTimeHour property is set
        internal bool IsSetEndTimeHour()
        {
            return this._endTimeHour.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTimeMinute. 
        /// <para>
        /// The minutes for the maintenance window end (<c>00</c>-<c>59</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=59)]
        public int? EndTimeMinute
        {
            get { return this._endTimeMinute; }
            set { this._endTimeMinute = value; }
        }

        // Check to see if EndTimeMinute property is set
        internal bool IsSetEndTimeMinute()
        {
            return this._endTimeMinute.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTimeHour. 
        /// <para>
        /// The hour for the maintenance window start (<c>00</c>-<c>23</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=23)]
        public int? StartTimeHour
        {
            get { return this._startTimeHour; }
            set { this._startTimeHour = value; }
        }

        // Check to see if StartTimeHour property is set
        internal bool IsSetStartTimeHour()
        {
            return this._startTimeHour.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTimeMinute. 
        /// <para>
        /// The minutes past the hour for the maintenance window start (<c>00</c>-<c>59</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=59)]
        public int? StartTimeMinute
        {
            get { return this._startTimeMinute; }
            set { this._startTimeMinute = value; }
        }

        // Check to see if StartTimeMinute property is set
        internal bool IsSetStartTimeMinute()
        {
            return this._startTimeMinute.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// An option to select the default or custom maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MaintenanceWindowType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}