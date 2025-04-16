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
    /// This is the response object from the CopyObject operation.
    /// </summary>
    public partial class CopyObjectResponse : AmazonWebServiceResponse
    {
        private bool? _bucketKeyEnabled;
        private CopyObjectResult _copyObjectResult;
        private string _expiration;
        private RequestCharged _requestCharged;
        private ServerSideEncryption _serverSideEncryption;
        private string _sourceVersionId;
        private string _sseCustomerAlgorithm;
        private string _sseCustomerKeyMD5;
        private string _ssekmsEncryptionContext;
        private string _ssekmsKeyId;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Indicates whether the copied object uses an S3 Bucket Key for server-side encryption
        /// with Key Management Service (KMS) keys (SSE-KMS).
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
        /// Gets and sets the property CopyObjectResult. 
        /// <para>
        /// Container for all response elements.
        /// </para>
        /// </summary>
        public CopyObjectResult CopyObjectResult
        {
            get { return this._copyObjectResult; }
            set { this._copyObjectResult = value; }
        }

        // Check to see if CopyObjectResult property is set
        internal bool IsSetCopyObjectResult()
        {
            return this._copyObjectResult != null;
        }

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// If the object expiration is configured, the response includes this header.
        /// </para>
        ///  <note> 
        /// <para>
        /// Object expiration information is not returned in directory buckets and this header
        /// returns the value "<c>NotImplemented</c>" in all responses for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string Expiration
        {
            get { return this._expiration; }
            set { this._expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCharged.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this._requestCharged; }
            set { this._requestCharged = value; }
        }

        // Check to see if RequestCharged property is set
        internal bool IsSetRequestCharged()
        {
            return this._requestCharged != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryption. 
        /// <para>
        /// The server-side encryption algorithm used when you store this object in Amazon S3
        /// (for example, <c>AES256</c>, <c>aws:kms</c>, <c>aws:kms:dsse</c>).
        /// </para>
        /// </summary>
        public ServerSideEncryption ServerSideEncryption
        {
            get { return this._serverSideEncryption; }
            set { this._serverSideEncryption = value; }
        }

        // Check to see if ServerSideEncryption property is set
        internal bool IsSetServerSideEncryption()
        {
            return this._serverSideEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property SourceVersionId. 
        /// <para>
        /// Version ID of the source object that was copied.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported when the source object is in a directory bucket.
        /// </para>
        ///  </note>
        /// </summary>
        public string SourceVersionId
        {
            get { return this._sourceVersionId; }
            set { this._sourceVersionId = value; }
        }

        // Check to see if SourceVersionId property is set
        internal bool IsSetSourceVersionId()
        {
            return this._sourceVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property SSECustomerAlgorithm. 
        /// <para>
        /// If server-side encryption with a customer-provided encryption key was requested, the
        /// response will include this header to confirm the encryption algorithm that's used.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string SSECustomerAlgorithm
        {
            get { return this._sseCustomerAlgorithm; }
            set { this._sseCustomerAlgorithm = value; }
        }

        // Check to see if SSECustomerAlgorithm property is set
        internal bool IsSetSSECustomerAlgorithm()
        {
            return this._sseCustomerAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property SSECustomerKeyMD5. 
        /// <para>
        /// If server-side encryption with a customer-provided encryption key was requested, the
        /// response will include this header to provide the round-trip message integrity verification
        /// of the customer-provided encryption key.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string SSECustomerKeyMD5
        {
            get { return this._sseCustomerKeyMD5; }
            set { this._sseCustomerKeyMD5 = value; }
        }

        // Check to see if SSECustomerKeyMD5 property is set
        internal bool IsSetSSECustomerKeyMD5()
        {
            return this._sseCustomerKeyMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property SSEKMSEncryptionContext. 
        /// <para>
        /// If present, indicates the Amazon Web Services KMS Encryption Context to use for object
        /// encryption. The value of this header is a Base64 encoded UTF-8 string holding JSON
        /// with the encryption context key-value pairs.
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
        /// If present, indicates the ID of the KMS key that was used for object encryption.
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

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID of the newly created copy.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}