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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
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
namespace Amazon.Budgets.Model
{
    /// <summary>
    /// Provides information about the current operational state of a billing view resource,
    /// including its ability to access and update based on its associated billing view.
    /// </summary>
    public partial class HealthStatus
    {
        private DateTime? _lastUpdatedTime;
        private HealthStatusValue _status;
        private HealthStatusReason _statusReason;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime.
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the billing view resource.
        /// </para>
        /// </summary>
        public HealthStatusValue Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current status.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BILLING_VIEW_NO_ACCESS</c>: The billing view resource does not grant <c>billing:GetBillingViewData</c>
        /// permission to this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BILLING_VIEW_UNHEALTHY</c>: The billing view associated with the budget is unhealthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FILTER_INVALID</c>: The filter contains reference to an account you do not have
        /// access to.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MULTI_YEAR_HISTORICAL_DATA_DISABLED</c>: The budget is not being updated. Enable
        /// multi-year historical data in your Cost Management preferences.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public HealthStatusReason StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}