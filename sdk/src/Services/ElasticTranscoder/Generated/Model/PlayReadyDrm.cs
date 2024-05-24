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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// The PlayReady DRM settings, if any, that you want Elastic Transcoder to apply to the
    /// output files associated with this playlist.
    /// 
    ///  
    /// <para>
    /// PlayReady DRM encrypts your media files using <c>aes-ctr</c> encryption.
    /// </para>
    ///  
    /// <para>
    /// If you use DRM for an <c>HLSv3</c> playlist, your outputs must have a master playlist.
    /// </para>
    /// </summary>
    public partial class PlayReadyDrm
    {
        private string _format;
        private string _initializationVector;
        private string _key;
        private string _keyId;
        private string _keyMd5;
        private string _licenseAcquisitionUrl;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The type of DRM, if any, that you want Elastic Transcoder to apply to the output files
        /// associated with this playlist.
        /// </para>
        /// </summary>
        public string Format
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
        /// Gets and sets the property InitializationVector. 
        /// <para>
        /// The series of random bits created by a random bit generator, unique for every encryption
        /// operation, that you want Elastic Transcoder to use to encrypt your files. The initialization
        /// vector must be base64-encoded, and it must be exactly 8 bytes long before being base64-encoded.
        /// If no initialization vector is provided, Elastic Transcoder generates one for you.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string InitializationVector
        {
            get { return this._initializationVector; }
            set { this._initializationVector = value; }
        }

        // Check to see if InitializationVector property is set
        internal bool IsSetInitializationVector()
        {
            return this._initializationVector != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The DRM key for your file, provided by your DRM license provider. The key must be
        /// base64-encoded, and it must be one of the following bit lengths before being base64-encoded:
        /// </para>
        ///  
        /// <para>
        ///  <c>128</c>, <c>192</c>, or <c>256</c>. 
        /// </para>
        ///  
        /// <para>
        /// The key must also be encrypted by using AWS KMS.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The ID for your DRM key, so that your DRM license provider knows which key to provide.
        /// </para>
        ///  
        /// <para>
        /// The key ID must be provided in big endian, and Elastic Transcoder converts it to little
        /// endian before inserting it into the PlayReady DRM headers. If you are unsure whether
        /// your license server provides your key ID in big or little endian, check with your
        /// DRM provider.
        /// </para>
        /// </summary>
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property KeyMd5. 
        /// <para>
        /// The MD5 digest of the key used for DRM on your file, and that you want Elastic Transcoder
        /// to use as a checksum to make sure your key was not corrupted in transit. The key MD5
        /// must be base64-encoded, and it must be exactly 16 bytes before being base64-encoded.
        /// </para>
        /// </summary>
        public string KeyMd5
        {
            get { return this._keyMd5; }
            set { this._keyMd5 = value; }
        }

        // Check to see if KeyMd5 property is set
        internal bool IsSetKeyMd5()
        {
            return this._keyMd5 != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseAcquisitionUrl. 
        /// <para>
        /// The location of the license key required to play DRM content. The URL must be an absolute
        /// path, and is referenced by the PlayReady header. The PlayReady header is referenced
        /// in the protection header of the client manifest for Smooth Streaming outputs, and
        /// in the EXT-X-DXDRM and EXT-XDXDRMINFO metadata tags for HLS playlist outputs. An example
        /// URL looks like this: <c>https://www.example.com/exampleKey/</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LicenseAcquisitionUrl
        {
            get { return this._licenseAcquisitionUrl; }
            set { this._licenseAcquisitionUrl = value; }
        }

        // Check to see if LicenseAcquisitionUrl property is set
        internal bool IsSetLicenseAcquisitionUrl()
        {
            return this._licenseAcquisitionUrl != null;
        }

    }
}