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
    /// This is the response object from the DescribeDashboardDefinition operation.
    /// </summary>
    public partial class DescribeDashboardDefinitionResponse : AmazonWebServiceResponse
    {
        private string _dashboardId;
        private DashboardPublishOptions _dashboardPublishOptions;
        private DashboardVersionDefinition _definition;
        private List<DashboardError> _errors = AWSConfigs.InitializeCollections ? new List<DashboardError>() : null;
        private string _name;
        private string _requestId;
        private ResourceStatus _resourceStatus;
        private int? _status;
        private string _themeArn;

        /// <summary>
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID of the dashboard described.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// Options for publishing the dashboard:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AvailabilityStatus</c> for <c>AdHocFilteringOption</c> - This status can be either
        /// <c>ENABLED</c> or <c>DISABLED</c>. When this is set to <c>DISABLED</c>, QuickSight
        /// disables the left filter pane on the published dashboard, which can be used for ad
        /// hoc (one-time) filtering. This option is <c>ENABLED</c> by default. 
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
        /// Gets and sets the property Errors. 
        /// <para>
        /// Errors associated with this dashboard version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<DashboardError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceStatus. 
        /// <para>
        /// Status associated with the dashboard version.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATION_IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATION_SUCCESSFUL</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATION_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_SUCCESSFUL</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceStatus ResourceStatus
        {
            get { return this._resourceStatus; }
            set { this._resourceStatus = value; }
        }

        // Check to see if ResourceStatus property is set
        internal bool IsSetResourceStatus()
        {
            return this._resourceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int? Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThemeArn. 
        /// <para>
        /// The ARN of the theme of the dashboard.
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

    }
}