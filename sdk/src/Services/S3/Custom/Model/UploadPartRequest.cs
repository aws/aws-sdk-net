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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the UploadPart operation.
    /// Uploads a part in a multipart upload.
    /// 
    ///  <note> 
    /// <para>
    /// In this operation, you provide part data in your request. However, you have an option
    /// to specify your existing Amazon S3 object as a data source for the part you are uploading.
    /// To upload a part from an existing object, you use the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>
    /// operation. 
    /// </para>
    ///  </note> 
    /// <para>
    /// You must initiate a multipart upload (see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateMultipartUpload.html">CreateMultipartUpload</a>)
    /// before you can upload any part. In response to your initiate request, Amazon S3 returns
    /// an upload ID, a unique identifier, that you must include in your upload part request.
    /// </para>
    ///  
    /// <para>
    /// Part numbers can be any number from 1 to 10,000, inclusive. A part number uniquely
    /// identifies a part and also defines its position within the object being created. If
    /// you upload a new part using the same part number that was used with a previous part,
    /// the previously uploaded part is overwritten.
    /// </para>
    ///  
    /// <para>
    /// For information about maximum and minimum part sizes and other multipart upload specifications,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/qfacts.html">Multipart
    /// upload limits</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To ensure that data is not corrupted when traversing the network, specify the <code>Content-MD5</code>
    /// header in the upload part request. Amazon S3 checks the part data against the provided
    /// MD5 value. If they do not match, Amazon S3 returns an error. 
    /// </para>
    ///  
    /// <para>
    /// If the upload request is signed with Signature Version 4, then Amazon Web Services
    /// S3 uses the <code>x-amz-content-sha256</code> header as a checksum instead of <code>Content-MD5</code>.
    /// For more information see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-auth-using-authorization-header.html">Authenticating
    /// Requests: Using the Authorization Header (Amazon Web Services Signature Version 4)</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Note:</b> After you initiate multipart upload and upload one or more parts, you
    /// must either complete or abort multipart upload in order to stop getting charged for
    /// storage of the uploaded parts. Only after you either complete or abort multipart upload,
    /// Amazon S3 frees up the parts storage and stops charging you for the parts storage.
    /// </para>
    ///  
    /// <para>
    /// For more information on multipart uploads, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html">Multipart
    /// Upload Overview</a> in the <i>Amazon S3 User Guide </i>.
    /// </para>
    ///  
    /// <para>
    /// For information on the permissions required to use the multipart upload API, go to
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
    /// Upload and Permissions</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can optionally request server-side encryption where Amazon S3 encrypts your data
    /// as it writes it to disks in its data centers and decrypts it for you when you access
    /// it. You have the option of providing your own encryption key, or you can use the Amazon
    /// Web Services managed encryption keys. If you choose to provide your own encryption
    /// key, the request headers you provide in the request must match the headers you used
    /// in the request to initiate the upload by using <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateMultipartUpload.html">CreateMultipartUpload</a>.
    /// For more information, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingServerSideEncryption.html">Using
    /// Server-Side Encryption</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Server-side encryption is supported by the S3 Multipart Upload actions. Unless you
    /// are using a customer-provided encryption key, you don't need to specify the encryption
    /// parameters in each UploadPart request. Instead, you only need to specify the server-side
    /// encryption parameters in the initial Initiate Multipart request. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateMultipartUpload.html">CreateMultipartUpload</a>.
    /// </para>
    ///  
    /// <para>
    /// If you requested server-side encryption using a customer-provided encryption key in
    /// your initiate multipart upload request, you must provide identical encryption information
    /// in each part upload using the following headers.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// x-amz-server-side-encryption-customer-algorithm
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// x-amz-server-side-encryption-customer-key
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// x-amz-server-side-encryption-customer-key-MD5
    /// </para>
    ///  </li> </ul> <para class="title"> <b>Special Errors</b> 
    /// </para>
    ///  <ul> <li> <ul> <li> 
    /// <para>
    ///  <i>Code: NoSuchUpload</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Cause: The specified multipart upload does not exist. The upload ID might be invalid,
    /// or the multipart upload might have been aborted or completed.</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i> HTTP Status Code: 404 Not Found </i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>SOAP Fault Code Prefix: Client</i> 
    /// </para>
    ///  </li> </ul> </li> </ul> <para class="title"> <b>Related Resources</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateMultipartUpload.html">CreateMultipartUpload</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CompleteMultipartUpload.html">CompleteMultipartUpload</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_AbortMultipartUpload.html">AbortMultipartUpload</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListParts.html">ListParts</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListMultipartUploads.html">ListMultipartUploads</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UploadPartRequest : AmazonWebServiceRequest
    {
        private Stream inputStream;
        private string bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumSHA1;
        private string _checksumSHA256;
        private string md5Digest;
        private string expectedBucketOwner;
        private string key;
        private int? partNumber;
        private RequestPayer requestPayer;
        private ServerSideEncryptionCustomerMethod serverSideCustomerEncryption;
        private string serverSideEncryptionCustomerProvidedKey;
        private string serverSideEncryptionCustomerProvidedKeyMD5;
        private string uploadId;
        private long? partSize;
        private string filePath;
        private long? filePosition;
        private bool useChunkEncoding = true;
        private bool lastPart;
        private bool calculateContentMD5Header = false;

        /// <summary>
        /// Input stream for the request; content for the request will be read from the stream.
        /// </summary>
        public Stream InputStream
        {
            get { return this.inputStream; }
            set { this.inputStream = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetInputStream()
        {
            return this.inputStream != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket to which the multipart upload was initiated.
        /// </para>
        ///  
        /// <para>
        /// When using this action with an access point, you must direct requests to the access
        /// point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com.
        /// When using this action with an access point through the Amazon Web Services SDKs,
        /// you provide the access point ARN in place of the bucket name. For more information
        /// about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using
        /// access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When using this action with Amazon S3 on Outposts, you must direct requests to the
        /// S3 on Outposts hostname. The S3 on Outposts hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com.
        /// When using this action using S3 on Outposts through the Amazon Web Services SDKs,
        /// you provide the Outposts bucket ARN in place of the bucket name. For more information
        /// about S3 on Outposts ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object. Amazon S3 will
        /// fail the request with a 400 error if there is no checksum associated with the object.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you provide an individual checksum, Amazon S3 will ignore any provided <code>ChecksumAlgorithm</code>.
        /// </para>
        /// </summary>
        public ChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this._checksumAlgorithm; }
            set { this._checksumAlgorithm = value; }
        }

        // Check to see if ChecksumAlgorithm property is set
        internal bool IsSetChecksumAlgorithm()
        {
            return this._checksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC32. 
        /// <para>
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the base64-encoded, 32-bit
        /// CRC32 checksum of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumCRC32
        {
            get { return this._checksumCRC32; }
            set { this._checksumCRC32 = value; }
        }

        // Check to see if ChecksumCRC32 property is set
        internal bool IsSetChecksumCRC32()
        {
            return this._checksumCRC32 != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC32C. 
        /// <para>
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the base64-encoded, 32-bit
        /// CRC32C checksum of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumCRC32C
        {
            get { return this._checksumCRC32C; }
            set { this._checksumCRC32C = value; }
        }

        // Check to see if ChecksumCRC32C property is set
        internal bool IsSetChecksumCRC32C()
        {
            return this._checksumCRC32C != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumSHA1. 
        /// <para>
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the base64-encoded, 160-bit
        /// SHA-1 digest of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumSHA1
        {
            get { return this._checksumSHA1; }
            set { this._checksumSHA1 = value; }
        }

        // Check to see if ChecksumSHA1 property is set
        internal bool IsSetChecksumSHA1()
        {
            return this._checksumSHA1 != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumSHA256. 
        /// <para>
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the base64-encoded, 256-bit
        /// SHA-256 digest of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumSHA256
        {
            get { return this._checksumSHA256; }
            set { this._checksumSHA256 = value; }
        }

        // Check to see if ChecksumSHA256 property is set
        internal bool IsSetChecksumSHA256()
        {
            return this._checksumSHA256 != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the bucket is owned by a different
        /// account, the request will fail with an HTTP <code>403 (Access Denied)</code> error.
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
        /// The key of the object.
        /// </summary>
        /// <remarks>
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..". /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".." 
        /// is interpreted as use parent directory. For further information view the documentation for 
        /// the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
        /// </remarks>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// Gets and sets the property PartNumber. 
        /// <para>
        /// Part number of part being uploaded. This is a positive integer between 1 and 10,000.
        /// </para>
        /// </summary>
        public int PartNumber
        {
            get { return this.partNumber.GetValueOrDefault(); }
            set { this.partNumber = value; }
        }

        // Check to see if PartNumber property is set
        internal bool IsSetPartNumber()
        {
            return this.partNumber.HasValue;
        }

        /// <summary>
        /// Confirms that the requester knows that she or he will be charged for the request.
        /// Bucket owners need not specify this parameter in their requests.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this.requestPayer; }
            set { this.requestPayer = value; }
        }

        // Check to see if RequestPayer property is set
        internal bool IsSetRequestPayer()
        {
            return requestPayer != null;
        }

        /// <summary>
        /// The Server-side encryption algorithm to be used with the customer provided key.
        /// <para>
        /// Specifies the algorithm to use to when encrypting the object (for example, AES256).
        /// </para>
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod
        {
            get { return this.serverSideCustomerEncryption; }
            set { this.serverSideCustomerEncryption = value; }
        }

        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionCustomerMethod()
        {
            return this.serverSideCustomerEncryption != null && this.serverSideCustomerEncryption != ServerSideEncryptionCustomerMethod.None;
        }

        /// <summary>
        /// The base64-encoded encryption key for Amazon S3 to use to encrypt the object
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
        /// Checks if ServerSideEncryptionCustomerProvidedKey property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKey()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionCustomerProvidedKey);
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
        /// Checks if ServerSideEncryptionCustomerProvidedKeyMD5 property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionCustomerProvidedKeyMD5);
        }	

        /// <summary>
        /// Upload ID identifying the multipart upload whose part is being uploaded.
        /// </summary>
        public string UploadId
        {
            get { return this.uploadId; }
            set { this.uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this.uploadId != null;
        }

        /// <summary>
        /// Caller needs to set this to true when uploading the last part. This property only needs to be set
        /// when using the AmazonS3EncryptionClient.
        /// </summary>
        public bool IsLastPart
        {
            get { return this.lastPart; }
            set { this.lastPart = value; }
        }

        /// <summary>
        /// <para><b>WARNING: Setting DisableMD5Stream to true disables the MD5 data integrity check 
        /// on this request.</b></para>
        /// <para>When true, MD5Stream will not be used in the upload request. This may increase 
        /// upload performance under high CPU loads. The default value is null. When null, the 
        /// AWSConfigsS3.DisableMD5Stream property value will be used.</para>
        /// <para>MD5Stream, SigV4 payload signing, and HTTPS each provide some data integrity 
        /// verification. If DisableMD5Stream is true and DisablePayloadSigning is true, then the 
        /// possibility of data corruption is completely dependant on HTTPS being the only remaining 
        /// source of data integrity verification.</para>
        /// </summary>
        public bool? DisableMD5Stream { get; set; }

        /// <summary>
        /// An MD5 digest for the part.
        /// </summary>
        public string MD5Digest
        {
            get { return this.md5Digest; }
            set { this.md5Digest = value; }
        }

        /// <summary>
        /// Checks if the MD5Digest property is set.
        /// </summary>
        /// <returns>true if Md5Digest property is set.</returns>
        internal bool IsSetMD5Digest()
        {
            return !string.IsNullOrEmpty(this.md5Digest);
        }

        /// <summary>
        /// The size of the part to be uploaded.
        /// </summary>
        public long PartSize
        {
            get { return this.partSize.GetValueOrDefault(); }
            set { this.partSize = value; }
        }

        /// <summary>
        /// Checks if PartSize property is set.
        /// </summary>
        /// <returns>true if PartSize property is set.</returns>
        internal bool IsSetPartSize()
        {
            return this.partSize.HasValue;
        }
        
        /// <summary>
		/// <para>
        /// Full path and name of a file from which the content for the part is retrieved.
		/// </para>
        /// <para>
        /// For WinRT and Windows Phone this property must be in the form of "ms-appdata:///local/file.txt".
        /// </para>
        /// </summary>
        public string FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }

        /// <summary>
        /// Checks if the FilePath property is set.
        /// </summary>
        /// <returns>true if FilePath property is set.</returns>
        internal bool IsSetFilePath()
        {
            return !string.IsNullOrEmpty(this.filePath);
        }

        /// <summary>
        /// Position in the file specified by FilePath from which to retrieve the content of the part. 
        /// This field is required when a file path is specified. It is ignored when using the InputStream property.
        /// </summary>
        public long FilePosition
        {
            get { return this.filePosition.GetValueOrDefault(); }
            set { this.filePosition = value; }
        }

        /// <summary>
        /// If this value is set to true then a chunked encoding upload will be used for the request.
        /// Default: true.
        /// </summary>
        public bool UseChunkEncoding
        {
            get { return this.useChunkEncoding; }
            set { this.useChunkEncoding = value; }
        }

        /// <summary>      
        /// <para><b>WARNING: Setting DisablePayloadSigning to true disables the SigV4 payload signing 
        /// data integrity check on this request.</b></para>  
        /// <para>If using SigV4, the DisablePayloadSigning flag controls if the payload should be 
        /// signed on a request by request basis. By default this flag is null which will use the 
        /// default client behavior. The default client behavior is to sign the payload. When 
        /// DisablePayloadSigning is true, the request will be signed with an UNSIGNED-PAYLOAD value. 
        /// Setting DisablePayloadSigning to true requires that the request is sent over a HTTPS 
        /// connection.</para>        
        /// <para>Under certain circumstances, such as uploading to S3 while using MD5 hashing, it may 
        /// be desireable to use UNSIGNED-PAYLOAD to decrease signing CPU usage. This flag only applies 
        /// to Amazon S3 PutObject and UploadPart requests.</para>
        /// <para>MD5Stream, SigV4 payload signing, and HTTPS each provide some data integrity 
        /// verification. If DisableMD5Stream is true and DisablePayloadSigning is true, then the 
        /// possibility of data corruption is completely dependant on HTTPS being the only remaining 
        /// source of data integrity verification.</para>
        /// </summary>
        public bool? DisablePayloadSigning { get; set; }

        /// <summary>
        /// Checks if the FilePosition property is set.
        /// </summary>
        /// <returns>true if FilePosition property is set.</returns>
        internal bool IsSetFilePosition()
        {
            return this.filePosition.HasValue;
        }

        /// <summary>
        /// Attach a callback that will be called as data is being sent to the AWS Service.
        /// </summary>
        public EventHandler<Amazon.Runtime.StreamTransferProgressArgs> StreamTransferProgress
        {
            get
            {
                return ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)this).StreamUploadProgressCallback;
            }
            set
            {
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)this).StreamUploadProgressCallback = value;
            }
        }

        /// <summary>
        /// Overriden to turn off sending SHA256 header.
        /// </summary>
        protected override bool IncludeSHA256Header
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Overriden to turn on Expect 100 continue.
        /// </summary>
        protected override bool Expect100Continue
        {
            get
            {
                return true;
            }
        }

        internal int IVSize { get; set; }

        /// <summary>
        /// Gets or sets whether the Content-MD5 header should be calculated for upload.
        /// </summary>
        public bool CalculateContentMD5Header
        {
            get { return this.calculateContentMD5Header; }
            set { this.calculateContentMD5Header = value; }
        }
    }
}

