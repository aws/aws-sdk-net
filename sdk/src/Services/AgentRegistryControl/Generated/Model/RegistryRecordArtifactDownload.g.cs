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
    /// The skill package of a registry record, as a short-lived download URL and the package's
    /// SHA-256 checksum. Responses never include the package bytes.
    /// </summary>
    public partial class RegistryRecordArtifactDownload
    {
        /// <summary>
        /// Gets and sets the property DownloadUrl. 
        /// <para>
        /// A presigned Amazon S3 URL that downloads the package. The URL is valid for up to 5
        /// minutes, and the response doesn't include its expiry time. To get a new URL, call
        /// the operation again. Anyone who has the URL can download the package until it expires,
        /// so don't log, store, or share it.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Checks to see if the DownloadUrl property is set.
        /// </summary>
        internal bool IsSetDownloadUrl() => this.DownloadUrl != null;

        /// <summary>
        /// Gets and sets the property Sha256. 
        /// <para>
        /// The SHA-256 checksum of the package, as 64 lowercase hexadecimal characters. The download
        /// response carries no signature that you can check, so compare the checksum of the file
        /// that you download with this value before you use the package.
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
