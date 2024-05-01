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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
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
namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Container for the parameters to the ListRepositoriesInDomain operation.
    /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_RepositorySummary.html">RepositorySummary</a>
    /// objects. Each <c>RepositorySummary</c> contains information about a repository in
    /// the specified domain and that matches the input parameters.
    /// </summary>
    public partial class ListRepositoriesInDomainRequest : AmazonCodeArtifactRequest
    {
        private string _administratorAccount;
        private string _domain;
        private string _domainOwner;
        private int? _maxResults;
        private string _nextToken;
        private string _repositoryPrefix;

        /// <summary>
        /// Gets and sets the property AdministratorAccount. 
        /// <para>
        ///  Filter the list of repositories to only include those that are managed by the Amazon
        /// Web Services account ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AdministratorAccount
        {
            get { return this._administratorAccount; }
            set { this._administratorAccount = value; }
        }

        // Check to see if AdministratorAccount property is set
        internal bool IsSetAdministratorAccount()
        {
            return this._administratorAccount != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain that contains the returned list of repositories. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=50)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property DomainOwner. 
        /// <para>
        ///  The 12-digit account number of the Amazon Web Services account that owns the domain.
        /// It does not include dashes or spaces. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string DomainOwner
        {
            get { return this._domainOwner; }
            set { this._domainOwner = value; }
        }

        // Check to see if DomainOwner property is set
        internal bool IsSetDomainOwner()
        {
            return this._domainOwner != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return per page. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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
        /// Gets and sets the property RepositoryPrefix. 
        /// <para>
        ///  A prefix used to filter returned repositories. Only repositories with names that
        /// start with <c>repositoryPrefix</c> are returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string RepositoryPrefix
        {
            get { return this._repositoryPrefix; }
            set { this._repositoryPrefix = value; }
        }

        // Check to see if RepositoryPrefix property is set
        internal bool IsSetRepositoryPrefix()
        {
            return this._repositoryPrefix != null;
        }

    }
}