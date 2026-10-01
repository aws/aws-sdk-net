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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Summary information about a quote.
    /// </summary>
    public partial class QuoteSummary
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the account that owns the quote.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The country code for the Outpost site location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Checks to see if the CountryCode property is set.
        /// </summary>
        internal bool IsSetCountryCode() => this.CountryCode != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the quote was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the quote.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The date the quote expires.
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The ARN of the Outpost associated with the quote.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the OutpostArn property is set.
        /// </summary>
        internal bool IsSetOutpostArn() => this.OutpostArn != null;

        /// <summary>
        /// Gets and sets the property QuoteId. 
        /// <para>
        /// The ID of the quote.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string QuoteId { get; set; }

        /// <summary>
        /// Checks to see if the QuoteId property is set.
        /// </summary>
        internal bool IsSetQuoteId() => this.QuoteId != null;

        /// <summary>
        /// Gets and sets the property QuoteOptions. 
        /// <para>
        /// The configuration and pricing options for the quote.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<QuoteOption> QuoteOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<QuoteOption>() : null;

        /// <summary>
        /// Checks to see if the QuoteOptions property is set.
        /// </summary>
        internal bool IsSetQuoteOptions() => this.QuoteOptions != null && (this.QuoteOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QuoteStatus. 
        /// <para>
        /// The status of the quote.
        /// </para>
        /// </summary>
        public QuoteStatus QuoteStatus { get; set; }

        /// <summary>
        /// Checks to see if the QuoteStatus property is set.
        /// </summary>
        internal bool IsSetQuoteStatus() => this.QuoteStatus != null;

        /// <summary>
        /// Gets and sets the property RequestedCapacities. 
        /// <para>
        /// The capacity requirements specified in the quote request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<QuoteCapacity> RequestedCapacities { get; set; } = AWSConfigs.InitializeCollections ? new List<QuoteCapacity>() : null;

        /// <summary>
        /// Checks to see if the RequestedCapacities property is set.
        /// </summary>
        internal bool IsSetRequestedCapacities() => this.RequestedCapacities != null && (this.RequestedCapacities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestedConstraints. 
        /// <para>
        /// The physical constraints specified in the quote request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<QuoteConstraint> RequestedConstraints { get; set; } = AWSConfigs.InitializeCollections ? new List<QuoteConstraint>() : null;

        /// <summary>
        /// Checks to see if the RequestedConstraints property is set.
        /// </summary>
        internal bool IsSetRequestedConstraints() => this.RequestedConstraints != null && (this.RequestedConstraints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestedPaymentOptions. 
        /// <para>
        /// The payment options specified in the quote request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<string> RequestedPaymentOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RequestedPaymentOptions property is set.
        /// </summary>
        internal bool IsSetRequestedPaymentOptions() => this.RequestedPaymentOptions != null && (this.RequestedPaymentOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestedPaymentTerms. 
        /// <para>
        /// The payment terms specified in the quote request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<string> RequestedPaymentTerms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RequestedPaymentTerms property is set.
        /// </summary>
        internal bool IsSetRequestedPaymentTerms() => this.RequestedPaymentTerms != null && (this.RequestedPaymentTerms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message about the status of the quote.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property SubmittedOrderId. 
        /// <para>
        /// The ID of the order submitted for the quote.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string SubmittedOrderId { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedOrderId property is set.
        /// </summary>
        internal bool IsSetSubmittedOrderId() => this.SubmittedOrderId != null;
    }
}
