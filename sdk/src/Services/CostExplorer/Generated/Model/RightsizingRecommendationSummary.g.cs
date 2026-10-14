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
    /// The summary of rightsizing recommendations
    /// </summary>
    public partial class RightsizingRecommendationSummary
    {
        /// <summary>
        /// Gets and sets the property EstimatedTotalMonthlySavingsAmount. 
        /// <para>
        /// The estimated total savings resulting from modifications, on a monthly basis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedTotalMonthlySavingsAmount { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedTotalMonthlySavingsAmount property is set.
        /// </summary>
        internal bool IsSetEstimatedTotalMonthlySavingsAmount() => this.EstimatedTotalMonthlySavingsAmount != null;

        /// <summary>
        /// Gets and sets the property SavingsCurrencyCode. 
        /// <para>
        /// The currency code that Amazon Web Services used to calculate the savings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string SavingsCurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the SavingsCurrencyCode property is set.
        /// </summary>
        internal bool IsSetSavingsCurrencyCode() => this.SavingsCurrencyCode != null;

        /// <summary>
        /// Gets and sets the property SavingsPercentage. 
        /// <para>
        ///  The savings percentage based on the recommended modifications. It's relative to the
        /// total On-Demand costs that are associated with these instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string SavingsPercentage { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPercentage property is set.
        /// </summary>
        internal bool IsSetSavingsPercentage() => this.SavingsPercentage != null;

        /// <summary>
        /// Gets and sets the property TotalRecommendationCount. 
        /// <para>
        /// The total number of instance recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TotalRecommendationCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalRecommendationCount property is set.
        /// </summary>
        internal bool IsSetTotalRecommendationCount() => this.TotalRecommendationCount != null;
    }
}
