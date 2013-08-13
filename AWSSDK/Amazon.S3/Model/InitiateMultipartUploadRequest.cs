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
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to start a multi-part upload to S3.
    /// </summary>
    public class InitiateMultipartUploadRequest : S3PutWithACLRequest
    {
        #region Private members

        private string bucketName;
        private string key;
        private S3CannedACL cannedACL;
        private string contentType;
        internal NameValueCollection metaData;
        private S3StorageClass storageClass;
        private ServerSideEncryptionMethod encryption;
        private string websiteRedirectLocation;

        #endregion

        #region BucketName

        /// <summary>
        /// The name of the bucket where the new object will be created, or existing object updated.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket where the new object will be created, or existing object updated.
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
        /// <returns>The request with the BucketName set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InitiateMultipartUploadRequest WithBucketName(string bucketName)
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
        /// The key of the object to create or update.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the key of the object to create or update.
        /// </summary>
        /// <param name="key">The object key</param>
        /// <returns>the request with the Key set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InitiateMultipartUploadRequest WithKey(string key)
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

        #region CannedACL

        /// <summary>
        /// A canned access control list (ACL) to apply to the object.
        /// Please refer to <see cref="T:Amazon.S3.Model.S3CannedACL"/> for information on S3 Canned ACLs.
        /// </summary>
        public S3CannedACL CannedACL
        {
            get { return this.cannedACL; }
            set { this.cannedACL = value; }
        }

        /// <summary>
        /// Sets a canned access control list (ACL) to apply to the object.
        /// Please refer to <see cref="T:Amazon.S3.Model.S3CannedACL"/> for information on S3 Canned ACLs.
        /// </summary>
        /// <param name="acl">The Canned ACL to be set on the object</param>
        /// <returns>The request with the CannedACL set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InitiateMultipartUploadRequest WithCannedACL(S3CannedACL acl)
        {
            this.cannedACL = acl;
            return this;
        }

        /// <summary>
        /// Checks if the CannedACL property is set.
        /// </summary>
        /// <returns>true if there is the CannedACL property is set.</returns>
        internal bool IsSetCannedACL()
        {
            return (cannedACL != S3CannedACL.NoACL);
        }

        /// <summary>
        /// Resets any existng canned ACL setting to 'none'.
        /// </summary>
        public void RemoveCannedACL()
        {
            this.cannedACL = S3CannedACL.NoACL;
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
        public string ContentType
        {
            get { return this.contentType; }
            set { this.contentType = value; }
        }

        /// <summary>
        /// Sets a standard MIME type describing the format of the object data.
        /// </summary>
        /// <remarks>
        /// The content type for the content being uploaded. This property defaults to "binary/octet-stream".
        /// For more information, refer to: <see href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.17"/>
        /// </remarks>
        /// <param name="contentType">The content type</param>
        /// <returns>The request with the ContentType set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InitiateMultipartUploadRequest WithContentType(string contentType)
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

        #region Metadata

        /// <summary>
        /// Adds a key/value pair to the Metadata property for this request.
        /// The S3 Object that you create will have this metadata associated
        /// with it.
        /// </summary>
        /// <param name="key">The key to associate with the object</param>
        /// <param name="value">The value for the key</param>
        /// <returns>The response with Metadata set.</returns>
        public InitiateMultipartUploadRequest WithMetaData(string key, string value)
        {
            if (key == null || value == null)
            {
                return this;
            }

            if (metaData == null)
            {
                metaData = new NameValueCollection(5);
            }

            metaData.Add(key, value);

            return this;
        }

        /// <summary>
        /// Adds a set of key-value pairs to the request.
        /// The S3 Object that you create will have this metadata associated
        /// with it.
        /// </summary>
        /// <param name="metaInfo">The set of key-value pairs that will eventually be
        /// associated with the S3 Object</param>
        /// <returns></returns>
        public InitiateMultipartUploadRequest WithMetaData(NameValueCollection metaInfo)
        {
            if (metaInfo == null || metaInfo.Count == 0)
            {
                return this;
            }

            if (metaData == null)
            {
                metaData = new NameValueCollection(metaInfo.Count);
            }

            metaData.Add(metaInfo);

            return this;
        }

        /// <summary>
        /// Checks if Metadata property is set.
        /// </summary>
        /// <returns>true if Metadata property is set.</returns>
        internal bool IsSetMetaData()
        {
            return (metaData != null && metaData.Count > 0);
        }

        /// <summary>
        /// Removes a key from the Metadata list if it was added previously.
        /// </summary>
        /// <param name="key">The key to remove</param>
        public void RemoveMetaData(string key)
        {
            if (metaData == null || metaData.Count == 0)
            {
                return;
            }

            metaData.Remove(key);
        }

        #endregion

        #region StorageClass

        /// <summary>
        /// StorageClass property for the object.
        /// </summary>
        /// <remarks>
        /// Default: S3StorageClass.Standard. Set this property
        /// only if you want reduced redundancy for this object.
        /// Please refer to 
        /// <see cref="T:Amazon.S3.Model.S3StorageClass"/> for
        /// information on S3 Storage Classes.
        /// </remarks>
        public S3StorageClass StorageClass
        {
            get { return this.storageClass; }
            set
            {
                if (value >= S3StorageClass.Standard &&
                    value <= S3StorageClass.ReducedRedundancy)
                {
                    this.storageClass = value;
                }
            }
        }

        /// <summary>
        /// Sets the StorageClass property for the object.
        /// </summary>
        /// <remarks>
        /// Default: S3StorageClass.Standard. Set this property
        /// only if you want reduced redundancy for this object.
        /// Please refer to 
        /// <see cref="T:Amazon.S3.Model.S3StorageClass"/> for
        /// information on S3 Storage Classes.
        /// </remarks>
        /// <param name="sClass">The Storage Class to be set on the object</param>
        /// <returns>The request with the StorageClass set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InitiateMultipartUploadRequest WithStorageClass(S3StorageClass sClass)
        {
            this.storageClass = sClass;
            return this;
        }

        #endregion

        #region Grants

        /// <summary>
        /// Adds custom Access Control Lists (ACLs) to the object.
        /// Please refer to <see cref="T:Amazon.S3.Model.S3Grant"/> for information on
        /// S3 Grants.
        /// </summary>
        /// <param name="grants">One or more S3 Grants</param>
        /// <returns>The request with the Grants set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InitiateMultipartUploadRequest WithGrants(params S3Grant[] grants)
        {
            this.Grants.AddRange(grants);
            return this;
        }

        #endregion

        #region ServerSideEncryption

        /// <summary>
        /// <para>
        /// Specifies the encryption to be used on the server for the new object.
        /// </para>
        /// <para>
        /// Default: None
        /// </para>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.encryption; }
            set { this.encryption = value; }
        }

        /// <summary>
        /// <para>
        /// Specifies the encryption to be used on the server for the new object.
        /// </para>
        /// <para>
        /// Default: None
        /// </para>
        /// </summary>
        /// <param name="encryption">ServerSideEncryptionMethod for the new object</param>
        /// <returns>The response with the ServerSideEncryptionMethod set.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InitiateMultipartUploadRequest WithServerSideEncryptionMethod(ServerSideEncryptionMethod encryption)
        {
            this.ServerSideEncryptionMethod = encryption;
            return this;
        }

        #endregion

        #region Website Redirect Location
        /// <summary>
        /// Sets the WebsiteRedirectLocation property on the new object so that when a GET request 
        /// is made from the S3 website endpoint a 301 HTTP status code will be returned indicating 
        /// a redirect with the specified value as the redirect location.
        /// </summary>
        public string WebsiteRedirectLocation
        {
            get { return this.websiteRedirectLocation; }
            set { this.websiteRedirectLocation = value; }
        }

        /// <summary>
        /// Sets the WebsiteRedirectLocation property on the new object so that when a GET request 
        /// is made from the S3 website endpoint a 301 HTTP status code will be returned indicating 
        /// a redirect with the specified value as the redirect location.
        /// </summary>
        /// <param name="websiteRedirectLocation">The redirect value to be returned on a GET request</param>
        /// <returns>the request with the WebsiteRedirectLocation set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InitiateMultipartUploadRequest WithWebsiteRedirectLocation(string websiteRedirectLocation)
        {
            this.websiteRedirectLocation = websiteRedirectLocation;
            return this;
        }

        /// <summary>
        /// Checks if WebsiteRedirectLocation property is set.
        /// </summary>
        /// <returns>true if WebsiteRedirectLocation property is set.</returns>
        internal bool IsSetWebsiteRedirectLocation()
        {
            return !System.String.IsNullOrEmpty(this.websiteRedirectLocation);
        }

        #endregion
    }
}
