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
    /// This is the response object from the GetCurrentUserData operation.
    /// </summary>
    public partial class GetCurrentUserDataResponse : AmazonWebServiceResponse
    {
        private long? _approximateTotalCount;
        private string _nextToken;
        private List<UserData> _userDataList = new List<UserData>();

        /// <summary>
        /// Gets and sets the property ApproximateTotalCount. 
        /// <para>
        /// The total count of the result, regardless of the current page size.
        /// </para>
        /// </summary>
        public long ApproximateTotalCount
        {
            get { return this._approximateTotalCount.GetValueOrDefault(); }
            set { this._approximateTotalCount = value; }
        }

        // Check to see if ApproximateTotalCount property is set
        internal bool IsSetApproximateTotalCount()
        {
            return this._approximateTotalCount.HasValue; 
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
        /// Gets and sets the property UserDataList. 
        /// <para>
        /// A list of the user data that is returned.
        /// </para>
        /// </summary>
        public List<UserData> UserDataList
        {
            get { return this._userDataList; }
            set { this._userDataList = value; }
        }

        // Check to see if UserDataList property is set
        internal bool IsSetUserDataList()
        {
            return this._userDataList != null && this._userDataList.Count > 0; 
        }

    }
}