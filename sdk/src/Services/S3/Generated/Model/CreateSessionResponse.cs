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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the CreateSession operation.
    /// </summary>
    public partial class CreateSessionResponse : AmazonWebServiceResponse
    {
        private bool? _bucketKeyEnabled;
        private SessionCredentials _credentials;
        private ServerSideEncryptionMethod _serverSideEncryption;
        private string _ssekmsEncryptionContext;
        private string _ssekmsKeyId;

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Indicates whether to use an S3 Bucket Key for server-side encryption with KMS keys
        /// (SSE-KMS).
        /// </para>
        /// </summary>
        public bool? BucketKeyEnabled
        {
            get { return this._bucketKeyEnabled; }
            set { this._bucketKeyEnabled = value; }
        }

        // Check to see if BucketKeyEnabled property is set
        internal bool IsSetBucketKeyEnabled()
        {
            return this._bucketKeyEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The established temporary security credentials for the created session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SessionCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryption. 
        /// <para>
        /// The server-side encryption algorithm used when you store objects in the directory
        /// bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// When accessing data stored in Amazon FSx file systems using S3 access points, the
        /// only valid server side encryption option is <c>aws:fsx</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryption
        {
            get { return this._serverSideEncryption; }
            set { this._serverSideEncryption = value; }
        }

        // Check to see if ServerSideEncryption property is set
        internal bool IsSetServerSideEncryption()
        {
            return this._serverSideEncryption != null && this._serverSideEncryption != ServerSideEncryptionMethod.None;
        }

        /// <summary>
        /// Gets and sets the property SSEKMSEncryptionContext. 
        /// <para>
        /// If present, indicates the Amazon Web Services KMS Encryption Context to use for object
        /// encryption. The value of this header is a Base64 encoded string of a UTF-8 encoded
        /// JSON, which contains the encryption context as key-value pairs. This value is stored
        /// as object metadata and automatically gets passed on to Amazon Web Services KMS for
        /// future <c>GetObject</c> operations on this object.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SSEKMSEncryptionContext
        {
            get { return this._ssekmsEncryptionContext; }
            set { this._ssekmsEncryptionContext = value; }
        }

        // Check to see if SSEKMSEncryptionContext property is set
        internal bool IsSetSSEKMSEncryptionContext()
        {
            return this._ssekmsEncryptionContext != null;
        }

        /// <summary>
        /// Gets and sets the property SSEKMSKeyId. 
        /// <para>
        /// If you specify <c>x-amz-server-side-encryption</c> with <c>aws:kms</c>, this header
        /// indicates the ID of the KMS symmetric encryption customer managed key that was used
        /// for object encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SSEKMSKeyId
        {
            get { return this._ssekmsKeyId; }
            set { this._ssekmsKeyId = value; }
        }

        // Check to see if SSEKMSKeyId property is set
        internal bool IsSetSSEKMSKeyId()
        {
            return this._ssekmsKeyId != null;
        }

    }
}