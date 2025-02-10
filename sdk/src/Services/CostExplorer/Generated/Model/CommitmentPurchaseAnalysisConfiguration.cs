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
    /// The configuration for the commitment purchase analysis.
    /// </summary>
    public partial class CommitmentPurchaseAnalysisConfiguration
    {
        private SavingsPlansPurchaseAnalysisConfiguration _savingsPlansPurchaseAnalysisConfiguration;

        /// <summary>
        /// Gets and sets the property SavingsPlansPurchaseAnalysisConfiguration. 
        /// <para>
        /// The configuration for the Savings Plans purchase analysis.
        /// </para>
        /// </summary>
        public SavingsPlansPurchaseAnalysisConfiguration SavingsPlansPurchaseAnalysisConfiguration
        {
            get { return this._savingsPlansPurchaseAnalysisConfiguration; }
            set { this._savingsPlansPurchaseAnalysisConfiguration = value; }
        }

        // Check to see if SavingsPlansPurchaseAnalysisConfiguration property is set
        internal bool IsSetSavingsPlansPurchaseAnalysisConfiguration()
        {
            return this._savingsPlansPurchaseAnalysisConfiguration != null;
        }

    }
}