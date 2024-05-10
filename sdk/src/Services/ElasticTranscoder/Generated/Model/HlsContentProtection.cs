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
    /// The HLS content protection settings, if any, that you want Elastic Transcoder to apply
    /// to your output files.
    /// </summary>
    public partial class HlsContentProtection
    {
        private string _initializationVector;
        private string _key;
        private string _keyMd5;
        private string _keyStoragePolicy;
        private string _licenseAcquisitionUrl;
        private string _method;

        /// <summary>
        /// Gets and sets the property InitializationVector. 
        /// <para>
        /// If Elastic Transcoder is generating your key for you, you must leave this field blank.
        /// </para>
        ///  
        /// <para>
        /// The series of random bits created by a random bit generator, unique for every encryption
        /// operation, that you want Elastic Transcoder to use to encrypt your output files. The
        /// initialization vector must be base64-encoded, and it must be exactly 16 bytes before
        /// being base64-encoded.
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
        /// If you want Elastic Transcoder to generate a key for you, leave this field blank.
        /// </para>
        ///  
        /// <para>
        /// If you choose to supply your own key, you must encrypt the key by using AWS KMS. The
        /// key must be base64-encoded, and it must be one of the following bit lengths before
        /// being base64-encoded:
        /// </para>
        ///  
        /// <para>
        ///  <c>128</c>, <c>192</c>, or <c>256</c>. 
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
        /// Gets and sets the property KeyMd5. 
        /// <para>
        /// If Elastic Transcoder is generating your key for you, you must leave this field blank.
        /// </para>
        ///  
        /// <para>
        /// The MD5 digest of the key that you want Elastic Transcoder to use to encrypt your
        /// output file, and that you want Elastic Transcoder to use as a checksum to make sure
        /// your key was not corrupted in transit. The key MD5 must be base64-encoded, and it
        /// must be exactly 16 bytes before being base64- encoded.
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
        /// Gets and sets the property KeyStoragePolicy. 
        /// <para>
        /// Specify whether you want Elastic Transcoder to write your HLS license key to an Amazon
        /// S3 bucket. If you choose <c>WithVariantPlaylists</c>, <c>LicenseAcquisitionUrl</c>
        /// must be left blank and Elastic Transcoder writes your data key into the same bucket
        /// as the associated playlist.
        /// </para>
        /// </summary>
        public string KeyStoragePolicy
        {
            get { return this._keyStoragePolicy; }
            set { this._keyStoragePolicy = value; }
        }

        // Check to see if KeyStoragePolicy property is set
        internal bool IsSetKeyStoragePolicy()
        {
            return this._keyStoragePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseAcquisitionUrl. 
        /// <para>
        /// The location of the license key required to decrypt your HLS playlist. The URL must
        /// be an absolute path, and is referenced in the URI attribute of the EXT-X-KEY metadata
        /// tag in the playlist file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
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

        /// <summary>
        /// Gets and sets the property Method. 
        /// <para>
        /// The content protection method for your output. The only valid value is: <c>aes-128</c>.
        /// </para>
        ///  
        /// <para>
        /// This value is written into the method attribute of the <c>EXT-X-KEY</c> metadata tag
        /// in the output playlist.
        /// </para>
        /// </summary>
        public string Method
        {
            get { return this._method; }
            set { this._method = value; }
        }

        // Check to see if Method property is set
        internal bool IsSetMethod()
        {
            return this._method != null;
        }

    }
}