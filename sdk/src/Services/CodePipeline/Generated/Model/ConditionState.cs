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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Information about the state of the condition.
    /// </summary>
    public partial class ConditionState
    {
        private ConditionExecution _latestExecution;
        private List<RuleState> _ruleStates = AWSConfigs.InitializeCollections ? new List<RuleState>() : null;

        /// <summary>
        /// Gets and sets the property LatestExecution. 
        /// <para>
        /// The state of the latest run of the rule.
        /// </para>
        /// </summary>
        public ConditionExecution LatestExecution
        {
            get { return this._latestExecution; }
            set { this._latestExecution = value; }
        }

        // Check to see if LatestExecution property is set
        internal bool IsSetLatestExecution()
        {
            return this._latestExecution != null;
        }

        /// <summary>
        /// Gets and sets the property RuleStates. 
        /// <para>
        /// The state of the rules for the condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleState> RuleStates
        {
            get { return this._ruleStates; }
            set { this._ruleStates = value; }
        }

        // Check to see if RuleStates property is set
        internal bool IsSetRuleStates()
        {
            return this._ruleStates != null && (this._ruleStates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}