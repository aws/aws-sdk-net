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
    /// Basic information about a package.
    /// </summary>
    public partial class PackageDetails
    {
        private List<string> _allowListedUserList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PackageConfiguration _availablePackageConfiguration;
        private string _availablePackageVersion;
        private PluginProperties _availablePluginProperties;
        private DateTime? _createdAt;
        private string _engineVersion;
        private ErrorDetails _errorDetails;
        private DateTime? _lastUpdatedAt;
        private string _packageDescription;
        private PackageEncryptionOptions _packageEncryptionOptions;
        private string _packageID;
        private string _packageName;
        private string _packageOwner;
        private PackageStatus _packageStatus;
        private PackageType _packageType;
        private PackageVendingOptions _packageVendingOptions;

        /// <summary>
        /// Gets and sets the property AllowListedUserList. 
        /// <para>
        ///  A list of users who are allowed to view and associate the package. This field is
        /// only visible to the owner of a package.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowListedUserList
        {
            get { return this._allowListedUserList; }
            set { this._allowListedUserList = value; }
        }

        // Check to see if AllowListedUserList property is set
        internal bool IsSetAllowListedUserList()
        {
            return this._allowListedUserList != null && (this._allowListedUserList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailablePackageConfiguration. 
        /// <para>
        /// This represents the available configuration parameters for the package.
        /// </para>
        /// </summary>
        public PackageConfiguration AvailablePackageConfiguration
        {
            get { return this._availablePackageConfiguration; }
            set { this._availablePackageConfiguration = value; }
        }

        // Check to see if AvailablePackageConfiguration property is set
        internal bool IsSetAvailablePackageConfiguration()
        {
            return this._availablePackageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AvailablePackageVersion. 
        /// <para>
        /// The package version.
        /// </para>
        /// </summary>
        public string AvailablePackageVersion
        {
            get { return this._availablePackageVersion; }
            set { this._availablePackageVersion = value; }
        }

        // Check to see if AvailablePackageVersion property is set
        internal bool IsSetAvailablePackageVersion()
        {
            return this._availablePackageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property AvailablePluginProperties. 
        /// <para>
        /// If the package is a <c>ZIP-PLUGIN</c> package, additional information about plugin
        /// properties.
        /// </para>
        /// </summary>
        public PluginProperties AvailablePluginProperties
        {
            get { return this._availablePluginProperties; }
            set { this._availablePluginProperties = value; }
        }

        // Check to see if AvailablePluginProperties property is set
        internal bool IsSetAvailablePluginProperties()
        {
            return this._availablePluginProperties != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the package was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// Version of OpenSearch or Elasticsearch, in the format Elasticsearch_X.Y or OpenSearch_X.Y.
        /// Defaults to the latest version of OpenSearch.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// Additional information if the package is in an error state. Null otherwise.
        /// </para>
        /// </summary>
        public ErrorDetails ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// Date and time when the package was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PackageDescription. 
        /// <para>
        /// User-specified description of the package.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string PackageDescription
        {
            get { return this._packageDescription; }
            set { this._packageDescription = value; }
        }

        // Check to see if PackageDescription property is set
        internal bool IsSetPackageDescription()
        {
            return this._packageDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PackageEncryptionOptions. 
        /// <para>
        /// Encryption options for a package.
        /// </para>
        /// </summary>
        public PackageEncryptionOptions PackageEncryptionOptions
        {
            get { return this._packageEncryptionOptions; }
            set { this._packageEncryptionOptions = value; }
        }

        // Check to see if PackageEncryptionOptions property is set
        internal bool IsSetPackageEncryptionOptions()
        {
            return this._packageEncryptionOptions != null;
        }

        /// <summary>
        /// Gets and sets the property PackageID. 
        /// <para>
        /// The unique identifier of the package.
        /// </para>
        /// </summary>
        public string PackageID
        {
            get { return this._packageID; }
            set { this._packageID = value; }
        }

        // Check to see if PackageID property is set
        internal bool IsSetPackageID()
        {
            return this._packageID != null;
        }

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// The user-specified name of the package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=256)]
        public string PackageName
        {
            get { return this._packageName; }
            set { this._packageName = value; }
        }

        // Check to see if PackageName property is set
        internal bool IsSetPackageName()
        {
            return this._packageName != null;
        }

        /// <summary>
        /// Gets and sets the property PackageOwner. 
        /// <para>
        /// The owner of the package who is allowed to create and update a package and add users
        /// to the package scope.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string PackageOwner
        {
            get { return this._packageOwner; }
            set { this._packageOwner = value; }
        }

        // Check to see if PackageOwner property is set
        internal bool IsSetPackageOwner()
        {
            return this._packageOwner != null;
        }

        /// <summary>
        /// Gets and sets the property PackageStatus. 
        /// <para>
        /// The current status of the package. The available options are <c>AVAILABLE</c>, <c>COPYING</c>,
        /// <c>COPY_FAILED</c>, <c>VALIDATNG</c>, <c>VALIDATION_FAILED</c>, <c>DELETING</c>, and
        /// <c>DELETE_FAILED</c>.
        /// </para>
        /// </summary>
        public PackageStatus PackageStatus
        {
            get { return this._packageStatus; }
            set { this._packageStatus = value; }
        }

        // Check to see if PackageStatus property is set
        internal bool IsSetPackageStatus()
        {
            return this._packageStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PackageType. 
        /// <para>
        /// The type of package.
        /// </para>
        /// </summary>
        public PackageType PackageType
        {
            get { return this._packageType; }
            set { this._packageType = value; }
        }

        // Check to see if PackageType property is set
        internal bool IsSetPackageType()
        {
            return this._packageType != null;
        }

        /// <summary>
        /// Gets and sets the property PackageVendingOptions. 
        /// <para>
        /// Package Vending Options for a package.
        /// </para>
        /// </summary>
        public PackageVendingOptions PackageVendingOptions
        {
            get { return this._packageVendingOptions; }
            set { this._packageVendingOptions = value; }
        }

        // Check to see if PackageVendingOptions property is set
        internal bool IsSetPackageVendingOptions()
        {
            return this._packageVendingOptions != null;
        }

    }
}