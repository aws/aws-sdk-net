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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// A rate card item within a configurable upfront pricing term, including a selector
    /// for choosing the configuration and per-unit rates.
    /// </summary>
    public partial class ConfigurableUpfrontRateCardItem
    {
        private Constraints _constraints;
        private List<RateCardItem> _rateCard = AWSConfigs.InitializeCollections ? new List<RateCardItem>() : null;
        private Selector _selector;

        /// <summary>
        /// Gets and sets the property Constraints. 
        /// <para>
        /// Constraints on how the buyer can configure this rate card, such as whether multiple
        /// dimensions can be selected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Constraints Constraints
        {
            get { return this._constraints; }
            set { this._constraints = value; }
        }

        // Check to see if Constraints property is set
        internal bool IsSetConstraints()
        {
            return this._constraints != null;
        }

        /// <summary>
        /// Gets and sets the property RateCard. 
        /// <para>
        /// The per-unit rates for this configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RateCardItem> RateCard
        {
            get { return this._rateCard; }
            set { this._rateCard = value; }
        }

        // Check to see if RateCard property is set
        internal bool IsSetRateCard()
        {
            return this._rateCard != null && (this._rateCard.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Selector. 
        /// <para>
        /// The selector criteria for this rate card, such as duration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Selector Selector
        {
            get { return this._selector; }
            set { this._selector = value; }
        }

        // Check to see if Selector property is set
        internal bool IsSetSelector()
        {
            return this._selector != null;
        }

    }
}