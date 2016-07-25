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
 *
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

using Amazon.S3.Model;
using System.Globalization;
using Amazon.Util;

namespace Amazon.S3.Util
{
    /// <summary>
    /// Parameters for uploading to Amazon S3 a file using HTTP POS
    /// </summary>
    /// <remarks>
    /// <para>
    /// If a S3PostUploadSignedPolicy is assigned, then values set (other than InputStream or Path) on this object must adhere to the policy. 
    /// This includes metadata. If metadata is specified in the policy, then it must be included in the request. Adding metadata not in the
    /// policy will cause the POST to fail.
    /// </para><para>
    /// For more information, <see href="http://docs.aws.amazon.com/AmazonS3/latest/dev/UsingHTTPPOST.html"/>
    /// </para>
    /// </remarks>
    public class S3PostUploadRequest
    {
        private S3StorageClass _storageClass;
        private HttpStatusCode _actionStatus;
        private RegionEndpoint _region = RegionEndpoint.USEast1;

        private bool
            _isSetStorageClass = false,
            _isSetActionStatus = false;


        /// <summary>
        /// Default constructor.
        /// </summary>
        public S3PostUploadRequest()
        {
            this.Metadata = new Dictionary<string, string>();
            this.CannedACL = S3CannedACL.Private;
            this._actionStatus = HttpStatusCode.NoContent;
            this._storageClass = S3StorageClass.Standard;
        }

        /// <summary>
        /// S3 Bucket to upload the object to
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// The name of the uploaded key.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Stream to read the upload data for
        /// </summary>
        /// <remarks>
        /// If you use InputStream, then you also need to set ContentLength
        /// </remarks>
        public Stream InputStream { get; set; }

        /// <summary>
        /// File path to read the upload data from
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Content type for the uploaded data
        /// </summary>
        /// <remarks>
        /// If this is not set, an attempt will be made to infer it from the extension on Key or Path (in that order), 
        /// otherwise 'application/octet-stream' will be assumed.
        /// </remarks>
        public string ContentType { get; set; }

        /// <summary>
        /// Specifies an Amazon S3 access control list
        /// </summary>
        public S3CannedACL CannedACL { get; set; }

        /// <summary>
        /// Signed policy from bucket owner.
        /// </summary>
        public S3PostUploadSignedPolicy SignedPolicy { get; set; }

        /// <summary>
        /// Where to redirect browsers on a successful upload
        /// </summary>
        public string SuccessActionRedirect { get; set; }

        /// <summary>
        /// The status code returned to the client upon successful upload if success_action_redirect is not specified
        /// </summary>
        /// <remarks>
        /// <para>
        /// Accepts the values OK (200) , Created (201), or NoContent (204, default).
        /// </para><para>
        /// If the value is set to OK or NoContent, Amazon S3 returns an empty document with a 200 or 204 status code.
        /// </para><para>
        /// If the value is set to Created, Amazon S3 returns an XML document with a 201 status code.
        /// </para><para>
        /// If the value is not set or if it is set to an invalid value, Amazon S3 returns an empty document with a 204 status code. 
        /// </para>
        /// </remarks>
        public HttpStatusCode SuccessActionStatus
        {
            get { return this._actionStatus; }
            set
            {
                this._actionStatus = value;
                this._isSetActionStatus = true;
            }
        }

        /// <summary>
        /// Storage class to use for storing the object
        /// </summary>
        /// <remarks>
        /// Default: STANDARD
        /// </remarks>
        public S3StorageClass StorageClass
        {
            get { return this._storageClass; }
            set 
            { 
                this._storageClass = value; 
                this._isSetStorageClass = true; 
            }
        }

        /// <summary>
        /// The AWS region where the bucket is located.
        /// </summary>
        /// <remarks>
        /// Depending upon the bucket name, POST uploads will be
        /// successfully redirected, but for buckets with non-DNS-compliant
        /// characters, redirects will fail. Setting this to the appropriate 
        /// region will avoid the redirect.
        /// </remarks>
        public RegionEndpoint Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        /// <summary>
        /// Metadata to set on the uploaded object
        /// </summary>
        /// <remarks>
        /// If keys do not begin with 'x-amz-meta-' it will be added at POST time.
        /// </remarks>
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Write the multipart/form-data for this request for all fields except the file data to a stream
        /// </summary>
        internal void WriteFormData(string boundary, Stream outputStream)
        {
            if (!String.IsNullOrEmpty(this.Key))
                WriteFormDatum(outputStream, S3Constants.PostFormDataObjectKey, this.Key, boundary);

            WriteFormDatum(outputStream, S3Constants.PostFormDataAcl, this.CannedACL, boundary);

            if (this._isSetStorageClass)
                WriteFormDatum(outputStream, HeaderKeys.XAmzStorageClassHeader, this.StorageClass, boundary);

            if (this._isSetActionStatus)
                WriteFormDatum(outputStream, S3Constants.PostFormDataStatus, ((Int32)this.SuccessActionStatus).ToString(CultureInfo.InvariantCulture), boundary);

            if (!String.IsNullOrEmpty(this.SuccessActionRedirect))
                WriteFormDatum(outputStream, S3Constants.PostFormDataRedirect, this.SuccessActionRedirect, boundary);

            if (String.IsNullOrEmpty(this.ContentType))
            {
                if (this.Key.IndexOf('.') > -1)
                    this.ContentType = AmazonS3Util.MimeTypeFromExtension(this.Key.Substring(this.Key.LastIndexOf('.')));
                else if (!String.IsNullOrEmpty(this.Path) && this.Path.IndexOf('.') > -1)
                    this.ContentType = AmazonS3Util.MimeTypeFromExtension(this.Key.Substring(this.Path.LastIndexOf('.')));
            }

            WriteFormDatum(outputStream, S3Constants.PostFormDataContentType, this.ContentType, boundary);

            if (this.SignedPolicy != null && !string.IsNullOrEmpty(this.SignedPolicy.SecurityToken))
            {
                this.Metadata[S3Constants.PostFormDataSecurityToken] = this.SignedPolicy.SecurityToken;
            }

            foreach (var kvp in this.Metadata)
            {
                var metakey = kvp.Key.StartsWith(S3Constants.PostFormDataXAmzPrefix, StringComparison.Ordinal) ? kvp.Key : S3Constants.PostFormDataMetaPrefix + kvp.Key;
                WriteFormDatum(outputStream, metakey, kvp.Value, boundary);
            }

            if (this.SignedPolicy != null)
            {
                WriteFormDatum(outputStream, S3Constants.PostFormDataAccessKeyId, this.SignedPolicy.AccessKeyId, boundary);
                WriteFormDatum(outputStream, S3Constants.PostFormDataPolicy, this.SignedPolicy.Policy, boundary);
                WriteFormDatum(outputStream, S3Constants.PostFormDataSignature, this.SignedPolicy.Signature, boundary);
            }
        }

        private static void WriteFormDatum(Stream stream, string name, string value, string boundary)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, "--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}\r\n", boundary, name, value));
            stream.Write(bytes, 0, bytes.Length);
        }
    }
}
