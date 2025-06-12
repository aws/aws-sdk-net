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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDashboard operation.
    /// Updates the specified dashboard. 
    /// 
    ///  
    /// <para>
    ///  To set a refresh schedule, CloudTrail must be granted permissions to run the <c>StartDashboardRefresh</c>
    /// operation to refresh the dashboard on your behalf. To provide permissions, run the
    /// <c>PutResourcePolicy</c> operation to attach a resource-based policy to the dashboard.
    /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-dashboards">
    /// Resource-based policy example for a dashboard</a> in the <i>CloudTrail User Guide</i>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  CloudTrail runs queries to populate the dashboard's widgets during a manual or scheduled
    /// refresh. CloudTrail must be granted permissions to run the <c>StartQuery</c> operation
    /// on your behalf. To provide permissions, run the <c>PutResourcePolicy</c> operation
    /// to attach a resource-based policy to each event data store. For more information,
    /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-eds-dashboard">Example:
    /// Allow CloudTrail to run queries to populate a dashboard</a> in the <i>CloudTrail User
    /// Guide</i>. 
    /// </para>
    /// </summary>
    public partial class UpdateDashboardRequest : AmazonCloudTrailRequest
    {
        private string _dashboardId;
        private RefreshSchedule _refreshSchedule;
        private bool? _terminationProtectionEnabled;
        private List<RequestWidget> _widgets = AWSConfigs.InitializeCollections ? new List<RequestWidget>() : null;

        /// <summary>
        /// Gets and sets the property DashboardId. 
        /// <para>
        ///  The name or ARN of the dashboard. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RefreshSchedule. 
        /// <para>
        ///  The refresh schedule configuration for the dashboard. 
        /// </para>
        /// </summary>
        public RefreshSchedule RefreshSchedule
        {
            get { return this._refreshSchedule; }
            set { this._refreshSchedule = value; }
        }

        // Check to see if RefreshSchedule property is set
        internal bool IsSetRefreshSchedule()
        {
            return this._refreshSchedule != null;
        }

        /// <summary>
        /// Gets and sets the property TerminationProtectionEnabled. 
        /// <para>
        ///  Specifies whether termination protection is enabled for the dashboard. If termination
        /// protection is enabled, you cannot delete the dashboard until termination protection
        /// is disabled. 
        /// </para>
        /// </summary>
        public bool? TerminationProtectionEnabled
        {
            get { return this._terminationProtectionEnabled; }
            set { this._terminationProtectionEnabled = value; }
        }

        // Check to see if TerminationProtectionEnabled property is set
        internal bool IsSetTerminationProtectionEnabled()
        {
            return this._terminationProtectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Widgets. 
        /// <para>
        ///  An array of widgets for the dashboard. A custom dashboard can have a maximum of 10
        /// widgets. 
        /// </para>
        ///  
        /// <para>
        /// To add new widgets, pass in an array that includes the existing widgets along with
        /// any new widgets. Run the <c>GetDashboard</c> operation to get the list of widgets
        /// for the dashboard.
        /// </para>
        ///  
        /// <para>
        /// To remove widgets, pass in an array that includes the existing widgets minus the widgets
        /// you want removed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RequestWidget> Widgets
        {
            get { return this._widgets; }
            set { this._widgets = value; }
        }

        // Check to see if Widgets property is set
        internal bool IsSetWidgets()
        {
            return this._widgets != null && (this._widgets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}