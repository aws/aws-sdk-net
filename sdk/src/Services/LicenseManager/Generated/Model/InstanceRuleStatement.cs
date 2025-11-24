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
    /// Instance rule statement.
    /// </summary>
    public partial class InstanceRuleStatement
    {
        private AndRuleStatement _andRuleStatement;
        private MatchingRuleStatement _matchingRuleStatement;
        private OrRuleStatement _orRuleStatement;
        private ScriptRuleStatement _scriptRuleStatement;

        /// <summary>
        /// Gets and sets the property AndRuleStatement. 
        /// <para>
        /// AND rule statement.
        /// </para>
        /// </summary>
        public AndRuleStatement AndRuleStatement
        {
            get { return this._andRuleStatement; }
            set { this._andRuleStatement = value; }
        }

        // Check to see if AndRuleStatement property is set
        internal bool IsSetAndRuleStatement()
        {
            return this._andRuleStatement != null;
        }

        /// <summary>
        /// Gets and sets the property MatchingRuleStatement. 
        /// <para>
        /// Matching rule statement.
        /// </para>
        /// </summary>
        public MatchingRuleStatement MatchingRuleStatement
        {
            get { return this._matchingRuleStatement; }
            set { this._matchingRuleStatement = value; }
        }

        // Check to see if MatchingRuleStatement property is set
        internal bool IsSetMatchingRuleStatement()
        {
            return this._matchingRuleStatement != null;
        }

        /// <summary>
        /// Gets and sets the property OrRuleStatement. 
        /// <para>
        /// OR rule statement.
        /// </para>
        /// </summary>
        public OrRuleStatement OrRuleStatement
        {
            get { return this._orRuleStatement; }
            set { this._orRuleStatement = value; }
        }

        // Check to see if OrRuleStatement property is set
        internal bool IsSetOrRuleStatement()
        {
            return this._orRuleStatement != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptRuleStatement. 
        /// <para>
        /// Script rule statement.
        /// </para>
        /// </summary>
        public ScriptRuleStatement ScriptRuleStatement
        {
            get { return this._scriptRuleStatement; }
            set { this._scriptRuleStatement = value; }
        }

        // Check to see if ScriptRuleStatement property is set
        internal bool IsSetScriptRuleStatement()
        {
            return this._scriptRuleStatement != null;
        }

    }
}