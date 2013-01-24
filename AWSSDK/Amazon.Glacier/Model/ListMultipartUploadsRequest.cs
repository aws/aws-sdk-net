/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the ListMultipartUploads operation.
    /// <para>This operation lists in-progress multipart uploads for the specified vault. An in-progress multipart upload is a multipart upload that
    /// has been initiated by an InitiateMultipartUpload request, but has not yet been completed or aborted. The list returned in the List Multipart
    /// Upload response has no guaranteed order. </para> <para>The List Multipart Uploads operation supports pagination. By default, this operation
    /// returns up to 1,000 multipart uploads in the response. You should always check the response for a <c>marker</c> at which to continue the
    /// list; if there are no more items the <c>marker</c> is <c>null</c> .
    /// To return a list of multipart uploads that begins at a specific upload, set the <c>marker</c> request parameter to the value you
    /// obtained from a previous List Multipart Upload request. You can also limit the number of uploads returned in the response by specifying the
    /// <c>limit</c> parameter in the request.</para> <para>Note the difference between this operation and listing parts (ListParts). The List
    /// Multipart Uploads operation lists all multipart uploads for a vault and does not require a multipart upload ID. The List Parts operation
    /// requires a multipart upload ID since parts are associated with a single upload.</para> <para>An AWS account has full permission to perform
    /// all operations (actions). However, AWS Identity and Access Management (IAM) users don't have any permissions by default. You must grant them
    /// explicit permission to perform specific actions. For more information, see Access Control Using AWS Identity and Access Management
    /// (IAM).</para> <para>For conceptual information and the underlying REST API, go to Working with Archives in Amazon Glacier and List Multipart
    /// Uploads in the <i>Amazon Glacier Developer Guide</i> .</para>
    /// </summary>
    /// <seealso cref="Amazon.Glacier.AmazonGlacier.ListMultipartUploads"/>
    public class ListMultipartUploadsRequest : AmazonWebServiceRequest
    {
        private string accountId;
        private string vaultName;
        private string uploadIdMarker;
        private int? limit;

        /// <summary>
        /// The <c>AccountId</c> is the AWS Account ID. You can specify either the AWS Account ID or optionally a '-', in which case Amazon Glacier uses
        /// the AWS Account ID associated with the credentials used to sign the request. If you specify your Account ID, do not include hyphens in it.
        ///  
        /// </summary>
        public string AccountId
        {
            get { return this.accountId; }
            set { this.accountId = value; }
        }

        /// <summary>
        /// Sets the AccountId property
        /// </summary>
        /// <param name="accountId">The value to set for the AccountId property </param>
        /// <returns>this instance</returns>
        public ListMultipartUploadsRequest WithAccountId(string accountId)
        {
            this.accountId = accountId;
            return this;
        }
            

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this.accountId != null;       
        }

        /// <summary>
        /// The name of the vault.
        ///  
        /// </summary>
        public string VaultName
        {
            get { return this.vaultName; }
            set { this.vaultName = value; }
        }

        /// <summary>
        /// Sets the VaultName property
        /// </summary>
        /// <param name="vaultName">The value to set for the VaultName property </param>
        /// <returns>this instance</returns>
        public ListMultipartUploadsRequest WithVaultName(string vaultName)
        {
            this.vaultName = vaultName;
            return this;
        }
            

        // Check to see if VaultName property is set
        internal bool IsSetVaultName()
        {
            return this.vaultName != null;       
        }

        /// <summary>
        /// An opaque string used for pagination. This value specifies the upload at which the listing of uploads should begin. Get the marker value
        /// from a previous List Uploads response. You need only include the marker if you are continuing the pagination of results started in a
        /// previous List Uploads request.
        ///  
        /// </summary>
        public string UploadIdMarker
        {
            get { return this.uploadIdMarker; }
            set { this.uploadIdMarker = value; }
        }

        /// <summary>
        /// Sets the UploadIdMarker property
        /// </summary>
        /// <param name="uploadIdMarker">The value to set for the UploadIdMarker property </param>
        /// <returns>this instance</returns>
        public ListMultipartUploadsRequest WithUploadIdMarker(string uploadIdMarker)
        {
            this.uploadIdMarker = uploadIdMarker;
            return this;
        }
            

        // Check to see if UploadIdMarker property is set
        internal bool IsSetUploadIdMarker()
        {
            return this.uploadIdMarker != null;       
        }

        /// <summary>
        /// Specifies the maximum number of uploads returned in the response body. If this value is not specified, the List Uploads operation returns up
        /// to 1,000 uploads.
        ///  
        /// </summary>
        public int Limit
        {
            get { return this.limit ?? default(int); }
            set { this.limit = value; }
        }

        /// <summary>
        /// Sets the Limit property
        /// </summary>
        /// <param name="limit">The value to set for the Limit property </param>
        /// <returns>this instance</returns>
        public ListMultipartUploadsRequest WithLimit(int limit)
        {
            this.limit = limit;
            return this;
        }
            

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.limit.HasValue;       
        }
    }
}
    
