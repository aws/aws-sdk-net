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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a disk image.
    /// </summary>
    public partial class DiskImageDetail
    {
        private long? _bytes;
        private DiskImageFormat _format;
        private string _importManifestUrl;

        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// The size of the disk image, in GiB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long Bytes
        {
            get { return this._bytes.GetValueOrDefault(); }
            set { this._bytes = value; }
        }

        // Check to see if Bytes property is set
        internal bool IsSetBytes()
        {
            return this._bytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The disk image format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DiskImageFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property ImportManifestUrl. 
        /// <para>
        /// A presigned URL for the import manifest stored in Amazon S3 and presented here as
        /// an Amazon S3 presigned URL. For information about creating a presigned URL for an
        /// Amazon S3 object, read the "Query String Request Authentication Alternative" section
        /// of the <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html">Authenticating
        /// REST Requests</a> topic in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string ImportManifestUrl
        {
            get { return this._importManifestUrl; }
            set { this._importManifestUrl = value; }
        }

        // Check to see if ImportManifestUrl property is set
        internal bool IsSetImportManifestUrl()
        {
            return this._importManifestUrl != null;
        }

    }
}