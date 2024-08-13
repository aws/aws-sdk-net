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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeDashboard operation.
    /// </summary>
    public partial class DescribeDashboardResponse : AmazonWebServiceResponse
    {
        private string _dashboardArn;
        private DateTime? _dashboardCreationDate;
        private string _dashboardDefinition;
        private string _dashboardDescription;
        private string _dashboardId;
        private DateTime? _dashboardLastUpdateDate;
        private string _dashboardName;
        private string _projectId;

        /// <summary>
        /// Gets and sets the property DashboardArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the dashboard, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:${Partition}:iotsitewise:${Region}:${Account}:dashboard/${DashboardId}</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string DashboardArn
        {
            get { return this._dashboardArn; }
            set { this._dashboardArn = value; }
        }

        // Check to see if DashboardArn property is set
        internal bool IsSetDashboardArn()
        {
            return this._dashboardArn != null;
        }

        /// <summary>
        /// Gets and sets the property DashboardCreationDate. 
        /// <para>
        /// The date the dashboard was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? DashboardCreationDate
        {
            get { return this._dashboardCreationDate; }
            set { this._dashboardCreationDate = value; }
        }

        // Check to see if DashboardCreationDate property is set
        internal bool IsSetDashboardCreationDate()
        {
            return this._dashboardCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DashboardDefinition. 
        /// <para>
        /// The dashboard's definition JSON literal. For detailed information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/create-dashboards-using-aws-cli.html">Creating
        /// dashboards (CLI)</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=204800)]
        public string DashboardDefinition
        {
            get { return this._dashboardDefinition; }
            set { this._dashboardDefinition = value; }
        }

        // Check to see if DashboardDefinition property is set
        internal bool IsSetDashboardDefinition()
        {
            return this._dashboardDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property DashboardDescription. 
        /// <para>
        /// The dashboard's description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DashboardDescription
        {
            get { return this._dashboardDescription; }
            set { this._dashboardDescription = value; }
        }

        // Check to see if DashboardDescription property is set
        internal bool IsSetDashboardDescription()
        {
            return this._dashboardDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID of the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// Gets and sets the property DashboardLastUpdateDate. 
        /// <para>
        /// The date the dashboard was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? DashboardLastUpdateDate
        {
            get { return this._dashboardLastUpdateDate; }
            set { this._dashboardLastUpdateDate = value; }
        }

        // Check to see if DashboardLastUpdateDate property is set
        internal bool IsSetDashboardLastUpdateDate()
        {
            return this._dashboardLastUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DashboardName. 
        /// <para>
        /// The name of the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DashboardName
        {
            get { return this._dashboardName; }
            set { this._dashboardName = value; }
        }

        // Check to see if DashboardName property is set
        internal bool IsSetDashboardName()
        {
            return this._dashboardName != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The ID of the project that the dashboard is in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ProjectId
        {
            get { return this._projectId; }
            set { this._projectId = value; }
        }

        // Check to see if ProjectId property is set
        internal bool IsSetProjectId()
        {
            return this._projectId != null;
        }

    }
}