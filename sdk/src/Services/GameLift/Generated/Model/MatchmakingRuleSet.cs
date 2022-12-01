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
    /// Set of rule statements, used with FlexMatch, that determine how to build your player
    /// matches. Each rule set describes a type of group to be created and defines the parameters
    /// for acceptable player matches.
    /// 
    ///  
    /// <para>
    /// A rule set may define the following elements for a match. For detailed information
    /// and examples showing how to construct a rule set, see <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-rulesets.html">Build
    /// a FlexMatch rule set</a>. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Teams -- Required. A rule set must define one or multiple teams for the match and
    /// set minimum and maximum team sizes. For example, a rule set might describe a 4x4 match
    /// that requires all eight slots to be filled. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Player attributes -- Optional. These attributes specify a set of player characteristics
    /// to evaluate when looking for a match. Matchmaking requests that use a rule set with
    /// player attributes must provide the corresponding attribute values. For example, an
    /// attribute might specify a player's skill or level.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Rules -- Optional. Rules define how to evaluate potential players for a match based
    /// on player attributes. A rule might specify minimum requirements for individual players,
    /// teams, or entire matches. For example, a rule might require each player to meet a
    /// certain skill level, each team to have at least one player in a certain role, or the
    /// match to have a minimum average skill level. or may describe an entire group--such
    /// as all teams must be evenly matched or have at least one player in a certain role.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Expansions -- Optional. Expansions allow you to relax the rules after a period of
    /// time when no acceptable matches are found. This feature lets you balance getting players
    /// into games in a reasonable amount of time instead of making them wait indefinitely
    /// for the best possible match. For example, you might use an expansion to increase the
    /// maximum skill variance between players after 30 seconds.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class MatchmakingRuleSet
    {
        private DateTime? _creationTime;
        private string _ruleSetArn;
        private string _ruleSetBody;
        private string _ruleSetName;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example <code>"1469498468.057"</code>).
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleSetArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a GameLift matchmaking rule set resource and uniquely identifies
        /// it. ARNs are unique across all Regions. Format is <code>arn:aws:gamelift:&lt;region&gt;::matchmakingruleset/&lt;ruleset
        /// name&gt;</code>. In a GameLift rule set ARN, the resource ID matches the <i>RuleSetName</i>
        /// value.
        /// </para>
        /// </summary>
        public string RuleSetArn
        {
            get { return this._ruleSetArn; }
            set { this._ruleSetArn = value; }
        }

        // Check to see if RuleSetArn property is set
        internal bool IsSetRuleSetArn()
        {
            return this._ruleSetArn != null;
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
        /// Gets and sets the property RuleSetName. 
        /// <para>
        /// A unique identifier for the matchmaking rule set
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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