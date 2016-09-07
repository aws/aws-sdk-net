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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Represents the response from the server to the request to list the user import jobs.
    /// </summary>
    public partial class ListUserImportJobsResponse : AmazonWebServiceResponse
    {
        private string _paginationToken;
        private List<UserImportJobType> _userImportJobs = new List<UserImportJobType>();

        /// <summary>
        /// Gets and sets the property PaginationToken. 
        /// <para>
        /// An identifier that can be used to return the next set of user import jobs in the list.
        /// </para>
        /// </summary>
        public string PaginationToken
        {
            get { return this._paginationToken; }
            set { this._paginationToken = value; }
        }

        // Check to see if PaginationToken property is set
        internal bool IsSetPaginationToken()
        {
            return this._paginationToken != null;
        }

        /// <summary>
        /// Gets and sets the property UserImportJobs. 
        /// <para>
        /// The user import jobs.
        /// </para>
        /// </summary>
        public List<UserImportJobType> UserImportJobs
        {
            get { return this._userImportJobs; }
            set { this._userImportJobs = value; }
        }

        // Check to see if UserImportJobs property is set
        internal bool IsSetUserImportJobs()
        {
            return this._userImportJobs != null && this._userImportJobs.Count > 0; 
        }

    }
}