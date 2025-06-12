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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This structure contains configuration details about an integration between CloudWatch
    /// Logs and OpenSearch Service.
    /// </summary>
    public partial class OpenSearchResourceConfig
    {
        private string _applicationArn;
        private List<string> _dashboardViewerPrincipals = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _dataSourceRoleArn;
        private string _kmsKeyArn;
        private int? _retentionDays;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// If you want to use an existing OpenSearch Service application for your integration
        /// with OpenSearch Service, specify it here. If you omit this, a new application will
        /// be created.
        /// </para>
        /// </summary>
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property DashboardViewerPrincipals. 
        /// <para>
        /// Specify the ARNs of IAM roles and IAM users who you want to grant permission to for
        /// viewing the dashboards.
        /// </para>
        ///  <important> 
        /// <para>
        /// In addition to specifying these users here, you must also grant them the <b>CloudWatchOpenSearchDashboardAccess</b>
        /// IAM policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/OpenSearch-Dashboards-UserRoles.html">IAM
        /// policies for users</a>.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> DashboardViewerPrincipals
        {
            get { return this._dashboardViewerPrincipals; }
            set { this._dashboardViewerPrincipals = value; }
        }

        // Check to see if DashboardViewerPrincipals property is set
        internal bool IsSetDashboardViewerPrincipals()
        {
            return this._dashboardViewerPrincipals != null && (this._dashboardViewerPrincipals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataSourceRoleArn. 
        /// <para>
        /// Specify the ARN of an IAM role that CloudWatch Logs will use to create the integration.
        /// This role must have the permissions necessary to access the OpenSearch Service collection
        /// to be able to create the dashboards. For more information about the permissions needed,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/OpenSearch-Dashboards-CreateRole.html">Permissions
        /// that the integration needs</a> in the CloudWatch Logs User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSourceRoleArn
        {
            get { return this._dataSourceRoleArn; }
            set { this._dataSourceRoleArn = value; }
        }

        // Check to see if DataSourceRoleArn property is set
        internal bool IsSetDataSourceRoleArn()
        {
            return this._dataSourceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// To have the vended dashboard data encrypted with KMS instead of the CloudWatch Logs
        /// default encryption method, specify the ARN of the KMS key that you want to use.
        /// </para>
        /// </summary>
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionDays. 
        /// <para>
        /// Specify how many days that you want the data derived by OpenSearch Service to be retained
        /// in the index that the dashboard refers to. This also sets the maximum time period
        /// that you can choose when viewing data in the dashboard. Choosing a longer time frame
        /// will incur additional costs. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public int? RetentionDays
        {
            get { return this._retentionDays; }
            set { this._retentionDays = value; }
        }

        // Check to see if RetentionDays property is set
        internal bool IsSetRetentionDays()
        {
            return this._retentionDays.HasValue; 
        }

    }
}