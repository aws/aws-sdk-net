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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the response parameters to the <c>ListDomainsForPackage</c> operation.
    /// </summary>
    public partial class ListDomainsForPackageResponse : AmazonWebServiceResponse
    {
        private List<DomainPackageDetails> _domainPackageDetailsList = AWSConfigs.InitializeCollections ? new List<DomainPackageDetails>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DomainPackageDetailsList. 
        /// <para>
        /// Information about all domains associated with a package.
        /// </para>
        /// </summary>
        public List<DomainPackageDetails> DomainPackageDetailsList
        {
            get { return this._domainPackageDetailsList; }
            set { this._domainPackageDetailsList = value; }
        }

        // Check to see if DomainPackageDetailsList property is set
        internal bool IsSetDomainPackageDetailsList()
        {
            return this._domainPackageDetailsList != null && (this._domainPackageDetailsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When <c>nextToken</c> is returned, there are more results available. The value of
        /// <c>nextToken</c> is a unique pagination token for each page. Send the request again
        /// using the returned token to retrieve the next page.
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

    }
}