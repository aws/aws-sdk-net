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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// This is the response object from the SearchSkillGroups operation.
    /// </summary>
    public partial class SearchSkillGroupsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SkillGroupData> _skillGroups = new List<SkillGroupData>();
        private int? _totalCount;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned to indicate that there is more data available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1100)]
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
        /// Gets and sets the property SkillGroups. 
        /// <para>
        /// The skill groups that meet the filter criteria, in sort order.
        /// </para>
        /// </summary>
        public List<SkillGroupData> SkillGroups
        {
            get { return this._skillGroups; }
            set { this._skillGroups = value; }
        }

        // Check to see if SkillGroups property is set
        internal bool IsSetSkillGroups()
        {
            return this._skillGroups != null && this._skillGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of skill groups returned.
        /// </para>
        /// </summary>
        public int TotalCount
        {
            get { return this._totalCount.GetValueOrDefault(); }
            set { this._totalCount = value; }
        }

        // Check to see if TotalCount property is set
        internal bool IsSetTotalCount()
        {
            return this._totalCount.HasValue; 
        }

    }
}