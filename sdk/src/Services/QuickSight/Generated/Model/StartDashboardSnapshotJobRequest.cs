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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the StartDashboardSnapshotJob operation.
    /// Starts an asynchronous job that generates a dashboard snapshot. You can request up
    /// to one paginated PDF and up to five CSVs per API call.
    /// 
    ///  
    /// <para>
    /// Poll job descriptions with a <code>DescribeDashboardSnapshotJob</code> API call. Once
    /// the job succeeds, use the <code>DescribeDashboardSnapshotJobResult</code> API to obtain
    /// the download URIs that the job generates.
    /// </para>
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
        /// job is running. This ID can be used to poll the status of a job with a <code>DescribeDashboardSnapshotJob</code>
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
        /// snapshot is for. This API will not return information about registered Amazon QuickSight.
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