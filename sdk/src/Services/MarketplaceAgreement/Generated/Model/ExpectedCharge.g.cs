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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Estimated charge for the request.
    /// </summary>
    public partial class ExpectedCharge
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The tax-exclusive amount of the charge. Only available when the charge amount is known.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount != null;

        /// <summary>
        /// Gets and sets the property AmountAfterTax. 
        /// <para>
        /// The tax-inclusive amount the acceptor has to pay. The amount is only present for fixed
        /// charges.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string AmountAfterTax { get; set; }

        /// <summary>
        /// Checks to see if the AmountAfterTax property is set.
        /// </summary>
        internal bool IsSetAmountAfterTax() => this.AmountAfterTax != null;

        /// <summary>
        /// Gets and sets the property EstimatedTaxes. 
        /// <para>
        /// Provides an aggregated view of estimated tax information for this specific charge.
        /// </para>
        /// </summary>
        public EstimatedTaxes EstimatedTaxes { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedTaxes property is set.
        /// </summary>
        internal bool IsSetEstimatedTaxes() => this.EstimatedTaxes != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Unique identifier of the charge for a given agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The date and time when the charge is due to be invoiced. This is available only when
        /// the charge date is known.
        /// </para>
        /// </summary>
        public DateTime? Time { get; set; }

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time.HasValue;

        /// <summary>
        /// Gets and sets the property Timing. 
        /// <para>
        /// Indicates when the charge amount will be incurred. Values include <c>ON_ACCEPTANCE</c>
        /// (charged immediately when the agreement request is accepted), <c>BILLING_PERIOD</c>
        /// (charged on each billing period), and <c>SCHEDULED</c> (charged at a predetermined
        /// future date).
        /// </para>
        /// </summary>
        public Timing Timing { get; set; }

        /// <summary>
        /// Checks to see if the Timing property is set.
        /// </summary>
        internal bool IsSetTiming() => this.Timing != null;
    }
}
