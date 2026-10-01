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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the build artifacts for the CodeBuild project.
    /// </summary>
    public partial class AwsCodeBuildProjectArtifactsDetails
    {
        /// <summary>
        /// Gets and sets the property ArtifactIdentifier. 
        /// <para>
        /// An identifier for the artifact definition.
        /// </para>
        /// </summary>
        public string ArtifactIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactIdentifier property is set.
        /// </summary>
        internal bool IsSetArtifactIdentifier() => this.ArtifactIdentifier != null;

        /// <summary>
        /// Gets and sets the property EncryptionDisabled. 
        /// <para>
        /// Indicates whether to disable encryption on the artifact. Only valid when <c>Type</c>
        /// is <c>S3</c>.
        /// </para>
        /// </summary>
        public bool? EncryptionDisabled { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionDisabled property is set.
        /// </summary>
        internal bool IsSetEncryptionDisabled() => this.EncryptionDisabled.HasValue;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Only used when <c>Type</c> is <c>S3</c>. The name of the S3 bucket where the artifact
        /// is located.
        /// </para>
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Only used when Type is S3. The name of the artifact. Used with <c>NamepaceType</c>
        /// and <c>Path</c> to determine the pattern for storing the artifact.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NamespaceType. 
        /// <para>
        /// Only used when <c>Type</c> is <c>S3</c>. The value to use for the namespace. Used
        /// with <c>Name</c> and <c>Path</c> to determine the pattern for storing the artifact.
        /// </para>
        /// </summary>
        public string NamespaceType { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceType property is set.
        /// </summary>
        internal bool IsSetNamespaceType() => this.NamespaceType != null;

        /// <summary>
        /// Gets and sets the property OverrideArtifactName. 
        /// <para>
        /// Whether the name specified in the buildspec file overrides the artifact name.
        /// </para>
        /// </summary>
        public bool? OverrideArtifactName { get; set; }

        /// <summary>
        /// Checks to see if the OverrideArtifactName property is set.
        /// </summary>
        internal bool IsSetOverrideArtifactName() => this.OverrideArtifactName.HasValue;

        /// <summary>
        /// Gets and sets the property Packaging. 
        /// <para>
        /// Only used when <c>Type</c> is <c>S3</c>. The type of output artifact to create.
        /// </para>
        /// </summary>
        public string Packaging { get; set; }

        /// <summary>
        /// Checks to see if the Packaging property is set.
        /// </summary>
        internal bool IsSetPackaging() => this.Packaging != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// Only used when <c>Type</c> is <c>S3</c>. The path to the artifact. Used with <c>Name</c>
        /// and <c>NamespaceType</c> to determine the pattern for storing the artifact.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of build artifact.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
