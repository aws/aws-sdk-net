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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// A billing view segment. A segment represents a time range during which the billing
    /// domain and account relationships for a billing view remained unchanged.
    /// </summary>
    public partial class BillingViewSegmentsListElement
    {
        private string _billingGroupPrimaryAccountId;
        private string _billingTransferAccountId;
        private BillingDomain _domain;
        private string _managementAccountId;
        private BillingViewSegmentTimeRange _timeRange;

        /// <summary>
        /// Gets and sets the property BillingGroupPrimaryAccountId. 
        /// <para>
        ///  The billing group primary account ID. The response includes this field for billing
        /// group members. Compare this value to your own account ID to determine whether you
        /// are the primary account. 
        /// </para>
        /// </summary>
        public string BillingGroupPrimaryAccountId
        {
            get { return this._billingGroupPrimaryAccountId; }
            set { this._billingGroupPrimaryAccountId = value; }
        }

        // Check to see if BillingGroupPrimaryAccountId property is set
        internal bool IsSetBillingGroupPrimaryAccountId()
        {
            return this._billingGroupPrimaryAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property BillingTransferAccountId. 
        /// <para>
        ///  The billing transfer account ID. The response includes this field only when the caller
        /// is a billing transfer source account. The response omits this field for billing group
        /// billing views. 
        /// </para>
        /// </summary>
        public string BillingTransferAccountId
        {
            get { return this._billingTransferAccountId; }
            set { this._billingTransferAccountId = value; }
        }

        // Check to see if BillingTransferAccountId property is set
        internal bool IsSetBillingTransferAccountId()
        {
            return this._billingTransferAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The billing domain for this segment. The following values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PRO_FORMA</c> - Data shaped by Billing Conductor that doesn't reflect the final
        /// charges owed to Amazon Web Services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BILLABLE</c> - Data that represents the final charges owed to Amazon Web Services.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BillingDomain Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property ManagementAccountId. 
        /// <para>
        ///  The management account ID of the organization. The response includes this field for
        /// organization member accounts. 
        /// </para>
        /// </summary>
        public string ManagementAccountId
        {
            get { return this._managementAccountId; }
            set { this._managementAccountId = value; }
        }

        // Check to see if ManagementAccountId property is set
        internal bool IsSetManagementAccountId()
        {
            return this._managementAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property TimeRange. 
        /// <para>
        ///  The time range during which this segment is effective. 
        /// </para>
        /// </summary>
        public BillingViewSegmentTimeRange TimeRange
        {
            get { return this._timeRange; }
            set { this._timeRange = value; }
        }

        // Check to see if TimeRange property is set
        internal bool IsSetTimeRange()
        {
            return this._timeRange != null;
        }

    }
}