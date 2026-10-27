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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the build output artifacts for the build project.
    /// </summary>
    public partial class ProjectArtifacts
    {
        /// <summary>
        /// Gets and sets the property ArtifactIdentifier. 
        /// <para>
        ///  An identifier for this artifact definition. 
        /// </para>
        /// </summary>
        public string ArtifactIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactIdentifier property is set.
        /// </summary>
        internal bool IsSetArtifactIdentifier() => this.ArtifactIdentifier != null;

        /// <summary>
        /// Gets and sets the property BucketOwnerAccess.
        /// </summary>
        public BucketOwnerAccess BucketOwnerAccess { get; set; }

        /// <summary>
        /// Checks to see if the BucketOwnerAccess property is set.
        /// </summary>
        internal bool IsSetBucketOwnerAccess() => this.BucketOwnerAccess != null;

        /// <summary>
        /// Gets and sets the property EncryptionDisabled. 
        /// <para>
        ///  Set to true if you do not want your output artifacts encrypted. This option is valid
        /// only if your artifacts type is Amazon S3. If this is set with another artifacts type,
        /// an invalidInputException is thrown. 
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
        /// Information about the build output artifact location:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>type</c> is set to <c>CODEPIPELINE</c>, CodePipeline ignores this value if specified.
        /// This is because CodePipeline manages its build output locations instead of CodeBuild.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>type</c> is set to <c>NO_ARTIFACTS</c>, this value is ignored if specified,
        /// because no build output is produced.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>type</c> is set to <c>S3</c>, this is the name of the output bucket.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Along with <c>path</c> and <c>namespaceType</c>, the pattern that CodeBuild uses to
        /// name and store the output artifact:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>type</c> is set to <c>CODEPIPELINE</c>, CodePipeline ignores this value if specified.
        /// This is because CodePipeline manages its build output names instead of CodeBuild.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>type</c> is set to <c>NO_ARTIFACTS</c>, this value is ignored if specified,
        /// because no build output is produced.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>type</c> is set to <c>S3</c>, this is the name of the output artifact object.
        /// If you set the name to be a forward slash ("/"), the artifact is stored in the root
        /// of the output bucket.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If <c>path</c> is set to <c>MyArtifacts</c>, <c>namespaceType</c> is set to <c>BUILD_ID</c>,
        /// and <c>name</c> is set to <c>MyArtifact.zip</c>, then the output artifact is stored
        /// in <c>MyArtifacts/&lt;build-ID&gt;/MyArtifact.zip</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If <c>path</c> is empty, <c>namespaceType</c> is set to <c>NONE</c>, and <c>name</c>
        /// is set to "<c>/</c>", the output artifact is stored in the root of the output bucket.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If <c>path</c> is set to <c>MyArtifacts</c>, <c>namespaceType</c> is set to <c>BUILD_ID</c>,
        /// and <c>name</c> is set to "<c>/</c>", the output artifact is stored in <c>MyArtifacts/&lt;build-ID&gt;</c>.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NamespaceType. 
        /// <para>
        /// Along with <c>path</c> and <c>name</c>, the pattern that CodeBuild uses to determine
        /// the name and location to store the output artifact:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>type</c> is set to <c>CODEPIPELINE</c>, CodePipeline ignores this value if specified.
        /// This is because CodePipeline manages its build output names instead of CodeBuild.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>type</c> is set to <c>NO_ARTIFACTS</c>, this value is ignored if specified,
        /// because no build output is produced.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>type</c> is set to <c>S3</c>, valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BUILD_ID</c>: Include the build ID in the location of the build output artifact.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c>: Do not include the build ID. This is the default if <c>namespaceType</c>
        /// is not specified.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For example, if <c>path</c> is set to <c>MyArtifacts</c>, <c>namespaceType</c> is
        /// set to <c>BUILD_ID</c>, and <c>name</c> is set to <c>MyArtifact.zip</c>, the output
        /// artifact is stored in <c>MyArtifacts/&lt;build-ID&gt;/MyArtifact.zip</c>.
        /// </para>
        /// </summary>
        public ArtifactNamespace NamespaceType { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceType property is set.
        /// </summary>
        internal bool IsSetNamespaceType() => this.NamespaceType != null;

        /// <summary>
        /// Gets and sets the property OverrideArtifactName. 
        /// <para>
        ///  If this flag is set, a name specified in the buildspec file overrides the artifact
        /// name. The name specified in a buildspec file is calculated at build time and uses
        /// the Shell Command Language. For example, you can append a date and time to your artifact
        /// name so that it is always unique. 
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
        /// The type of build output artifact to create:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>type</c> is set to <c>CODEPIPELINE</c>, CodePipeline ignores this value if specified.
        /// This is because CodePipeline manages its build output artifacts instead of CodeBuild.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>type</c> is set to <c>NO_ARTIFACTS</c>, this value is ignored if specified,
        /// because no build output is produced.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>type</c> is set to <c>S3</c>, valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c>: CodeBuild creates in the output bucket a folder that contains the build
        /// output. This is the default if <c>packaging</c> is not specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ZIP</c>: CodeBuild creates in the output bucket a ZIP file that contains the build
        /// output.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public ArtifactPackaging Packaging { get; set; }

        /// <summary>
        /// Checks to see if the Packaging property is set.
        /// </summary>
        internal bool IsSetPackaging() => this.Packaging != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// Along with <c>namespaceType</c> and <c>name</c>, the pattern that CodeBuild uses to
        /// name and store the output artifact:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>type</c> is set to <c>CODEPIPELINE</c>, CodePipeline ignores this value if specified.
        /// This is because CodePipeline manages its build output names instead of CodeBuild.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>type</c> is set to <c>NO_ARTIFACTS</c>, this value is ignored if specified,
        /// because no build output is produced.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>type</c> is set to <c>S3</c>, this is the path to the output artifact. If <c>path</c>
        /// is not specified, <c>path</c> is not used.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, if <c>path</c> is set to <c>MyArtifacts</c>, <c>namespaceType</c> is
        /// set to <c>NONE</c>, and <c>name</c> is set to <c>MyArtifact.zip</c>, the output artifact
        /// is stored in the output bucket at <c>MyArtifacts/MyArtifact.zip</c>.
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
        /// The type of build output artifact. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CODEPIPELINE</c>: The build project has build output generated through CodePipeline.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>CODEPIPELINE</c> type is not supported for <c>secondaryArtifacts</c>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>NO_ARTIFACTS</c>: The build project does not produce any build output.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3</c>: The build project stores build output in Amazon S3.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ArtifactsType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
