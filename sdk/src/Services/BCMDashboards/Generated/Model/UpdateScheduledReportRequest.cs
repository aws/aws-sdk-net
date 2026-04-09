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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
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
    /// Container for the parameters to the UpdateScheduledReport operation.
    /// Updates an existing scheduled report's properties, including its name, description,
    /// schedule configuration, and widget settings. Only the parameters included in the request
    /// are updated; all other properties remain unchanged.
    /// </summary>
    public partial class UpdateScheduledReportRequest : AmazonBCMDashboardsRequest
    {
        private string _arn;
        private bool? _clearWidgetDateRangeOverride;
        private bool? _clearWidgetIds;
        private string _dashboardArn;
        private string _description;
        private string _name;
        private ScheduleConfig _scheduleConfig;
        private string _scheduledReportExecutionRoleArn;
        private DateTimeRange _widgetDateRangeOverride;
        private List<string> _widgetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the scheduled report to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClearWidgetDateRangeOverride. 
        /// <para>
        /// Set to true to clear existing widgetDateRangeOverride.
        /// </para>
        /// </summary>
        public bool? ClearWidgetDateRangeOverride
        {
            get { return this._clearWidgetDateRangeOverride; }
            set { this._clearWidgetDateRangeOverride = value; }
        }

        // Check to see if ClearWidgetDateRangeOverride property is set
        internal bool IsSetClearWidgetDateRangeOverride()
        {
            return this._clearWidgetDateRangeOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClearWidgetIds. 
        /// <para>
        /// Set to true to clear existing widgetIds.
        /// </para>
        /// </summary>
        public bool? ClearWidgetIds
        {
            get { return this._clearWidgetIds; }
            set { this._clearWidgetIds = value; }
        }

        // Check to see if ClearWidgetIds property is set
        internal bool IsSetClearWidgetIds()
        {
            return this._clearWidgetIds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DashboardArn. 
        /// <para>
        /// The ARN of the dashboard to associate with the scheduled report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description for the scheduled report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name for the scheduled report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=50)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleConfig. 
        /// <para>
        /// The updated schedule configuration for the report.
        /// </para>
        /// </summary>
        public ScheduleConfig ScheduleConfig
        {
            get { return this._scheduleConfig; }
            set { this._scheduleConfig = value; }
        }

        // Check to see if ScheduleConfig property is set
        internal bool IsSetScheduleConfig()
        {
            return this._scheduleConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledReportExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role that the scheduled report uses to execute. Amazon Web Services
        /// Billing and Cost Management Dashboards will assume this IAM role while executing the
        /// scheduled report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ScheduledReportExecutionRoleArn
        {
            get { return this._scheduledReportExecutionRoleArn; }
            set { this._scheduledReportExecutionRoleArn = value; }
        }

        // Check to see if ScheduledReportExecutionRoleArn property is set
        internal bool IsSetScheduledReportExecutionRoleArn()
        {
            return this._scheduledReportExecutionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property WidgetDateRangeOverride. 
        /// <para>
        /// The date range override to apply to widgets in the scheduled report.
        /// </para>
        /// </summary>
        public DateTimeRange WidgetDateRangeOverride
        {
            get { return this._widgetDateRangeOverride; }
            set { this._widgetDateRangeOverride = value; }
        }

        // Check to see if WidgetDateRangeOverride property is set
        internal bool IsSetWidgetDateRangeOverride()
        {
            return this._widgetDateRangeOverride != null;
        }

        /// <summary>
        /// Gets and sets the property WidgetIds. 
        /// <para>
        /// The list of widget identifiers to include in the scheduled report. If not specified,
        /// all widgets in the dashboard are included.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> WidgetIds
        {
            get { return this._widgetIds; }
            set { this._widgetIds = value; }
        }

        // Check to see if WidgetIds property is set
        internal bool IsSetWidgetIds()
        {
            return this._widgetIds != null && (this._widgetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}