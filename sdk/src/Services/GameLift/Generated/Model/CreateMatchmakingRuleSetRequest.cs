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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMatchmakingRuleSet operation.
    /// Creates a new rule set for FlexMatch matchmaking. A rule set describes the type of
    /// match to create, such as the number and size of teams. It also sets the parameters
    /// for acceptable player matches, such as minimum skill level or character type.
    /// 
    ///  
    /// <para>
    /// To create a matchmaking rule set, provide unique rule set name and the rule set body
    /// in JSON format. Rule sets must be defined in the same Region as the matchmaking configuration
    /// they are used with.
    /// </para>
    ///  
    /// <para>
    /// Since matchmaking rule sets cannot be edited, it is a good idea to check the rule
    /// set syntax using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ValidateMatchmakingRuleSet.html">ValidateMatchmakingRuleSet</a>
    /// before creating a new rule set.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-rulesets.html">Build
    /// a rule set</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-configuration.html">Design
    /// a matchmaker</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-intro.html">Matchmaking
    /// with FlexMatch</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateMatchmakingRuleSetRequest : AmazonGameLiftRequest
    {
        private string _name;
        private string _ruleSetBody;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique identifier for the matchmaking rule set. A matchmaking configuration identifies
        /// the rule set it uses by this name value. Note that the rule set name is different
        /// from the optional <code>name</code> field in the rule set body.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
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
        /// A collection of matchmaking rules, formatted as a JSON string. Comments are not allowed
        /// in JSON, but most elements support a description field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of labels to assign to the new matchmaking rule set resource. Tags are developer-defined
        /// key-value pairs. Tagging Amazon Web Services resources are useful for resource management,
        /// access management and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}