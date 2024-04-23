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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the ListUserProficiencies operation.
    /// </summary>
    public partial class ListUserProficienciesResponse : AmazonWebServiceResponse
    {
        private string _lastModifiedRegion;
        private DateTime? _lastModifiedTime;
        private string _nextToken;
        private List<UserProficiency> _userProficiencyList = AWSConfigs.InitializeCollections ? new List<UserProficiency>() : null;

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The region in which a user's proficiencies were last modified.
        /// </para>
        /// </summary>
        public string LastModifiedRegion
        {
            get { return this._lastModifiedRegion; }
            set { this._lastModifiedRegion = value; }
        }

        // Check to see if LastModifiedRegion property is set
        internal bool IsSetLastModifiedRegion()
        {
            return this._lastModifiedRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time that the user's proficiencies are were modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for the next set of results.
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
        /// Gets and sets the property UserProficiencyList. 
        /// <para>
        /// Information about the user proficiencies.
        /// </para>
        /// </summary>
        public List<UserProficiency> UserProficiencyList
        {
            get { return this._userProficiencyList; }
            set { this._userProficiencyList = value; }
        }

        // Check to see if UserProficiencyList property is set
        internal bool IsSetUserProficiencyList()
        {
            return this._userProficiencyList != null && (this._userProficiencyList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}