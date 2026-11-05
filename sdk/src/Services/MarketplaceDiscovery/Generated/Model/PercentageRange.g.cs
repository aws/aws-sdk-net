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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// A price increase percentage range with minimum, maximum, and default values.
    /// </summary>
    public partial class PercentageRange
    {
        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The percentage increase applied by default when no other value is finalized before
        /// the adjustment deadline. Falls between <c>minimumValue</c> and <c>maximumValue</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property MaximumValue. 
        /// <para>
        /// The maximum percentage by which the price can increase at each renewal cycle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string MaximumValue { get; set; }

        /// <summary>
        /// Checks to see if the MaximumValue property is set.
        /// </summary>
        internal bool IsSetMaximumValue() => this.MaximumValue != null;

        /// <summary>
        /// Gets and sets the property MinimumValue. 
        /// <para>
        /// The minimum percentage by which the price can increase at each renewal cycle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string MinimumValue { get; set; }

        /// <summary>
        /// Checks to see if the MinimumValue property is set.
        /// </summary>
        internal bool IsSetMinimumValue() => this.MinimumValue != null;
    }
}
