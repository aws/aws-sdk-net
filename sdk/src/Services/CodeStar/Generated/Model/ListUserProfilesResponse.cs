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
    /// This is the response object from the ListUserProfiles operation.
    /// </summary>
    public partial class ListUserProfilesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<UserProfileSummary> _userProfiles = new List<UserProfileSummary>();

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
        /// Gets and sets the property UserProfiles. 
        /// <para>
        /// All the user profiles configured in AWS CodeStar for an AWS account.
        /// </para>
        /// </summary>
        public List<UserProfileSummary> UserProfiles
        {
            get { return this._userProfiles; }
            set { this._userProfiles = value; }
        }

        // Check to see if UserProfiles property is set
        internal bool IsSetUserProfiles()
        {
            return this._userProfiles != null && this._userProfiles.Count > 0; 
        }

    }
}