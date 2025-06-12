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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the GetPackageVersion operation.
    /// </summary>
    public partial class GetPackageVersionResponse : AmazonWebServiceResponse
    {
        private PackageVersionArtifact _artifact;
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _creationDate;
        private string _description;
        private string _errorReason;
        private DateTime? _lastModifiedDate;
        private string _packageName;
        private string _packageVersionArn;
        private string _recipe;
        private Sbom _sbom;
        private SbomValidationStatus _sbomValidationStatus;
        private PackageVersionStatus _status;
        private string _versionName;

        /// <summary>
        /// Gets and sets the property Artifact. 
        /// <para>
        /// The various components that make up a software package version.
        /// </para>
        /// </summary>
        public PackageVersionArtifact Artifact
        {
            get { return this._artifact; }
            set { this._artifact = value; }
        }

        // Check to see if Artifact property is set
        internal bool IsSetArtifact()
        {
            return this._artifact != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Metadata that were added to the package version that can be used to define a package
        /// version’s configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date when the package version was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The package version description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
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
        /// Gets and sets the property ErrorReason. 
        /// <para>
        /// Error reason for a package version failure during creation or update.
        /// </para>
        /// </summary>
        public string ErrorReason
        {
            get { return this._errorReason; }
            set { this._errorReason = value; }
        }

        // Check to see if ErrorReason property is set
        internal bool IsSetErrorReason()
        {
            return this._errorReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the package version was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// The name of the software package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property PackageVersionArn. 
        /// <para>
        /// The ARN for the package version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string PackageVersionArn
        {
            get { return this._packageVersionArn; }
            set { this._packageVersionArn = value; }
        }

        // Check to see if PackageVersionArn property is set
        internal bool IsSetPackageVersionArn()
        {
            return this._packageVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Recipe. 
        /// <para>
        /// The inline job document associated with a software package version used for a quick
        /// job deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=3072)]
        public string Recipe
        {
            get { return this._recipe; }
            set { this._recipe = value; }
        }

        // Check to see if Recipe property is set
        internal bool IsSetRecipe()
        {
            return this._recipe != null;
        }

        /// <summary>
        /// Gets and sets the property Sbom. 
        /// <para>
        /// The software bill of materials for a software package version.
        /// </para>
        /// </summary>
        public Sbom Sbom
        {
            get { return this._sbom; }
            set { this._sbom = value; }
        }

        // Check to see if Sbom property is set
        internal bool IsSetSbom()
        {
            return this._sbom != null;
        }

        /// <summary>
        /// Gets and sets the property SbomValidationStatus. 
        /// <para>
        /// The status of the validation for a new software bill of materials added to a software
        /// package version.
        /// </para>
        /// </summary>
        public SbomValidationStatus SbomValidationStatus
        {
            get { return this._sbomValidationStatus; }
            set { this._sbomValidationStatus = value; }
        }

        // Check to see if SbomValidationStatus property is set
        internal bool IsSetSbomValidationStatus()
        {
            return this._sbomValidationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status associated to the package version. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/preparing-to-use-software-package-catalog.html#package-version-lifecycle">Package
        /// version lifecycle</a>.
        /// </para>
        /// </summary>
        public PackageVersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The name of the package version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string VersionName
        {
            get { return this._versionName; }
            set { this._versionName = value; }
        }

        // Check to see if VersionName property is set
        internal bool IsSetVersionName()
        {
            return this._versionName != null;
        }

    }
}