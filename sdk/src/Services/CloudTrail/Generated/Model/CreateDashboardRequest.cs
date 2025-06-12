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
    /// Container for the parameters to the CreateDashboard operation.
    /// Creates a custom dashboard or the Highlights dashboard. 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b>Custom dashboards</b> - Custom dashboards allow you to query events in any event
    /// data store type. You can add up to 10 widgets to a custom dashboard. You can manually
    /// refresh a custom dashboard, or you can set a refresh schedule.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Highlights dashboard</b> - You can create the Highlights dashboard to see a summary
    /// of key user activities and API usage across all your event data stores. CloudTrail
    /// Lake manages the Highlights dashboard and refreshes the dashboard every 6 hours. To
    /// create the Highlights dashboard, you must set and enable a refresh schedule.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  CloudTrail runs queries to populate the dashboard's widgets during a manual or scheduled
    /// refresh. CloudTrail must be granted permissions to run the <c>StartQuery</c> operation
    /// on your behalf. To provide permissions, run the <c>PutResourcePolicy</c> operation
    /// to attach a resource-based policy to each event data store. For more information,
    /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-eds-dashboard">Example:
    /// Allow CloudTrail to run queries to populate a dashboard</a> in the <i>CloudTrail User
    /// Guide</i>. 
    /// </para>
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
    /// For more information about dashboards, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-dashboard.html">CloudTrail
    /// Lake dashboards</a> in the <i>CloudTrail User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateDashboardRequest : AmazonCloudTrailRequest
    {
        private string _name;
        private RefreshSchedule _refreshSchedule;
        private List<Tag> _tagsList = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private bool? _terminationProtectionEnabled;
        private List<RequestWidget> _widgets = AWSConfigs.InitializeCollections ? new List<RequestWidget>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the dashboard. The name must be unique to your account. 
        /// </para>
        ///  
        /// <para>
        /// To create the Highlights dashboard, the name must be <c>AWSCloudTrail-Highlights</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=128)]
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
        /// Gets and sets the property RefreshSchedule. 
        /// <para>
        ///  The refresh schedule configuration for the dashboard. 
        /// </para>
        ///  
        /// <para>
        /// To create the Highlights dashboard, you must set a refresh schedule and set the <c>Status</c>
        /// to <c>ENABLED</c>. The <c>Unit</c> for the refresh schedule must be <c>HOURS</c> and
        /// the <c>Value</c> must be <c>6</c>.
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
        /// Gets and sets the property TagsList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=200)]
        public List<Tag> TagsList
        {
            get { return this._tagsList; }
            set { this._tagsList = value; }
        }

        // Check to see if TagsList property is set
        internal bool IsSetTagsList()
        {
            return this._tagsList != null && (this._tagsList.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        ///  An array of widgets for a custom dashboard. A custom dashboard can have a maximum
        /// of ten widgets. 
        /// </para>
        ///  
        /// <para>
        /// You do not need to specify widgets for the Highlights dashboard.
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