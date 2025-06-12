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
    /// Container for the parameters to the UpdatePackageGroupOriginConfiguration operation.
    /// Updates the package origin configuration for a package group.
    /// 
    ///  
    /// <para>
    /// The package origin configuration determines how new versions of a package can be added
    /// to a repository. You can allow or block direct publishing of new package versions,
    /// or ingestion and retaining of new package versions from an external connection or
    /// upstream source. For more information about package group origin controls and configuration,
    /// see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/package-group-origin-controls.html">Package
    /// group origin controls</a> in the <i>CodeArtifact User Guide</i>.
    /// </para>
    /// </summary>
    public partial class UpdatePackageGroupOriginConfigurationRequest : AmazonCodeArtifactRequest
    {
        private List<PackageGroupAllowedRepository> _addAllowedRepositories = AWSConfigs.InitializeCollections ? new List<PackageGroupAllowedRepository>() : null;
        private string _domain;
        private string _domainOwner;
        private string _packageGroup;
        private List<PackageGroupAllowedRepository> _removeAllowedRepositories = AWSConfigs.InitializeCollections ? new List<PackageGroupAllowedRepository>() : null;
        private Dictionary<string, string> _restrictions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AddAllowedRepositories. 
        /// <para>
        /// The repository name and restrictions to add to the allowed repository list of the
        /// specified package group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PackageGroupAllowedRepository> AddAllowedRepositories
        {
            get { return this._addAllowedRepositories; }
            set { this._addAllowedRepositories = value; }
        }

        // Check to see if AddAllowedRepositories property is set
        internal bool IsSetAddAllowedRepositories()
        {
            return this._addAllowedRepositories != null && (this._addAllowedRepositories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain which contains the package group for which to update the origin
        /// configuration. 
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
        /// Gets and sets the property PackageGroup. 
        /// <para>
        ///  The pattern of the package group for which to update the origin configuration. 
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

        /// <summary>
        /// Gets and sets the property RemoveAllowedRepositories. 
        /// <para>
        /// The repository name and restrictions to remove from the allowed repository list of
        /// the specified package group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PackageGroupAllowedRepository> RemoveAllowedRepositories
        {
            get { return this._removeAllowedRepositories; }
            set { this._removeAllowedRepositories = value; }
        }

        // Check to see if RemoveAllowedRepositories property is set
        internal bool IsSetRemoveAllowedRepositories()
        {
            return this._removeAllowedRepositories != null && (this._removeAllowedRepositories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Restrictions. 
        /// <para>
        ///  The origin configuration settings that determine how package versions can enter repositories.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Restrictions
        {
            get { return this._restrictions; }
            set { this._restrictions = value; }
        }

        // Check to see if Restrictions property is set
        internal bool IsSetRestrictions()
        {
            return this._restrictions != null && (this._restrictions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}