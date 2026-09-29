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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListPackages operation. Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageSummary.html">PackageSummary</a>
    /// objects for packages in a repository that match the request parameters.
    /// </summary>
    public partial class ListPackagesRequest : AmazonCodeArtifactRequest
    {
        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain that contains the repository that contains the requested packages.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 50)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property DomainOwner. 
        /// <para>
        ///  The 12-digit account number of the Amazon Web Services account that owns the domain.
        /// It does not include dashes or spaces. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string DomainOwner { get; set; }

        /// <summary>
        /// Checks to see if the DomainOwner property is set.
        /// </summary>
        internal bool IsSetDomainOwner() => this.DomainOwner != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format used to filter requested packages. Only packages from the provided format
        /// will be returned.
        /// </para>
        /// </summary>
        public PackageFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return per page. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace prefix used to filter requested packages. Only packages with a namespace
        /// that starts with the provided string value are returned. Note that although this option
        /// is called <c>--namespace</c> and not <c>--namespace-prefix</c>, it has prefix-matching
        /// behavior.
        /// </para>
        ///  
        /// <para>
        /// Each package format uses namespace as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  The namespace of a Maven package version is its <c>groupId</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The namespace of an npm or Swift package version is its <c>scope</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The namespace of a generic package is its <c>namespace</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Python, NuGet, Ruby, and Cargo package versions do not contain a corresponding component,
        /// package versions of those formats do not have a namespace. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PackagePrefix. 
        /// <para>
        ///  A prefix used to filter requested packages. Only packages with names that start with
        /// <c>packagePrefix</c> are returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string PackagePrefix { get; set; }

        /// <summary>
        /// Checks to see if the PackagePrefix property is set.
        /// </summary>
        internal bool IsSetPackagePrefix() => this.PackagePrefix != null;

        /// <summary>
        /// Gets and sets the property Publish. 
        /// <para>
        /// The value of the <c>Publish</c> package origin control restriction used to filter
        /// requested packages. Only packages with the provided restriction are returned. For
        /// more information, see <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageOriginRestrictions.html">PackageOriginRestrictions</a>.
        /// </para>
        /// </summary>
        public AllowPublish Publish { get; set; }

        /// <summary>
        /// Checks to see if the Publish property is set.
        /// </summary>
        internal bool IsSetPublish() => this.Publish != null;

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        ///  The name of the repository that contains the requested packages. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100)]
        public string Repository { get; set; }

        /// <summary>
        /// Checks to see if the Repository property is set.
        /// </summary>
        internal bool IsSetRepository() => this.Repository != null;

        /// <summary>
        /// Gets and sets the property Upstream. 
        /// <para>
        /// The value of the <c>Upstream</c> package origin control restriction used to filter
        /// requested packages. Only packages with the provided restriction are returned. For
        /// more information, see <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageOriginRestrictions.html">PackageOriginRestrictions</a>.
        /// </para>
        /// </summary>
        public AllowUpstream Upstream { get; set; }

        /// <summary>
        /// Checks to see if the Upstream property is set.
        /// </summary>
        internal bool IsSetUpstream() => this.Upstream != null;
    }
}
