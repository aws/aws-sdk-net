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
    /// A summary of the capacity changes for a quote option.
    /// </summary>
    public partial class CapacitySummary
    {
        /// <summary>
        /// Gets and sets the property CapacityChange. 
        /// <para>
        /// The change in capacity between the existing and final state.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<QuoteCapacity> CapacityChange { get; set; } = AWSConfigs.InitializeCollections ? new List<QuoteCapacity>() : null;

        /// <summary>
        /// Checks to see if the CapacityChange property is set.
        /// </summary>
        internal bool IsSetCapacityChange() => this.CapacityChange != null && (this.CapacityChange.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExistingCapacities. 
        /// <para>
        /// The existing capacities on the Outpost before the quote is fulfilled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<QuoteCapacity> ExistingCapacities { get; set; } = AWSConfigs.InitializeCollections ? new List<QuoteCapacity>() : null;

        /// <summary>
        /// Checks to see if the ExistingCapacities property is set.
        /// </summary>
        internal bool IsSetExistingCapacities() => this.ExistingCapacities != null && (this.ExistingCapacities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FinalCapacities. 
        /// <para>
        /// The final capacities on the Outpost after the quote is fulfilled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<QuoteCapacity> FinalCapacities { get; set; } = AWSConfigs.InitializeCollections ? new List<QuoteCapacity>() : null;

        /// <summary>
        /// Checks to see if the FinalCapacities property is set.
        /// </summary>
        internal bool IsSetFinalCapacities() => this.FinalCapacities != null && (this.FinalCapacities.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
