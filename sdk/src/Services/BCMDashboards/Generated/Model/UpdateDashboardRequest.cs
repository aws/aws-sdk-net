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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
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
namespace Amazon.BCMDashboards.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDashboard operation.
    /// Updates an existing dashboard's properties, including its name, description, and widget
    /// configurations.
    /// </summary>
    public partial class UpdateDashboardRequest : AmazonBCMDashboardsRequest
    {
        private string _arn;
        private string _description;
        private string _name;
        private List<Widget> _widgets = AWSConfigs.InitializeCollections ? new List<Widget>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the dashboard to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description for the dashboard. If not specified, the existing description
        /// is retained.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name for the dashboard. If not specified, the existing name is retained.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=50)]
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
        /// Gets and sets the property Widgets. 
        /// <para>
        /// The updated array of widget configurations for the dashboard. Replaces all existing
        /// widgets.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
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