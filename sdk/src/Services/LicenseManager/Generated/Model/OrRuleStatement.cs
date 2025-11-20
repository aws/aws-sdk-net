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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// OR rule statement.
    /// </summary>
    public partial class OrRuleStatement
    {
        private List<MatchingRuleStatement> _matchingRuleStatements = AWSConfigs.InitializeCollections ? new List<MatchingRuleStatement>() : null;
        private List<ScriptRuleStatement> _scriptRuleStatements = AWSConfigs.InitializeCollections ? new List<ScriptRuleStatement>() : null;

        /// <summary>
        /// Gets and sets the property MatchingRuleStatements. 
        /// <para>
        /// Matching rule statements.
        /// </para>
        /// </summary>
        public List<MatchingRuleStatement> MatchingRuleStatements
        {
            get { return this._matchingRuleStatements; }
            set { this._matchingRuleStatements = value; }
        }

        // Check to see if MatchingRuleStatements property is set
        internal bool IsSetMatchingRuleStatements()
        {
            return this._matchingRuleStatements != null && (this._matchingRuleStatements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScriptRuleStatements. 
        /// <para>
        /// Script rule statements.
        /// </para>
        /// </summary>
        public List<ScriptRuleStatement> ScriptRuleStatements
        {
            get { return this._scriptRuleStatements; }
            set { this._scriptRuleStatements = value; }
        }

        // Check to see if ScriptRuleStatements property is set
        internal bool IsSetScriptRuleStatements()
        {
            return this._scriptRuleStatements != null && (this._scriptRuleStatements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}