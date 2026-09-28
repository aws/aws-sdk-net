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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Basic information about a package.
    /// </summary>
    public partial class PackageDetails
    {
        /// <summary>
        /// Gets and sets the property AllowListedUserList. 
        /// <para>
        ///  A list of users who are allowed to view and associate the package. This field is
        /// only visible to the owner of a package.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowListedUserList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowListedUserList property is set.
        /// </summary>
        internal bool IsSetAllowListedUserList() => this.AllowListedUserList != null && (this.AllowListedUserList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailablePackageConfiguration. 
        /// <para>
        /// This represents the available configuration parameters for the package.
        /// </para>
        /// </summary>
        public PackageConfiguration AvailablePackageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AvailablePackageConfiguration property is set.
        /// </summary>
        internal bool IsSetAvailablePackageConfiguration() => this.AvailablePackageConfiguration != null;

        /// <summary>
        /// Gets and sets the property AvailablePackageVersion. 
        /// <para>
        /// The package version.
        /// </para>
        /// </summary>
        public string AvailablePackageVersion { get; set; }

        /// <summary>
        /// Checks to see if the AvailablePackageVersion property is set.
        /// </summary>
        internal bool IsSetAvailablePackageVersion() => this.AvailablePackageVersion != null;

        /// <summary>
        /// Gets and sets the property AvailablePluginProperties. 
        /// <para>
        /// If the package is a <c>ZIP-PLUGIN</c> package, additional information about plugin
        /// properties.
        /// </para>
        /// </summary>
        public PluginProperties AvailablePluginProperties { get; set; }

        /// <summary>
        /// Checks to see if the AvailablePluginProperties property is set.
        /// </summary>
        internal bool IsSetAvailablePluginProperties() => this.AvailablePluginProperties != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the package was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// Version of OpenSearch or Elasticsearch, in the format Elasticsearch_X.Y or OpenSearch_X.Y.
        /// Defaults to the latest version of OpenSearch.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// Additional information if the package is in an error state. Null otherwise.
        /// </para>
        /// </summary>
        public ErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// Date and time when the package was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property PackageDescription. 
        /// <para>
        /// User-specified description of the package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PackageDescription { get; set; }

        /// <summary>
        /// Checks to see if the PackageDescription property is set.
        /// </summary>
        internal bool IsSetPackageDescription() => this.PackageDescription != null;

        /// <summary>
        /// Gets and sets the property PackageEncryptionOptions. 
        /// <para>
        /// Encryption options for a package.
        /// </para>
        /// </summary>
        public PackageEncryptionOptions PackageEncryptionOptions { get; set; }

        /// <summary>
        /// Checks to see if the PackageEncryptionOptions property is set.
        /// </summary>
        internal bool IsSetPackageEncryptionOptions() => this.PackageEncryptionOptions != null;

        /// <summary>
        /// Gets and sets the property PackageID. 
        /// <para>
        /// The unique identifier of the package.
        /// </para>
        /// </summary>
        public string PackageID { get; set; }

        /// <summary>
        /// Checks to see if the PackageID property is set.
        /// </summary>
        internal bool IsSetPackageID() => this.PackageID != null;

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// The user-specified name of the package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 256)]
        public string PackageName { get; set; }

        /// <summary>
        /// Checks to see if the PackageName property is set.
        /// </summary>
        internal bool IsSetPackageName() => this.PackageName != null;

        /// <summary>
        /// Gets and sets the property PackageOwner. 
        /// <para>
        /// The owner of the package who is allowed to create and update a package and add users
        /// to the package scope.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PackageOwner { get; set; }

        /// <summary>
        /// Checks to see if the PackageOwner property is set.
        /// </summary>
        internal bool IsSetPackageOwner() => this.PackageOwner != null;

        /// <summary>
        /// Gets and sets the property PackageStatus. 
        /// <para>
        /// The current status of the package. The available options are <c>AVAILABLE</c>, <c>COPYING</c>,
        /// <c>COPY_FAILED</c>, <c>VALIDATNG</c>, <c>VALIDATION_FAILED</c>, <c>DELETING</c>, and
        /// <c>DELETE_FAILED</c>.
        /// </para>
        /// </summary>
        public PackageStatus PackageStatus { get; set; }

        /// <summary>
        /// Checks to see if the PackageStatus property is set.
        /// </summary>
        internal bool IsSetPackageStatus() => this.PackageStatus != null;

        /// <summary>
        /// Gets and sets the property PackageType. 
        /// <para>
        /// The type of package.
        /// </para>
        /// </summary>
        public PackageType PackageType { get; set; }

        /// <summary>
        /// Checks to see if the PackageType property is set.
        /// </summary>
        internal bool IsSetPackageType() => this.PackageType != null;

        /// <summary>
        /// Gets and sets the property PackageVendingOptions. 
        /// <para>
        /// Package Vending Options for a package.
        /// </para>
        /// </summary>
        public PackageVendingOptions PackageVendingOptions { get; set; }

        /// <summary>
        /// Checks to see if the PackageVendingOptions property is set.
        /// </summary>
        internal bool IsSetPackageVendingOptions() => this.PackageVendingOptions != null;
    }
}
