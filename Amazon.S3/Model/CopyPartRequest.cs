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
using System.Collections.Specialized;
using System.Collections.Generic;

using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The CopyPartRequest contains the parameters used for the CopyPart operation.
    /// <br />Required Parameters: SourceBucket, SourceKey, DestinationBucket, DestinationKey,
    /// UploadID, PartNumber
    /// <br />Optional Parameters: ETagsToMatch, ETagsToNotMatch, ModifiedSinceDate,
    /// UnmodifiedSinceDate, Timeout, SourceVersionId, FirstByte, LastByte
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
        private int timeout = System.Threading.Timeout.Infinite;
        private int? partNumber;
        private long? firstByte;
        private long? lastByte;

        #endregion

        #region SourceBucket

        /// <summary>
        /// Gets and sets the SourceBucket property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceBucket")]
        public string SourceBucket
        {
            get { return this.srcBucket; }
            set { this.srcBucket = value; }
        }

        /// <summary>
        /// Sets the SourceBucket property for this request.
        /// This is the S3Bucket that contains the S3 Object you
        /// want to copy.
        /// </summary>
        /// <param name="srcBucket">The value that SourceBucket is set to</param>
        /// <returns>the request with the SourceBucket set</returns>
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
        /// Gets and sets the SourceKey property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceKey")]
        public string SourceKey
        {
            get { return this.srcKey; }
            set { this.srcKey = value; }
        }

        /// <summary>
        /// Sets the SourceKey property for this request.
        /// This is the S3Object you want to copy.
        /// </summary>
        /// <param name="srcKey">The value that SourceKey is set to</param>
        /// <returns>the request with the SourceKey set</returns>
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
        /// Gets and sets the SourceVersionId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceVersionId")]
        public string SourceVersionId
        {
            get { return this.srcVersionId; }
            set { this.srcVersionId = value; }
        }

        /// <summary>
        /// Sets the SourceVersionId property for this request.
        /// This is the SourceVersionId for the S3 Object you want to Get.
        /// </summary>
        /// <param name="srcVersionId">The value that SourceVersionId is set to</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the DestinationBucket property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DestinationBucket")]
        public string DestinationBucket
        {
            get { return this.dstBucket; }
            set { this.dstBucket = value; }
        }

        /// <summary>
        /// Sets the DestinationBucket property for this request.
        /// This is the S3 Bucket where the copied S3 Object is put.
        /// </summary>
        /// <param name="dstBucket">The value that DestinationBucket is set to</param>
        /// <returns>the request with the DestinationBucket set</returns>
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
        /// Gets and sets the DestinationKey property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DestinationKey")]
        public string DestinationKey
        {
            get { return this.dstKey; }
            set { this.dstKey = value; }
        }

        /// <summary>
        /// Sets the DestinationKey property for this request.
        /// This is the key for the new S3 Object that is copied.
        /// </summary>
        /// <param name="dstKey">The value that DestinationKey is set to</param>
        /// <returns>the request with the Destinationkey set</returns>
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
        /// Gets and sets the UploadID property.
        /// </summary>
        [XmlElementAttribute(ElementName = "UploadID")]
        public string UploadID
        {
            get { return this.uploadID; }
            set { this.uploadID = value; }
        }

        /// <summary>
        /// Sets the UploadID property for this request.
        /// This is the ID of the multipart upload for which we are copying a part.
        /// </summary>
        /// <param name="uploadID">The value that UploadID is set to</param>
        /// <returns>the request with the UploadID set</returns>
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
        /// Gets and sets the ETagsToMatch property.
        /// </summary>
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
        /// Adds the Etags to the ETagsToMatch property for this request.
        /// Copies the object if its entity tag (ETag) matches
        /// one of the specified tag; otherwise return a 412 (precondition failed).
        /// </summary>
        /// <param name="etagsToMatch">The items to be added to the ETagsToMatch.</param>
        /// <returns>this instance</returns>
        public CopyPartRequest WithETagsToMatch(params string[] etagsToMatch)
        {
            if (etagsToMatch != null)
            {
                this.ETagToMatch.AddRange(etagsToMatch);
            }
            return this;
        }

        /// <summary>
        /// Adds the Etags to the ETagsToMatch property for this request.
        /// Copies the object if its entity tag (ETag) matches
        /// one of the specified tag; otherwise return a 412 (precondition failed).
        /// </summary>
        /// <param name="etagsToMatch">The items to be added to the ETagsToMatch.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the ETagsToNotMatch property.
        /// </summary>
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
        /// Adds the Etags to the ETagsToNotMatch property for this request.
        /// Copies the object if its entity tag (ETag) is different
        /// from all the specified Etags; otherwise returns a 412 (failed condition).
        /// </summary>
        /// <param name="etagsToNotMatch">The ETags to add to the ETagsToNotMatch property</param>
        /// <returns>this instance</returns>
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
        /// Copies the object if its entity tag (ETag) is different
        /// from all the specified Etags; otherwise returns a 412 (failed condition).
        /// </summary>
        /// <param name="etagsToNotMatch">The ETags to add to the ETagsToNotMatch property</param>
        /// <returns>this instance</returns>
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
        /// Copies the object if it has been modified since the
        /// specified time; otherwise returns a 412 (failed condition).
        /// </summary>
        /// <param name="modifiedSinceDate">The value that ModifiedSinceDate is set to</param>
        /// <returns>this instance</returns>
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
        /// Copies the object if it hasn't been modified since the
        /// specified time; otherwise returns a 412 (precondition failed).
        /// </summary>
        /// <param name="unmodifiedSinceDate">The value that UnmodifiedSinceDate is set to</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets of the Timeout property (in milliseconds).
        /// The value of this property is assigned to the
        /// ReadWriteTimeout and Timeout properties of the
        /// HTTPWebRequest object used for S3 COPY requests.
        /// </summary>
        /// <remarks>Attempting to set value less than or equal to 0 (and not Infinite)
        /// will be silently ignored</remarks>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        public int Timeout
        {
            get { return this.timeout; }
            set
            {
                if ((value > 0) || (value == System.Threading.Timeout.Infinite))
                {
                    this.timeout = value;
                }
            }
        }

        /// <summary>
        /// Sets the Timeout property (in milliseconds).
        /// Please set the timeout only if you are certain that
        /// the file will not be transferred within the default intervals
        /// for an HttpWebRequest.
        /// </summary>
        /// <param name="timeout">Timeout property</param>
        /// <remarks>Attempting to set value less than or equal to 0 (and not Infinite)
        /// will be silently ignored</remarks>
        /// <returns>this instance</returns>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        public CopyPartRequest WithTimeout(int timeout)
        {
            Timeout = timeout;
            return this;
        }

        internal override bool SupportTimeout
        {
            get { return true; }
        }

        #endregion

        #region PartNumber

        /// <summary>
        /// Gets and sets of the PartNumber property.
        /// Valid part numbers are from 1 to 10,000 inclusive and will uniquely identify the part 
        /// and determine the relative ordering within the destination object.  If a part already
        /// exists with the PartNumber it will be overwritten.
        /// </summary>
        public int PartNumber
        {
            get { return this.partNumber.GetValueOrDefault(); }
            set { this.partNumber = value; }
        }

        /// <summary>
        /// Sets of the PartNumber property.
        /// Valid part numbers are from 1 to 10,000 inclusive and will uniquely identify the part 
        /// and determine the relative ordering within the destination object.  If a part already
        /// exists with the PartNumber it will be overwritten.
        /// </summary>
        /// <param name="partNumber">value to set the PartNumber property to</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the firstByte property.  This property contains the location of the first 
        /// byte in the range if only a portion of the source object is to be copied as the part.  
        /// The LastByte property must also be set or this value will be ignored.
        /// </summary>
        public long FirstByte
        {
            get { return this.firstByte.GetValueOrDefault(); }
            set { this.firstByte = value;  }
        }

        /// <summary>
        /// Sets the firstByte property.  This property contains the location of the first 
        /// byte in the range if only a portion of the source object is to be copied as the part.
        /// The LastByte property must also be set or this value will be ignored.
        /// </summary>
        /// <param name="firstByte">The value to set the FirstByte property too</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the lastByte property.  This property contains the location of the last 
        /// byte in the range if only a portion of the source object is to be copied as the part.  
        /// The FirstByte property must also be set or this value will be ignored.
        /// </summary>
        public long LastByte
        {
            get { return this.lastByte.GetValueOrDefault(); }
            set { this.lastByte = value; }
        }

        /// <summary>
        /// Gets and sets the lastByte property.  This property contains the location of the last 
        /// byte in the range if only a portion of the source object is to be copied as the part.  
        /// The FirstByte property must also be set or this value will be ignored.
        /// </summary>
        /// <param name="lastByte">The value to set the LastByte property to</param>
        /// <returns>this instance</returns>
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

    }
}