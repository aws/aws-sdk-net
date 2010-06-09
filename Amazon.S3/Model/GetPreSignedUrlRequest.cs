/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// The GetPreSignedUrlRequest contains the parameters used to create
    /// a pre signed URL. For more information, refer: 
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/S3_QSAuth.html"/>
    /// <br />Required Parameters: BucketName, Key, Expires
    /// <br />Optional Parameters: Verb; default is GET
    /// </summary>
    public class GetPreSignedUrlRequest : S3Request
    {
        #region Private Members

        private string bucketName;
        private string key;
        private DateTime? expires;
        private Protocol protocol;
        private HttpVerb verb;

        #endregion

        #region BucketName

        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the BucketName property for this request.
        /// This is the S3 Bucket that contains the S3 Object
        /// you want to create a pre signed URL for.
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the Key property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Key")]
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the Key property for this request.
        /// This is the Key for the S3 Object you want to create a 
        /// pre signed URL for.
        /// </summary>
        /// <param name="key">The value that Key is set to</param>
        /// <returns>this instance</returns>
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

        #region Expires
        /// <summary>
        /// Gets and sets the Expires property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Expires")]
        public DateTime Expires
        {
            get { return this.expires.GetValueOrDefault(); }
            set { this.expires = value; }
        }

        /// <summary>
        /// Sets the Expires property for this request.
        /// The time when the signature expires, specified as a DateTime 
        /// Object. 
        /// </summary>
        /// <param name="expires">The value that Expires is set to</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the Protocol property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Protocol")]
        public Protocol Protocol
        {
            get { return this.protocol; }
            set { this.protocol = value; }
        }

        /// <summary>
        /// Sets the Protocol property for this request.
        /// Specifies whether the pre signed URL will use 
        /// http or https. Defaults to https unless otherwise 
        /// set.
        /// </summary>
        /// <param name="protocol">The value that Protocol is set to</param>
        /// <returns>the response with the Protocol set</returns>
        public GetPreSignedUrlRequest WithProtocol(Protocol protocol)
        {
            this.protocol = protocol;
            return this;
        }

        #endregion

        #region Verb
        /// <summary>
        /// Gets and sets the Verb property.
        /// Specifies the verb used in the pre-signed URL.
        /// Accepted verbs are GET, PUT and HEAD.
        /// Default is GET.
        /// </summary>
        [XmlElementAttribute(ElementName = "Verb")]
        public HttpVerb Verb
        {
            get { return this.verb; }
            set { this.verb = value; }
        }

        /// <summary>
        /// Sets the Verb property for this request.
        /// Specifies which verb to use in the pre-signed URL.
        /// Accepted verbs are GET, PUT and HEAD.
        /// Default value is GET.
        /// </summary>
        /// <param name="verb">The value that Verb is set to</param>
        /// <returns>the response with the Verb set</returns>
        public GetPreSignedUrlRequest WithVerb(HttpVerb verb)
        {
            Verb = verb;
            return this;
        }
        #endregion
    }
}