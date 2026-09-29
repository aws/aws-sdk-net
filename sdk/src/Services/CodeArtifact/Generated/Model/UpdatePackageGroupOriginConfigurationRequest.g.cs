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
    /// Container for the parameters to the UpdatePackageGroupOriginConfiguration operation.
    /// Updates the package origin configuration for a package group. <para> The package origin
    /// configuration determines how new versions of a package can be added to a repository.
    /// You can allow or block direct publishing of new package versions, or ingestion and
    /// retaining of new package versions from an external connection or upstream source.
    /// For more information about package group origin controls and configuration, see <a
    /// href="https://docs.aws.amazon.com/codeartifact/latest/ug/package-group-origin-controls.html">Package
    /// group origin controls</a> in the <i>CodeArtifact User Guide</i>. </para>
    /// </summary>
    public partial class UpdatePackageGroupOriginConfigurationRequest : AmazonCodeArtifactRequest
    {
        /// <summary>
        /// Gets and sets the property AddAllowedRepositories. 
        /// <para>
        /// The repository name and restrictions to add to the allowed repository list of the
        /// specified package group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PackageGroupAllowedRepository> AddAllowedRepositories { get; set; } = AWSConfigs.InitializeCollections ? new List<PackageGroupAllowedRepository>() : null;

        /// <summary>
        /// Checks to see if the AddAllowedRepositories property is set.
        /// </summary>
        internal bool IsSetAddAllowedRepositories() => this.AddAllowedRepositories != null && (this.AddAllowedRepositories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain which contains the package group for which to update the origin
        /// configuration. 
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
        /// Gets and sets the property PackageGroup. 
        /// <para>
        ///  The pattern of the package group for which to update the origin configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 520)]
        public string PackageGroup { get; set; }

        /// <summary>
        /// Checks to see if the PackageGroup property is set.
        /// </summary>
        internal bool IsSetPackageGroup() => this.PackageGroup != null;

        /// <summary>
        /// Gets and sets the property RemoveAllowedRepositories. 
        /// <para>
        /// The repository name and restrictions to remove from the allowed repository list of
        /// the specified package group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PackageGroupAllowedRepository> RemoveAllowedRepositories { get; set; } = AWSConfigs.InitializeCollections ? new List<PackageGroupAllowedRepository>() : null;

        /// <summary>
        /// Checks to see if the RemoveAllowedRepositories property is set.
        /// </summary>
        internal bool IsSetRemoveAllowedRepositories() => this.RemoveAllowedRepositories != null && (this.RemoveAllowedRepositories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Restrictions. 
        /// <para>
        ///  The origin configuration settings that determine how package versions can enter repositories.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Restrictions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Restrictions property is set.
        /// </summary>
        internal bool IsSetRestrictions() => this.Restrictions != null && (this.Restrictions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
