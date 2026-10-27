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
    /// A range of price increase percentages that the proposer can choose from before the
    /// adjustment deadline of the agreement.
    /// 
    ///  
    /// <para>
    ///  <c>MinValue</c> will be less than <c>MaxValue</c>, and <c>DefaultValue</c> will fall
    /// within the range. When the proposer authorizes a single percentage instead of a range,
    /// <c>PriceIncrease</c> is a <c>FixedPercentage</c> rather than a <c>PercentageRange</c>.
    /// </para>
    /// </summary>
    public partial class PercentageRange
    {
        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The percentage that is applied if the proposer doesn't choose a value before the adjustment
        /// deadline. Valid values range from <c>0.00</c> to <c>100.00</c>, with up to two decimal
        /// places.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// The highest percentage that the proposer can choose, from <c>0.00</c> to <c>100.00</c>
        /// with up to two decimal places.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6)]
        public string MaxValue { get; set; }

        /// <summary>
        /// Checks to see if the MaxValue property is set.
        /// </summary>
        internal bool IsSetMaxValue() => this.MaxValue != null;

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// The lowest percentage that the proposer can choose, from <c>0.00</c> to <c>100.00</c>
        /// with up to two decimal places.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6)]
        public string MinValue { get; set; }

        /// <summary>
        /// Checks to see if the MinValue property is set.
        /// </summary>
        internal bool IsSetMinValue() => this.MinValue != null;
    }
}
