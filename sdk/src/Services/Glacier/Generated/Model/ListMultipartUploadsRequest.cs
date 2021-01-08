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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the ListMultipartUploads operation.
    /// This operation lists in-progress multipart uploads for the specified vault. An in-progress
    /// multipart upload is a multipart upload that has been initiated by an <a>InitiateMultipartUpload</a>
    /// request, but has not yet been completed or aborted. The list returned in the List
    /// Multipart Upload response has no guaranteed order. 
    /// 
    ///  
    /// <para>
    /// The List Multipart Uploads operation supports pagination. By default, this operation
    /// returns up to 50 multipart uploads in the response. You should always check the response
    /// for a <code>marker</code> at which to continue the list; if there are no more items
    /// the <code>marker</code> is <code>null</code>. To return a list of multipart uploads
    /// that begins at a specific upload, set the <code>marker</code> request parameter to
    /// the value you obtained from a previous List Multipart Upload request. You can also
    /// limit the number of uploads returned in the response by specifying the <code>limit</code>
    /// parameter in the request.
    /// </para>
    ///  
    /// <para>
    /// Note the difference between this operation and listing parts (<a>ListParts</a>). The
    /// List Multipart Uploads operation lists all multipart uploads for a vault and does
    /// not require a multipart upload ID. The List Parts operation requires a multipart upload
    /// ID since parts are associated with a single upload.
    /// </para>
    ///  
    /// <para>
    /// An AWS account has full permission to perform all operations (actions). However, AWS
    /// Identity and Access Management (IAM) users don't have any permissions by default.
    /// You must grant them explicit permission to perform specific actions. For more information,
    /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
    /// Control Using AWS Identity and Access Management (IAM)</a>.
    /// </para>
    ///  
    /// <para>
    /// For conceptual information and the underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
    /// with Archives in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-list-uploads.html">List
    /// Multipart Uploads </a> in the <i>Amazon Glacier Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ListMultipartUploadsRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private int? _limit;
        private string _uploadIdMarker;
        private string _vaultName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ListMultipartUploadsRequest() { }

        /// <summary>
        /// Instantiates ListMultipartUploadsRequest with the parameterized properties
        /// </summary>
        /// <param name="vaultName">The name of the vault.</param>
        public ListMultipartUploadsRequest(string vaultName)
        {
            _vaultName = vaultName;
        }

        /// <summary>
        /// Instantiates ListMultipartUploadsRequest with the parameterized properties
        /// </summary>
        /// <param name="accountId">The <code>AccountId</code> value is the AWS account ID of the account that owns the vault. You can either specify an AWS account ID or optionally a single '<code>-</code>' (hyphen), in which case Amazon S3 Glacier uses the AWS account ID associated with the credentials used to sign the request. If you use an account ID, do not include any hyphens ('-') in the ID. </param>
        /// <param name="vaultName">The name of the vault.</param>
        public ListMultipartUploadsRequest(string accountId, string vaultName)
        {
            _accountId = accountId;
            _vaultName = vaultName;
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <code>AccountId</code> value is the AWS account ID of the account that owns the
        /// vault. You can either specify an AWS account ID or optionally a single '<code>-</code>'
        /// (hyphen), in which case Amazon S3 Glacier uses the AWS account ID associated with
        /// the credentials used to sign the request. If you use an account ID, do not include
        /// any hyphens ('-') in the ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Specifies the maximum number of uploads returned in the response body. If this value
        /// is not specified, the List Uploads operation returns up to 50 uploads.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadIdMarker. 
        /// <para>
        /// An opaque string used for pagination. This value specifies the upload at which the
        /// listing of uploads should begin. Get the marker value from a previous List Uploads
        /// response. You need only include the marker if you are continuing the pagination of
        /// results started in a previous List Uploads request.
        /// </para>
        /// </summary>
        public string UploadIdMarker
        {
            get { return this._uploadIdMarker; }
            set { this._uploadIdMarker = value; }
        }

        // Check to see if UploadIdMarker property is set
        internal bool IsSetUploadIdMarker()
        {
            return this._uploadIdMarker != null;
        }

        /// <summary>
        /// Gets and sets the property VaultName. 
        /// <para>
        /// The name of the vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VaultName
        {
            get { return this._vaultName; }
            set { this._vaultName = value; }
        }

        // Check to see if VaultName property is set
        internal bool IsSetVaultName()
        {
            return this._vaultName != null;
        }

    }
}