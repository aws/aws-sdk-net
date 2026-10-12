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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Provides an estimate of the revenue that the partner is expected to generate from
    /// the opportunity. This information helps partners assess the financial value of the
    /// project.
    /// </summary>
    public partial class ExpectedCustomerSpend
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// Represents the estimated monthly revenue that the partner expects to earn from the
        /// opportunity. This helps in forecasting financial returns.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount != null;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// Indicates the currency in which the revenue estimate is provided. This helps in understanding
        /// the financial impact across different markets. Accepted values are <c>USD</c> (US
        /// Dollars) and <c>EUR</c> (Euros). If the AWS Partition is <c>aws-eusc</c> (AWS European
        /// Sovereign Cloud), the currency code must be <c>EUR</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public CurrencyCode CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property EstimationUrl. 
        /// <para>
        /// A URL providing additional information or context about the spend estimation.
        /// </para>
        /// </summary>
        public string EstimationUrl { get; set; }

        /// <summary>
        /// Checks to see if the EstimationUrl property is set.
        /// </summary>
        internal bool IsSetEstimationUrl() => this.EstimationUrl != null;

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// Indicates how frequently the customer is expected to spend the projected amount. Use
        /// <c>Monthly</c> for recurring monthly spend (required for <c>TargetCompany: "AWS"</c>
        /// entries). Use <c>None</c> for one-time deal value entries (required for <c>TargetCompany:
        /// "Self"</c> entries when providing Total Contract Value).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PaymentFrequency Frequency { get; set; }

        /// <summary>
        /// Checks to see if the Frequency property is set.
        /// </summary>
        internal bool IsSetFrequency() => this.Frequency != null;

        /// <summary>
        /// Gets and sets the property TargetCompany. 
        /// <para>
        /// Specifies the entity associated with this spend entry. Use <c>AWS</c> for the system’s
        /// AWS Monthly Recurring Revenue (MRR) estimate. Use <c>Self</c> for the partner’s own
        /// deal value entry when providing Total Contract Value (TCV) for automatic MRR conversion.
        /// When <c>ExpectedContractDuration</c> is present on the Project, only <c>AWS</c> and
        /// <c>Self</c> are accepted. When <c>ExpectedContractDuration</c> is not present, only
        /// <c>AWS</c> is accepted and any other value will be automatically set to <c>AWS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetCompany { get; set; }

        /// <summary>
        /// Checks to see if the TargetCompany property is set.
        /// </summary>
        internal bool IsSetTargetCompany() => this.TargetCompany != null;
    }
}
