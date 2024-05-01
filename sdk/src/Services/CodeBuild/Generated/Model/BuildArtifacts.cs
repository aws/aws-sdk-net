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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about build output artifacts.
    /// </summary>
    public partial class BuildArtifacts
    {
        private string _artifactIdentifier;
        private BucketOwnerAccess _bucketOwnerAccess;
        private bool? _encryptionDisabled;
        private string _location;
        private string _md5sum;
        private bool? _overrideArtifactName;
        private string _sha256sum;

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
        /// Gets and sets the property BucketOwnerAccess.
        /// </summary>
        public BucketOwnerAccess BucketOwnerAccess
        {
            get { return this._bucketOwnerAccess; }
            set { this._bucketOwnerAccess = value; }
        }

        // Check to see if BucketOwnerAccess property is set
        internal bool IsSetBucketOwnerAccess()
        {
            return this._bucketOwnerAccess != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionDisabled. 
        /// <para>
        ///  Information that tells you if encryption for build artifacts is disabled. 
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
        /// Information about the location of the build artifacts.
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
        /// Gets and sets the property Md5sum. 
        /// <para>
        /// The MD5 hash of the build artifact.
        /// </para>
        ///  
        /// <para>
        /// You can use this hash along with a checksum tool to confirm file integrity and authenticity.
        /// </para>
        ///  <note> 
        /// <para>
        /// This value is available only if the build project's <c>packaging</c> value is set
        /// to <c>ZIP</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public string Md5sum
        {
            get { return this._md5sum; }
            set { this._md5sum = value; }
        }

        // Check to see if Md5sum property is set
        internal bool IsSetMd5sum()
        {
            return this._md5sum != null;
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
        /// Gets and sets the property Sha256sum. 
        /// <para>
        /// The SHA-256 hash of the build artifact.
        /// </para>
        ///  
        /// <para>
        /// You can use this hash along with a checksum tool to confirm file integrity and authenticity.
        /// </para>
        ///  <note> 
        /// <para>
        /// This value is available only if the build project's <c>packaging</c> value is set
        /// to <c>ZIP</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public string Sha256sum
        {
            get { return this._sha256sum; }
            set { this._sha256sum = value; }
        }

        // Check to see if Sha256sum property is set
        internal bool IsSetSha256sum()
        {
            return this._sha256sum != null;
        }

    }
}