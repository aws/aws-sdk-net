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
    /// Container for the parameters to the UpdateRepository operation.
    /// Update the properties of a repository.
    /// </summary>
    public partial class UpdateRepositoryRequest : AmazonCodeArtifactRequest
    {
        private string _description;
        private string _domain;
        private string _domainOwner;
        private string _repository;
        private List<UpstreamRepository> _upstreams = AWSConfigs.InitializeCollections ? new List<UpstreamRepository>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  An updated repository description. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain associated with the repository to update. 
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
        /// Gets and sets the property Repository. 
        /// <para>
        ///  The name of the repository to update. 
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
        /// Gets and sets the property Upstreams. 
        /// <para>
        ///  A list of upstream repositories to associate with the repository. The order of the
        /// upstream repositories in the list determines their priority order when CodeArtifact
        /// looks for a requested package version. For more information, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/repos-upstream.html">Working
        /// with upstream repositories</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UpstreamRepository> Upstreams
        {
            get { return this._upstreams; }
            set { this._upstreams = value; }
        }

        // Check to see if Upstreams property is set
        internal bool IsSetUpstreams()
        {
            return this._upstreams != null && (this._upstreams.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}