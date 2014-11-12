/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System;
using System.Xml.Serialization;
using Amazon.Runtime;
using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to create a pre-signed URL to a bucket or object. 
    /// </summary>
    /// <remarks>
    /// For more information, refer to: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/S3_QSAuth.html"/>.
    /// <br />Required Parameters: BucketName, Expires
    /// <br />Optional Parameters: Key, VersionId, Verb: default is GET
    /// </remarks>
    public class GetPreSignedUrlRequest : AmazonWebServiceRequest
    {
        #region Private Members

        ResponseHeaderOverrides _responseHeaders;
        string bucketName;
        string key;
        DateTime? expires;
        Protocol protocol;
        HttpVerb verb;
        string versionId;
        ServerSideEncryptionMethod encryption;
        private string serverSideEncryptionKeyManagementServiceKeyId;
        private HeadersCollection headersCollection = new HeadersCollection();
        private MetadataCollection metadataCollection = new MetadataCollection();

        private ServerSideEncryptionCustomerMethod serverSideCustomerEncryption;

        #endregion

        #region BucketName

        /// <summary>
        /// The name of the bucket to create a pre-signed url to, or containing the object.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Checks if BucketName property is set.
        /// </summary>
        /// <returns>true if BucketName property is set.</returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this.bucketName);
        }

        #endregion

        #region Key

        /// <summary>
        /// The key to the object for which a pre-signed url should be created.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Checks if Key property is set.
        /// </summary>
        /// <returns>true if Key property is set.</returns>
        internal bool IsSetKey()
        {
            return !System.String.IsNullOrEmpty(this.key);
        }

        #endregion

        #region ContentType
        /// <summary>
        /// A standard MIME type describing the format of the object data.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The content type for the content being uploaded. This property defaults to "binary/octet-stream".
        /// For more information, refer to: <see href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.17"/>.
        /// </para>
        /// <para>
        /// Note that if content type is specified, it should also be included in the HttpRequest headers
        /// of the eventual upload request, otherwise a signature error may result.
        /// </para>
        /// </remarks>
        public string ContentType
        {
            get { return this.headersCollection.ContentType; }
            set { this.headersCollection.ContentType = value; }
        }

        #endregion

        #region Expires
        /// <summary>
        /// The expiry date and time for the pre-signed url.
        /// </summary>
        public DateTime Expires
        {
            get { return this.expires.GetValueOrDefault(); }
            set { this.expires = value; }
        }

        /// <summary>
        /// Checks if Expires property is set.
        /// </summary>
        /// <returns>true if Expires property is set.</returns>
        public bool IsSetExpires()
        {
            return this.expires.HasValue;
        }

        #endregion

        #region Protocol

        /// <summary>
        /// The requested protocol (http/https) for the pre-signed url.
        /// </summary>
        /// <remarks>
        /// Defaults to https.
        /// </remarks>
        public Protocol Protocol
        {
            get { return this.protocol; }
            set { this.protocol = value; }
        }

        #endregion

        #region Verb
        /// <summary>
        /// The verb for the pre-signed url. 
        /// </summary>
        /// <remarks>
        /// Accepted verbs are GET, PUT, DELETE and HEAD.
        /// Default is GET.
        /// </remarks>
        public HttpVerb Verb
        {
            get { return this.verb; }
            set { this.verb = value; }
        }

        #endregion

        #region VersionId

        /// <summary>
        /// Version id for the object that the pre-signed url will reference. If not set,
        /// the url will reference the latest version of the object.
        /// </summary>
        /// <remarks>
        /// This is the VersionId for the S3 Object you want to get
        /// a PreSigned URL for. The VersionId property will be ignored
        /// for PreSigned "PUT" requests and for requests that don't specify
        /// the Key property.
        /// </remarks>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// Checks if VersionId property is set.
        /// </summary>
        /// <returns>true if VersionId property is set.</returns>
        internal bool IsSetVersionId()
        {
            return !System.String.IsNullOrEmpty(this.versionId);
        }

        #endregion

        #region ServerSideEncryption

        /// <summary>
        /// Specifies the encryption used on the server to store the content.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Default is None.
        /// </para>
        /// <para>
        /// If specifying encryption (not None), the corresponding request must include header
        /// "x-amz-server-side-encryption" with the value of the encryption.
        /// </para>
        /// </remarks>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.encryption; }
            set { this.encryption = value; }
        }

        /// <summary>
        /// The id of the AWS Key Management Service key that Amazon S3 should use to encrypt and decrypt the object.
        /// If a key id is not specified, the default key will be used for encryption and decryption.
        /// </summary>
        public string ServerSideEncryptionKeyManagementServiceKeyId
        {
            get { return this.serverSideEncryptionKeyManagementServiceKeyId; }
            set { this.serverSideEncryptionKeyManagementServiceKeyId = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionKeyManagementServiceKeyId property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionKeyManagementServiceKeyId property is set.</returns>
        internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionKeyManagementServiceKeyId);
        }

        #endregion

        #region ServerSideEncryption Customer Key

        /// <summary>
        /// The Server-side encryption algorithm to be used with the customer provided key.
        ///  
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod
        {
            get { return this.serverSideCustomerEncryption; }
            set { this.serverSideCustomerEncryption = value; }
        }

        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionCustomerMethod()
        {
            return this.serverSideCustomerEncryption != null && this.serverSideCustomerEncryption != ServerSideEncryptionCustomerMethod.None;
        }

        #endregion

        #region Response Headers

        /// <summary>
        /// A set of response headers that should be returned with the pre-signed url creation response.
        /// </summary>
        public ResponseHeaderOverrides ResponseHeaderOverrides
        {
            get
            {
                if (this._responseHeaders == null)
                {
                    this._responseHeaders = new ResponseHeaderOverrides();
                }
                return this._responseHeaders;
            }
            set
            {
                this._responseHeaders = value;
            }
        }


        #endregion

        #region Headers

        /// <summary>
        /// The collection of headers for the request.
        /// </summary>
        public HeadersCollection Headers
        {
            get
            {
                if (this.headersCollection == null)
                    this.headersCollection = new HeadersCollection();
                return this.headersCollection;
            }
            internal set
            {
                this.headersCollection = value;
            }
        }

        #endregion

        #region Metadata

        /// <summary>
        /// The collection of meta data for the request.
        /// </summary>
        public MetadataCollection Metadata
        {
            get
            {
                if (this.metadataCollection == null)
                    this.metadataCollection = new MetadataCollection();
                return this.metadataCollection;
            }
            internal set
            {
                this.metadataCollection = value;
            }
        }

        #endregion
    }
}