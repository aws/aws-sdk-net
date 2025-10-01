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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Update parameters for privacy budget templates with access budgets functionality,
    /// allowing modification of existing budget configurations.
    /// </summary>
    public partial class AccessBudgetsPrivacyTemplateUpdateParameters
    {
        private List<BudgetParameter> _budgetParameters = AWSConfigs.InitializeCollections ? new List<BudgetParameter>() : null;

        /// <summary>
        /// Gets and sets the property BudgetParameters. 
        /// <para>
        /// Updated array of budget parameters for the access budget configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<BudgetParameter> BudgetParameters
        {
            get { return this._budgetParameters; }
            set { this._budgetParameters = value; }
        }

        // Check to see if BudgetParameters property is set
        internal bool IsSetBudgetParameters()
        {
            return this._budgetParameters != null && (this._budgetParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}