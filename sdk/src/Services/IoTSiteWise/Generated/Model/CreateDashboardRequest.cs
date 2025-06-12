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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDashboard operation.
    /// Creates a dashboard in an IoT SiteWise Monitor project.
    /// </summary>
    public partial class CreateDashboardRequest : AmazonIoTSiteWiseRequest
    {
        private string _clientToken;
        private string _dashboardDefinition;
        private string _dashboardDescription;
        private string _dashboardName;
        private string _projectId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique case-sensitive identifier that you can provide to ensure the idempotency
        /// of the request. Don't reuse this client token if a new idempotent request is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DashboardDefinition. 
        /// <para>
        /// The dashboard definition specified in a JSON literal.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// IoT SiteWise Monitor (Classic) see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/create-dashboards-using-aws-cli.html">Create
        /// dashboards (CLI)</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IoT SiteWise Monitor (AI-aware) see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/create-dashboards-ai-dashboard-cli.html">Create
        /// dashboards (CLI)</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// in the <i>IoT SiteWise User Guide</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=204800)]
        public string DashboardDefinition
        {
            get { return this._dashboardDefinition; }
            set { this._dashboardDefinition = value; }
        }

        // Check to see if DashboardDefinition property is set
        internal bool IsSetDashboardDefinition()
        {
            return this._dashboardDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property DashboardDescription. 
        /// <para>
        /// A description for the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DashboardDescription
        {
            get { return this._dashboardDescription; }
            set { this._dashboardDescription = value; }
        }

        // Check to see if DashboardDescription property is set
        internal bool IsSetDashboardDescription()
        {
            return this._dashboardDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DashboardName. 
        /// <para>
        /// A friendly name for the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DashboardName
        {
            get { return this._dashboardName; }
            set { this._dashboardName = value; }
        }

        // Check to see if DashboardName property is set
        internal bool IsSetDashboardName()
        {
            return this._dashboardName != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The ID of the project in which to create the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ProjectId
        {
            get { return this._projectId; }
            set { this._projectId = value; }
        }

        // Check to see if ProjectId property is set
        internal bool IsSetProjectId()
        {
            return this._projectId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that contain metadata for the dashboard. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/tag-resources.html">Tagging
        /// your IoT SiteWise resources</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}