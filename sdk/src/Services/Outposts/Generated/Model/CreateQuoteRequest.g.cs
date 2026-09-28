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
    /// Container for the parameters to the CreateQuote operation. Creates a quote for an
    /// Outpost. A quote provides pricing and configuration options based on the requested
    /// capacity. You can optionally associate the quote with an existing Outpost or create
    /// a standalone quote by specifying only the country code and requested capacities.
    /// </summary>
    public partial class CreateQuoteRequest : AmazonOutpostsRequest
    {
        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The country code for the Outpost site location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
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
        /// The ID or ARN of the Outpost to associate with the quote. If not specified, the quote
        /// is created without an Outpost association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 180)]
        public string OutpostIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OutpostIdentifier property is set.
        /// </summary>
        internal bool IsSetOutpostIdentifier() => this.OutpostIdentifier != null;

        /// <summary>
        /// Gets and sets the property RequestedCapacities. 
        /// <para>
        /// The capacity requirements for the quote. Each entry specifies a capacity type (such
        /// as Amazon EC2), the unit, and the quantity. For Amazon EC2, the quantity is the number
        /// of additional instances to add to the Outpost. For Amazon EBS and Amazon S3, the quantity
        /// is the total desired end-state capacity of the Outpost.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2000)]
        public List<QuoteCapacity> RequestedCapacities { get; set; } = AWSConfigs.InitializeCollections ? new List<QuoteCapacity>() : null;

        /// <summary>
        /// Checks to see if the RequestedCapacities property is set.
        /// </summary>
        internal bool IsSetRequestedCapacities() => this.RequestedCapacities != null && (this.RequestedCapacities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestedConstraints. 
        /// <para>
        /// The physical constraints for the quote, such as maximum number of racks, maximum power
        /// draw per rack, or maximum weight per rack.
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
        /// The payment options to include in the quote pricing. If not specified, all available
        /// payment options are returned.
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
        /// The payment terms to include in the quote pricing. If not specified, all available
        /// payment terms are returned.
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
