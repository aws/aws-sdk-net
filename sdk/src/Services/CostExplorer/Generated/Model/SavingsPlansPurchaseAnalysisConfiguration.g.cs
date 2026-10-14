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
    /// The configuration for the Savings Plans purchase analysis.
    /// </summary>
    public partial class SavingsPlansPurchaseAnalysisConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account that the analysis is for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AccountScope. 
        /// <para>
        /// The account scope that you want your analysis for.
        /// </para>
        /// </summary>
        public AccountScope AccountScope { get; set; }

        /// <summary>
        /// Checks to see if the AccountScope property is set.
        /// </summary>
        internal bool IsSetAccountScope() => this.AccountScope != null;

        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// The type of analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalysisType AnalysisType { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisType property is set.
        /// </summary>
        internal bool IsSetAnalysisType() => this.AnalysisType != null;

        /// <summary>
        /// Gets and sets the property LookBackTimePeriod. 
        /// <para>
        /// The time period associated with the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateInterval LookBackTimePeriod { get; set; }

        /// <summary>
        /// Checks to see if the LookBackTimePeriod property is set.
        /// </summary>
        internal bool IsSetLookBackTimePeriod() => this.LookBackTimePeriod != null;

        /// <summary>
        /// Gets and sets the property SavingsPlansTargetCoverage. 
        /// <para>
        /// Specifies the target Savings Plans coverage as a percentage from <c>10</c> to <c>100</c>.
        /// This field is required when <c>AnalysisType</c> is <c>TARGET_AVERAGE_COVERAGE</c>.
        /// It defines the target average hourly coverage that the recommended Savings Plans commitment
        /// should achieve over the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 100)]
        public int? SavingsPlansTargetCoverage { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlansTargetCoverage property is set.
        /// </summary>
        internal bool IsSetSavingsPlansTargetCoverage() => this.SavingsPlansTargetCoverage.HasValue;

        /// <summary>
        /// Gets and sets the property SavingsPlansToAdd. 
        /// <para>
        /// Savings Plans to include in the analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<SavingsPlans> SavingsPlansToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<SavingsPlans>() : null;

        /// <summary>
        /// Checks to see if the SavingsPlansToAdd property is set.
        /// </summary>
        internal bool IsSetSavingsPlansToAdd() => this.SavingsPlansToAdd != null && (this.SavingsPlansToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SavingsPlansToExclude. 
        /// <para>
        /// Savings Plans to exclude from the analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<string> SavingsPlansToExclude { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SavingsPlansToExclude property is set.
        /// </summary>
        internal bool IsSetSavingsPlansToExclude() => this.SavingsPlansToExclude != null && (this.SavingsPlansToExclude.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
