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
    /// Container for the parameters to the StartDashboardSnapshotJob operation.
    /// Starts an asynchronous job that generates a snapshot of a dashboard's output. You
    /// can request one or several of the following format configurations in each API call.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// 1 Paginated PDF
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 1 Excel workbook that includes up to 5 table or pivot table visuals
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 5 CSVs from table or pivot table visuals
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The status of a submitted job can be polled with the <c>DescribeDashboardSnapshotJob</c>
    /// API. When you call the <c>DescribeDashboardSnapshotJob</c> API, check the <c>JobStatus</c>
    /// field in the response. Once the job reaches a <c>COMPLETED</c> or <c>FAILED</c> status,
    /// use the <c>DescribeDashboardSnapshotJobResult</c> API to obtain the URLs for the generated
    /// files. If the job fails, the <c>DescribeDashboardSnapshotJobResult</c> API returns
    /// detailed information about the error that occurred.
    /// </para>
    ///  
    /// <para>
    ///  <b>StartDashboardSnapshotJob API throttling</b> 
    /// </para>
    ///  
    /// <para>
    /// QuickSight utilizes API throttling to create a more consistent user experience within
    /// a time span for customers when they call the <c>StartDashboardSnapshotJob</c>. By
    /// default, 12 jobs can run simlutaneously in one Amazon Web Services account and users
    /// can submit up 10 API requests per second before an account is throttled. If an overwhelming
    /// number of API requests are made by the same user in a short period of time, QuickSight
    /// throttles the API calls to maintin an optimal experience and reliability for all QuickSight
    /// users.
    /// </para>
    ///  
    /// <para>
    ///  <b>Common throttling scenarios</b> 
    /// </para>
    ///  
    /// <para>
    /// The following list provides information about the most commin throttling scenarios
    /// that can occur.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>A large number of <c>SnapshotExport</c> API jobs are running simultaneously on
    /// an Amazon Web Services account.</b> When a new <c>StartDashboardSnapshotJob</c> is
    /// created and there are already 12 jobs with the <c>RUNNING</c> status, the new job
    /// request fails and returns a <c>LimitExceededException</c> error. Wait for a current
    /// job to comlpete before you resubmit the new job.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>A large number of API requests are submitted on an Amazon Web Services account.</b>
    /// When a user makes more than 10 API calls to the QuickSight API in one second, a <c>ThrottlingException</c>
    /// is returned.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If your use case requires a higher throttling limit, contact your account admin or
    /// <a href="http://aws.amazon.com/contact-us/">Amazon Web ServicesSupport</a> to explore
    /// options to tailor a more optimal expereince for your account.
    /// </para>
    ///  
    /// <para>
    ///  <b>Best practices to handle throttling</b> 
    /// </para>
    ///  
    /// <para>
    /// If your use case projects high levels of API traffic, try to reduce the degree of
    /// frequency and parallelism of API calls as much as you can to avoid throttling. You
    /// can also perform a timing test to calculate an estimate for the total processing time
    /// of your projected load that stays within the throttling limits of the QuickSight APIs.
    /// For example, if your projected traffic is 100 snapshot jobs before 12:00 PM per day,
    /// start 12 jobs in parallel and measure the amount of time it takes to proccess all
    /// 12 jobs. Once you obtain the result, multiply the duration by 9, for example <c>(12
    /// minutes * 9 = 108 minutes)</c>. Use the new result to determine the latest time at
    /// which the jobs need to be started to meet your target deadline.
    /// </para>
    ///  
    /// <para>
    /// The time that it takes to process a job can be impacted by the following factors:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The dataset type (Direct Query or SPICE).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The size of the dataset.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The complexity of the calculated fields that are used in the dashboard.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The number of visuals that are on a sheet.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The types of visuals that are on the sheet.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The number of formats and snapshots that are requested in the job configuration.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The size of the generated snapshots.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartDashboardSnapshotJobRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _dashboardId;
        private SnapshotConfiguration _snapshotConfiguration;
        private string _snapshotJobId;
        private SnapshotUserConfiguration _userConfiguration;

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
        /// The ID of the dashboard that you want to start a snapshot job for. 
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
        /// Gets and sets the property SnapshotConfiguration. 
        /// <para>
        /// A structure that describes the configuration of the dashboard snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SnapshotConfiguration SnapshotConfiguration
        {
            get { return this._snapshotConfiguration; }
            set { this._snapshotConfiguration = value; }
        }

        // Check to see if SnapshotConfiguration property is set
        internal bool IsSetSnapshotConfiguration()
        {
            return this._snapshotConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotJobId. 
        /// <para>
        /// An ID for the dashboard snapshot job. This ID is unique to the dashboard while the
        /// job is running. This ID can be used to poll the status of a job with a <c>DescribeDashboardSnapshotJob</c>
        /// while the job runs. You can reuse this ID for another job 24 hours after the current
        /// job is completed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string SnapshotJobId
        {
            get { return this._snapshotJobId; }
            set { this._snapshotJobId = value; }
        }

        // Check to see if SnapshotJobId property is set
        internal bool IsSetSnapshotJobId()
        {
            return this._snapshotJobId != null;
        }

        /// <summary>
        /// Gets and sets the property UserConfiguration. 
        /// <para>
        ///  A structure that contains information about the anonymous users that the generated
        /// snapshot is for. This API will not return information about registered QuickSight.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SnapshotUserConfiguration UserConfiguration
        {
            get { return this._userConfiguration; }
            set { this._userConfiguration = value; }
        }

        // Check to see if UserConfiguration property is set
        internal bool IsSetUserConfiguration()
        {
            return this._userConfiguration != null;
        }

    }
}