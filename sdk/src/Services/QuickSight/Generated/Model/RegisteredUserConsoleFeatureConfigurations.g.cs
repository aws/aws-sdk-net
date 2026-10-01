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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The feature configurations of an embedded Amazon Quick Sight console.
    /// </summary>
    public partial class RegisteredUserConsoleFeatureConfigurations
    {
        /// <summary>
        /// Gets and sets the property AmazonQInQuickSight. 
        /// <para>
        /// The Amazon Q configurations of an embedded Amazon Quick Sight console.
        /// </para>
        /// </summary>
        public AmazonQInQuickSightConsoleConfigurations AmazonQInQuickSight { get; set; }

        /// <summary>
        /// Checks to see if the AmazonQInQuickSight property is set.
        /// </summary>
        internal bool IsSetAmazonQInQuickSight() => this.AmazonQInQuickSight != null;

        /// <summary>
        /// Gets and sets the property DashboardCustomizationSummary. 
        /// <para>
        /// The dashboard customization summary configuration for an embedded Quick Sight console.
        /// </para>
        /// </summary>
        public DashboardCustomizationSummaryConfigurations DashboardCustomizationSummary { get; set; }

        /// <summary>
        /// Checks to see if the DashboardCustomizationSummary property is set.
        /// </summary>
        internal bool IsSetDashboardCustomizationSummary() => this.DashboardCustomizationSummary != null;

        /// <summary>
        /// Gets and sets the property RecentSnapshots. 
        /// <para>
        /// The recent snapshots configuration for an embedded Quick Sight dashboard.
        /// </para>
        /// </summary>
        public RecentSnapshotsConfigurations RecentSnapshots { get; set; }

        /// <summary>
        /// Checks to see if the RecentSnapshots property is set.
        /// </summary>
        internal bool IsSetRecentSnapshots() => this.RecentSnapshots != null;

        /// <summary>
        /// Gets and sets the property Schedules. 
        /// <para>
        /// The schedules configuration for an embedded Quick Sight dashboard.
        /// </para>
        /// </summary>
        public SchedulesConfigurations Schedules { get; set; }

        /// <summary>
        /// Checks to see if the Schedules property is set.
        /// </summary>
        internal bool IsSetSchedules() => this.Schedules != null;

        /// <summary>
        /// Gets and sets the property SharedView. 
        /// <para>
        /// The shared view settings of an embedded dashboard.
        /// </para>
        /// </summary>
        public SharedViewConfigurations SharedView { get; set; }

        /// <summary>
        /// Checks to see if the SharedView property is set.
        /// </summary>
        internal bool IsSetSharedView() => this.SharedView != null;

        /// <summary>
        /// Gets and sets the property StatePersistence. 
        /// <para>
        /// The state persistence configurations of an embedded Amazon Quick Sight console.
        /// </para>
        /// </summary>
        public StatePersistenceConfigurations StatePersistence { get; set; }

        /// <summary>
        /// Checks to see if the StatePersistence property is set.
        /// </summary>
        internal bool IsSetStatePersistence() => this.StatePersistence != null;

        /// <summary>
        /// Gets and sets the property ThresholdAlerts. 
        /// <para>
        /// The threshold alerts configuration for an embedded Quick Sight dashboard.
        /// </para>
        /// </summary>
        public ThresholdAlertsConfigurations ThresholdAlerts { get; set; }

        /// <summary>
        /// Checks to see if the ThresholdAlerts property is set.
        /// </summary>
        internal bool IsSetThresholdAlerts() => this.ThresholdAlerts != null;
    }
}
