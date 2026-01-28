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
    /// Container for the parameters to the DescribeDashboardSnapshotJobResult operation.
    /// Describes the result of an existing snapshot job that has finished running.
    /// 
    ///  
    /// <para>
    /// A finished snapshot job will return a <c>COMPLETED</c> or <c>FAILED</c> status when
    /// you poll the job with a <c>DescribeDashboardSnapshotJob</c> API call.
    /// </para>
    ///  
    /// <para>
    /// If the job has not finished running, this operation returns a message that says <c>Dashboard
    /// Snapshot Job with id &lt;SnapshotjobId&gt; has not reached a terminal state.</c>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Registered user support</b> 
    /// </para>
    ///  
    /// <para>
    /// This API can be called as before to get the result of a job started by the same Quick
    /// Sight user. The result for the user will be returned in <c>RegisteredUsers</c> response
    /// attribute. The attribute will contain a list with at most one object in it.
    /// </para>
    ///  
    /// <para>
    ///  <b>Possible error scenarios</b> 
    /// </para>
    ///  
    /// <para>
    /// The request fails with an Access Denied error in the following scenarios:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The credentials have expired.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The job was started by a different user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The registered user doesn't have access to the specified dashboard.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The request succeeds but the job fails in the following scenarios:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>DASHBOARD_ACCESS_DENIED</c> - The registered user lost access to the dashboard.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CAPABILITY_RESTRICTED</c> - The registered user is restricted from exporting data
    /// in <b>all</b> selected formats.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The request succeeds but the response contains an error code in the following scenarios:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>CAPABILITY_RESTRICTED</c> - The registered user is restricted from exporting data
    /// in <b>some</b> selected formats.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RLS_CHANGED</c> - Row-level security settings have changed. Re-run the job with
    /// current settings.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CLS_CHANGED</c> - Column-level security settings have changed. Re-run the job
    /// with current settings.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DATASET_DELETED</c> - The dataset has been deleted. Verify the dataset exists
    /// before re-running the job.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeDashboardSnapshotJobResultRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _dashboardId;
        private string _snapshotJobId;

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
        /// The ID of the dashboard that you have started a snapshot job for.
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
        /// Gets and sets the property SnapshotJobId. 
        /// <para>
        /// The ID of the job to be described. The job ID is set when you start a new job with
        /// a <c>StartDashboardSnapshotJob</c> API call.
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

    }
}