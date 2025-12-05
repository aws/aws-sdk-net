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
    /// Container for the parameters to the RenameObject operation.
    /// Renames an existing object in a directory bucket that uses the S3 Express One Zone
    /// storage class. You can use <c>RenameObject</c> by specifying an existing object’s
    /// name as the source and the new name of the object as the destination within the same
    /// directory bucket.
    /// 
    ///  <note> 
    /// <para>
    ///  <c>RenameObject</c> is only supported for objects stored in the S3 Express One Zone
    /// storage class.
    /// </para>
    ///  </note> 
    /// <para>
    ///  To prevent overwriting an object, you can use the <c>If-None-Match</c> conditional
    /// header.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>If-None-Match</b> - Renames the object only if an object with the specified name
    /// does not already exist in the directory bucket. If you don't want to overwrite an
    /// existing object, you can add the <c>If-None-Match</c> conditional header with the
    /// value <c>‘*’</c> in the <c>RenameObject</c> request. Amazon S3 then returns a <c>412
    /// Precondition Failed</c> error if the object with the specified name already exists.
    /// For more information, see <a href="https://datatracker.ietf.org/doc/rfc7232/">RFC
    /// 7232</a>.
    /// </para>
    ///  </li> </ul> <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    ///  To grant access to the <c>RenameObject</c> operation on a directory bucket, we recommend
    /// that you use the <c>CreateSession</c> operation for session-based authorization. Specifically,
    /// you grant the <c>s3express:CreateSession</c> permission to the directory bucket in
    /// a bucket policy or an IAM identity-based policy. Then, you make the <c>CreateSession</c>
    /// API call on the directory bucket to obtain a session token. With the session token
    /// in your request header, you can make API requests to this operation. After the session
    /// token expires, you make another <c>CreateSession</c> API call to generate a new session
    /// token for use. The Amazon Web Services CLI and SDKs will create and manage your session
    /// including refreshing the session token automatically to avoid service interruptions
    /// when a session expires. In your bucket policy, you can specify the <c>s3express:SessionMode</c>
    /// condition key to control who can create a <c>ReadWrite</c> or <c>ReadOnly</c> session.
    /// A <c>ReadWrite</c> session is required for executing all the Zonal endpoint API operations,
    /// including <c>RenameObject</c>. For more information about authorization, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <c>CreateSession</c> </a>. To learn more about Zonal endpoint API operations, see
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-create-session.html">Authorizing
    /// Zonal endpoint API operations with CreateSession</a> in the <i>Amazon S3 User Guide</i>.
    /// 
    /// </para>
    ///  </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class RenameObjectRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private string _clientToken;
        private string _destinationIfMatch;
        private DateTime? _destinationIfModifiedSince;
        private string _destinationIfNoneMatch;
        private DateTime? _destinationIfUnmodifiedSince;
        private string _key;
        private string _renameSource;
        private string _sourceIfMatch;
        private DateTime? _sourceIfModifiedSince;
        private string _sourceIfNoneMatch;
        private DateTime? _sourceIfUnmodifiedSince;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name of the directory bucket containing the object.
        /// </para>
        ///  
        /// <para>
        ///  You must use virtual-hosted-style requests in the format <c>Bucket-name.s3express-zone-id.region-code.amazonaws.com</c>.
        /// Path-style requests are not supported. Directory bucket names must be unique in the
        /// chosen Availability Zone. Bucket names must follow the format <c>bucket-base-name--zone-id--x-s3
        /// </c> (for example, <c>amzn-s3-demo-bucket--usw2-az1--x-s3</c>). For information about
        /// bucket naming restrictions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory
        /// bucket naming rules</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return !string.IsNullOrEmpty(this._bucketName);
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique string with a max of 64 ASCII characters in the ASCII range of 33 - 126.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>RenameObject</c> supports idempotency using a client token. To make an idempotent
        /// API request using <c>RenameObject</c>, specify a client token in the request. You
        /// should not reuse the same client token for other API requests. If you retry a request
        /// that completed successfully using the same client token and the same parameters, the
        /// retry succeeds without performing any further actions. If you retry a successful request
        /// using the same client token, but one or more of the parameters are different, the
        /// retry fails and an <c>IdempotentParameterMismatch</c> error is returned. 
        /// </para>
        ///  </note>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return !string.IsNullOrEmpty(this._clientToken);
        }

        /// <summary>
        /// Gets and sets the property DestinationIfMatch. 
        /// <para>
        /// Renames the object only if the ETag (entity tag) value provided during the operation
        /// matches the ETag of the object in S3. The <c>If-Match</c> header field makes the request
        /// method conditional on ETags. If the ETag values do not match, the operation returns
        /// a <c>412 Precondition Failed</c> error.
        /// </para>
        ///  
        /// <para>
        /// Expects the ETag value as a string.
        /// </para>
        /// </summary>
        public string DestinationIfMatch
        {
            get { return this._destinationIfMatch; }
            set { this._destinationIfMatch = value; }
        }

        // Check to see if DestinationIfMatch property is set
        internal bool IsSetDestinationIfMatch()
        {
            return !string.IsNullOrEmpty(this._destinationIfMatch);
        }

        /// <summary>
        /// Gets and sets the property DestinationIfModifiedSince. 
        /// <para>
        /// Renames the object if the destination exists and if it has been modified since the
        /// specified time.
        /// </para>
        /// </summary>
        public DateTime? DestinationIfModifiedSince
        {
            get { return this._destinationIfModifiedSince; }
            set { this._destinationIfModifiedSince = value; }
        }

        // Check to see if DestinationIfModifiedSince property is set
        internal bool IsSetDestinationIfModifiedSince()
        {
            return this._destinationIfModifiedSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationIfNoneMatch. 
        /// <para>
        ///  Renames the object only if the destination does not already exist in the specified
        /// directory bucket. If the object does exist when you send a request with <c>If-None-Match:*</c>,
        /// the S3 API will return a <c>412 Precondition Failed</c> error, preventing an overwrite.
        /// The <c>If-None-Match</c> header prevents overwrites of existing data by validating
        /// that there's not an object with the same key name already in your directory bucket.
        /// </para>
        ///  
        /// <para>
        ///  Expects the <c>*</c> character (asterisk).
        /// </para>
        /// </summary>
        public string DestinationIfNoneMatch
        {
            get { return this._destinationIfNoneMatch; }
            set { this._destinationIfNoneMatch = value; }
        }

        // Check to see if DestinationIfNoneMatch property is set
        internal bool IsSetDestinationIfNoneMatch()
        {
            return !string.IsNullOrEmpty(this._destinationIfNoneMatch);
        }

        /// <summary>
        /// Gets and sets the property DestinationIfUnmodifiedSince. 
        /// <para>
        /// Renames the object if it hasn't been modified since the specified time.
        /// </para>
        /// </summary>
        public DateTime? DestinationIfUnmodifiedSince
        {
            get { return this._destinationIfUnmodifiedSince; }
            set { this._destinationIfUnmodifiedSince = value; }
        }

        // Check to see if DestinationIfUnmodifiedSince property is set
        internal bool IsSetDestinationIfUnmodifiedSince()
        {
            return this._destinationIfUnmodifiedSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Key name of the object to rename.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return !string.IsNullOrEmpty(this._key);
        }

        /// <summary>
        /// Gets and sets the property RenameSource. 
        /// <para>
        /// Specifies the source for the rename operation. The value must be URL encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RenameSource
        {
            get { return this._renameSource; }
            set { this._renameSource = value; }
        }

        // Check to see if RenameSource property is set
        internal bool IsSetRenameSource()
        {
            return !string.IsNullOrEmpty(this._renameSource);
        }

        /// <summary>
        /// Gets and sets the property SourceIfMatch. 
        /// <para>
        /// Renames the object if the source exists and if its entity tag (ETag) matches the specified
        /// ETag. 
        /// </para>
        /// </summary>
        public string SourceIfMatch
        {
            get { return this._sourceIfMatch; }
            set { this._sourceIfMatch = value; }
        }

        // Check to see if SourceIfMatch property is set
        internal bool IsSetSourceIfMatch()
        {
            return !string.IsNullOrEmpty(this._sourceIfMatch);
        }

        /// <summary>
        /// Gets and sets the property SourceIfModifiedSince. 
        /// <para>
        /// Renames the object if the source exists and if it has been modified since the specified
        /// time.
        /// </para>
        /// </summary>
        public DateTime? SourceIfModifiedSince
        {
            get { return this._sourceIfModifiedSince; }
            set { this._sourceIfModifiedSince = value; }
        }

        // Check to see if SourceIfModifiedSince property is set
        internal bool IsSetSourceIfModifiedSince()
        {
            return this._sourceIfModifiedSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceIfNoneMatch. 
        /// <para>
        /// Renames the object if the source exists and if its entity tag (ETag) is different
        /// than the specified ETag. If an asterisk (<c>*</c>) character is provided, the operation
        /// will fail and return a <c>412 Precondition Failed</c> error. 
        /// </para>
        /// </summary>
        public string SourceIfNoneMatch
        {
            get { return this._sourceIfNoneMatch; }
            set { this._sourceIfNoneMatch = value; }
        }

        // Check to see if SourceIfNoneMatch property is set
        internal bool IsSetSourceIfNoneMatch()
        {
            return !string.IsNullOrEmpty(this._sourceIfNoneMatch);
        }

        /// <summary>
        /// Gets and sets the property SourceIfUnmodifiedSince. 
        /// <para>
        /// Renames the object if the source exists and hasn't been modified since the specified
        /// time.
        /// </para>
        /// </summary>
        public DateTime? SourceIfUnmodifiedSince
        {
            get { return this._sourceIfUnmodifiedSince; }
            set { this._sourceIfUnmodifiedSince = value; }
        }

        // Check to see if SourceIfUnmodifiedSince property is set
        internal bool IsSetSourceIfUnmodifiedSince()
        {
            return this._sourceIfUnmodifiedSince.HasValue; 
        }

    }
}