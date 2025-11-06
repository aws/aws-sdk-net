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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Analysis details providing explanation for Contact Lens automation decision.
    /// </summary>
    public partial class EvaluationContactLensAnswerAnalysisDetails
    {
        private List<EvaluationAutomationRuleCategory> _matchedRuleCategories = AWSConfigs.InitializeCollections ? new List<EvaluationAutomationRuleCategory>() : null;

        /// <summary>
        /// Gets and sets the property MatchedRuleCategories. 
        /// <para>
        /// A list of match rule categories.
        /// </para>
        /// </summary>
        public List<EvaluationAutomationRuleCategory> MatchedRuleCategories
        {
            get { return this._matchedRuleCategories; }
            set { this._matchedRuleCategories = value; }
        }

        // Check to see if MatchedRuleCategories property is set
        internal bool IsSetMatchedRuleCategories()
        {
            return this._matchedRuleCategories != null && (this._matchedRuleCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}