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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// The scheduling details for the maintenance window. Patching and system updates take
    /// place during the maintenance window.
    /// </summary>
    public partial class MaintenanceWindow
    {
        private int? _customActionTimeoutInMins;
        private List<DayOfWeek> _daysOfWeek = AWSConfigs.InitializeCollections ? new List<DayOfWeek>() : null;
        private List<int> _hoursOfDay = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private bool? _isCustomActionTimeoutEnabled;
        private int? _leadTimeInWeeks;
        private List<Month> _months = AWSConfigs.InitializeCollections ? new List<Month>() : null;
        private PatchingModeType _patchingMode;
        private PreferenceType _preference;
        private bool? _skipRu;
        private List<int> _weeksOfMonth = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Gets and sets the property CustomActionTimeoutInMins. 
        /// <para>
        /// The custom action timeout in minutes for the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=120)]
        public int? CustomActionTimeoutInMins
        {
            get { return this._customActionTimeoutInMins; }
            set { this._customActionTimeoutInMins = value; }
        }

        // Check to see if CustomActionTimeoutInMins property is set
        internal bool IsSetCustomActionTimeoutInMins()
        {
            return this._customActionTimeoutInMins.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DaysOfWeek. 
        /// <para>
        /// The days of the week when maintenance can be performed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DayOfWeek> DaysOfWeek
        {
            get { return this._daysOfWeek; }
            set { this._daysOfWeek = value; }
        }

        // Check to see if DaysOfWeek property is set
        internal bool IsSetDaysOfWeek()
        {
            return this._daysOfWeek != null && (this._daysOfWeek.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HoursOfDay. 
        /// <para>
        /// The hours of the day when maintenance can be performed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> HoursOfDay
        {
            get { return this._hoursOfDay; }
            set { this._hoursOfDay = value; }
        }

        // Check to see if HoursOfDay property is set
        internal bool IsSetHoursOfDay()
        {
            return this._hoursOfDay != null && (this._hoursOfDay.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsCustomActionTimeoutEnabled. 
        /// <para>
        /// Indicates whether custom action timeout is enabled for the maintenance window.
        /// </para>
        /// </summary>
        public bool? IsCustomActionTimeoutEnabled
        {
            get { return this._isCustomActionTimeoutEnabled; }
            set { this._isCustomActionTimeoutEnabled = value; }
        }

        // Check to see if IsCustomActionTimeoutEnabled property is set
        internal bool IsSetIsCustomActionTimeoutEnabled()
        {
            return this._isCustomActionTimeoutEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LeadTimeInWeeks. 
        /// <para>
        /// The lead time in weeks before the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public int? LeadTimeInWeeks
        {
            get { return this._leadTimeInWeeks; }
            set { this._leadTimeInWeeks = value; }
        }

        // Check to see if LeadTimeInWeeks property is set
        internal bool IsSetLeadTimeInWeeks()
        {
            return this._leadTimeInWeeks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Months. 
        /// <para>
        /// The months when maintenance can be performed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Month> Months
        {
            get { return this._months; }
            set { this._months = value; }
        }

        // Check to see if Months property is set
        internal bool IsSetMonths()
        {
            return this._months != null && (this._months.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PatchingMode. 
        /// <para>
        /// The patching mode for the maintenance window.
        /// </para>
        /// </summary>
        public PatchingModeType PatchingMode
        {
            get { return this._patchingMode; }
            set { this._patchingMode = value; }
        }

        // Check to see if PatchingMode property is set
        internal bool IsSetPatchingMode()
        {
            return this._patchingMode != null;
        }

        /// <summary>
        /// Gets and sets the property Preference. 
        /// <para>
        /// The preference for the maintenance window scheduling.
        /// </para>
        /// </summary>
        public PreferenceType Preference
        {
            get { return this._preference; }
            set { this._preference = value; }
        }

        // Check to see if Preference property is set
        internal bool IsSetPreference()
        {
            return this._preference != null;
        }

        /// <summary>
        /// Gets and sets the property SkipRu. 
        /// <para>
        /// Indicates whether to skip release updates during maintenance.
        /// </para>
        /// </summary>
        public bool? SkipRu
        {
            get { return this._skipRu; }
            set { this._skipRu = value; }
        }

        // Check to see if SkipRu property is set
        internal bool IsSetSkipRu()
        {
            return this._skipRu.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WeeksOfMonth. 
        /// <para>
        /// The weeks of the month when maintenance can be performed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> WeeksOfMonth
        {
            get { return this._weeksOfMonth; }
            set { this._weeksOfMonth = value; }
        }

        // Check to see if WeeksOfMonth property is set
        internal bool IsSetWeeksOfMonth()
        {
            return this._weeksOfMonth != null && (this._weeksOfMonth.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}