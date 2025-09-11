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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
    /// The feature configuration for an embedded dashboard.
    /// </summary>
    public partial class RegisteredUserDashboardFeatureConfigurations
    {
        private AmazonQInQuickSightDashboardConfigurations _amazonQInQuickSight;
        private BookmarksConfigurations _bookmarks;
        private RecentSnapshotsConfigurations _recentSnapshots;
        private SchedulesConfigurations _schedules;
        private SharedViewConfigurations _sharedView;
        private StatePersistenceConfigurations _statePersistence;
        private ThresholdAlertsConfigurations _thresholdAlerts;

        /// <summary>
        /// Gets and sets the property AmazonQInQuickSight. 
        /// <para>
        /// The Amazon Q configurations of an embedded QuickSight dashboard.
        /// </para>
        /// </summary>
        public AmazonQInQuickSightDashboardConfigurations AmazonQInQuickSight
        {
            get { return this._amazonQInQuickSight; }
            set { this._amazonQInQuickSight = value; }
        }

        // Check to see if AmazonQInQuickSight property is set
        internal bool IsSetAmazonQInQuickSight()
        {
            return this._amazonQInQuickSight != null;
        }

        /// <summary>
        /// Gets and sets the property Bookmarks. 
        /// <para>
        /// The bookmarks configuration for an embedded dashboard in QuickSight.
        /// </para>
        /// </summary>
        public BookmarksConfigurations Bookmarks
        {
            get { return this._bookmarks; }
            set { this._bookmarks = value; }
        }

        // Check to see if Bookmarks property is set
        internal bool IsSetBookmarks()
        {
            return this._bookmarks != null;
        }

        /// <summary>
        /// Gets and sets the property RecentSnapshots. 
        /// <para>
        /// The recent snapshots configuration for an QuickSight embedded dashboard
        /// </para>
        /// </summary>
        public RecentSnapshotsConfigurations RecentSnapshots
        {
            get { return this._recentSnapshots; }
            set { this._recentSnapshots = value; }
        }

        // Check to see if RecentSnapshots property is set
        internal bool IsSetRecentSnapshots()
        {
            return this._recentSnapshots != null;
        }

        /// <summary>
        /// Gets and sets the property Schedules. 
        /// <para>
        /// The schedules configuration for an embedded QuickSight dashboard.
        /// </para>
        /// </summary>
        public SchedulesConfigurations Schedules
        {
            get { return this._schedules; }
            set { this._schedules = value; }
        }

        // Check to see if Schedules property is set
        internal bool IsSetSchedules()
        {
            return this._schedules != null;
        }

        /// <summary>
        /// Gets and sets the property SharedView. 
        /// <para>
        /// The shared view settings of an embedded dashboard.
        /// </para>
        /// </summary>
        public SharedViewConfigurations SharedView
        {
            get { return this._sharedView; }
            set { this._sharedView = value; }
        }

        // Check to see if SharedView property is set
        internal bool IsSetSharedView()
        {
            return this._sharedView != null;
        }

        /// <summary>
        /// Gets and sets the property StatePersistence. 
        /// <para>
        /// The state persistence settings of an embedded dashboard.
        /// </para>
        /// </summary>
        public StatePersistenceConfigurations StatePersistence
        {
            get { return this._statePersistence; }
            set { this._statePersistence = value; }
        }

        // Check to see if StatePersistence property is set
        internal bool IsSetStatePersistence()
        {
            return this._statePersistence != null;
        }

        /// <summary>
        /// Gets and sets the property ThresholdAlerts. 
        /// <para>
        /// The threshold alerts configuration for an QuickSight embedded dashboard.
        /// </para>
        /// </summary>
        public ThresholdAlertsConfigurations ThresholdAlerts
        {
            get { return this._thresholdAlerts; }
            set { this._thresholdAlerts = value; }
        }

        // Check to see if ThresholdAlerts property is set
        internal bool IsSetThresholdAlerts()
        {
            return this._thresholdAlerts != null;
        }

    }
}