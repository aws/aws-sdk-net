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
    /// A configuration and pricing option for a quote. Each option includes the capacity
    /// breakdown, physical specifications for the racks or servers, and pricing details.
    /// </summary>
    public partial class QuoteOption
    {
        /// <summary>
        /// Gets and sets the property Capacities. 
        /// <para>
        /// The capacities included in this quote option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<QuoteCapacity> Capacities { get; set; } = AWSConfigs.InitializeCollections ? new List<QuoteCapacity>() : null;

        /// <summary>
        /// Checks to see if the Capacities property is set.
        /// </summary>
        internal bool IsSetCapacities() => this.Capacities != null && (this.Capacities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CapacitySummary. 
        /// <para>
        /// A summary of the existing, final, and changed capacity for this quote option.
        /// </para>
        /// </summary>
        public CapacitySummary CapacitySummary { get; set; }

        /// <summary>
        /// Checks to see if the CapacitySummary property is set.
        /// </summary>
        internal bool IsSetCapacitySummary() => this.CapacitySummary != null;

        /// <summary>
        /// Gets and sets the property PricingOptions. 
        /// <para>
        /// The pricing options for this quote option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 9)]
        public List<PricingOption> PricingOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<PricingOption>() : null;

        /// <summary>
        /// Checks to see if the PricingOptions property is set.
        /// </summary>
        internal bool IsSetPricingOptions() => this.PricingOptions != null && (this.PricingOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QuoteOptionIdentifier. 
        /// <para>
        /// The ID of the quote option.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 21)]
        public string QuoteOptionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the QuoteOptionIdentifier property is set.
        /// </summary>
        internal bool IsSetQuoteOptionIdentifier() => this.QuoteOptionIdentifier != null;

        /// <summary>
        /// Gets and sets the property Specifications. 
        /// <para>
        /// The physical specifications for the racks or servers in this quote option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<QuoteSpecification> Specifications { get; set; } = AWSConfigs.InitializeCollections ? new List<QuoteSpecification>() : null;

        /// <summary>
        /// Checks to see if the Specifications property is set.
        /// </summary>
        internal bool IsSetSpecifications() => this.Specifications != null && (this.Specifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
