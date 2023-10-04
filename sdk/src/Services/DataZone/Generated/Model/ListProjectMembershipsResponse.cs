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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// This is the response object from the ListProjectMemberships operation.
    /// </summary>
    public partial class ListProjectMembershipsResponse : AmazonWebServiceResponse
    {
        private List<ProjectMember> _members = new List<ProjectMember>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Members. 
        /// <para>
        /// The members of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ProjectMember> Members
        {
            get { return this._members; }
            set { this._members = value; }
        }

        // Check to see if Members property is set
        internal bool IsSetMembers()
        {
            return this._members != null && this._members.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of memberships is greater than the default value for the <code>MaxResults</code>
        /// parameter, or if you explicitly specify a value for <code>MaxResults</code> that is
        /// less than the number of memberships, the response includes a pagination token named
        /// <code>NextToken</code>. You can specify this <code>NextToken</code> value in a subsequent
        /// call to <code>ListProjectMemberships</code> to list the next set of memberships.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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

    }
}