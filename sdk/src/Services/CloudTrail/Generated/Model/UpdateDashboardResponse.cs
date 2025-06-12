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
    /// This is the response object from the UpdateDashboard operation.
    /// </summary>
    public partial class UpdateDashboardResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdTimestamp;
        private string _dashboardArn;
        private string _name;
        private RefreshSchedule _refreshSchedule;
        private bool? _terminationProtectionEnabled;
        private DashboardType _type;
        private DateTime? _updatedTimestamp;
        private List<Widget> _widgets = AWSConfigs.InitializeCollections ? new List<Widget>() : null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        ///  The timestamp that shows when the dashboard was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DashboardArn. 
        /// <para>
        ///  The ARN for the dashboard. 
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
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name for the dashboard. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
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
        ///  The refresh schedule for the dashboard, if configured. 
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
        ///  Indicates whether termination protection is enabled for the dashboard. 
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
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of dashboard. 
        /// </para>
        /// </summary>
        public DashboardType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        ///  The timestamp that shows when the dashboard was updated. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp
        {
            get { return this._updatedTimestamp; }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Widgets. 
        /// <para>
        ///  An array of widgets for the dashboard. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Widget> Widgets
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