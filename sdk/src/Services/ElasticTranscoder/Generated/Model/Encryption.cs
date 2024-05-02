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
    /// The encryption settings, if any, that are used for decrypting your input files or
    /// encrypting your output files. If your input file is encrypted, you must specify the
    /// mode that Elastic Transcoder uses to decrypt your file, otherwise you must specify
    /// the mode you want Elastic Transcoder to use to encrypt your output files.
    /// </summary>
    public partial class Encryption
    {
        private string _initializationVector;
        private string _key;
        private string _keyMd5;
        private string _mode;

        /// <summary>
        /// Gets and sets the property InitializationVector. 
        /// <para>
        /// The series of random bits created by a random bit generator, unique for every encryption
        /// operation, that you used to encrypt your input files or that you want Elastic Transcoder
        /// to use to encrypt your output files. The initialization vector must be base64-encoded,
        /// and it must be exactly 16 bytes long before being base64-encoded.
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
        /// The data encryption key that you want Elastic Transcoder to use to encrypt your output
        /// file, or that was used to encrypt your input file. The key must be base64-encoded
        /// and it must be one of the following bit lengths before being base64-encoded:
        /// </para>
        ///  
        /// <para>
        ///  <c>128</c>, <c>192</c>, or <c>256</c>. 
        /// </para>
        ///  
        /// <para>
        /// The key must also be encrypted by using the Amazon Key Management Service.
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
        /// The MD5 digest of the key that you used to encrypt your input file, or that you want
        /// Elastic Transcoder to use to encrypt your output file. Elastic Transcoder uses the
        /// key digest as a checksum to make sure your key was not corrupted in transit. The key
        /// MD5 must be base64-encoded, and it must be exactly 16 bytes long before being base64-encoded.
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
        /// Gets and sets the property Mode. 
        /// <para>
        /// The specific server-side encryption mode that you want Elastic Transcoder to use when
        /// decrypting your input files or encrypting your output files. Elastic Transcoder supports
        /// the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>s3:</b> Amazon S3 creates and manages the keys used for encrypting your files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>s3-aws-kms:</b> Amazon S3 calls the Amazon Key Management Service, which creates
        /// and manages the keys that are used for encrypting your files. If you specify <c>s3-aws-kms</c>
        /// and you don't want to use the default key, you must add the AWS-KMS key that you want
        /// to use to your pipeline.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>aes-cbc-pkcs7:</b> A padded cipher-block mode of operation originally used for
        /// HLS files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>aes-ctr:</b> AES Counter Mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>aes-gcm:</b> AES Galois Counter Mode, a mode of operation that is an authenticated
        /// encryption format, meaning that a file, key, or initialization vector that has been
        /// tampered with fails the decryption process.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For all three AES options, you must provide the following settings, which must be
        /// base64-encoded:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Key</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Key MD5</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Initialization Vector</b> 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// For the AES modes, your private encryption keys and your unencrypted data are never
        /// stored by AWS; therefore, it is important that you safely manage your encryption keys.
        /// If you lose them, you won't be able to unencrypt your data.
        /// </para>
        ///  </important>
        /// </summary>
        public string Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}