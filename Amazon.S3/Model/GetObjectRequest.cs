/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// The GetObjectRequest contains the parameters used for the GetObject operation.
    /// For more information about the optional parameters,
    /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/RESTObjectGET.html"/>
    /// <br />Required Parameters: BucketName, Key
    /// <br />Optional Parameters: VersionId, ModifiedSinceDate, UnmodifiedSinceDate, 
    /// ETagToMatch, ETagToNotMatch, ByteRange
    /// </summary>
    public class GetObjectRequest : S3Request
    {
        #region Private Members

        string bucketName;
        string key;
        string versionId;
        DateTime? modifiedSinceDate;
        DateTime? unmodifiedSinceDate;
        string etagToMatch;
        string etagToNotMatch;
        Tuple<long, long> byteRange;
        int timeout = 0;
        ResponseHeaderOverrides _responseHeaders;

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
        /// This is the S3 Bucket that contains the S3 Object you
        /// want to get.
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
        /// <returns>this instance</returns>
        public GetObjectRequest WithBucketName(string bucketName)
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
        /// This is the Key for the S3 Object you want to Get.
        /// </summary>
        /// <param name="key">The value that Key is set to</param>
        /// <returns>this instance</returns>
        public GetObjectRequest WithKey(string key)
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

        #region VersionId

        /// <summary>
        /// Gets and sets the VersionId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "VersionId")]
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// Sets the VersionId property for this request.
        /// This is the VersionId for the S3 Object you want to Get.
        /// </summary>
        /// <param name="versionId">The value that VersionId is set to</param>
        /// <returns>this instance</returns>
        public GetObjectRequest WithVersionId(string versionId)
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

        #region ModifiedSinceDate

        /// <summary>
        /// Gets and sets the ModifiedSinceDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ModifiedSinceDate")]
        public DateTime ModifiedSinceDate
        {
            get { return this.modifiedSinceDate.GetValueOrDefault(); }
            set { this.modifiedSinceDate = value; }
        }

        /// <summary>
        /// Sets the ModifiedSinceDate property for this request.
        /// When this is set the S3 object is returned only if it
        /// has been modified since the specified time, otherwise
        /// returns a 304 (not modified).
        /// </summary>
        /// <param name="modifiedSinceDate">The value that ModifiedSinceDate is set to</param>
        /// <returns>this instance</returns>
        public GetObjectRequest WithModifiedSinceDate(DateTime modifiedSinceDate)
        {
            this.modifiedSinceDate = modifiedSinceDate;
            return this;
        }

        /// <summary>
        /// Checks if ModifiedSinceDate property is set.
        /// </summary>
        /// <returns>true if ModifiedSinceDate property is set.</returns>
        internal bool IsSetModifiedSinceDate()
        {
            return modifiedSinceDate.HasValue;
        }

        #endregion

        #region UnmodifiedSinceDate

        /// <summary>
        /// Gets and sets the UnmodifiedSinceDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "UnmodifiedSinceDate")]
        public DateTime UnmodifiedSinceDate
        {
            get { return this.unmodifiedSinceDate.GetValueOrDefault(); }
            set { this.unmodifiedSinceDate = value; }
        }

        /// <summary>
        /// Sets the UnmodifiedSinceDate property for this request.
        /// When this is set the S3 object is returned only if it
        /// has not been modified since the specified time, otherwise
        /// return a 412 (precondition failed).
        /// </summary>
        /// <param name="unmodifiedSinceDate">The value that UnmodifiedSinceDate is set to</param>
        /// <returns>this instance</returns>
        public GetObjectRequest WithUnmodifiedSinceDate(DateTime unmodifiedSinceDate)
        {
            this.unmodifiedSinceDate = unmodifiedSinceDate;
            return this;
        }

        /// <summary>
        /// Checks if UnmodifiedSinceDate property is set.
        /// </summary>
        /// <returns>true if UnmodifiedSinceDate property is set.</returns>
        internal bool IsSetUnmodifiedSinceDate()
        {
            return unmodifiedSinceDate.HasValue;
        }

        #endregion

        #region ETagToMatch

        /// <summary>
        /// Gets and sets the ETagToMatch property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETagToMatch")]
        public string ETagToMatch
        {
            get { return this.etagToMatch; }
            set { this.etagToMatch = value; }
        }

        /// <summary>
        /// Sets the ETagToMatch property for this request.
        /// When this is set the S3 object is returned only if
        /// its entity tag (ETag) is the same as the one specified,
        /// otherwise return a 412 (precondition failed).
        /// </summary>
        /// <param name="etagToMatch">The value that ETagToMatch is set to</param>
        /// <returns>this instance</returns>
        public GetObjectRequest WithETagToMatch(string etagToMatch)
        {
            this.etagToMatch = etagToMatch;
            return this;
        }

        /// <summary>
        /// Checks if ETagToMatch property is set.
        /// </summary>
        /// <returns>true if ETagToMatch property is set.</returns>
        internal bool IsSetETagToMatch()
        {
            return !System.String.IsNullOrEmpty(this.etagToMatch);
        }

        #endregion

        #region ETagToNotMatch

        /// <summary>
        /// Gets and sets the ETagToNotMatch property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETagToNotMatch")]
        public string ETagToNotMatch
        {
            get { return this.etagToNotMatch; }
            set { this.etagToNotMatch = value; }
        }

        /// <summary>
        /// Sets the ETagToNotMatch property for this request.
        /// When this is set the S3 object is returned only if
        /// its entity tag (ETag) is different from the one
        /// specified, otherwise return a 304 (not modified).
        /// </summary>
        /// <param name="etagToNotMatch">The value that ETagToNotMatch is set to</param>
        /// <returns>this instance</returns>
        public GetObjectRequest WithETagToNotMatch(string etagToNotMatch)
        {
            this.etagToNotMatch = etagToNotMatch;
            return this;
        }

        /// <summary>
        /// Checks if ETagToNotMatch property is set.
        /// </summary>
        /// <returns>true if ETagToNotMatch property is set.</returns>
        internal bool IsSetETagToNotMatch()
        {
            return !System.String.IsNullOrEmpty(this.etagToNotMatch);
        }

        #endregion

        #region ByteRange

        /// <summary>
        /// Gets and sets the ByteRangeLong property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ByteRange")]
        public Tuple<long, long> ByteRangeLong
        {
            get { return this.byteRange; }
            set { this.byteRange = value; }
        }

        /// <summary>
        /// Sets the ByteRangeLong property with the start and end index
        /// specified.
        /// When this is set the request downloads the specified range of an object.
        /// </summary>
        /// <param name="startIndex">Specifies the index to start at</param>
        /// <param name="endIndex">Specifies the index to end at</param>
        /// <returns>this instance</returns>
        public GetObjectRequest WithByteRangeLong(long startIndex, long endIndex)
        {
            if (startIndex > endIndex)
            {
                throw new ArgumentException("The Start Index of the range needs to be greater than the End Index");
            }

            if (startIndex < 0)
            {
                throw new ArgumentException("The Start Index of the range needs to be >= 0");
            }

            if (endIndex < 0)
            {
                throw new ArgumentException("The End Index of the range needs to be >= 0");
            }

            this.byteRange = new Tuple<long, long>(startIndex, endIndex);

            return this;
        }
        
        /// <summary>
        /// Gets the ByteRange property.
        /// </summary>
        public Tuple<int, int> ByteRange
        {
            get 
            {
                if (this.byteRange == null)
                {
                    return null;
                }

                return new Tuple<int, int>((int)this.byteRange.First, (int)this.byteRange.Second); 
            }
        }

        /// <summary>
        /// Sets the ByteRange property with the start and end index
        /// specified.
        /// When this is set the request downloads the specified range of an object.
        /// </summary>
        /// <param name="startIndex">Specifies the index to start at</param>
        /// <param name="endIndex">Specifies the index to end at</param>
        /// <returns>this instance</returns>
        public GetObjectRequest WithByteRange(int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
            {
                throw new ArgumentException("The Start Index of the range needs to be greater than the End Index");
            }

            if (startIndex < 0)
            {
                throw new ArgumentException("The Start Index of the range needs to be >= 0");
            }

            if (endIndex < 0)
            {
                throw new ArgumentException("The End Index of the range needs to be >= 0");
            }

            this.byteRange = new Tuple<long, long>(startIndex, endIndex);

            return this;
        }

        /// <summary>
        /// Checks if ByteRange property is set.
        /// </summary>
        /// <returns>true if ByteRange property is set.</returns>
        internal bool IsSetByteRange()
        {
            return this.ByteRangeLong != null;
        }

        #endregion

        #region Timeout

        /// <summary>
        /// Gets and sets of the Timeout property (in milliseconds).
        /// The value of this property is assigned to the
        /// ReadWriteTimeout and Timeout properties of the
        /// HTTPWebRequest object used for S3 GET Object requests.
        /// </summary>
        /// <remarks>A value less than or equal to 0 will be silently ignored</remarks>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        public int Timeout
        {
            get { return this.timeout; }
            set
            {
                if (value > 0)
                {
                    this.timeout = value;
                }
            }
        }

        /// <summary>
        /// Sets the Timeout property (in milliseconds). 
        /// The value of this property is assigned to the
        /// ReadWriteTimeout and Timeout properties of the
        /// Please specify a timeout value only if you are certain that
        /// the file will not be retrieved within the default intervals
        /// specified for an HttpWebRequest.
        /// </summary>
        /// <param name="timeout">Timeout property</param>
        /// <remarks>A value less than or equal to 0 will be silently ignored</remarks>
        /// <returns>this instance</returns>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        public GetObjectRequest WithTimeout(int timeout)
        {
            Timeout = timeout;
            return this;
        }

        internal override bool SupportTimeout
        {
            get { return true; }
        }

        #endregion

        #region Response Headers


        /// <summary>
        /// Gets and sets the response headers to be returned back with the response of the object.
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
        /// Sets the ResponseHeaderOverrides property and returns back this instance for method chaining.
        /// </summary>
        /// <param name="responseHeaderOverrides">The response headers</param>
        /// <returns>this instance</returns>
        public GetObjectRequest WithResponseHeaderOverrides(ResponseHeaderOverrides responseHeaderOverrides)
        {
            this.ResponseHeaderOverrides = responseHeaderOverrides;
            return this;
        }

        #endregion

    }
}