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
    /// The configuration for the Savings Plans purchase analysis.
    /// </summary>
    public partial class SavingsPlansPurchaseAnalysisConfiguration
    {
        private string _accountId;
        private AccountScope _accountScope;
        private AnalysisType _analysisType;
        private DateInterval _lookBackTimePeriod;
        private List<SavingsPlans> _savingsPlansToAdd = AWSConfigs.InitializeCollections ? new List<SavingsPlans>() : null;
        private List<string> _savingsPlansToExclude = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account that the analysis is for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AccountScope. 
        /// <para>
        /// The account scope that you want your analysis for.
        /// </para>
        /// </summary>
        public AccountScope AccountScope
        {
            get { return this._accountScope; }
            set { this._accountScope = value; }
        }

        // Check to see if AccountScope property is set
        internal bool IsSetAccountScope()
        {
            return this._accountScope != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// The type of analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalysisType AnalysisType
        {
            get { return this._analysisType; }
            set { this._analysisType = value; }
        }

        // Check to see if AnalysisType property is set
        internal bool IsSetAnalysisType()
        {
            return this._analysisType != null;
        }

        /// <summary>
        /// Gets and sets the property LookBackTimePeriod. 
        /// <para>
        /// The time period associated with the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateInterval LookBackTimePeriod
        {
            get { return this._lookBackTimePeriod; }
            set { this._lookBackTimePeriod = value; }
        }

        // Check to see if LookBackTimePeriod property is set
        internal bool IsSetLookBackTimePeriod()
        {
            return this._lookBackTimePeriod != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsPlansToAdd. 
        /// <para>
        /// Savings Plans to include in the analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<SavingsPlans> SavingsPlansToAdd
        {
            get { return this._savingsPlansToAdd; }
            set { this._savingsPlansToAdd = value; }
        }

        // Check to see if SavingsPlansToAdd property is set
        internal bool IsSetSavingsPlansToAdd()
        {
            return this._savingsPlansToAdd != null && (this._savingsPlansToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SavingsPlansToExclude. 
        /// <para>
        /// Savings Plans to exclude from the analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<string> SavingsPlansToExclude
        {
            get { return this._savingsPlansToExclude; }
            set { this._savingsPlansToExclude = value; }
        }

        // Check to see if SavingsPlansToExclude property is set
        internal bool IsSetSavingsPlansToExclude()
        {
            return this._savingsPlansToExclude != null && (this._savingsPlansToExclude.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}