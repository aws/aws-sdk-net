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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains a recommendation for bot optimization identified by the Bot Analyzer.
    /// </summary>
    public partial class BotAnalyzerRecommendation
    {
        private string _issueDescription;
        private IssueLocation _issueLocation;
        private Priority _priority;
        private string _proposedFix;

        /// <summary>
        /// Gets and sets the property IssueDescription. 
        /// <para>
        /// A detailed description of the identified configuration issue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2000)]
        public string IssueDescription
        {
            get { return this._issueDescription; }
            set { this._issueDescription = value; }
        }

        // Check to see if IssueDescription property is set
        internal bool IsSetIssueDescription()
        {
            return this._issueDescription != null;
        }

        /// <summary>
        /// Gets and sets the property IssueLocation. 
        /// <para>
        /// The location information for the identified issue within the bot configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IssueLocation IssueLocation
        {
            get { return this._issueLocation; }
            set { this._issueLocation = value; }
        }

        // Check to see if IssueLocation property is set
        internal bool IsSetIssueLocation()
        {
            return this._issueLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority level of the recommendation.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>High | Medium | Low</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Priority Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority != null;
        }

        /// <summary>
        /// Gets and sets the property ProposedFix. 
        /// <para>
        /// The recommended solution to address the identified issue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2000)]
        public string ProposedFix
        {
            get { return this._proposedFix; }
            set { this._proposedFix = value; }
        }

        // Check to see if ProposedFix property is set
        internal bool IsSetProposedFix()
        {
            return this._proposedFix != null;
        }

    }
}