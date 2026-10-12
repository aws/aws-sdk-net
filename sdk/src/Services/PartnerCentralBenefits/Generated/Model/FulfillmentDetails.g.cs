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
    /// Contains comprehensive information about how a benefit allocation is fulfilled across
    /// different fulfillment types.
    /// </summary>
    public partial class FulfillmentDetails
    {
        /// <summary>
        /// Gets and sets the property AccessDetails. 
        /// <para>
        /// Details about access-based fulfillment, if applicable to this benefit allocation.
        /// </para>
        /// </summary>
        public AccessDetails AccessDetails { get; set; }

        /// <summary>
        /// Checks to see if the AccessDetails property is set.
        /// </summary>
        internal bool IsSetAccessDetails() => this.AccessDetails != null;

        /// <summary>
        /// Gets and sets the property ConsumableDetails. 
        /// <para>
        /// Details about consumable-based fulfillment, if applicable to this benefit allocation.
        /// </para>
        /// </summary>
        public ConsumableDetails ConsumableDetails { get; set; }

        /// <summary>
        /// Checks to see if the ConsumableDetails property is set.
        /// </summary>
        internal bool IsSetConsumableDetails() => this.ConsumableDetails != null;

        /// <summary>
        /// Gets and sets the property CreditDetails. 
        /// <para>
        /// Details about credit-based fulfillment, if applicable to this benefit allocation.
        /// </para>
        /// </summary>
        public CreditDetails CreditDetails { get; set; }

        /// <summary>
        /// Checks to see if the CreditDetails property is set.
        /// </summary>
        internal bool IsSetCreditDetails() => this.CreditDetails != null;

        /// <summary>
        /// Gets and sets the property DisbursementDetails. 
        /// <para>
        /// Details about disbursement-based fulfillment, if applicable to this benefit allocation.
        /// </para>
        /// </summary>
        public DisbursementDetails DisbursementDetails { get; set; }

        /// <summary>
        /// Checks to see if the DisbursementDetails property is set.
        /// </summary>
        internal bool IsSetDisbursementDetails() => this.DisbursementDetails != null;
    }
}
