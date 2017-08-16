/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeMatchmakingConfigurations operation.
    /// Retrieves the details of FlexMatch matchmaking configurations. with this operation,
    /// you have the following options: (1) retrieve all existing configurations, (2) provide
    /// the names of one or more configurations to retrieve, or (3) retrieve all configurations
    /// that use a specified rule set name. When requesting multiple items, use the pagination
    /// parameters to retrieve results as a set of sequential pages. If successful, a configuration
    /// is returned for each requested name. When specifying a list of names, only configurations
    /// that currently exist are returned. 
    /// 
    ///  
    /// <para>
    /// Operations related to match configurations and rule sets include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateMatchmakingConfiguration</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeMatchmakingConfigurations</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateMatchmakingConfiguration</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteMatchmakingConfiguration</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateMatchmakingRuleSet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeMatchmakingRuleSets</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ValidateMatchmakingRuleSet</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeMatchmakingConfigurationsRequest : AmazonGameLiftRequest
    {
        private int? _limit;
        private List<string> _names = new List<string>();
        private string _nextToken;
        private string _ruleSetName;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Maximum number of results to return. Use this parameter with <code>NextToken</code>
        /// to get results as a set of sequential pages. This parameter is limited to 10.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// Unique identifier for a matchmaking configuration(s) to retrieve. To request all existing
        /// configurations, leave this parameter empty.
        /// </para>
        /// </summary>
        public List<string> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && this._names.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this action. To start at the beginning of
        /// the result set, do not specify a value.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RuleSetName. 
        /// <para>
        /// Unique identifier for a matchmaking rule set. Use this parameter to retrieve all matchmaking
        /// configurations that use this rule set.
        /// </para>
        /// </summary>
        public string RuleSetName
        {
            get { return this._ruleSetName; }
            set { this._ruleSetName = value; }
        }

        // Check to see if RuleSetName property is set
        internal bool IsSetRuleSetName()
        {
            return this._ruleSetName != null;
        }

    }
}