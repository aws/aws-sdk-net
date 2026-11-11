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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a disk image.
    /// </summary>
    public partial class DiskImageDescription
    {
        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The checksum computed for the disk image.
        /// </para>
        /// </summary>
        public string Checksum { get; set; }

        /// <summary>
        /// Checks to see if the Checksum property is set.
        /// </summary>
        internal bool IsSetChecksum() => this.Checksum != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The disk image format.
        /// </para>
        /// </summary>
        public DiskImageFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property ImportManifestUrl. 
        /// <para>
        /// A presigned URL for the import manifest stored in Amazon S3. For information about
        /// creating a presigned URL for an Amazon S3 object, read the "Query String Request Authentication
        /// Alternative" section of the <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html">Authenticating
        /// REST Requests</a> topic in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ImportManifestUrl { get; set; }

        /// <summary>
        /// Checks to see if the ImportManifestUrl property is set.
        /// </summary>
        internal bool IsSetImportManifestUrl() => this.ImportManifestUrl != null;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the disk image, in GiB.
        /// </para>
        /// </summary>
        public long? Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size.HasValue;
    }
}
