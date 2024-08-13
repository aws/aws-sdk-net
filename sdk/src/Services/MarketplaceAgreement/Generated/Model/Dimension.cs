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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
    /// Defines the dimensions that the acceptor has purchased from the overall set of dimensions
    /// presented in the rate card.
    /// </summary>
    public partial class Dimension
    {
        private string _dimensionKey;
        private int? _dimensionValue;

        /// <summary>
        /// Gets and sets the property DimensionKey. 
        /// <para>
        /// The name of key value of the dimension.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string DimensionKey
        {
            get { return this._dimensionKey; }
            set { this._dimensionKey = value; }
        }

        // Check to see if DimensionKey property is set
        internal bool IsSetDimensionKey()
        {
            return this._dimensionKey != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionValue. 
        /// <para>
        /// The number of units of the dimension the acceptor has purchased.
        /// </para>
        ///  <note> 
        /// <para>
        /// For Agreements with <c>ConfigurableUpfrontPricingTerm</c>, the <c>RateCard</c> section
        /// will define the prices and dimensions defined by the seller (proposer), whereas the
        /// <c>Configuration</c> section will define the actual dimensions, prices, and units
        /// the buyer has chosen to accept.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? DimensionValue
        {
            get { return this._dimensionValue; }
            set { this._dimensionValue = value; }
        }

        // Check to see if DimensionValue property is set
        internal bool IsSetDimensionValue()
        {
            return this._dimensionValue.HasValue; 
        }

    }
}