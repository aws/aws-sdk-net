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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This is the response object from the PutDashboard operation.
    /// </summary>
    public partial class PutDashboardResponse : AmazonWebServiceResponse
    {
        private List<DashboardValidationMessage> _dashboardValidationMessages = new List<DashboardValidationMessage>();

        /// <summary>
        /// Gets and sets the property DashboardValidationMessages. 
        /// <para>
        /// If the input for <code>PutDashboard</code> was correct and the dashboard was successfully
        /// created or modified, this result is empty.
        /// </para>
        ///  
        /// <para>
        /// If this result includes only warning messages, then the input was valid enough for
        /// the dashboard to be created or modified, but some elements of the dashboard might
        /// not render.
        /// </para>
        ///  
        /// <para>
        /// If this result includes error messages, the input was not valid and the operation
        /// failed.
        /// </para>
        /// </summary>
        public List<DashboardValidationMessage> DashboardValidationMessages
        {
            get { return this._dashboardValidationMessages; }
            set { this._dashboardValidationMessages = value; }
        }

        // Check to see if DashboardValidationMessages property is set
        internal bool IsSetDashboardValidationMessages()
        {
            return this._dashboardValidationMessages != null && this._dashboardValidationMessages.Count > 0; 
        }

    }
}