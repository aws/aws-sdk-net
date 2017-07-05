/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDashboards operation.
    /// Deletes all dashboards that you specify. You may specify up to 100 dashboards to delete.
    /// If there is an error during this call, no dashboards are deleted.
    /// </summary>
    public partial class DeleteDashboardsRequest : AmazonCloudWatchRequest
    {
        private List<string> _dashboardNames = new List<string>();

        /// <summary>
        /// Gets and sets the property DashboardNames. 
        /// <para>
        /// The dashboards to be deleted.
        /// </para>
        /// </summary>
        public List<string> DashboardNames
        {
            get { return this._dashboardNames; }
            set { this._dashboardNames = value; }
        }

        // Check to see if DashboardNames property is set
        internal bool IsSetDashboardNames()
        {
            return this._dashboardNames != null && this._dashboardNames.Count > 0; 
        }

    }
}