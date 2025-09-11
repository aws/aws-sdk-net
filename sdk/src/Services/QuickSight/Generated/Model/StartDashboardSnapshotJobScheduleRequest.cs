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
    /// Container for the parameters to the StartDashboardSnapshotJobSchedule operation.
    /// Starts an asynchronous job that runs an existing dashboard schedule and sends the
    /// dashboard snapshot through email. 
    /// 
    ///  
    /// <para>
    /// Only one job can run simultaneously in a given schedule. Repeated requests are skipped
    /// with a <c>202</c> HTTP status code.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/sending-reports.html">Scheduling
    /// and sending QuickSight reports by email</a> and <a href="https://docs.aws.amazon.com/quicksight/latest/user/email-reports-from-dashboard.html">Configuring
    /// email report settings for a QuickSight dashboard</a> in the <i>Amazon QuickSight User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class StartDashboardSnapshotJobScheduleRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _dashboardId;
        private string _scheduleId;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that the dashboard snapshot job is executed
        /// in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID of the dashboard that you want to start a snapshot job schedule for. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string DashboardId
        {
            get { return this._dashboardId; }
            set { this._dashboardId = value; }
        }

        // Check to see if DashboardId property is set
        internal bool IsSetDashboardId()
        {
            return this._dashboardId != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleId. 
        /// <para>
        /// The ID of the schedule that you want to start a snapshot job schedule for. The schedule
        /// ID can be found in the QuickSight console in the <b>Schedules</b> pane of the dashboard
        /// that the schedule is configured for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string ScheduleId
        {
            get { return this._scheduleId; }
            set { this._scheduleId = value; }
        }

        // Check to see if ScheduleId property is set
        internal bool IsSetScheduleId()
        {
            return this._scheduleId != null;
        }

    }
}