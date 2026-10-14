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
    /// The dollar value of the anomaly.
    /// </summary>
    public partial class Impact
    {
        /// <summary>
        /// Gets and sets the property MaxImpact. 
        /// <para>
        /// The maximum dollar value that's observed for an anomaly.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? MaxImpact { get; set; }

        /// <summary>
        /// Checks to see if the MaxImpact property is set.
        /// </summary>
        internal bool IsSetMaxImpact() => this.MaxImpact.HasValue;

        /// <summary>
        /// Gets and sets the property TotalActualSpend. 
        /// <para>
        /// The cumulative dollar amount that was actually spent during the anomaly.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? TotalActualSpend { get; set; }

        /// <summary>
        /// Checks to see if the TotalActualSpend property is set.
        /// </summary>
        internal bool IsSetTotalActualSpend() => this.TotalActualSpend.HasValue;

        /// <summary>
        /// Gets and sets the property TotalExpectedSpend. 
        /// <para>
        /// The cumulative dollar amount that was expected to be spent during the anomaly. It
        /// is calculated using advanced machine learning models to determine the typical spending
        /// pattern based on historical data for a customer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? TotalExpectedSpend { get; set; }

        /// <summary>
        /// Checks to see if the TotalExpectedSpend property is set.
        /// </summary>
        internal bool IsSetTotalExpectedSpend() => this.TotalExpectedSpend.HasValue;

        /// <summary>
        /// Gets and sets the property TotalImpact. 
        /// <para>
        /// The cumulative dollar difference between the total actual spend and total expected
        /// spend. It is calculated as <c>TotalActualSpend - TotalExpectedSpend</c>.
        /// </para>
        /// </summary>
        public double? TotalImpact { get; set; }

        /// <summary>
        /// Checks to see if the TotalImpact property is set.
        /// </summary>
        internal bool IsSetTotalImpact() => this.TotalImpact.HasValue;

        /// <summary>
        /// Gets and sets the property TotalImpactPercentage. 
        /// <para>
        /// The cumulative percentage difference between the total actual spend and total expected
        /// spend. It is calculated as <c>(TotalImpact / TotalExpectedSpend) * 100</c>. When <c>TotalExpectedSpend</c>
        /// is zero, this field is omitted. Expected spend can be zero in situations such as when
        /// you start to use a service for the first time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? TotalImpactPercentage { get; set; }

        /// <summary>
        /// Checks to see if the TotalImpactPercentage property is set.
        /// </summary>
        internal bool IsSetTotalImpactPercentage() => this.TotalImpactPercentage.HasValue;
    }
}
