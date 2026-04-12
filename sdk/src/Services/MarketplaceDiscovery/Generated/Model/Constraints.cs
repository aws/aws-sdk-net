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
    /// Constraints that control how a buyer can configure a rate card.
    /// </summary>
    public partial class Constraints
    {
        private RateCardConstraintType _multipleDimensionSelection;
        private RateCardConstraintType _quantityConfiguration;

        /// <summary>
        /// Gets and sets the property MultipleDimensionSelection. 
        /// <para>
        /// Whether the buyer can select multiple dimensions. Values are <c>Allowed</c> or <c>Disallowed</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RateCardConstraintType MultipleDimensionSelection
        {
            get { return this._multipleDimensionSelection; }
            set { this._multipleDimensionSelection = value; }
        }

        // Check to see if MultipleDimensionSelection property is set
        internal bool IsSetMultipleDimensionSelection()
        {
            return this._multipleDimensionSelection != null;
        }

        /// <summary>
        /// Gets and sets the property QuantityConfiguration. 
        /// <para>
        /// Whether the buyer can configure quantities. Values are <c>Allowed</c> or <c>Disallowed</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RateCardConstraintType QuantityConfiguration
        {
            get { return this._quantityConfiguration; }
            set { this._quantityConfiguration = value; }
        }

        // Check to see if QuantityConfiguration property is set
        internal bool IsSetQuantityConfiguration()
        {
            return this._quantityConfiguration != null;
        }

    }
}