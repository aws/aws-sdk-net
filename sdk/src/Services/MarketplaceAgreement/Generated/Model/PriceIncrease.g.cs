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
    /// The price increase that is applied each time the agreement renews. Exactly one of
    /// the following fields is set.
    /// </summary>
    public partial class PriceIncrease
    {
        /// <summary>
        /// Gets and sets the property FixedPercentage. 
        /// <para>
        /// A fixed price increase percentage that is applied at each renewal.
        /// </para>
        /// </summary>
        public FixedPercentage FixedPercentage { get; set; }

        /// <summary>
        /// Checks to see if the FixedPercentage property is set.
        /// </summary>
        internal bool IsSetFixedPercentage() => this.FixedPercentage != null;

        /// <summary>
        /// Gets and sets the property PercentageRange. 
        /// <para>
        /// A range of price increase percentages that the proposer can choose from before the
        /// adjustment deadline of the agreement.
        /// </para>
        /// </summary>
        public PercentageRange PercentageRange { get; set; }

        /// <summary>
        /// Checks to see if the PercentageRange property is set.
        /// </summary>
        internal bool IsSetPercentageRange() => this.PercentageRange != null;
    }
}
