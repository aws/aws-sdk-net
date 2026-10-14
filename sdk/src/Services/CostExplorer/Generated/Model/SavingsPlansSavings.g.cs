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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The amount of savings that you're accumulating, against the public On-Demand rate
    /// of the usage accrued in an account.
    /// </summary>
    public partial class SavingsPlansSavings
    {
        /// <summary>
        /// Gets and sets the property NetSavings. 
        /// <para>
        /// The savings amount that you're accumulating for the usage that's covered by a Savings
        /// Plans, when compared to the On-Demand equivalent of the same usage.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NetSavings { get; set; }

        /// <summary>
        /// Checks to see if the NetSavings property is set.
        /// </summary>
        internal bool IsSetNetSavings() => this.NetSavings != null;

        /// <summary>
        /// Gets and sets the property OnDemandCostEquivalent. 
        /// <para>
        /// How much the amount that the usage would have cost if it was accrued at the On-Demand
        /// rate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string OnDemandCostEquivalent { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandCostEquivalent property is set.
        /// </summary>
        internal bool IsSetOnDemandCostEquivalent() => this.OnDemandCostEquivalent != null;
    }
}
