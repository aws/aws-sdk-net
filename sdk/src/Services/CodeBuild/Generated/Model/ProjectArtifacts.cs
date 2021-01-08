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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the build output artifacts for the build project.
    /// </summary>
    public partial class ProjectArtifacts
    {
        private string _artifactIdentifier;
        private bool? _encryptionDisabled;
        private string _location;
        private string _name;
        private ArtifactNamespace _namespaceType;
        private bool? _overrideArtifactName;
        private ArtifactPackaging _packaging;
        private string _path;
        private ArtifactsType _type;

        /// <summary>
        /// Gets and sets the property ArtifactIdentifier. 
        /// <para>
        ///  An identifier for this artifact definition. 
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
        ///  Set to true if you do not want your output artifacts encrypted. This option is valid
        /// only if your artifacts type is Amazon Simple Storage Service (Amazon S3). If this
        /// is set with another artifacts type, an invalidInputException is thrown. 
        /// </para>
        /// </summary>
        public bool EncryptionDisabled
        {
            get { return this._encryptionDisabled.GetValueOrDefault(); }
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
        /// Information about the build output artifact location:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <code>type</code> is set to <code>CODEPIPELINE</code>, AWS CodePipeline ignores
        /// this value if specified. This is because AWS CodePipeline manages its build output
        /// locations instead of AWS CodeBuild.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>type</code> is set to <code>NO_ARTIFACTS</code>, this value is ignored if
        /// specified, because no build output is produced.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>type</code> is set to <code>S3</code>, this is the name of the output bucket.
        /// </para>
        ///  </li> </ul>
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
        /// Along with <code>path</code> and <code>namespaceType</code>, the pattern that AWS
        /// CodeBuild uses to name and store the output artifact:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <code>type</code> is set to <code>CODEPIPELINE</code>, AWS CodePipeline ignores
        /// this value if specified. This is because AWS CodePipeline manages its build output
        /// names instead of AWS CodeBuild.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>type</code> is set to <code>NO_ARTIFACTS</code>, this value is ignored if
        /// specified, because no build output is produced.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>type</code> is set to <code>S3</code>, this is the name of the output artifact
        /// object. If you set the name to be a forward slash ("/"), the artifact is stored in
        /// the root of the output bucket.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If <code>path</code> is set to <code>MyArtifacts</code>, <code>namespaceType</code>
        /// is set to <code>BUILD_ID</code>, and <code>name</code> is set to <code>MyArtifact.zip</code>,
        /// then the output artifact is stored in <code>MyArtifacts/&lt;build-ID&gt;/MyArtifact.zip</code>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If <code>path</code> is empty, <code>namespaceType</code> is set to <code>NONE</code>,
        /// and <code>name</code> is set to "<code>/</code>", the output artifact is stored in
        /// the root of the output bucket. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If <code>path</code> is set to <code>MyArtifacts</code>, <code>namespaceType</code>
        /// is set to <code>BUILD_ID</code>, and <code>name</code> is set to "<code>/</code>",
        /// the output artifact is stored in <code>MyArtifacts/&lt;build-ID&gt;</code>. 
        /// </para>
        ///  </li> </ul>
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
        /// Along with <code>path</code> and <code>name</code>, the pattern that AWS CodeBuild
        /// uses to determine the name and location to store the output artifact:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <code>type</code> is set to <code>CODEPIPELINE</code>, AWS CodePipeline ignores
        /// this value if specified. This is because AWS CodePipeline manages its build output
        /// names instead of AWS CodeBuild.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>type</code> is set to <code>NO_ARTIFACTS</code>, this value is ignored if
        /// specified, because no build output is produced.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>type</code> is set to <code>S3</code>, valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BUILD_ID</code>: Include the build ID in the location of the build output artifact.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NONE</code>: Do not include the build ID. This is the default if <code>namespaceType</code>
        /// is not specified.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For example, if <code>path</code> is set to <code>MyArtifacts</code>, <code>namespaceType</code>
        /// is set to <code>BUILD_ID</code>, and <code>name</code> is set to <code>MyArtifact.zip</code>,
        /// the output artifact is stored in <code>MyArtifacts/&lt;build-ID&gt;/MyArtifact.zip</code>.
        /// </para>
        /// </summary>
        public ArtifactNamespace NamespaceType
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
        ///  If this flag is set, a name specified in the buildspec file overrides the artifact
        /// name. The name specified in a buildspec file is calculated at build time and uses
        /// the Shell Command Language. For example, you can append a date and time to your artifact
        /// name so that it is always unique. 
        /// </para>
        /// </summary>
        public bool OverrideArtifactName
        {
            get { return this._overrideArtifactName.GetValueOrDefault(); }
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
        /// The type of build output artifact to create:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <code>type</code> is set to <code>CODEPIPELINE</code>, AWS CodePipeline ignores
        /// this value if specified. This is because AWS CodePipeline manages its build output
        /// artifacts instead of AWS CodeBuild.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>type</code> is set to <code>NO_ARTIFACTS</code>, this value is ignored if
        /// specified, because no build output is produced.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>type</code> is set to <code>S3</code>, valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NONE</code>: AWS CodeBuild creates in the output bucket a folder that contains
        /// the build output. This is the default if <code>packaging</code> is not specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ZIP</code>: AWS CodeBuild creates in the output bucket a ZIP file that contains
        /// the build output.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public ArtifactPackaging Packaging
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
        /// Along with <code>namespaceType</code> and <code>name</code>, the pattern that AWS
        /// CodeBuild uses to name and store the output artifact:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <code>type</code> is set to <code>CODEPIPELINE</code>, AWS CodePipeline ignores
        /// this value if specified. This is because AWS CodePipeline manages its build output
        /// names instead of AWS CodeBuild.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>type</code> is set to <code>NO_ARTIFACTS</code>, this value is ignored if
        /// specified, because no build output is produced.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>type</code> is set to <code>S3</code>, this is the path to the output artifact.
        /// If <code>path</code> is not specified, <code>path</code> is not used.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, if <code>path</code> is set to <code>MyArtifacts</code>, <code>namespaceType</code>
        /// is set to <code>NONE</code>, and <code>name</code> is set to <code>MyArtifact.zip</code>,
        /// the output artifact is stored in the output bucket at <code>MyArtifacts/MyArtifact.zip</code>.
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
        /// The type of build output artifact. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CODEPIPELINE</code>: The build project has build output generated through AWS
        /// CodePipeline. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>CODEPIPELINE</code> type is not supported for <code>secondaryArtifacts</code>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <code>NO_ARTIFACTS</code>: The build project does not produce any build output.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>S3</code>: The build project stores build output in Amazon Simple Storage Service
        /// (Amazon S3).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ArtifactsType Type
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