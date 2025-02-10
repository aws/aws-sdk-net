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
    /// Container for the parameters to the UpdateDashboardsQAConfiguration operation.
    /// Updates a Dashboard QA configuration.
    /// </summary>
    public partial class UpdateDashboardsQAConfigurationRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private DashboardsQAStatus _dashboardsQAStatus;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the dashboard QA configuration
        /// that you want to update.
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
        /// Gets and sets the property DashboardsQAStatus. 
        /// <para>
        /// The status of dashboards QA configuration that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DashboardsQAStatus DashboardsQAStatus
        {
            get { return this._dashboardsQAStatus; }
            set { this._dashboardsQAStatus = value; }
        }

        // Check to see if DashboardsQAStatus property is set
        internal bool IsSetDashboardsQAStatus()
        {
            return this._dashboardsQAStatus != null;
        }

    }
}