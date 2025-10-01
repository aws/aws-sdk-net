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
    /// Output parameters for privacy budget templates with access budgets support, containing
    /// the configured budget information.
    /// </summary>
    public partial class AccessBudgetsPrivacyTemplateParametersOutput
    {
        private List<BudgetParameter> _budgetParameters = AWSConfigs.InitializeCollections ? new List<BudgetParameter>() : null;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property BudgetParameters. 
        /// <para>
        /// An array of budget parameters returned from the access budget configuration.
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

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource associated with this privacy budget
        /// template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}