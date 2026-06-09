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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
        private List<QuoteCapacity> _capacities = AWSConfigs.InitializeCollections ? new List<QuoteCapacity>() : null;
        private CapacitySummary _capacitySummary;
        private List<PricingOption> _pricingOptions = AWSConfigs.InitializeCollections ? new List<PricingOption>() : null;
        private string _quoteOptionIdentifier;
        private List<QuoteSpecification> _specifications = AWSConfigs.InitializeCollections ? new List<QuoteSpecification>() : null;

        /// <summary>
        /// Gets and sets the property Capacities. 
        /// <para>
        /// The capacities included in this quote option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=2000)]
        public List<QuoteCapacity> Capacities
        {
            get { return this._capacities; }
            set { this._capacities = value; }
        }

        // Check to see if Capacities property is set
        internal bool IsSetCapacities()
        {
            return this._capacities != null && (this._capacities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CapacitySummary. 
        /// <para>
        /// A summary of the existing, final, and changed capacity for this quote option.
        /// </para>
        /// </summary>
        public CapacitySummary CapacitySummary
        {
            get { return this._capacitySummary; }
            set { this._capacitySummary = value; }
        }

        // Check to see if CapacitySummary property is set
        internal bool IsSetCapacitySummary()
        {
            return this._capacitySummary != null;
        }

        /// <summary>
        /// Gets and sets the property PricingOptions. 
        /// <para>
        /// The pricing options for this quote option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=9)]
        public List<PricingOption> PricingOptions
        {
            get { return this._pricingOptions; }
            set { this._pricingOptions = value; }
        }

        // Check to see if PricingOptions property is set
        internal bool IsSetPricingOptions()
        {
            return this._pricingOptions != null && (this._pricingOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QuoteOptionIdentifier. 
        /// <para>
        /// The ID of the quote option.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=21)]
        public string QuoteOptionIdentifier
        {
            get { return this._quoteOptionIdentifier; }
            set { this._quoteOptionIdentifier = value; }
        }

        // Check to see if QuoteOptionIdentifier property is set
        internal bool IsSetQuoteOptionIdentifier()
        {
            return this._quoteOptionIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Specifications. 
        /// <para>
        /// The physical specifications for the racks or servers in this quote option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<QuoteSpecification> Specifications
        {
            get { return this._specifications; }
            set { this._specifications = value; }
        }

        // Check to see if Specifications property is set
        internal bool IsSetSpecifications()
        {
            return this._specifications != null && (this._specifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}