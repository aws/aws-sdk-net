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
    /// This is the response object from the DescribeDashboardPermissions operation.
    /// </summary>
    public partial class DescribeDashboardPermissionsResponse : AmazonWebServiceResponse
    {
        private string _dashboardArn;
        private string _dashboardId;
        private LinkSharingConfiguration _linkSharingConfiguration;
        private List<ResourcePermission> _permissions = new List<ResourcePermission>();
        private string _requestId;
        private int? _status;

        /// <summary>
        /// Gets and sets the property DashboardArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dashboard.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID for the dashboard.
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
        /// Gets and sets the property LinkSharingConfiguration. 
        /// <para>
        /// A structure that contains the configuration of a shareable link that grants access
        /// to the dashboard. Your users can use the link to view and interact with the dashboard,
        /// if the dashboard has been shared with them. For more information about sharing dashboards,
        /// see <a href="https://docs.aws.amazon.com/quicksight/latest/user/sharing-a-dashboard.html">Sharing
        /// Dashboards</a>.
        /// </para>
        /// </summary>
        public LinkSharingConfiguration LinkSharingConfiguration
        {
            get { return this._linkSharingConfiguration; }
            set { this._linkSharingConfiguration = value; }
        }

        // Check to see if LinkSharingConfiguration property is set
        internal bool IsSetLinkSharingConfiguration()
        {
            return this._linkSharingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// A structure that contains the permissions for the dashboard.
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

    }
}