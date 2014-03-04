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
    public class GetPreSignedUrlRequest : S3Request
    {
        #region Private Members

        ResponseHeaderOverrides _responseHeaders;
        string bucketName;
        string contentType;
        string key;
        DateTime? expires;
        Protocol protocol;
        HttpVerb verb;
        string versionId;
        ServerSideEncryptionMethod encryption;

        #endregion

        #region BucketName

        /// <summary>
        /// The name of the bucket to create a pre-signed url to, or containing the object.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket for which a pre-signed url is requested, or containing the object
        /// with key Key.
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetPreSignedUrlRequest WithBucketName(string bucketName)
        {
            this.bucketName = bucketName;
            return this;
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
        [XmlElementAttribute(ElementName = "Key")]
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the key to the object for which a pre-signed url should be created.
        /// </summary>
        /// <param name="key">The object key</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetPreSignedUrlRequest WithKey(string key)
        {
            this.key = key;
            return this;
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
        /// The content type for the content being uploaded. This property defaults to "binary/octet-stream".
        /// For more information, refer to: <see href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.17"/>
        /// </remarks>
        [XmlElementAttribute(ElementName = "ContentType")]
        public string ContentType
        {
            get { return this.contentType; }
            set { this.contentType = value; }
        }

        /// <summary>
        /// A standard MIME type describing the format of the object data.
        /// </summary>
        /// <remarks>
        /// The content type for the content being uploaded. This property defaults to "binary/octet-stream".
        /// For more information, refer to: <see href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.17"/>
        /// </remarks>
        /// <param name="contentType">The content type required</param>
        /// <returns>The request with the ContentType set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetPreSignedUrlRequest WithContentType(string contentType)
        {
            this.contentType = contentType;
            return this;
        }

        /// <summary>
        /// Checks if ContentType property is set.
        /// </summary>
        /// <returns>true if ContentType property is set.</returns>
        internal bool IsSetContentType()
        {
            return !System.String.IsNullOrEmpty(this.contentType);
        }

        #endregion

        #region Expires
        /// <summary>
        /// The expiry date and time for the pre-signed url.
        /// </summary>
        [XmlElementAttribute(ElementName = "Expires")]
        public DateTime Expires
        {
            get { return this.expires.GetValueOrDefault(); }
            set { this.expires = value; }
        }

        /// <summary>
        /// Sets the expiry date and time for the pre-signed url.
        /// </summary>
        /// <param name="expires">Expiry date</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetPreSignedUrlRequest WithExpires(DateTime expires)
        {
            this.expires = expires;
            return this;
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
        [XmlElementAttribute(ElementName = "Protocol")]
        public Protocol Protocol
        {
            get { return this.protocol; }
            set { this.protocol = value; }
        }

        /// <summary>
        /// Sets the requested protocol (http/https) for the pre-signed url.
        /// </summary>
        /// <remarks>
        /// Defaults to https.
        /// </remarks>
        /// <param name="protocol">Protocol type for the url</param>
        /// <returns>the response with the Protocol set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetPreSignedUrlRequest WithProtocol(Protocol protocol)
        {
            this.protocol = protocol;
            return this;
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
        [XmlElementAttribute(ElementName = "Verb")]
        public HttpVerb Verb
        {
            get { return this.verb; }
            set { this.verb = value; }
        }

        /// <summary>
        /// Sets the verb for the pre-signed url. 
        /// </summary>
        /// <remarks>
        /// Accepted verbs are GET, PUT, DELETE and HEAD.
        /// Default is GET.
        /// </remarks>
        /// <param name="verb">Requested verb</param>
        /// <returns>the response with the Verb set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetPreSignedUrlRequest WithVerb(HttpVerb verb)
        {
            Verb = verb;
            return this;
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
        [XmlElementAttribute(ElementName = "VersionId")]
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// Sets the version id for the object that the pre-signed url will reference. If not set,
        /// the url will reference the latest version of the object.
        /// </summary>
        /// <remarks>
        /// This is the VersionId for the S3 Object you want to get
        /// a PreSigned URL for. The VersionId property will be ignored
        /// for PreSigned "PUT" requests and for requests that don't specify
        /// the Key property.
        /// </remarks>
        /// <param name="versionId">The object version id</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetPreSignedUrlRequest WithVersionId(string versionId)
        {
            this.versionId = versionId;
            return this;
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
        /// <param name="encryption">The value of the ServerSideEncryptionMethod to set.</param>
        /// <returns>The response with the ServerSideEncryptionMethod set.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetPreSignedUrlRequest WithServerSideEncryptionMethod(ServerSideEncryptionMethod encryption)
        {
            this.ServerSideEncryptionMethod = encryption;
            return this;
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

        /// <summary>
        /// A set of response headers that should be returned with the pre-signed url creation response.
        /// </summary>
        /// <param name="responseHeaderOverrides">Requested response headers</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetPreSignedUrlRequest WithResponseHeaderOverrides(ResponseHeaderOverrides responseHeaderOverrides)
        {
            this.ResponseHeaderOverrides = responseHeaderOverrides;
            return this;
        }

        #endregion
    }
}
