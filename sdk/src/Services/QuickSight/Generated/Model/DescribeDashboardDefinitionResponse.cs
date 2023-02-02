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
    /// This is the response object from the DescribeDashboardDefinition operation.
    /// </summary>
    public partial class DescribeDashboardDefinitionResponse : AmazonWebServiceResponse
    {
        private string _dashboardId;
        private DashboardPublishOptions _dashboardPublishOptions;
        private DashboardVersionDefinition _definition;
        private List<DashboardError> _errors = new List<DashboardError>();
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
        /// Gets and sets the property Errors. 
        /// <para>
        /// Errors associated with this dashboard version.
        /// </para>
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
            return this._errors != null && this._errors.Count > 0; 
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
        ///  <code>CREATION_IN_PROGRESS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATION_SUCCESSFUL</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATION_FAILED</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_IN_PROGRESS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_SUCCESSFUL</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_FAILED</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETED</code> 
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
        public int Status
        {
            get { return this._status.GetValueOrDefault(); }
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