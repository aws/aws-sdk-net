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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// A skill package to upload with a registry record: a ZIP archive of a skill that follows
    /// the Agent Skills specification. The registry validates the package asynchronously,
    /// stores it, and sets <c>skillMd.data</c> from the package's SKILL.md.
    /// </summary>
    public partial class RegistryRecordArtifactUpload
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The ZIP archive of the skill package, up to 5 MiB (5,242,880 bytes). In a JSON request,
        /// the content is base64-encoded. The Amazon Web Services SDKs encode it for you.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public MemoryStream Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property Sha256. 
        /// <para>
        /// The optional SHA-256 checksum of the ZIP archive, as 64 lowercase hexadecimal characters,
        /// computed over the archive's bytes rather than its base64 text. If it doesn't match
        /// the content, the request fails with a <c>ValidationException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 64, Max = 64)]
        public string Sha256 { get; set; }

        /// <summary>
        /// Checks to see if the Sha256 property is set.
        /// </summary>
        internal bool IsSetSha256() => this.Sha256 != null;
    }
}
