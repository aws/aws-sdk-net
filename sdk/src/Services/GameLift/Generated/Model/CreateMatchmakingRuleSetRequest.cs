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
    /// Container for the parameters to the CreateMatchmakingRuleSet operation.
    /// Creates a new rule set for FlexMatch matchmaking. A rule set describes the type of
    /// match to create, such as the number and size of teams, and sets the parameters for
    /// acceptable player matches, such as minimum skill level or character type. A rule set
    /// is used by a <a>MatchmakingConfiguration</a>. 
    /// 
    ///  
    /// <para>
    /// To create a matchmaking rule set, provide unique rule set name and the rule set body
    /// in JSON format. Rule sets must be defined in the same region as the matchmaking configuration
    /// they will be used with.
    /// </para>
    ///  
    /// <para>
    /// Since matchmaking rule sets cannot be edited, it is a good idea to check the rule
    /// set syntax using <a>ValidateMatchmakingRuleSet</a> before creating a new rule set.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-rulesets.html">Build
    /// a Rule Set</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-configuration.html">Design
    /// a Matchmaker</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-intro.html">Matchmaking
    /// with FlexMatch</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related operations</b> 
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
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteMatchmakingRuleSet</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateMatchmakingRuleSetRequest : AmazonGameLiftRequest
    {
        private string _name;
        private string _ruleSetBody;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Unique identifier for a matchmaking rule set. A matchmaking configuration identifies
        /// the rule set it uses by this name value. (Note: The rule set name is different from
        /// the optional "name" field in the rule set body.) 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RuleSetBody. 
        /// <para>
        /// Collection of matchmaking rules, formatted as a JSON string. Note that comments are
        /// not allowed in JSON, but most elements support a description field.
        /// </para>
        /// </summary>
        public string RuleSetBody
        {
            get { return this._ruleSetBody; }
            set { this._ruleSetBody = value; }
        }

        // Check to see if RuleSetBody property is set
        internal bool IsSetRuleSetBody()
        {
            return this._ruleSetBody != null;
        }

    }
}