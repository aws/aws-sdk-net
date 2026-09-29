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
    /// Container for the parameters to the UpdateRepository operation. Update the properties
    /// of a repository.
    /// </summary>
    public partial class UpdateRepositoryRequest : AmazonCodeArtifactRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  An updated repository description. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain associated with the repository to update. 
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
        /// Gets and sets the property Repository. 
        /// <para>
        ///  The name of the repository to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100)]
        public string Repository { get; set; }

        /// <summary>
        /// Checks to see if the Repository property is set.
        /// </summary>
        internal bool IsSetRepository() => this.Repository != null;

        /// <summary>
        /// Gets and sets the property Upstreams. 
        /// <para>
        ///  A list of upstream repositories to associate with the repository. The order of the
        /// upstream repositories in the list determines their priority order when CodeArtifact
        /// looks for a requested package version. For more information, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/repos-upstream.html">Working
        /// with upstream repositories</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UpstreamRepository> Upstreams { get; set; } = AWSConfigs.InitializeCollections ? new List<UpstreamRepository>() : null;

        /// <summary>
        /// Checks to see if the Upstreams property is set.
        /// </summary>
        internal bool IsSetUpstreams() => this.Upstreams != null && (this.Upstreams.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
