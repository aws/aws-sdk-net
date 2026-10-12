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

namespace Amazon.PartnerCentralBenefits.Model
{
    /// <summary>
    /// Contains information about consumable benefit fulfillment, such as usage quotas or
    /// service limits.
    /// </summary>
    public partial class ConsumableDetails
    {
        /// <summary>
        /// Gets and sets the property AllocatedAmount. 
        /// <para>
        /// The total amount of the consumable benefit that has been allocated.
        /// </para>
        /// </summary>
        public MonetaryValue AllocatedAmount { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedAmount property is set.
        /// </summary>
        internal bool IsSetAllocatedAmount() => this.AllocatedAmount != null;

        /// <summary>
        /// Gets and sets the property IssuanceDetails. 
        /// <para>
        /// Detailed information about how the consumable benefit was issued and distributed.
        /// </para>
        /// </summary>
        public IssuanceDetail IssuanceDetails { get; set; }

        /// <summary>
        /// Checks to see if the IssuanceDetails property is set.
        /// </summary>
        internal bool IsSetIssuanceDetails() => this.IssuanceDetails != null;

        /// <summary>
        /// Gets and sets the property RemainingAmount. 
        /// <para>
        /// The remaining amount of the consumable benefit that is still available for use.
        /// </para>
        /// </summary>
        public MonetaryValue RemainingAmount { get; set; }

        /// <summary>
        /// Checks to see if the RemainingAmount property is set.
        /// </summary>
        internal bool IsSetRemainingAmount() => this.RemainingAmount != null;

        /// <summary>
        /// Gets and sets the property UtilizedAmount. 
        /// <para>
        /// The amount of the consumable benefit that has already been used.
        /// </para>
        /// </summary>
        public MonetaryValue UtilizedAmount { get; set; }

        /// <summary>
        /// Checks to see if the UtilizedAmount property is set.
        /// </summary>
        internal bool IsSetUtilizedAmount() => this.UtilizedAmount != null;
    }
}
