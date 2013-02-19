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
    /// The parameters to fetch an object from a bucket.
    /// </summary>
    /// <remarks>
    /// For more information about the optional parameters, refer to: 
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/RESTObjectGET.html"/>
    /// <br />Required Parameters: BucketName, Key
    /// <br />Optional Parameters: VersionId, ModifiedSinceDate, UnmodifiedSinceDate, ETagToMatch, ETagToNotMatch, ByteRange
    /// </remarks>
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
        ResponseHeaderOverrides _responseHeaders;

        #endregion

        #region BucketName

        /// <summary>
        /// The name of the bucket containing the object.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket containing the object.
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
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
        /// The key of the object to be fetched.
        /// </summary>
        [XmlElementAttribute(ElementName = "Key")]
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the key of the object to be fetched.
        /// </summary>
        /// <param name="key">The object key</param>
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
        /// Version of the object to fetch. If not set, the latest version of
        /// the object is returned.
        /// </summary>
        [XmlElementAttribute(ElementName = "VersionId")]
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// Sets the version of the object to fetch. If not set, the latest version of
        /// the object is returned.
        /// </summary>
        /// <param name="versionId">Object version id</param>
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
        /// Returns the object only if it has been modified since the specified time, 
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        [XmlElementAttribute(ElementName = "ModifiedSinceDate")]
        public DateTime ModifiedSinceDate
        {
            get { return this.modifiedSinceDate.GetValueOrDefault(); }
            set { this.modifiedSinceDate = value; }
        }

        /// <summary>
        /// Returns the object only if it has been modified since the specified time, 
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// When this is set the S3 object is returned only if it has been modified since the specified time, otherwise
        /// returns a 304 (not modified).
        /// </remarks>
        /// <param name="modifiedSinceDate">Date and time to test</param>
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
        /// Returns the object only if it has not been modified since the specified time, 
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        [XmlElementAttribute(ElementName = "UnmodifiedSinceDate")]
        public DateTime UnmodifiedSinceDate
        {
            get { return this.unmodifiedSinceDate.GetValueOrDefault(); }
            set { this.unmodifiedSinceDate = value; }
        }

        /// <summary>
        /// Returns the object only if it has been modified since the specified time, 
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// When this is set the S3 object is returned only if it has not been modified since the specified time, otherwise
        /// return a 412 (precondition failed).
        /// </remarks>
        /// <param name="unmodifiedSinceDate">The date and time to test</param>
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
        /// ETag to be matched as a pre-condition for returning the object,
        /// otherwise a PreconditionFailed signal is returned.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETagToMatch")]
        public string ETagToMatch
        {
            get { return this.etagToMatch; }
            set { this.etagToMatch = value; }
        }

        /// <summary>
        /// Sets an ETag to be matched as a pre-condition for returning the object,
        /// otherwise a PreconditionFailed signal is returned.
        /// </summary>
        /// <remarks>
        /// When this is set the S3 object is returned only if its entity tag (ETag) is the same as the one specified,
        /// otherwise return a 412 (precondition failed).
        /// </remarks>
        /// <param name="etagToMatch">The ETag to match</param>
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
        /// ETag that should not be matched as a pre-condition for returning the object,
        /// otherwise a PreconditionFailed signal is returned.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETagToNotMatch")]
        public string ETagToNotMatch
        {
            get { return this.etagToNotMatch; }
            set { this.etagToNotMatch = value; }
        }

        /// <summary>
        /// Sets an ETag that should not be matched as a pre-condition for returning the object,
        /// otherwise a PreconditionFailed signal is returned.
        /// </summary>
        /// <remarks>
        /// When this is set the S3 object is returned only if
        /// its entity tag (ETag) is different from the one
        /// specified, otherwise return a 304 (not modified).
        /// </remarks>
        /// <param name="etagToNotMatch">The ETag to test</param>
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
        /// Byte range of the object to return. When this is set the request downloads the specified range of an object.
        /// </summary>
        [XmlElementAttribute(ElementName = "ByteRange")]
        public Tuple<long, long> ByteRangeLong
        {
            get { return this.byteRange; }
            set { this.byteRange = value; }
        }

        /// <summary>
        /// Sets a byte range of the object to return. When this is set the request downloads the specified range of an object.
        /// </summary>
        /// <param name="startIndex">The index to start at</param>
        /// <param name="endIndex">The index to end at</param>
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
        /// Returns the byte range to retrieve, if set.
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
        /// Sets a byte range of the object to return. When this is set the request downloads the specified range of an object.
        /// </summary>
        /// <param name="startIndex">The index to start at</param>
        /// <param name="endIndex">The index to end at</param>
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
        /// Overrides the default HttpWebRequest timeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The value of this property (in milliseconds) is assigned to the Timeout property of the HTTPWebRequest object used
        /// for S3 GET Object requests.
        /// </para>
        /// <para>
        /// Please specify a timeout value only if you are certain that the file will not be retrieved within the default intervals
        /// specified for an HttpWebRequest.
        /// </para>
        /// <para>
        /// A value less than or equal to 0 will be silently ignored
        /// </para>
        /// </remarks>
        /// <param name="timeout">Timeout property</param>
        /// <returns>this instance</returns>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        new public GetObjectRequest WithTimeout(int timeout)
        {
            Timeout = timeout;
            return this;
        }

        #endregion

        #region ReadWriteTimeout

        /// <summary>
        /// Overrides the default HttpWebRequest ReadWriteTimeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The value of this property (in milliseconds) is assigned to the
        /// ReadWriteTimeout property of the HTTPWebRequest object
        /// used for S3 GET Object requests.
        /// </para>
        /// <para>
        /// A value less than or equal to 0 will be silently ignored
        /// </para>
        /// </remarks>
        /// <param name="readWriteTimeout">ReadWriteTimeout property</param>
        /// <returns>this instance</returns>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        new public GetObjectRequest WithReadWriteTimeout(int readWriteTimeout)
        {
            ReadWriteTimeout = readWriteTimeout;
            return this;
        }

        #endregion

        #region Response Headers

        /// <summary>
        /// A set of response headers that should be returned with the object.
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
        /// A set of response headers that should be returned with the object.
        /// </summary>
        /// <param name="responseHeaderOverrides">Response headers to return</param>
        /// <returns>this instance</returns>
        public GetObjectRequest WithResponseHeaderOverrides(ResponseHeaderOverrides responseHeaderOverrides)
        {
            this.ResponseHeaderOverrides = responseHeaderOverrides;
            return this;
        }

        #endregion

    }
}