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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Represents the response from the server to the request to list the user import jobs.
    /// </summary>
    public partial class ListUserImportJobsResponse : AmazonWebServiceResponse
    {
        private string _paginationToken;
        private List<UserImportJobType> _userImportJobs = AWSConfigs.InitializeCollections ? new List<UserImportJobType>() : null;

        /// <summary>
        /// Gets and sets the property PaginationToken. 
        /// <para>
        /// The identifier that Amazon Cognito returned with the previous request to this operation.
        /// When you include a pagination token in your request, Amazon Cognito returns the next
        /// set of items in the list. By use of this token, you can paginate through the full
        /// list of items.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// An array of user import jobs from the requested user pool. For each, the response
        /// includes logging destination, status, and the Amazon S3 pre-signed URL for CSV upload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<UserImportJobType> UserImportJobs
        {
            get { return this._userImportJobs; }
            set { this._userImportJobs = value; }
        }

        // Check to see if UserImportJobs property is set
        internal bool IsSetUserImportJobs()
        {
            return this._userImportJobs != null && (this._userImportJobs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}