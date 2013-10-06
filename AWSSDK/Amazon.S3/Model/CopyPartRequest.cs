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
using System.Collections.Specialized;
using System.Collections.Generic;

using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to upload a part by copying data from an existing object as data source. 
    /// </summary>
    public class CopyPartRequest : S3Request
    {
        #region Private Members

        private string srcBucket;
        private string srcKey;
        private string srcVersionId;
        private string dstBucket;
        private string dstKey;
        private string uploadID;
        private List<string> etagsToMatch;
        private List<string> etagsToNotMatch;
        private DateTime? modifiedSinceDate;
        private DateTime? unmodifiedSinceDate;
        private int? partNumber;
        private long? firstByte;
        private long? lastByte;
        private ServerSideEncryptionMethod serverSideEncryption;

        #endregion

        #region SourceBucket

        /// <summary>
        /// The name of the bucket containing the object to copy.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceBucket")]
        public string SourceBucket
        {
            get { return this.srcBucket; }
            set { this.srcBucket = value; }
        }

        /// <summary>
        /// Sets the name of the bucket containing the object to copy.
        /// </summary>
        /// <param name="srcBucket">Name of the bucket containing the object to copy</param>
        /// <returns>the request with the SourceBucket set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyPartRequest WithSourceBucket(string srcBucket)
        {
            this.srcBucket = srcBucket;
            return this;
        }

        /// <summary>
        /// Checks if SourceBucket property is set.
        /// </summary>
        /// <returns>true if SourceBucket property is set.</returns>
        internal bool IsSetSourceBucket()
        {
            return !System.String.IsNullOrEmpty(this.srcBucket);
        }

        #endregion

        #region SourceKey
        /// <summary>
        /// The key of the object to copy.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceKey")]
        public string SourceKey
        {
            get { return this.srcKey; }
            set { this.srcKey = value; }
        }

        /// <summary>
        /// Sets the key of the object to copy.
        /// </summary>
        /// <param name="srcKey">Key of the S3 object to copy</param>
        /// <returns>the request with the SourceKey set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyPartRequest WithSourceKey(string srcKey)
        {
            this.srcKey = srcKey;
            return this;
        }

        /// <summary>
        /// Checks if SourceKey property is set.
        /// </summary>
        /// <returns>true if SourceKey property is set.</returns>
        internal bool IsSetSourceKey()
        {
            return !System.String.IsNullOrEmpty(this.srcKey);
        }

        #endregion

        #region SourceVersionId

        /// <summary>
        /// Specifies a particular version of the source object to copy. By default the latest version is copied.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceVersionId")]
        public string SourceVersionId
        {
            get { return this.srcVersionId; }
            set { this.srcVersionId = value; }
        }

        /// <summary>
        /// Specifies a particular version of the source object to copy. By default the latest version is copied.
        /// </summary>
        /// <param name="srcVersionId">Id of the version of the source object to be copied</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyPartRequest WithSourceVersionId(string srcVersionId)
        {
            this.srcVersionId = srcVersionId;
            return this;
        }

        /// <summary>
        /// Checks if SourceVersionId property is set.
        /// </summary>
        /// <returns>true if SourceVersionId property is set.</returns>
        internal bool IsSetSourceVersionId()
        {
            return !System.String.IsNullOrEmpty(this.srcVersionId);
        }

        #endregion
        
        #region DestinationBucket
        /// <summary>
        /// The name of the bucket to contain the copy of the source object.
        /// </summary>
        [XmlElementAttribute(ElementName = "DestinationBucket")]
        public string DestinationBucket
        {
            get { return this.dstBucket; }
            set { this.dstBucket = value; }
        }

        /// <summary>
        /// Sets the name of the bucket to contain the copy of the source object.
        /// </summary>
        /// <param name="dstBucket">Name of the bucket to contain the copy</param>
        /// <returns>the request with the DestinationBucket set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyPartRequest WithDestinationBucket(string dstBucket)
        {
            this.dstBucket = dstBucket;
            return this;
        }

        /// <summary>
        /// Checks if DestinationBucket property is set.
        /// </summary>
        /// <returns>true if DestinationBucket property is set.</returns>
        internal bool IsSetDestinationBucket()
        {
            return !System.String.IsNullOrEmpty(this.dstBucket);
        }
        #endregion

        #region DestinationKey
        /// <summary>
        /// The key to be given to the copy of the source object.
        /// </summary>
        [XmlElementAttribute(ElementName = "DestinationKey")]
        public string DestinationKey
        {
            get { return this.dstKey; }
            set { this.dstKey = value; }
        }

        /// <summary>
        /// Sets the key to be given to the copy of the source object.
        /// </summary>
        /// <param name="dstKey">Key of the copy of the source object</param>
        /// <returns>the response with the Destinationkey set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyPartRequest WithDestinationKey(string dstKey)
        {
            this.dstKey = dstKey;
            return this;
        }

        /// <summary>
        /// Checks if DestinationKey property is set.
        /// </summary>
        /// <returns>true if DestinationKey property is set.</returns>
        internal bool IsSetDestinationKey()
        {
            return !System.String.IsNullOrEmpty(this.dstKey);
        }

        #endregion        
        
        #region UploadID
        /// <summary>
        /// The ID identifying multipart upload for which we are copying a part.
        /// </summary>
        [XmlElementAttribute(ElementName = "UploadID")]
        public string UploadID
        {
            get { return this.uploadID; }
            set { this.uploadID = value; }
        }

        /// <summary>
        /// Sets the ID identifying multipart upload for which we are copying a part.
        /// </summary>
        /// <param name="uploadID">Id of the multipart upload</param>
        /// <returns>the request with the UploadID set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyPartRequest WithUploadID(string uploadID)
        {
            this.uploadID = uploadID;
            return this;
        }

        /// <summary>
        /// Checks if UploadID property is set.
        /// </summary>
        /// <returns>true if UploadID property is set.</returns>
        internal bool IsSetUploadID()
        {
            return !System.String.IsNullOrEmpty(this.uploadID);
        }

        #endregion

        #region ETagsToMatch

        /// <summary>
        /// Collection of ETags to be matched as a pre-condition for copying the source object
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if its entity tag (ETag) matches one of
        /// the specified tags; otherwise return a 412 (precondition failed).
        /// Constraints: This property can be used with IfUnmodifiedSince,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        [XmlElementAttribute(ElementName = "ETagsToMatch")]
        public List<string> ETagToMatch
        {
            get
            {
                if (this.etagsToMatch == null)
                {
                    this.etagsToMatch = new List<String>();
                }
                return this.etagsToMatch;
            }
            set { this.etagsToMatch = value; }
        }

        /// <summary>
        /// Adds the specified Etags to the ETagsToMatch property for this request.
        /// </summary>
        /// <remarks>
        /// Copies the object if its entity tag (ETag) matches one of
        /// the specified tags; otherwise return a 412 (precondition failed).
        /// Constraints: This property can be used with IfUnmodifiedSince,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        /// <param name="etagsToMatch">The items to be added to the ETagsToMatch collection.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyPartRequest WithETagsToMatch(params string[] etagsToMatch)
        {
            if (etagsToMatch != null)
            {
                this.ETagToMatch.AddRange(etagsToMatch);
            }
            return this;
        }

        /// <summary>
        /// Adds the specified Etags to the ETagsToMatch property for this request.
        /// </summary>
        /// <remarks>
        /// Copies the object if its entity tag (ETag) matches one of
        /// the specified tags; otherwise return a 412 (precondition failed).
        /// Constraints: This property can be used with IfUnmodifiedSince,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        /// <param name="etagsToMatch">The items to be added to the ETagsToMatch collection.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyPartRequest WithETagsToMatch(IEnumerable<String> etagsToMatch)
        {
            if (etagsToMatch != null)
            {
                this.ETagToMatch.AddRange(etagsToMatch);
            }
            return this;
        }

        /// <summary>
        /// Checks if ETagsToMatch property is set.
        /// </summary>
        /// <returns>true if ETagToMatch property is set.</returns>
        internal bool IsSetETagToMatch()
        {
            return ((etagsToMatch != null) && (etagsToMatch.Count > 0));
        }

        #endregion

        #region ETagsToNotMatch
        /// <summary>
        /// Collection of ETags that must not be matched as a pre-condition for copying the source object
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if its entity tag (ETag) does not match any of the specified
        /// tags; otherwise returns a 412 (failed condition).
        /// Constraints: This header can be used with IfModifiedSince, but cannot
        /// be used with other conditional copy properties.
        /// </remarks>
        [XmlElementAttribute(ElementName = "ETagsToNotMatch")]
        public List<string> ETagsToNotMatch
        {
            get
            {
                if (this.etagsToNotMatch == null)
                {
                    this.etagsToNotMatch = new List<String>();
                } 
                return this.etagsToNotMatch;
            }
            set { this.etagsToNotMatch = value; }
        }

        /// <summary>
        /// Adds the specified Etags to the ETagsToNotMatch property for this request.
        /// </summary>
        /// <remarks>
        /// Copies the object if its entity tag (ETag) does not match any of the specified
        /// tags; otherwise returns a 412 (failed condition).
        /// Constraints: This header can be used with IfModifiedSince, but cannot
        /// be used with other conditional copy properties.
        /// </remarks>
        /// <param name="etagsToNotMatch">The ETags to add to the ETagsToNotMatch property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyPartRequest WithETagsToNotMatch(params string[] etagsToNotMatch)
        {
            if (etagsToNotMatch != null)
            {
                ETagsToNotMatch.AddRange(etagsToNotMatch);
            }
            return this;
        }

        /// <summary>
        /// Adds the Etags to the ETagsToNotMatch property for this request.
        /// </summary>
        /// <remarks>
        /// Copies the object if its entity tag (ETag) does not match any of the specified
        /// tags; otherwise returns a 412 (failed condition).
        /// Constraints: This header can be used with IfModifiedSince, but cannot
        /// be used with other conditional copy properties.
        /// </remarks>
        /// <param name="etagsToNotMatch">The ETags to add to the ETagsToNotMatch property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyPartRequest WithETagsToNotMatch(IEnumerable<String> etagsToNotMatch)
        {
            if (etagsToNotMatch != null)
            {
                ETagsToNotMatch.AddRange(etagsToNotMatch);
            }
            return this;
        }

        /// <summary>
        /// Checks if ETagToNotMatch property is set.
        /// </summary>
        /// <returns>true if ETagToNotMatch property is set.</returns>
        internal bool IsSetETagToNotMatch()
        {
            return ((etagsToNotMatch != null) && (etagsToNotMatch.Count > 0));
        }

        #endregion

        #region ModifiedSinceDate
        /// <summary>
        /// Copies the object if it has been modified since the specified time, otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if it has been modified since the
        /// specified time; otherwise returns a 412 (failed condition).
        /// Constraints: This property can be used with ETagToNotMatch,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        [XmlElementAttribute(ElementName = "ModifiedSinceDate")]
        public DateTime ModifiedSinceDate
        {
            get { return this.modifiedSinceDate.GetValueOrDefault(); }
            set { this.modifiedSinceDate = value; }
        }

        /// <summary>
        /// Copies the object if it has been modified since the specified time, otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if it has been modified since the
        /// specified time; otherwise returns a 412 (failed condition).
        /// Constraints: This property can be used with ETagToNotMatch,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        /// <param name="modifiedSinceDate">The date/time to check the modification timestamp against</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyPartRequest WithModifiedSinceDate(DateTime modifiedSinceDate)
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
            return this.modifiedSinceDate.HasValue;
        }

        #endregion

        #region UnmodifiedSinceDate

        /// <summary>
        /// Copies the object if it has not been modified since the specified time, otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if it hasn't been modified since the
        /// specified time; otherwise returns a 412 (precondition failed).
        /// Constraints: This property can be used with ETagToMatch,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        [XmlElementAttribute(ElementName = "UnmodifiedSinceDate")]
        public DateTime UnmodifiedSinceDate
        {
            get { return this.unmodifiedSinceDate.GetValueOrDefault(); }
            set { this.unmodifiedSinceDate = value; }
        }

        /// <summary>
        /// Copies the object if it has not been modified since the specified time, otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if it hasn't been modified since the
        /// specified time; otherwise returns a 412 (precondition failed).
        /// Constraints: This property can be used with ETagToMatch,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        /// <param name="unmodifiedSinceDate">The date/time to check the modification timestamp against</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyPartRequest WithUnmodifiedSinceDate(DateTime unmodifiedSinceDate)
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
            return this.unmodifiedSinceDate.HasValue;
        }

        #endregion

        #region Timeout

        /// <summary>
        /// Custom timeout value (in milliseconds) to set in the HttpWebRequest object used for the request.
        /// </summary>
        /// <param name="timeout">Timeout property</param>
        /// <remarks>
        /// <para>
        /// A value less than or equal to 0 will be silently ignored
        /// </para>
        /// <para>
        /// You should only set a custom timeout if you are certain that
        /// the file will not be transferred within the default intervals
        /// for an HttpWebRequest.
        /// </para>
        /// </remarks>
        /// <returns>this instance</returns>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
 [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        new public CopyPartRequest WithTimeout(int timeout)
        {
            Timeout = timeout;
            return this;
        }

        #endregion

        #region ReadWriteTimeout

        /// <summary>
        /// Custom read-write timeout value (in milliseconds) to set in the HttpWebRequest object used for the request.
        /// </summary>
        /// <param name="readWriteTimeout">ReadWriteTimeout property</param>
        /// <remarks>A value less than or equal to 0 will be silently ignored</remarks>
        /// <returns>this instance</returns>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
 [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        new public CopyPartRequest WithReadWriteTimeout(int readWriteTimeout)
        {
            ReadWriteTimeout = readWriteTimeout;
            return this;
        }

        #endregion

        #region PartNumber

        /// <summary>
        /// The number of the part to be copied.
        /// </summary>
        /// <remarks>
        /// Valid part numbers are from 1 to 10,000 inclusive and will uniquely identify the part 
        /// and determine the relative ordering within the destination object.  If a part already
        /// exists with the PartNumber it will be overwritten.
        /// </remarks>
        public int PartNumber
        {
            get { return this.partNumber.GetValueOrDefault(); }
            set { this.partNumber = value; }
        }

        /// <summary>
        /// Sets the number of the part to be copied.
        /// </summary>
        /// <remarks>
        /// Valid part numbers are from 1 to 10,000 inclusive and will uniquely identify the part 
        /// and determine the relative ordering within the destination object.  If a part already
        /// exists with the PartNumber it will be overwritten.
        /// </remarks>
        /// <param name="partNumber">value to set the PartNumber property to</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyPartRequest WithPartNumber(int partNumber)
        {
            this.partNumber = partNumber;
            return this;
        }

        /// <summary>
        /// Checks if PartNumber property is set.
        /// </summary>
        /// <returns>true if PartNumber property is set.</returns>
        internal bool IsSetPartNumber()
        {
            return this.partNumber.HasValue;
        }

        #endregion

        #region FirstByte

        /// <summary>
        /// The location of the first byte in the range if only a portion of the 
        /// source object is to be copied as the part. 
        /// </summary>
        /// <remarks>
        /// The LastByte property must also be set or this value will be ignored.
        /// </remarks>
        public long FirstByte
        {
            get { return this.firstByte.GetValueOrDefault(); }
            set { this.firstByte = value;  }
        }

        /// <summary>
        /// Sets the location of the first byte in the range if only a portion of the 
        /// source object is to be copied as the part. 
        /// </summary>
        /// <remarks>
        /// The LastByte property must also be set or this value will be ignored.
        /// </remarks>
        /// <param name="firstByte">The value to set the FirstByte property too</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyPartRequest WithFirstByte(long firstByte)
        {
            this.firstByte = firstByte;
            return this;
        }

        /// <summary>
        /// Checks if FirstByte property is set.
        /// </summary>
        /// <returns>true if FirstByte property is set.</returns>
        internal bool IsSetFirstByte()
        {
            return this.firstByte.HasValue;
        }

        #endregion

        #region LastByte

        /// <summary>
        /// The location of the last byte in the range if only a portion of the 
        /// source object is to be copied as the part.  
        /// </summary>
        /// <remarks>
        /// The FirstByte property must also be set or this value will be ignored.
        /// </remarks>
        public long LastByte
        {
            get { return this.lastByte.GetValueOrDefault(); }
            set { this.lastByte = value; }
        }

        /// <summary>
        /// The location of the last byte in the range if only a portion of the 
        /// source object is to be copied as the part.  
        /// </summary>
        /// <remarks>
        /// The FirstByte property must also be set or this value will be ignored.
        /// </remarks>
        /// <param name="lastByte">The value to set the LastByte property to</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyPartRequest WithLastByte(long lastByte)
        {
            this.lastByte = lastByte;
            return this;
        }

        /// <summary>
        /// Checks if LastByte property is set.
        /// </summary>
        /// <returns>true if LastByte property is set.</returns>
        internal bool IsSetLastByte()
        {
            return this.lastByte.HasValue;
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
            get { return this.serverSideEncryption; }
            set { this.serverSideEncryption = value; }
        }

        /// <summary>
        /// <para>
        /// Specifies the encryption to be used on the server for the new object.
        /// </para>
        /// <para>
        /// Default: None
        /// </para>
        /// </summary>
        /// <param name="serverSideEncryption">ServerSideEncryptionMethod for the new object</param>
        /// <returns>The response with the ServerSideEncryptionMethod set.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyPartRequest WithServerSideEncryptionMethod(ServerSideEncryptionMethod serverSideEncryption)
        {
            this.serverSideEncryption = serverSideEncryption;
            return this;
        }

        #endregion

        #region Constructor

        public CopyPartRequest()
        {
            Timeout = System.Threading.Timeout.Infinite;
        }

        #endregion

    }
}
