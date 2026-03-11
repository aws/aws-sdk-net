/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.S3.Model;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// Contains all the parameters that can be set when making a request to abort multipart uploads
    /// with the <c>TransferUtility</c> method.
    /// </summary>
    public class TransferUtilityAbortMultipartUploadRequest
    {
        private string _bucketName;
        private DateTime? _initiatedDate;
        private string _expectedBucketOwner;
        private RequestPayer _requestPayer;

        /// <summary>
        /// Gets or sets the name of the bucket containing multipart uploads.
        /// </summary>
        /// <value>
        /// The name of the bucket containing multipart uploads.
        /// </value>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        /// <summary>
        /// Checks if BucketName property is set.
        /// </summary>
        /// <returns>true if BucketName property is set.</returns>
        internal bool IsSetBucketName()
        {
            return !string.IsNullOrEmpty(this._bucketName);
        }

        /// <summary>
        /// Gets or sets the date before which the multipart uploads were initiated.
        /// </summary>
        /// <value>
        /// The date before which the multipart uploads were initiated.
        /// </value>
        public DateTime? InitiatedDate
        {
            get { return this._initiatedDate; }
            set { this._initiatedDate = value; }
        }

        /// <summary>
        /// Checks if InitiatedDate property is set.
        /// </summary>
        /// <returns>true if InitiatedDate property is set.</returns>
        internal bool IsSetInitiatedDate()
        {
            return this._initiatedDate.HasValue;
        }

        /// <summary>
        /// Gets or sets the account ID of the expected bucket owner.
        /// If the account ID that you provide does not match the actual owner of the bucket,
        /// the request fails with the HTTP status code 403 Forbidden (access denied).
        /// </summary>
        /// <value>
        /// The account ID of the expected bucket owner.
        /// </value>
        public string ExpectedBucketOwner
        {
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        /// <summary>
        /// Checks if ExpectedBucketOwner property is set.
        /// </summary>
        /// <returns>true if ExpectedBucketOwner property is set.</returns>
        internal bool IsSetExpectedBucketOwner()
        {
            return !string.IsNullOrEmpty(this._expectedBucketOwner);
        }

        /// <summary>
        /// Gets or sets the request payer setting for the abort multipart upload operations.
        /// Confirms that the requester knows that they will be charged for the request.
        /// Bucket owners need not specify this parameter in their requests.
        /// </summary>
        /// <value>
        /// The request payer setting for the abort multipart upload operations.
        /// </value>
        public RequestPayer RequestPayer
        {
            get { return this._requestPayer; }
            set { this._requestPayer = value; }
        }

        /// <summary>
        /// Checks if RequestPayer property is set.
        /// </summary>
        /// <returns>true if RequestPayer property is set.</returns>
        internal bool IsSetRequestPayer()
        {
            return this._requestPayer != null;
        }
    }
}
