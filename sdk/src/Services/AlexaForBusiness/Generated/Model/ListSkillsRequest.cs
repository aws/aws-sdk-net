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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the ListSkills operation.
    /// Lists all enabled skills in a specific skill group.
    /// </summary>
    public partial class ListSkillsRequest : AmazonAlexaForBusinessRequest
    {
        private EnablementTypeFilter _enablementType;
        private int? _maxResults;
        private string _nextToken;
        private string _skillGroupArn;
        private SkillTypeFilter _skillType;

        /// <summary>
        /// Gets and sets the property EnablementType. 
        /// <para>
        /// Whether the skill is enabled under the user's account, or if it requires linking to
        /// be used.
        /// </para>
        /// </summary>
        public EnablementTypeFilter EnablementType
        {
            get { return this._enablementType; }
            set { this._enablementType = value; }
        }

        // Check to see if EnablementType property is set
        internal bool IsSetEnablementType()
        {
            return this._enablementType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to include in the response. If more results exist than
        /// the specified <code>MaxResults</code> value, a token is included in the response so
        /// that the remaining results can be retrieved.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional token returned from a prior request. Use this token for pagination of
        /// results from this action. If this parameter is specified, the response includes only
        /// results beyond the token, up to the value specified by <code>MaxResults</code>.
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
        /// Gets and sets the property SkillGroupArn. 
        /// <para>
        /// The ARN of the skill group for which to list enabled skills.
        /// </para>
        /// </summary>
        public string SkillGroupArn
        {
            get { return this._skillGroupArn; }
            set { this._skillGroupArn = value; }
        }

        // Check to see if SkillGroupArn property is set
        internal bool IsSetSkillGroupArn()
        {
            return this._skillGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property SkillType. 
        /// <para>
        /// Whether the skill is publicly available or is a private skill.
        /// </para>
        /// </summary>
        public SkillTypeFilter SkillType
        {
            get { return this._skillType; }
            set { this._skillType = value; }
        }

        // Check to see if SkillType property is set
        internal bool IsSetSkillType()
        {
            return this._skillType != null;
        }

    }
}