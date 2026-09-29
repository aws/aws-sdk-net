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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDashboard operation. Updates a dashboard
    /// in an Amazon Web Services account. <note> <para> Updating a Dashboard creates a new
    /// dashboard version but does not immediately publish the new version. You can update
    /// the published version of a dashboard by using the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdateDashboardPublishedVersion.html">UpdateDashboardPublishedVersion</a>
    /// </c> API operation. </para> </note>
    /// </summary>
    public partial class UpdateDashboardRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the dashboard that you're
        /// updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID for the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string DashboardId { get; set; }

        /// <summary>
        /// Checks to see if the DashboardId property is set.
        /// </summary>
        internal bool IsSetDashboardId() => this.DashboardId != null;

        /// <summary>
        /// Gets and sets the property DashboardPublishOptions. 
        /// <para>
        /// Options for publishing the dashboard when you create it:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AvailabilityStatus</c> for <c>AdHocFilteringOption</c> - This status can be either
        /// <c>ENABLED</c> or <c>DISABLED</c>. When this is set to <c>DISABLED</c>, Amazon Quick
        /// Sight disables the left filter pane on the published dashboard, which can be used
        /// for ad hoc (one-time) filtering. This option is <c>ENABLED</c> by default. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AvailabilityStatus</c> for <c>ExportToCSVOption</c> - This status can be either
        /// <c>ENABLED</c> or <c>DISABLED</c>. The visual option to export data to .CSV format
        /// isn't enabled when this is set to <c>DISABLED</c>. This option is <c>ENABLED</c> by
        /// default. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VisibilityState</c> for <c>SheetControlsOption</c> - This visibility state can
        /// be either <c>COLLAPSED</c> or <c>EXPANDED</c>. This option is <c>COLLAPSED</c> by
        /// default. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AvailabilityStatus</c> for <c>QuickSuiteActionsOption</c> - This status can be
        /// either <c>ENABLED</c> or <c>DISABLED</c>. Features related to Actions in Amazon Quick
        /// Suite on dashboards are disabled when this is set to <c>DISABLED</c>. This option
        /// is <c>DISABLED</c> by default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AvailabilityStatus</c> for <c>ExecutiveSummaryOption</c> - This status can be
        /// either <c>ENABLED</c> or <c>DISABLED</c>. The option to build an executive summary
        /// is disabled when this is set to <c>DISABLED</c>. This option is <c>ENABLED</c> by
        /// default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AvailabilityStatus</c> for <c>DataStoriesSharingOption</c> - This status can be
        /// either <c>ENABLED</c> or <c>DISABLED</c>. The option to share a data story is disabled
        /// when this is set to <c>DISABLED</c>. This option is <c>ENABLED</c> by default.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DashboardPublishOptions DashboardPublishOptions { get; set; }

        /// <summary>
        /// Checks to see if the DashboardPublishOptions property is set.
        /// </summary>
        internal bool IsSetDashboardPublishOptions() => this.DashboardPublishOptions != null;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The definition of a dashboard.
        /// </para>
        ///  
        /// <para>
        /// A definition is the data model of all features in a Dashboard, Template, or Analysis.
        /// </para>
        /// </summary>
        public DashboardVersionDefinition Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A structure that contains the parameters of the dashboard. These are parameter overrides
        /// for a dashboard. A dashboard can have any type of parameters, and some parameters
        /// might accept multiple values.
        /// </para>
        /// </summary>
        public Parameters Parameters { get; set; }

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null;

        /// <summary>
        /// Gets and sets the property SourceEntity. 
        /// <para>
        /// The entity that you are using as a source when you update the dashboard. In <c>SourceEntity</c>,
        /// you specify the type of object you're using as source. You can only update a dashboard
        /// from a template, so you use a <c>SourceTemplate</c> entity. If you need to update
        /// a dashboard from an analysis, first convert the analysis to a template by using the
        /// <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_CreateTemplate.html">CreateTemplate</a>
        /// </c> API operation. For <c>SourceTemplate</c>, specify the Amazon Resource Name (ARN)
        /// of the source template. The <c>SourceTemplate</c> ARN can contain any Amazon Web Services
        /// account and any Amazon Quick Sight-supported Amazon Web Services Region. 
        /// </para>
        ///  
        /// <para>
        /// Use the <c>DataSetReferences</c> entity within <c>SourceTemplate</c> to list the replacement
        /// datasets for the placeholders listed in the original. The schema in each dataset must
        /// match its placeholder. Use the <c>TopicReferences</c> entity to list the replacement
        /// topics for the topic placeholders listed in the original. The schema in each topic
        /// must match its placeholder.
        /// </para>
        /// </summary>
        public DashboardSourceEntity SourceEntity { get; set; }

        /// <summary>
        /// Checks to see if the SourceEntity property is set.
        /// </summary>
        internal bool IsSetSourceEntity() => this.SourceEntity != null;

        /// <summary>
        /// Gets and sets the property ThemeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the theme that is being used for this dashboard.
        /// If you add a value for this field, it overrides the value that was originally associated
        /// with the entity. The theme ARN must exist in the same Amazon Web Services account
        /// where you create the dashboard.
        /// </para>
        /// </summary>
        public string ThemeArn { get; set; }

        /// <summary>
        /// Checks to see if the ThemeArn property is set.
        /// </summary>
        internal bool IsSetThemeArn() => this.ThemeArn != null;

        /// <summary>
        /// Gets and sets the property ValidationStrategy. 
        /// <para>
        /// The option to relax the validation needed to update a dashboard with definition objects.
        /// This skips the validation step for specific errors.
        /// </para>
        /// </summary>
        public ValidationStrategy ValidationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStrategy property is set.
        /// </summary>
        internal bool IsSetValidationStrategy() => this.ValidationStrategy != null;

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// A description for the first version of the dashboard being created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// Checks to see if the VersionDescription property is set.
        /// </summary>
        internal bool IsSetVersionDescription() => this.VersionDescription != null;
    }
}
