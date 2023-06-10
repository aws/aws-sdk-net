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

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Container for the parameters to the ListPackages operation.
    /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageSummary.html">PackageSummary</a>
    /// objects for packages in a repository that match the request parameters.
    /// </summary>
    public partial class ListPackagesRequest : AmazonCodeArtifactRequest
    {
        private string _domain;
        private string _domainOwner;
        private PackageFormat _format;
        private int? _maxResults;
        private string _awsNamespace;
        private string _nextToken;
        private string _packagePrefix;
        private AllowPublish _publish;
        private string _repository;
        private AllowUpstream _upstream;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain that contains the repository that contains the requested packages.
        /// 
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
        /// Gets and sets the property Format. 
        /// <para>
        /// The format used to filter requested packages. Only packages from the provided format
        /// will be returned.
        /// </para>
        /// </summary>
        public PackageFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return per page. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace prefix used to filter requested packages. Only packages with a namespace
        /// that starts with the provided string value are returned. Note that although this option
        /// is called <code>--namespace</code> and not <code>--namespace-prefix</code>, it has
        /// prefix-matching behavior.
        /// </para>
        ///  
        /// <para>
        /// Each package format uses namespace as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  The namespace of a Maven package is its <code>groupId</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The namespace of an npm package is its <code>scope</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Python and NuGet packages do not contain a corresponding component, packages of those
        /// formats do not have a namespace. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The namespace of a generic package is its <code>namespace</code>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
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
        /// Gets and sets the property PackagePrefix. 
        /// <para>
        ///  A prefix used to filter requested packages. Only packages with names that start with
        /// <code>packagePrefix</code> are returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PackagePrefix
        {
            get { return this._packagePrefix; }
            set { this._packagePrefix = value; }
        }

        // Check to see if PackagePrefix property is set
        internal bool IsSetPackagePrefix()
        {
            return this._packagePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Publish. 
        /// <para>
        /// The value of the <code>Publish</code> package origin control restriction used to filter
        /// requested packages. Only packages with the provided restriction are returned. For
        /// more information, see <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageOriginRestrictions.html">PackageOriginRestrictions</a>.
        /// </para>
        /// </summary>
        public AllowPublish Publish
        {
            get { return this._publish; }
            set { this._publish = value; }
        }

        // Check to see if Publish property is set
        internal bool IsSetPublish()
        {
            return this._publish != null;
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        ///  The name of the repository that contains the requested packages. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=100)]
        public string Repository
        {
            get { return this._repository; }
            set { this._repository = value; }
        }

        // Check to see if Repository property is set
        internal bool IsSetRepository()
        {
            return this._repository != null;
        }

        /// <summary>
        /// Gets and sets the property Upstream. 
        /// <para>
        /// The value of the <code>Upstream</code> package origin control restriction used to
        /// filter requested packages. Only packages with the provided restriction are returned.
        /// For more information, see <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageOriginRestrictions.html">PackageOriginRestrictions</a>.
        /// </para>
        /// </summary>
        public AllowUpstream Upstream
        {
            get { return this._upstream; }
            set { this._upstream = value; }
        }

        // Check to see if Upstream property is set
        internal bool IsSetUpstream()
        {
            return this._upstream != null;
        }

    }
}