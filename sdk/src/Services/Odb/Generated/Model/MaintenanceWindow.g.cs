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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// The scheduling details for the maintenance window. Patching and system updates take
    /// place during the maintenance window.
    /// </summary>
    public partial class MaintenanceWindow
    {
        /// <summary>
        /// Gets and sets the property CustomActionTimeoutInMins. 
        /// <para>
        /// The custom action timeout in minutes for the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 15, Max = 120)]
        public int? CustomActionTimeoutInMins { get; set; }

        /// <summary>
        /// Checks to see if the CustomActionTimeoutInMins property is set.
        /// </summary>
        internal bool IsSetCustomActionTimeoutInMins() => this.CustomActionTimeoutInMins.HasValue;

        /// <summary>
        /// Gets and sets the property DaysOfWeek. 
        /// <para>
        /// The days of the week when maintenance can be performed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DayOfWeek> DaysOfWeek { get; set; } = AWSConfigs.InitializeCollections ? new List<DayOfWeek>() : null;

        /// <summary>
        /// Checks to see if the DaysOfWeek property is set.
        /// </summary>
        internal bool IsSetDaysOfWeek() => this.DaysOfWeek != null && (this.DaysOfWeek.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HoursOfDay. 
        /// <para>
        /// The hours of the day when maintenance can be performed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> HoursOfDay { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the HoursOfDay property is set.
        /// </summary>
        internal bool IsSetHoursOfDay() => this.HoursOfDay != null && (this.HoursOfDay.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsCustomActionTimeoutEnabled. 
        /// <para>
        /// Indicates whether custom action timeout is enabled for the maintenance window.
        /// </para>
        /// </summary>
        public bool? IsCustomActionTimeoutEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsCustomActionTimeoutEnabled property is set.
        /// </summary>
        internal bool IsSetIsCustomActionTimeoutEnabled() => this.IsCustomActionTimeoutEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LeadTimeInWeeks. 
        /// <para>
        /// The lead time in weeks before the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public int? LeadTimeInWeeks { get; set; }

        /// <summary>
        /// Checks to see if the LeadTimeInWeeks property is set.
        /// </summary>
        internal bool IsSetLeadTimeInWeeks() => this.LeadTimeInWeeks.HasValue;

        /// <summary>
        /// Gets and sets the property Months. 
        /// <para>
        /// The months when maintenance can be performed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Month> Months { get; set; } = AWSConfigs.InitializeCollections ? new List<Month>() : null;

        /// <summary>
        /// Checks to see if the Months property is set.
        /// </summary>
        internal bool IsSetMonths() => this.Months != null && (this.Months.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PatchingMode. 
        /// <para>
        /// The patching mode for the maintenance window.
        /// </para>
        /// </summary>
        public PatchingModeType PatchingMode { get; set; }

        /// <summary>
        /// Checks to see if the PatchingMode property is set.
        /// </summary>
        internal bool IsSetPatchingMode() => this.PatchingMode != null;

        /// <summary>
        /// Gets and sets the property Preference. 
        /// <para>
        /// The preference for the maintenance window scheduling.
        /// </para>
        /// </summary>
        public PreferenceType Preference { get; set; }

        /// <summary>
        /// Checks to see if the Preference property is set.
        /// </summary>
        internal bool IsSetPreference() => this.Preference != null;

        /// <summary>
        /// Gets and sets the property SkipRu. 
        /// <para>
        /// Indicates whether to skip release updates during maintenance.
        /// </para>
        /// </summary>
        public bool? SkipRu { get; set; }

        /// <summary>
        /// Checks to see if the SkipRu property is set.
        /// </summary>
        internal bool IsSetSkipRu() => this.SkipRu.HasValue;

        /// <summary>
        /// Gets and sets the property WeeksOfMonth. 
        /// <para>
        /// The weeks of the month when maintenance can be performed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> WeeksOfMonth { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the WeeksOfMonth property is set.
        /// </summary>
        internal bool IsSetWeeksOfMonth() => this.WeeksOfMonth != null && (this.WeeksOfMonth.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
