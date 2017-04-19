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
 * Do not modify this file. This file is generated from the codestar-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeStar.Model
{
    /// <summary>
    /// This is the response object from the ListTeamMembers operation.
    /// </summary>
    public partial class ListTeamMembersResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TeamMember> _teamMembers = new List<TeamMember>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The continuation token to use when requesting the next set of results, if there are
        /// more results to be returned.
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
        /// Gets and sets the property TeamMembers. 
        /// <para>
        /// A list of team member objects for the project.
        /// </para>
        /// </summary>
        public List<TeamMember> TeamMembers
        {
            get { return this._teamMembers; }
            set { this._teamMembers = value; }
        }

        // Check to see if TeamMembers property is set
        internal bool IsSetTeamMembers()
        {
            return this._teamMembers != null && this._teamMembers.Count > 0; 
        }

    }
}