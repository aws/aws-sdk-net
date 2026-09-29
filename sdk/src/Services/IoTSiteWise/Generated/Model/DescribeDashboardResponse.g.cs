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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeDashboard operation.
    /// </summary>
    public partial class DescribeDashboardResponse : AmazonWebServiceResponse
    {
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
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string DashboardArn { get; set; }

        /// <summary>
        /// Checks to see if the DashboardArn property is set.
        /// </summary>
        internal bool IsSetDashboardArn() => this.DashboardArn != null;

        /// <summary>
        /// Gets and sets the property DashboardCreationDate. 
        /// <para>
        /// The date the dashboard was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? DashboardCreationDate { get; set; }

        /// <summary>
        /// Checks to see if the DashboardCreationDate property is set.
        /// </summary>
        internal bool IsSetDashboardCreationDate() => this.DashboardCreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property DashboardDefinition. 
        /// <para>
        /// The dashboard's definition JSON literal. For detailed information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/create-dashboards-using-aws-cli.html">Creating
        /// dashboards (CLI)</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 204800)]
        public string DashboardDefinition { get; set; }

        /// <summary>
        /// Checks to see if the DashboardDefinition property is set.
        /// </summary>
        internal bool IsSetDashboardDefinition() => this.DashboardDefinition != null;

        /// <summary>
        /// Gets and sets the property DashboardDescription. 
        /// <para>
        /// The dashboard's description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DashboardDescription { get; set; }

        /// <summary>
        /// Checks to see if the DashboardDescription property is set.
        /// </summary>
        internal bool IsSetDashboardDescription() => this.DashboardDescription != null;

        /// <summary>
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID of the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string DashboardId { get; set; }

        /// <summary>
        /// Checks to see if the DashboardId property is set.
        /// </summary>
        internal bool IsSetDashboardId() => this.DashboardId != null;

        /// <summary>
        /// Gets and sets the property DashboardLastUpdateDate. 
        /// <para>
        /// The date the dashboard was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? DashboardLastUpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the DashboardLastUpdateDate property is set.
        /// </summary>
        internal bool IsSetDashboardLastUpdateDate() => this.DashboardLastUpdateDate.HasValue;

        /// <summary>
        /// Gets and sets the property DashboardName. 
        /// <para>
        /// The name of the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DashboardName { get; set; }

        /// <summary>
        /// Checks to see if the DashboardName property is set.
        /// </summary>
        internal bool IsSetDashboardName() => this.DashboardName != null;

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The ID of the project that the dashboard is in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Checks to see if the ProjectId property is set.
        /// </summary>
        internal bool IsSetProjectId() => this.ProjectId != null;
    }
}
