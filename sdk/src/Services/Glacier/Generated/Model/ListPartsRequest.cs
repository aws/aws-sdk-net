/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the ListParts operation.
    /// This operation lists the parts of an archive that have been uploaded in a specific
    /// multipart upload. You can make this request at any time during an in-progress multipart
    /// upload before you complete the upload (see <a>CompleteMultipartUpload</a>. List Parts
    /// returns an error for completed uploads. The list returned in the List Parts response
    /// is sorted by part range. 
    /// 
    ///  
    /// <para>
    /// The List Parts operation supports pagination. By default, this operation returns up
    /// to 1,000 uploaded parts in the response. You should always check the response for
    /// a <code class="code">marker</code> at which to continue the list; if there are no
    /// more items the <code class="code">marker</code> is <code class="code">null</code>.
    /// To return a list of parts that begins at a specific part, set the <code>marker</code>
    /// request parameter to the value you obtained from a previous List Parts request. You
    /// can also limit the number of parts returned in the response by specifying the <code>limit</code>
    /// parameter in the request. 
    /// </para>
    ///  
    /// <para>
    /// An AWS account has full permission to perform all operations (actions). However, AWS
    /// Identity and Access Management (IAM) users don't have any permissions by default.
    /// You must grant them explicit permission to perform specific actions. For more information,
    /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
    /// Control Using AWS Identity and Access Management (IAM)</a>.
    /// </para>
    ///  
    /// <para>
    /// For conceptual information and the underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
    /// with Archives in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-list-parts.html">List
    /// Parts</a> in the <i>Amazon Glacier Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ListPartsRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private int? _limit;
        private string _marker;
        private string _uploadId;
        private string _vaultName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ListPartsRequest() { }

        /// <summary>
        /// Instantiates ListPartsRequest with the parameterized properties
        /// </summary>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="uploadId">The upload ID of the multipart upload.</param>
        public ListPartsRequest(string vaultName, string uploadId)
        {
            _vaultName = vaultName;
            _uploadId = uploadId;
        }

        /// <summary>
        /// Instantiates ListPartsRequest with the parameterized properties
        /// </summary>
        /// <param name="accountId">The <code>AccountId</code> is the AWS Account ID. You can specify either the AWS Account ID or optionally a '-', in which case Amazon Glacier uses the AWS Account ID associated with the credentials used to sign the request. If you specify your Account ID, do not include hyphens in it. </param>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="uploadId">The upload ID of the multipart upload.</param>
        public ListPartsRequest(string accountId, string vaultName, string uploadId)
        {
            _accountId = accountId;
            _vaultName = vaultName;
            _uploadId = uploadId;
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <code>AccountId</code> is the AWS Account ID. You can specify either the AWS Account
        /// ID or optionally a '-', in which case Amazon Glacier uses the AWS Account ID associated
        /// with the credentials used to sign the request. If you specify your Account ID, do
        /// not include hyphens in it. 
        /// </para>
        /// </summary>
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
        /// Specifies the maximum number of parts returned in the response body. If this value
        /// is not specified, the List Parts operation returns up to 1,000 uploads.
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
        /// Gets and sets the property Marker. 
        /// <para>
        /// An opaque string used for pagination. This value specifies the part at which the listing
        /// of parts should begin. Get the marker value from the response of a previous List Parts
        /// response. You need only include the marker if you are continuing the pagination of
        /// results started in a previous List Parts request.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The upload ID of the multipart upload.
        /// </para>
        /// </summary>
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
        }

        /// <summary>
        /// Gets and sets the property VaultName. 
        /// <para>
        /// The name of the vault.
        /// </para>
        /// </summary>
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