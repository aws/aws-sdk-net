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
 * Do not modify this file. This file is generated from the restxmldataplane-1999-12-31.normal.json service model.
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
namespace Amazon.RestXmlDataPlane.Model
{
    /// <summary>
    /// Container for the parameters to the GetObject operation.
    /// As seen in Amazon S3. Object I/O is HTTP payload I/O, and is more of a function of
    /// network and checksum performance than serde. It is here because it's an important
    /// operation, for completeness.
    /// </summary>
    public partial class GetObjectRequest : AmazonRestXmlDataPlaneRequest
    {
        private string _bucket;
        private ChecksumMode _checksumMode;
        private string _expectedBucketOwner;
        private string _ifMatch;
        private DateTime? _ifModifiedSince;
        private string _ifNoneMatch;
        private DateTime? _ifUnmodifiedSince;
        private string _key;
        private int? _partNumber;
        private string _range;
        private string _requestPayer;
        private string _responseCacheControl;
        private string _responseContentDisposition;
        private string _responseContentEncoding;
        private string _responseContentLanguage;
        private string _responseContentType;
        private DateTime? _responseExpires;
        private string _sseCustomerAlgorithm;
        private string _sseCustomerKey;
        private string _sseCustomerKeyMD5;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property Bucket.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumMode.
        /// </summary>
        public ChecksumMode ChecksumMode
        {
            get { return this._checksumMode; }
            set { this._checksumMode = value; }
        }

        // Check to see if ChecksumMode property is set
        internal bool IsSetChecksumMode()
        {
            return this._checksumMode != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner.
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return this._expectedBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property IfMatch.
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

        /// <summary>
        /// Gets and sets the property IfModifiedSince.
        /// </summary>
        public DateTime? IfModifiedSince
        {
            get { return this._ifModifiedSince; }
            set { this._ifModifiedSince = value; }
        }

        // Check to see if IfModifiedSince property is set
        internal bool IsSetIfModifiedSince()
        {
            return this._ifModifiedSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IfNoneMatch.
        /// </summary>
        public string IfNoneMatch
        {
            get { return this._ifNoneMatch; }
            set { this._ifNoneMatch = value; }
        }

        // Check to see if IfNoneMatch property is set
        internal bool IsSetIfNoneMatch()
        {
            return this._ifNoneMatch != null;
        }

        /// <summary>
        /// Gets and sets the property IfUnmodifiedSince.
        /// </summary>
        public DateTime? IfUnmodifiedSince
        {
            get { return this._ifUnmodifiedSince; }
            set { this._ifUnmodifiedSince = value; }
        }

        // Check to see if IfUnmodifiedSince property is set
        internal bool IsSetIfUnmodifiedSince()
        {
            return this._ifUnmodifiedSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Key.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property PartNumber.
        /// </summary>
        public int? PartNumber
        {
            get { return this._partNumber; }
            set { this._partNumber = value; }
        }

        // Check to see if PartNumber property is set
        internal bool IsSetPartNumber()
        {
            return this._partNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Range.
        /// </summary>
        public string Range
        {
            get { return this._range; }
            set { this._range = value; }
        }

        // Check to see if Range property is set
        internal bool IsSetRange()
        {
            return this._range != null;
        }

        /// <summary>
        /// Gets and sets the property RequestPayer.
        /// </summary>
        public string RequestPayer
        {
            get { return this._requestPayer; }
            set { this._requestPayer = value; }
        }

        // Check to see if RequestPayer property is set
        internal bool IsSetRequestPayer()
        {
            return this._requestPayer != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseCacheControl.
        /// </summary>
        public string ResponseCacheControl
        {
            get { return this._responseCacheControl; }
            set { this._responseCacheControl = value; }
        }

        // Check to see if ResponseCacheControl property is set
        internal bool IsSetResponseCacheControl()
        {
            return this._responseCacheControl != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseContentDisposition.
        /// </summary>
        public string ResponseContentDisposition
        {
            get { return this._responseContentDisposition; }
            set { this._responseContentDisposition = value; }
        }

        // Check to see if ResponseContentDisposition property is set
        internal bool IsSetResponseContentDisposition()
        {
            return this._responseContentDisposition != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseContentEncoding.
        /// </summary>
        public string ResponseContentEncoding
        {
            get { return this._responseContentEncoding; }
            set { this._responseContentEncoding = value; }
        }

        // Check to see if ResponseContentEncoding property is set
        internal bool IsSetResponseContentEncoding()
        {
            return this._responseContentEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseContentLanguage.
        /// </summary>
        public string ResponseContentLanguage
        {
            get { return this._responseContentLanguage; }
            set { this._responseContentLanguage = value; }
        }

        // Check to see if ResponseContentLanguage property is set
        internal bool IsSetResponseContentLanguage()
        {
            return this._responseContentLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseContentType.
        /// </summary>
        public string ResponseContentType
        {
            get { return this._responseContentType; }
            set { this._responseContentType = value; }
        }

        // Check to see if ResponseContentType property is set
        internal bool IsSetResponseContentType()
        {
            return this._responseContentType != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseExpires.
        /// </summary>
        public DateTime? ResponseExpires
        {
            get { return this._responseExpires; }
            set { this._responseExpires = value; }
        }

        // Check to see if ResponseExpires property is set
        internal bool IsSetResponseExpires()
        {
            return this._responseExpires.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SSECustomerAlgorithm.
        /// </summary>
        public string SSECustomerAlgorithm
        {
            get { return this._sseCustomerAlgorithm; }
            set { this._sseCustomerAlgorithm = value; }
        }

        // Check to see if SSECustomerAlgorithm property is set
        internal bool IsSetSSECustomerAlgorithm()
        {
            return this._sseCustomerAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property SSECustomerKey.
        /// </summary>
        public string SSECustomerKey
        {
            get { return this._sseCustomerKey; }
            set { this._sseCustomerKey = value; }
        }

        // Check to see if SSECustomerKey property is set
        internal bool IsSetSSECustomerKey()
        {
            return this._sseCustomerKey != null;
        }

        /// <summary>
        /// Gets and sets the property SSECustomerKeyMD5.
        /// </summary>
        public string SSECustomerKeyMD5
        {
            get { return this._sseCustomerKeyMD5; }
            set { this._sseCustomerKeyMD5 = value; }
        }

        // Check to see if SSECustomerKeyMD5 property is set
        internal bool IsSetSSECustomerKeyMD5()
        {
            return this._sseCustomerKeyMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId.
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

        #region Flexible checksum properties
        
        /// <inheritdoc/>
        protected override CoreChecksumResponseBehavior CoreChecksumMode
        {
            get
            {
                if (IsSetChecksumMode())
                {
                    return (CoreChecksumResponseBehavior)Enum.Parse(typeof(CoreChecksumResponseBehavior), this.ChecksumMode);
                }

                return CoreChecksumResponseBehavior.DISABLED;
            }
            set { this.ChecksumMode = value.ToString(); }
        }

        private static readonly List<CoreChecksumAlgorithm> _supportedChecksumAlgorithms = new List<CoreChecksumAlgorithm>
        {
            CoreChecksumAlgorithm.CRC64NVME, CoreChecksumAlgorithm.CRC32, CoreChecksumAlgorithm.CRC32C, CoreChecksumAlgorithm.SHA256, CoreChecksumAlgorithm.SHA1
        };

        /// <inheritdoc/>
        protected override System.Collections.ObjectModel.ReadOnlyCollection<CoreChecksumAlgorithm> ChecksumResponseAlgorithms => _supportedChecksumAlgorithms.AsReadOnly();

        #endregion
    }
}