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
    /// Information about a package that is associated with a domain. For more information,
    /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
    /// packages for Amazon OpenSearch Service</a>.
    /// </summary>
    public partial class DomainPackageDetails
    {
        private PackageAssociationConfiguration _associationConfiguration;
        private string _domainName;
        private DomainPackageStatus _domainPackageStatus;
        private ErrorDetails _errorDetails;
        private DateTime? _lastUpdated;
        private string _packageID;
        private string _packageName;
        private PackageType _packageType;
        private string _packageVersion;
        private List<string> _prerequisitePackageIDList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _referencePath;

        /// <summary>
        /// Gets and sets the property AssociationConfiguration. 
        /// <para>
        /// The configuration for associating a package with an Amazon OpenSearch Service domain.
        /// </para>
        /// </summary>
        public PackageAssociationConfiguration AssociationConfiguration
        {
            get { return this._associationConfiguration; }
            set { this._associationConfiguration = value; }
        }

        // Check to see if AssociationConfiguration property is set
        internal bool IsSetAssociationConfiguration()
        {
            return this._associationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Name of the domain that the package is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=28)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property DomainPackageStatus. 
        /// <para>
        /// State of the association.
        /// </para>
        /// </summary>
        public DomainPackageStatus DomainPackageStatus
        {
            get { return this._domainPackageStatus; }
            set { this._domainPackageStatus = value; }
        }

        // Check to see if DomainPackageStatus property is set
        internal bool IsSetDomainPackageStatus()
        {
            return this._domainPackageStatus != null;
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
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// Timestamp of the most recent update to the package association status.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated
        {
            get { return this._lastUpdated; }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PackageID. 
        /// <para>
        /// Internal ID of the package.
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
        /// User-specified name of the package.
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
        /// Gets and sets the property PackageVersion. 
        /// <para>
        /// The current version of the package.
        /// </para>
        /// </summary>
        public string PackageVersion
        {
            get { return this._packageVersion; }
            set { this._packageVersion = value; }
        }

        // Check to see if PackageVersion property is set
        internal bool IsSetPackageVersion()
        {
            return this._packageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PrerequisitePackageIDList. 
        /// <para>
        /// A list of package IDs that must be associated with the domain before or with the package
        /// can be associated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PrerequisitePackageIDList
        {
            get { return this._prerequisitePackageIDList; }
            set { this._prerequisitePackageIDList = value; }
        }

        // Check to see if PrerequisitePackageIDList property is set
        internal bool IsSetPrerequisitePackageIDList()
        {
            return this._prerequisitePackageIDList != null && (this._prerequisitePackageIDList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReferencePath. 
        /// <para>
        /// The relative path of the package on the OpenSearch Service cluster nodes. This is
        /// <c>synonym_path</c> when the package is for synonym files.
        /// </para>
        /// </summary>
        public string ReferencePath
        {
            get { return this._referencePath; }
            set { this._referencePath = value; }
        }

        // Check to see if ReferencePath property is set
        internal bool IsSetReferencePath()
        {
            return this._referencePath != null;
        }

    }
}