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
    /// Container for the parameters to the UpdateQuote operation. Updates the specified quote.
    /// You can modify the requested capacities, constraints, payment options, payment terms,
    /// or Outpost association.
    /// </summary>
    public partial class UpdateQuoteRequest : AmazonOutpostsRequest
    {
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the quote.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property OutpostIdentifier. 
        /// <para>
        /// The ID or ARN of the Outpost to associate with the quote. Specify an empty string
        /// to remove the Outpost association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 180)]
        public string OutpostIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OutpostIdentifier property is set.
        /// </summary>
        internal bool IsSetOutpostIdentifier() => this.OutpostIdentifier != null;

        /// <summary>
        /// Gets and sets the property QuoteIdentifier. 
        /// <para>
        /// The ID of the quote.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string QuoteIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the QuoteIdentifier property is set.
        /// </summary>
        internal bool IsSetQuoteIdentifier() => this.QuoteIdentifier != null;

        /// <summary>
        /// Gets and sets the property RequestedCapacities. 
        /// <para>
        /// The updated capacity requirements for the quote.
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
        /// The updated physical constraints for the quote.
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
        /// The updated payment options to include in the quote pricing.
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
        /// The updated payment terms to include in the quote pricing.
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
    }
}
