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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// An object that shows the status of the Deliverability dashboard for your Amazon Pinpoint
    /// account.
    /// </summary>
    public partial class GetDeliverabilityDashboardOptionsResponse : AmazonWebServiceResponse
    {
        private bool? _dashboardEnabled;

        /// <summary>
        /// Gets and sets the property DashboardEnabled. 
        /// <para>
        /// Indicates whether the Deliverability dashboard is enabled. If the value is <code>true</code>,
        /// then the dashboard is enabled.
        /// </para>
        /// </summary>
        public bool DashboardEnabled
        {
            get { return this._dashboardEnabled.GetValueOrDefault(); }
            set { this._dashboardEnabled = value; }
        }

        // Check to see if DashboardEnabled property is set
        internal bool IsSetDashboardEnabled()
        {
            return this._dashboardEnabled.HasValue; 
        }

    }
}