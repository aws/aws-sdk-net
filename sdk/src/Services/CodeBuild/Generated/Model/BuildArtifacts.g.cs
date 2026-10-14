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
    /// Information about build output artifacts.
    /// </summary>
    public partial class BuildArtifacts
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
        ///  Information that tells you if encryption for build artifacts is disabled. 
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
        /// Information about the location of the build artifacts.
        /// </para>
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

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
        public string Md5sum { get; set; }

        /// <summary>
        /// Checks to see if the Md5sum property is set.
        /// </summary>
        internal bool IsSetMd5sum() => this.Md5sum != null;

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
        public string Sha256sum { get; set; }

        /// <summary>
        /// Checks to see if the Sha256sum property is set.
        /// </summary>
        internal bool IsSetSha256sum() => this.Sha256sum != null;
    }
}
