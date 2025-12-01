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
 * Do not modify this file. This file is generated from the partnercentral-benefits-2018-05-10.normal.json service model.
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
        private MonetaryValue _allocatedAmount;
        private IssuanceDetail _issuanceDetails;
        private MonetaryValue _remainingAmount;
        private MonetaryValue _utilizedAmount;

        /// <summary>
        /// Gets and sets the property AllocatedAmount. 
        /// <para>
        /// The total amount of the consumable benefit that has been allocated.
        /// </para>
        /// </summary>
        public MonetaryValue AllocatedAmount
        {
            get { return this._allocatedAmount; }
            set { this._allocatedAmount = value; }
        }

        // Check to see if AllocatedAmount property is set
        internal bool IsSetAllocatedAmount()
        {
            return this._allocatedAmount != null;
        }

        /// <summary>
        /// Gets and sets the property IssuanceDetails. 
        /// <para>
        /// Detailed information about how the consumable benefit was issued and distributed.
        /// </para>
        /// </summary>
        public IssuanceDetail IssuanceDetails
        {
            get { return this._issuanceDetails; }
            set { this._issuanceDetails = value; }
        }

        // Check to see if IssuanceDetails property is set
        internal bool IsSetIssuanceDetails()
        {
            return this._issuanceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RemainingAmount. 
        /// <para>
        /// The remaining amount of the consumable benefit that is still available for use.
        /// </para>
        /// </summary>
        public MonetaryValue RemainingAmount
        {
            get { return this._remainingAmount; }
            set { this._remainingAmount = value; }
        }

        // Check to see if RemainingAmount property is set
        internal bool IsSetRemainingAmount()
        {
            return this._remainingAmount != null;
        }

        /// <summary>
        /// Gets and sets the property UtilizedAmount. 
        /// <para>
        /// The amount of the consumable benefit that has already been used.
        /// </para>
        /// </summary>
        public MonetaryValue UtilizedAmount
        {
            get { return this._utilizedAmount; }
            set { this._utilizedAmount = value; }
        }

        // Check to see if UtilizedAmount property is set
        internal bool IsSetUtilizedAmount()
        {
            return this._utilizedAmount != null;
        }

    }
}