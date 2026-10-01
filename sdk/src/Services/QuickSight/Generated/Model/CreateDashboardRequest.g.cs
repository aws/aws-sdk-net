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
    /// Container for the parameters to the CreateDashboard operation. Creates a dashboard
    /// from either a template or directly with a <c>DashboardDefinition</c>. To first create
    /// a template, see the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_CreateTemplate.html">CreateTemplate</a>
    /// </c> API operation. <para> A dashboard is an entity in Amazon Quick Sight that identifies
    /// Amazon Quick Sight reports, created from analyses. You can share Amazon Quick Sight
    /// dashboards. With the right permissions, you can create scheduled email reports from
    /// them. If you have the correct permissions, you can create a dashboard from a template
    /// that exists in a different Amazon Web Services account. </para>
    /// </summary>
    public partial class CreateDashboardRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account where you want to create the dashboard.
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
        /// The ID for the dashboard, also added to the IAM policy.
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
        ///  
        /// <para>
        /// Either a <c>SourceEntity</c> or a <c>Definition</c> must be provided in order for
        /// the request to be valid.
        /// </para>
        /// </summary>
        public DashboardVersionDefinition Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property FolderArns. 
        /// <para>
        /// When you create the dashboard, Amazon Quick Sight adds the dashboard to these folders.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> FolderArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FolderArns property is set.
        /// </summary>
        internal bool IsSetFolderArns() => this.FolderArns != null && (this.FolderArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LinkEntities. 
        /// <para>
        /// A list of analysis Amazon Resource Names (ARNs) to be linked to the dashboard.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> LinkEntities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LinkEntities property is set.
        /// </summary>
        internal bool IsSetLinkEntities() => this.LinkEntities != null && (this.LinkEntities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LinkSharingConfiguration. 
        /// <para>
        /// A structure that contains the permissions of a shareable link to the dashboard.
        /// </para>
        /// </summary>
        public LinkSharingConfiguration LinkSharingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LinkSharingConfiguration property is set.
        /// </summary>
        internal bool IsSetLinkSharingConfiguration() => this.LinkSharingConfiguration != null;

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
        /// The parameters for the creation of the dashboard, which you want to use to override
        /// the default settings. A dashboard can have any type of parameters, and some parameters
        /// might accept multiple values. 
        /// </para>
        /// </summary>
        public Parameters Parameters { get; set; }

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// A structure that contains the permissions of the dashboard. You can use this structure
        /// for granting permissions by providing a list of IAM action information for each principal
        /// ARN. 
        /// </para>
        ///  
        /// <para>
        /// To specify no permissions, omit the permissions list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public List<ResourcePermission> Permissions { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null && (this.Permissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceEntity. 
        /// <para>
        /// The entity that you are using as a source when you create the dashboard. In <c>SourceEntity</c>,
        /// you specify the type of object you're using as source. You can only create a dashboard
        /// from a template, so you use a <c>SourceTemplate</c> entity. If you need to create
        /// a dashboard from an analysis, first convert the analysis to a template by using the
        /// <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_CreateTemplate.html">CreateTemplate</a>
        /// </c> API operation. For <c>SourceTemplate</c>, specify the Amazon Resource Name (ARN)
        /// of the source template. The <c>SourceTemplate</c>ARN can contain any Amazon Web Services
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
        ///  
        /// <para>
        /// Either a <c>SourceEntity</c> or a <c>Definition</c> must be provided in order for
        /// the request to be valid.
        /// </para>
        /// </summary>
        public DashboardSourceEntity SourceEntity { get; set; }

        /// <summary>
        /// Checks to see if the SourceEntity property is set.
        /// </summary>
        internal bool IsSetSourceEntity() => this.SourceEntity != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Contains a map of the key-value pairs for the resource tag or tags assigned to the
        /// dashboard.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThemeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the theme that is being used for this dashboard.
        /// If you add a value for this field, it overrides the value that is used in the source
        /// entity. The theme ARN must exist in the same Amazon Web Services account where you
        /// create the dashboard.
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
        /// The option to relax the validation needed to create a dashboard with definition objects.
        /// This option skips the validation step for specific errors.
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
