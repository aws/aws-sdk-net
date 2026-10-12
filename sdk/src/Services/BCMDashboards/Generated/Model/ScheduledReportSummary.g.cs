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

namespace Amazon.BCMDashboards.Model
{
    /// <summary>
    /// Contains summary information for a scheduled report.
    /// </summary>
    public partial class ScheduledReportSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the scheduled report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property DashboardArn. 
        /// <para>
        /// The ARN of the dashboard associated with the scheduled report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string DashboardArn { get; set; }

        /// <summary>
        /// Checks to see if the DashboardArn property is set.
        /// </summary>
        internal bool IsSetDashboardArn() => this.DashboardArn != null;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The health status of the scheduled report as of its last refresh time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HealthStatus HealthStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthStatus property is set.
        /// </summary>
        internal bool IsSetHealthStatus() => this.HealthStatus != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the scheduled report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The schedule expression that defines when the report runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpression property is set.
        /// </summary>
        internal bool IsSetScheduleExpression() => this.ScheduleExpression != null;

        /// <summary>
        /// Gets and sets the property ScheduleExpressionTimeZone. 
        /// <para>
        /// The time zone for the schedule expression, for example, <c>UTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ScheduleExpressionTimeZone { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpressionTimeZone property is set.
        /// </summary>
        internal bool IsSetScheduleExpressionTimeZone() => this.ScheduleExpressionTimeZone != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the schedule: <c>ENABLED</c> or <c>DISABLED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScheduleState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property WidgetIds. 
        /// <para>
        /// The list of widget identifiers included in the scheduled report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<string> WidgetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the WidgetIds property is set.
        /// </summary>
        internal bool IsSetWidgetIds() => this.WidgetIds != null && (this.WidgetIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
