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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the ListIdentityResolutionJobs operation.
    /// </summary>
    public partial class ListIdentityResolutionJobsResponse : AmazonWebServiceResponse
    {
        private List<IdentityResolutionJob> _identityResolutionJobsList = AWSConfigs.InitializeCollections ? new List<IdentityResolutionJob>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property IdentityResolutionJobsList. 
        /// <para>
        /// A list of Identity Resolution Jobs.
        /// </para>
        /// </summary>
        public List<IdentityResolutionJob> IdentityResolutionJobsList
        {
            get { return this._identityResolutionJobsList; }
            set { this._identityResolutionJobsList = value; }
        }

        // Check to see if IdentityResolutionJobsList property is set
        internal bool IsSetIdentityResolutionJobsList()
        {
            return this._identityResolutionJobsList != null && (this._identityResolutionJobsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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