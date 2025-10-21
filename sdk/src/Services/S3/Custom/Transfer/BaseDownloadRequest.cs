/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Text;

using Amazon.Runtime.Internal;
using Amazon.S3.Model;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// The base class for requests that return Amazon S3 objects.
    /// </summary>
    public abstract class BaseDownloadRequest
    {
        private string bucketName;
        private string key;
        private string versionId;
        private DateTime? modifiedSinceDate;
        private DateTime? unmodifiedSinceDate;
        private ChecksumMode checksumMode;

        private ServerSideEncryptionCustomerMethod serverSideCustomerEncryption;
        private string serverSideEncryptionCustomerProvidedKey;
        private string serverSideEncryptionCustomerProvidedKeyMD5;

        private RequestPayer requestPayer;

        private string expectedBucketOwner;
        private string ifMatch;
        private string ifNoneMatch;
        private ResponseHeaderOverrides responseHeaders;
        
        /// <summary>
        /// 	Gets or sets the name of the bucket.
        /// </summary>
        /// <value>
        /// 	The name of the bucket.
        /// </value>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Gets whether or not the bucket name is set.
        /// </summary>
        /// <returns>
        /// 	A value of <c>true</c> if the bucket name is set.
		///    Returns <c>false</c> if otherwise.
        /// </returns>
        internal bool IsSetBucketName()
        {
            return !String.IsNullOrEmpty(this.bucketName);
        }


        /// <summary>
        /// 	Gets or sets the key under which the Amazon S3 object is stored.
        /// </summary>
        /// <value>
        /// 	The key under which the Amazon S3 object is stored. 
        /// </value>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// 	Gets whether or not the key property is set.
        /// </summary>
        /// <returns>
        /// 	A value of <c>true</c> if key property is set.
        /// 	Returns <c>false</c> if otherwise.
        /// </returns>
        internal bool IsSetKey()
        {
            return !String.IsNullOrEmpty(this.key);
        }

        /// <summary>
        /// 	Gets or sets the version ID of the Amazon S3 object.
        /// </summary>
        /// <value>
        /// 	The version ID of the Amazon S3 object.
        /// </value>
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
            return !String.IsNullOrEmpty(this.versionId);
        }        

        /// <summary>
        /// 	Gets or sets the <c>ModifiedSinceDate</c> property.
        /// </summary>
        /// <value>
        /// 	The <c>ModifiedSinceDate</c> property. 
        /// </value>
        public DateTime ModifiedSinceDate
        {
            get { return this.modifiedSinceDate ?? DateTime.SpecifyKind(default, DateTimeKind.Utc); }
            set
            {
                this.modifiedSinceDate = value;
            }
        }

        // Check to see if ModifiedSinceDate property is set
        internal bool IsSetModifiedSinceDate()
        {
            return this.modifiedSinceDate.HasValue;
        }

        /// <summary>
        /// 	Gets or sets the <c>UnmodifiedSinceDate</c> property.
        /// </summary>
        /// <value>
        /// 	The <c>UnmodifiedSinceDate</c> property.
        /// </value>
        public DateTime UnmodifiedSinceDate
        {
            get { return this.unmodifiedSinceDate ?? DateTime.SpecifyKind(default, DateTimeKind.Utc); }
            set
            {
                this.unmodifiedSinceDate = value;
            }
        }

        // Check to see if UnmodifiedSinceDate property is set
        internal bool IsSetUnmodifiedSinceDate()
        {
            return this.unmodifiedSinceDate.HasValue;
        }

        /// <summary>
        /// The Server-side encryption algorithm to be used with the customer provided key.
        ///  
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod
        {
            get { return this.serverSideCustomerEncryption; }
            set { this.serverSideCustomerEncryption = value; }
        }

        /// <summary>
        /// The base64-encoded encryption key for Amazon S3 to use to decrypt the object
        /// <para>
        /// Using the encryption key you provide as part of your request Amazon S3 manages both the encryption, as it writes 
        /// to disks, and decryption, when you access your objects. Therefore, you don't need to maintain any data encryption code. The only 
        /// thing you do is manage the encryption keys you provide.
        /// </para>
        /// <para>
        /// When you retrieve an object, you must provide the same encryption key as part of your request. Amazon S3 first verifies 
        /// the encryption key you provided matches, and then decrypts the object before returning the object data to you.
        /// </para>
        /// <para>
        /// Important: Amazon S3 does not store the encryption key you provide.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionCustomerProvidedKey
        {
            get { return this.serverSideEncryptionCustomerProvidedKey; }
            set { this.serverSideEncryptionCustomerProvidedKey = value; }
        }

        /// <summary>
        /// The MD5 of the customer encryption key specified in the ServerSideEncryptionCustomerProvidedKey property. The MD5 is
        /// base 64 encoded. This field is optional, the SDK will calculate the MD5 if this is not set.
        /// </summary>
        public string ServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this.serverSideEncryptionCustomerProvidedKeyMD5; }
            set { this.serverSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        /// <summary>
        /// Gets and sets the property ChecksumMode. 
        /// <para>
        /// This must be enabled to retrieve the checksum.
        /// </para>
        /// </summary>
        public ChecksumMode ChecksumMode
        {
            get { return this.checksumMode; }
            set { this.checksumMode = value; }
        }

        /// <summary>
        /// Confirms that the requester knows that they will be charged for the request. 
        /// Bucket owners need not specify this parameter in their requests.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this.requestPayer; }
            set { this.requestPayer = value; }
        }
        
        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <c>403 Forbidden</c> (access denied).
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        /// <summary>
        /// Checks to see if ExpectedBucketOwner is set.
        /// </summary>
        /// <returns>true, if ExpectedBucketOwner property is set.</returns>
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }
        
        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// Return the object only if its entity tag (ETag) is the same as the one specified in this header;
        /// otherwise, return a <c>412 Precondition Failed</c> error.
        /// </para>
        /// <para>
        /// If both of the <c>If-Match</c> and <c>If-Unmodified-Since</c> headers are present in the request as follows:
        /// <c>If-Match</c> condition evaluates to <c>true</c>, and; <c>If-Unmodified-Since</c> condition evaluates to <c>false</c>;
        /// then, S3 returns <c>200 OK</c> and the data requested.
        /// </para>
        /// <para>
        /// For more information about conditional requests, see <see href="https://tools.ietf.org/html/rfc7232">RFC 7232</see>.
        /// </para>
        /// The <see cref="IfMatch"/> property is equivalent to the <see cref="GetObjectRequest.EtagToMatch"/>.
        /// </summary>
        public string IfMatch
        {
            get { return this.ifMatch; }
            set { this.ifMatch = value; }
        }

        /// <summary>
        /// Checks to see if IfMatch is set.
        /// </summary>
        /// <returns>true, if IfMatch property is set.</returns>
        internal bool IsSetIfMatch()
        {
            return !String.IsNullOrEmpty(this.ifMatch);
        }

        /// <summary>
        /// Gets and sets the property IfNoneMatch. 
        /// <para>
        /// Return the object only if its entity tag (ETag) is different from the one specified in this header;
        /// otherwise, return a <c>304 Not Modified</c> error.
        /// </para>
        /// <para>
        /// If both of the <c>If-None-Match</c> and <c>If-Modified-Since</c> headers are present in the request as follows:
        /// <c> If-None-Match</c> condition evaluates to <c>false</c>, and; <c>If-Modified-Since</c> condition evaluates to <c>true</c>;
        /// then, S3 returns <c>304 Not Modified</c> HTTP status code.
        /// </para>
        /// <para>
        /// For more information about conditional requests, see <see href="https://tools.ietf.org/html/rfc7232">RFC 7232</see>.
        /// </para>
        /// The <see cref="IfNoneMatch"/> property is equivalent to the <see cref="GetObjectRequest.EtagToNotMatch"/>.
        /// </summary>
        public string IfNoneMatch
        {
            get { return this.ifNoneMatch; }
            set { this.ifNoneMatch = value; }
        }

        /// <summary>
        /// Checks to see if IfNoneMatch is set.
        /// </summary>
        /// <returns>true, if IfNoneMatch property is set.</returns>
        internal bool IsSetIfNoneMatch()
        {
            return !String.IsNullOrEmpty(this.ifNoneMatch);
        }

        /// <summary>
        /// A set of response headers that should be returned with the object.
        /// </summary>
        public ResponseHeaderOverrides ResponseHeaderOverrides
        {
            get
            {
                if (this.responseHeaders == null)
                {
                    this.responseHeaders = new ResponseHeaderOverrides();
                }
                return this.responseHeaders;
            }
            set
            {
                this.responseHeaders = value;
            }
        }
    }
}