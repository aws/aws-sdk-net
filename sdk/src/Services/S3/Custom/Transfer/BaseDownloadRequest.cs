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
        private DateTime? modifiedSinceDateUtc;
        private DateTime? unmodifiedSinceDateUtc;
        private ChecksumMode checksumMode;

        private ServerSideEncryptionCustomerMethod serverSideCustomerEncryption;
        private string serverSideEncryptionCustomerProvidedKey;
        private string serverSideEncryptionCustomerProvidedKeyMD5;


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
            return !System.String.IsNullOrEmpty(this.bucketName);
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
            return !System.String.IsNullOrEmpty(this.key);
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
            return !System.String.IsNullOrEmpty(this.versionId);
        }

        /// <summary>
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use ModifiedSinceDateUtc instead. Setting either ModifiedSinceDate or
        /// ModifiedSinceDateUtc results in both ModifiedSinceDate and ModifiedSinceDateUtc being assigned,
        /// the latest assignment to either one of the two property is reflected in the value of both.
        /// ModifiedSinceDate is provided for backwards compatibility only and assigning a non-Utc DateTime
        /// to it results in the wrong timestamp being passed to the service.
        /// </para>
        /// 	Gets or sets the <c>ModifiedSinceDate</c> property.
        /// </summary>
        /// <value>
        /// 	The <c>ModifiedSinceDate</c> property. 
        /// </value>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use ModifiedSinceDateUtc instead. Setting either ModifiedSinceDate or ModifiedSinceDateUtc results in both ModifiedSinceDate and " +
            "ModifiedSinceDateUtc being assigned, the latest assignment to either one of the two property is " +
            "reflected in the value of both. ModifiedSinceDate is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime ModifiedSinceDate
        {
            get { return this.modifiedSinceDate.GetValueOrDefault(); }
            set
            {
                this.modifiedSinceDate = value;
                this.modifiedSinceDateUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }

        /// <summary>
        /// 	Gets or sets the <c>ModifiedSinceDate</c> property.
        /// </summary>
        /// <value>
        /// 	The <c>ModifiedSinceDate</c> property. 
        /// </value>
        public DateTime ModifiedSinceDateUtc
        {
            get { return this.modifiedSinceDateUtc ?? default(DateTime); }
            set
            {
                this.modifiedSinceDateUtc = value;
                this.modifiedSinceDate = value;
            }
        }

        // Check to see if ModifiedSinceDateUtc property is set
        internal bool IsSetModifiedSinceDateUtc()
        {
            return this.modifiedSinceDateUtc.HasValue;
        }

        /// <summary>
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use UnmodifiedSinceDateUtc instead. Setting either UnmodifiedSinceDate or
        /// UnmodifiedSinceDateUtc results in both UnmodifiedSinceDate and UnmodifiedSinceDateUtc being assigned,
        /// the latest assignment to either one of the two property is reflected in the value of both.
        /// UnmodifiedSinceDate is provided for backwards compatibility only and assigning a non-Utc DateTime
        /// to it results in the wrong timestamp being passed to the service.
        /// </para>
        /// 	Gets or sets the <c>UnmodifiedSinceDate</c> property.
        /// </summary>
        /// <value>
        /// 	The <c>UnmodifiedSinceDate</c> property.
        /// </value>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use UnmodifiedSinceDateUtc instead. Setting either UnmodifiedSinceDate or UnmodifiedSinceDateUtc results in both UnmodifiedSinceDate and " +
            "UnmodifiedSinceDateUtc being assigned, the latest assignment to either one of the two property is " +
            "reflected in the value of both. UnmodifiedSinceDate is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime UnmodifiedSinceDate
        {
            get { return this.unmodifiedSinceDate.GetValueOrDefault(); }
            set
            {
                this.unmodifiedSinceDate = value;
                this.unmodifiedSinceDateUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }

        /// <summary>
        /// 	Gets or sets the <c>UnmodifiedSinceDate</c> property.
        /// </summary>
        /// <value>
        /// 	The <c>UnmodifiedSinceDate</c> property.
        /// </value>
        public DateTime UnmodifiedSinceDateUtc
        {
            get { return this.unmodifiedSinceDateUtc ?? default(DateTime); }
            set
            {
                this.unmodifiedSinceDateUtc = value;
                this.unmodifiedSinceDate = value;
            }
        }

        // Check to see if UnmodifiedSinceDateUtc property is set
        internal bool IsSetUnmodifiedSinceDateUtc()
        {
            return this.unmodifiedSinceDateUtc.HasValue;
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
    }
}