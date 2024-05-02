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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the build artifacts for the CodeBuild project.
    /// </summary>
    public partial class AwsCodeBuildProjectArtifactsDetails
    {
        private string _artifactIdentifier;
        private bool? _encryptionDisabled;
        private string _location;
        private string _name;
        private string _namespaceType;
        private bool? _overrideArtifactName;
        private string _packaging;
        private string _path;
        private string _type;

        /// <summary>
        /// Gets and sets the property ArtifactIdentifier. 
        /// <para>
        /// An identifier for the artifact definition.
        /// </para>
        /// </summary>
        public string ArtifactIdentifier
        {
            get { return this._artifactIdentifier; }
            set { this._artifactIdentifier = value; }
        }

        // Check to see if ArtifactIdentifier property is set
        internal bool IsSetArtifactIdentifier()
        {
            return this._artifactIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionDisabled. 
        /// <para>
        /// Indicates whether to disable encryption on the artifact. Only valid when <c>Type</c>
        /// is <c>S3</c>.
        /// </para>
        /// </summary>
        public bool? EncryptionDisabled
        {
            get { return this._encryptionDisabled; }
            set { this._encryptionDisabled = value; }
        }

        // Check to see if EncryptionDisabled property is set
        internal bool IsSetEncryptionDisabled()
        {
            return this._encryptionDisabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Only used when <c>Type</c> is <c>S3</c>. The name of the S3 bucket where the artifact
        /// is located.
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Only used when Type is S3. The name of the artifact. Used with <c>NamepaceType</c>
        /// and <c>Path</c> to determine the pattern for storing the artifact.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceType. 
        /// <para>
        /// Only used when <c>Type</c> is <c>S3</c>. The value to use for the namespace. Used
        /// with <c>Name</c> and <c>Path</c> to determine the pattern for storing the artifact.
        /// </para>
        /// </summary>
        public string NamespaceType
        {
            get { return this._namespaceType; }
            set { this._namespaceType = value; }
        }

        // Check to see if NamespaceType property is set
        internal bool IsSetNamespaceType()
        {
            return this._namespaceType != null;
        }

        /// <summary>
        /// Gets and sets the property OverrideArtifactName. 
        /// <para>
        /// Whether the name specified in the buildspec file overrides the artifact name.
        /// </para>
        /// </summary>
        public bool? OverrideArtifactName
        {
            get { return this._overrideArtifactName; }
            set { this._overrideArtifactName = value; }
        }

        // Check to see if OverrideArtifactName property is set
        internal bool IsSetOverrideArtifactName()
        {
            return this._overrideArtifactName.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Packaging. 
        /// <para>
        /// Only used when <c>Type</c> is <c>S3</c>. The type of output artifact to create.
        /// </para>
        /// </summary>
        public string Packaging
        {
            get { return this._packaging; }
            set { this._packaging = value; }
        }

        // Check to see if Packaging property is set
        internal bool IsSetPackaging()
        {
            return this._packaging != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// Only used when <c>Type</c> is <c>S3</c>. The path to the artifact. Used with <c>Name</c>
        /// and <c>NamespaceType</c> to determine the pattern for storing the artifact.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of build artifact.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}