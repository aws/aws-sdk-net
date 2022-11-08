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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Basic information about a package.
    /// </summary>
    public partial class PackageDetails
    {
        private string _availablePackageVersion;
        private DateTime? _createdAt;
        private ErrorDetails _errorDetails;
        private DateTime? _lastUpdatedAt;
        private string _packageDescription;
        private string _packageID;
        private string _packageName;
        private PackageStatus _packageStatus;
        private PackageType _packageType;

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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the package was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
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
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
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
        /// User-specified name of the package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=28)]
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
        /// Gets and sets the property PackageStatus. 
        /// <para>
        /// Current status of the package.
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

    }
}