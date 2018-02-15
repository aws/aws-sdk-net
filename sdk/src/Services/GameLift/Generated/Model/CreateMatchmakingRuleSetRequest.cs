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
    /// acceptable player matches, such as minimum skill level or character type. Rule sets
    /// are used in matchmaking configurations, which define how matchmaking requests are
    /// handled. Each <a>MatchmakingConfiguration</a> uses one rule set; you can set up multiple
    /// rule sets to handle the scenarios that suit your game (such as for different game
    /// modes), and create a separate matchmaking configuration for each rule set. See additional
    /// information on rule set content in the <a>MatchmakingRuleSet</a> structure. For help
    /// creating rule sets, including useful examples, see the topic <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/match-intro.html">
    /// Adding FlexMatch to Your Game</a>.
    /// 
    ///  
    /// <para>
    /// Once created, matchmaking rule sets cannot be changed or deleted, so we recommend
    /// checking the rule set syntax using <a>ValidateMatchmakingRuleSet</a> before creating
    /// the rule set.
    /// </para>
    ///  
    /// <para>
    /// To create a matchmaking rule set, provide the set of rules and a unique name. Rule
    /// sets must be defined in the same region as the matchmaking configuration they will
    /// be used with. Rule sets cannot be edited or deleted. If you need to change a rule
    /// set, create a new one with the necessary edits and then update matchmaking configurations
    /// to use the new rule set.
    /// </para>
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
    public partial class CreateMatchmakingRuleSetRequest : AmazonGameLiftRequest
    {
        private string _name;
        private string _ruleSetBody;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Unique identifier for a matchmaking rule set. This name is used to identify the rule
        /// set associated with a matchmaking configuration.
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
        /// Collection of matchmaking rules, formatted as a JSON string. (Note that comments are
        /// not allowed in JSON, but most elements support a description field.)
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