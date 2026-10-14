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
    /// Container for the parameters to the UpdateScheduledReport operation. Updates an existing
    /// scheduled report's properties, including its name, description, schedule configuration,
    /// and widget settings. Only the parameters included in the request are updated; all
    /// other properties remain unchanged.
    /// </summary>
    public partial class UpdateScheduledReportRequest : AmazonBCMDashboardsRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the scheduled report to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ClearWidgetDateRangeOverride. Set to true to clear existing
        /// widgetDateRangeOverride.
        /// </summary>
        public bool? ClearWidgetDateRangeOverride { get; set; }

        /// <summary>
        /// Checks to see if the ClearWidgetDateRangeOverride property is set.
        /// </summary>
        internal bool IsSetClearWidgetDateRangeOverride() => this.ClearWidgetDateRangeOverride.HasValue;

        /// <summary>
        /// Gets and sets the property ClearWidgetIds. Set to true to clear existing widgetIds.
        /// </summary>
        public bool? ClearWidgetIds { get; set; }

        /// <summary>
        /// Checks to see if the ClearWidgetIds property is set.
        /// </summary>
        internal bool IsSetClearWidgetIds() => this.ClearWidgetIds.HasValue;

        /// <summary>
        /// Gets and sets the property DashboardArn. 
        /// <para>
        /// The ARN of the dashboard to associate with the scheduled report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DashboardArn { get; set; }

        /// <summary>
        /// Checks to see if the DashboardArn property is set.
        /// </summary>
        internal bool IsSetDashboardArn() => this.DashboardArn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description for the scheduled report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name for the scheduled report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ScheduleConfig. 
        /// <para>
        /// The updated schedule configuration for the report.
        /// </para>
        /// </summary>
        public ScheduleConfig ScheduleConfig { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleConfig property is set.
        /// </summary>
        internal bool IsSetScheduleConfig() => this.ScheduleConfig != null;

        /// <summary>
        /// Gets and sets the property ScheduledReportExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role that the scheduled report uses to execute. Amazon Web Services
        /// Billing and Cost Management Dashboards will assume this IAM role while executing the
        /// scheduled report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ScheduledReportExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledReportExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetScheduledReportExecutionRoleArn() => this.ScheduledReportExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property WidgetDateRangeOverride. 
        /// <para>
        /// The date range override to apply to widgets in the scheduled report.
        /// </para>
        /// </summary>
        public DateTimeRange WidgetDateRangeOverride { get; set; }

        /// <summary>
        /// Checks to see if the WidgetDateRangeOverride property is set.
        /// </summary>
        internal bool IsSetWidgetDateRangeOverride() => this.WidgetDateRangeOverride != null;

        /// <summary>
        /// Gets and sets the property WidgetIds. 
        /// <para>
        /// The list of widget identifiers to include in the scheduled report. If not specified,
        /// all widgets in the dashboard are included.
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
