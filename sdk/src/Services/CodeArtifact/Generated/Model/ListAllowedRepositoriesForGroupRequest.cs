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
    /// Container for the parameters to the ListAllowedRepositoriesForGroup operation.
    /// Lists the repositories in the added repositories list of the specified restriction
    /// type for a package group. For more information about restriction types and added repository
    /// lists, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/package-group-origin-controls.html">Package
    /// group origin controls</a> in the <i>CodeArtifact User Guide</i>.
    /// </summary>
    public partial class ListAllowedRepositoriesForGroupRequest : AmazonCodeArtifactRequest
    {
        private string _domain;
        private string _domainOwner;
        private int? _maxResults;
        private string _nextToken;
        private PackageGroupOriginRestrictionType _originRestrictionType;
        private string _packageGroup;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain that contains the package group from which to list allowed
        /// repositories. 
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
        /// Gets and sets the property OriginRestrictionType. 
        /// <para>
        /// The origin configuration restriction type of which to list allowed repositories.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PackageGroupOriginRestrictionType OriginRestrictionType
        {
            get { return this._originRestrictionType; }
            set { this._originRestrictionType = value; }
        }

        // Check to see if OriginRestrictionType property is set
        internal bool IsSetOriginRestrictionType()
        {
            return this._originRestrictionType != null;
        }

        /// <summary>
        /// Gets and sets the property PackageGroup. 
        /// <para>
        /// The pattern of the package group from which to list allowed repositories.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=520)]
        public string PackageGroup
        {
            get { return this._packageGroup; }
            set { this._packageGroup = value; }
        }

        // Check to see if PackageGroup property is set
        internal bool IsSetPackageGroup()
        {
            return this._packageGroup != null;
        }

    }
}