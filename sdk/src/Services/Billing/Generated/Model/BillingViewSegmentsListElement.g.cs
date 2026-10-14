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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property BillingGroupPrimaryAccountId. 
        /// <para>
        ///  The billing group primary account ID. The response includes this field for billing
        /// group members. Compare this value to your own account ID to determine whether you
        /// are the primary account. 
        /// </para>
        /// </summary>
        public string BillingGroupPrimaryAccountId { get; set; }

        /// <summary>
        /// Checks to see if the BillingGroupPrimaryAccountId property is set.
        /// </summary>
        internal bool IsSetBillingGroupPrimaryAccountId() => this.BillingGroupPrimaryAccountId != null;

        /// <summary>
        /// Gets and sets the property BillingTransferAccountId. 
        /// <para>
        ///  The billing transfer account ID. The response includes this field only when the caller
        /// is a billing transfer source account. The response omits this field for billing group
        /// billing views. 
        /// </para>
        /// </summary>
        public string BillingTransferAccountId { get; set; }

        /// <summary>
        /// Checks to see if the BillingTransferAccountId property is set.
        /// </summary>
        internal bool IsSetBillingTransferAccountId() => this.BillingTransferAccountId != null;

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
        public BillingDomain Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property ManagementAccountId. 
        /// <para>
        ///  The management account ID of the organization. The response includes this field for
        /// organization member accounts. 
        /// </para>
        /// </summary>
        public string ManagementAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ManagementAccountId property is set.
        /// </summary>
        internal bool IsSetManagementAccountId() => this.ManagementAccountId != null;

        /// <summary>
        /// Gets and sets the property TimeRange. 
        /// <para>
        ///  The time range during which this segment is effective. 
        /// </para>
        /// </summary>
        public BillingViewSegmentTimeRange TimeRange { get; set; }

        /// <summary>
        /// Checks to see if the TimeRange property is set.
        /// </summary>
        internal bool IsSetTimeRange() => this.TimeRange != null;
    }
}
