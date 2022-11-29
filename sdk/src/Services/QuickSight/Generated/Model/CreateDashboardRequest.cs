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
    /// Container for the parameters to the CreateDashboard operation.
    /// Creates a dashboard from a template. To first create a template, see the <code> <a
    /// href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_CreateTemplate.html">CreateTemplate</a>
    /// </code> API operation.
    /// 
    ///  
    /// <para>
    /// A dashboard is an entity in Amazon QuickSight that identifies Amazon QuickSight reports,
    /// created from analyses. You can share Amazon QuickSight dashboards. With the right
    /// permissions, you can create scheduled email reports from them. If you have the correct
    /// permissions, you can create a dashboard from a template that exists in a different
    /// Amazon Web Services account.
    /// </para>
    /// </summary>
    public partial class CreateDashboardRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _dashboardId;
        private DashboardPublishOptions _dashboardPublishOptions;
        private DashboardVersionDefinition _definition;
        private string _name;
        private Parameters _parameters;
        private List<ResourcePermission> _permissions = new List<ResourcePermission>();
        private DashboardSourceEntity _sourceEntity;
        private List<Tag> _tags = new List<Tag>();
        private string _themeArn;
        private string _versionDescription;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account where you want to create the dashboard.
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
        /// The ID for the dashboard, also added to the IAM policy.
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
        /// Gets and sets the property DashboardPublishOptions. 
        /// <para>
        /// Options for publishing the dashboard when you create it:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AvailabilityStatus</code> for <code>AdHocFilteringOption</code> - This status
        /// can be either <code>ENABLED</code> or <code>DISABLED</code>. When this is set to <code>DISABLED</code>,
        /// Amazon QuickSight disables the left filter pane on the published dashboard, which
        /// can be used for ad hoc (one-time) filtering. This option is <code>ENABLED</code> by
        /// default. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AvailabilityStatus</code> for <code>ExportToCSVOption</code> - This status
        /// can be either <code>ENABLED</code> or <code>DISABLED</code>. The visual option to
        /// export data to .CSV format isn't enabled when this is set to <code>DISABLED</code>.
        /// This option is <code>ENABLED</code> by default. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VisibilityState</code> for <code>SheetControlsOption</code> - This visibility
        /// state can be either <code>COLLAPSED</code> or <code>EXPANDED</code>. This option is
        /// <code>COLLAPSED</code> by default. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DashboardPublishOptions DashboardPublishOptions
        {
            get { return this._dashboardPublishOptions; }
            set { this._dashboardPublishOptions = value; }
        }

        // Check to see if DashboardPublishOptions property is set
        internal bool IsSetDashboardPublishOptions()
        {
            return this._dashboardPublishOptions != null;
        }

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
        public DashboardVersionDefinition Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters for the creation of the dashboard, which you want to use to override
        /// the default settings. A dashboard can have any type of parameters, and some parameters
        /// might accept multiple values. 
        /// </para>
        /// </summary>
        public Parameters Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null;
        }

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
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public List<ResourcePermission> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && this._permissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceEntity. 
        /// <para>
        /// The entity that you are using as a source when you create the dashboard. In <code>SourceEntity</code>,
        /// you specify the type of object you're using as source. You can only create a dashboard
        /// from a template, so you use a <code>SourceTemplate</code> entity. If you need to create
        /// a dashboard from an analysis, first convert the analysis to a template by using the
        /// <code> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_CreateTemplate.html">CreateTemplate</a>
        /// </code> API operation. For <code>SourceTemplate</code>, specify the Amazon Resource
        /// Name (ARN) of the source template. The <code>SourceTemplate</code>ARN can contain
        /// any Amazon Web Services account and any Amazon QuickSight-supported Amazon Web Services
        /// Region. 
        /// </para>
        ///  
        /// <para>
        /// Use the <code>DataSetReferences</code> entity within <code>SourceTemplate</code> to
        /// list the replacement datasets for the placeholders listed in the original. The schema
        /// in each dataset must match its placeholder. 
        /// </para>
        /// </summary>
        public DashboardSourceEntity SourceEntity
        {
            get { return this._sourceEntity; }
            set { this._sourceEntity = value; }
        }

        // Check to see if SourceEntity property is set
        internal bool IsSetSourceEntity()
        {
            return this._sourceEntity != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Contains a map of the key-value pairs for the resource tag or tags assigned to the
        /// dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThemeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the theme that is being used for this dashboard.
        /// If you add a value for this field, it overrides the value that is used in the source
        /// entity. The theme ARN must exist in the same Amazon Web Services account where you
        /// create the dashboard.
        /// </para>
        /// </summary>
        public string ThemeArn
        {
            get { return this._themeArn; }
            set { this._themeArn = value; }
        }

        // Check to see if ThemeArn property is set
        internal bool IsSetThemeArn()
        {
            return this._themeArn != null;
        }

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// A description for the first version of the dashboard being created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string VersionDescription
        {
            get { return this._versionDescription; }
            set { this._versionDescription = value; }
        }

        // Check to see if VersionDescription property is set
        internal bool IsSetVersionDescription()
        {
            return this._versionDescription != null;
        }

    }
}