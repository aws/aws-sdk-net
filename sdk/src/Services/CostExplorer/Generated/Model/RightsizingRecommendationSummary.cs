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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
        private string _estimatedTotalMonthlySavingsAmount;
        private string _savingsCurrencyCode;
        private string _savingsPercentage;
        private string _totalRecommendationCount;

        /// <summary>
        /// Gets and sets the property EstimatedTotalMonthlySavingsAmount. 
        /// <para>
        /// The estimated total savings resulting from modifications, on a monthly basis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedTotalMonthlySavingsAmount
        {
            get { return this._estimatedTotalMonthlySavingsAmount; }
            set { this._estimatedTotalMonthlySavingsAmount = value; }
        }

        // Check to see if EstimatedTotalMonthlySavingsAmount property is set
        internal bool IsSetEstimatedTotalMonthlySavingsAmount()
        {
            return this._estimatedTotalMonthlySavingsAmount != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsCurrencyCode. 
        /// <para>
        /// The currency code that Amazon Web Services used to calculate the savings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SavingsCurrencyCode
        {
            get { return this._savingsCurrencyCode; }
            set { this._savingsCurrencyCode = value; }
        }

        // Check to see if SavingsCurrencyCode property is set
        internal bool IsSetSavingsCurrencyCode()
        {
            return this._savingsCurrencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsPercentage. 
        /// <para>
        ///  The savings percentage based on the recommended modifications. It's relative to the
        /// total On-Demand costs that are associated with these instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SavingsPercentage
        {
            get { return this._savingsPercentage; }
            set { this._savingsPercentage = value; }
        }

        // Check to see if SavingsPercentage property is set
        internal bool IsSetSavingsPercentage()
        {
            return this._savingsPercentage != null;
        }

        /// <summary>
        /// Gets and sets the property TotalRecommendationCount. 
        /// <para>
        /// The total number of instance recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string TotalRecommendationCount
        {
            get { return this._totalRecommendationCount; }
            set { this._totalRecommendationCount = value; }
        }

        // Check to see if TotalRecommendationCount property is set
        internal bool IsSetTotalRecommendationCount()
        {
            return this._totalRecommendationCount != null;
        }

    }
}