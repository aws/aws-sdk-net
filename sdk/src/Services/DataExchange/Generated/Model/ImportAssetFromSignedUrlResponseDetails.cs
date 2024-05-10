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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
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
namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// The details in the response for an import request, including the signed URL and other
    /// information.
    /// </summary>
    public partial class ImportAssetFromSignedUrlResponseDetails
    {
        private string _assetName;
        private string _dataSetId;
        private string _md5Hash;
        private string _revisionId;
        private string _signedUrl;
        private DateTime? _signedUrlExpiresAt;

        /// <summary>
        /// Gets and sets the property AssetName. 
        /// <para>
        /// The name for the asset associated with this import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssetName
        {
            get { return this._assetName; }
            set { this._assetName = value; }
        }

        // Check to see if AssetName property is set
        internal bool IsSetAssetName()
        {
            return this._assetName != null;
        }

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The unique identifier for the data set associated with this import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSetId
        {
            get { return this._dataSetId; }
            set { this._dataSetId = value; }
        }

        // Check to see if DataSetId property is set
        internal bool IsSetDataSetId()
        {
            return this._dataSetId != null;
        }

        /// <summary>
        /// Gets and sets the property Md5Hash. 
        /// <para>
        /// The Base64-encoded Md5 hash for the asset, used to ensure the integrity of the file
        /// at that location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=24, Max=24)]
        public string Md5Hash
        {
            get { return this._md5Hash; }
            set { this._md5Hash = value; }
        }

        // Check to see if Md5Hash property is set
        internal bool IsSetMd5Hash()
        {
            return this._md5Hash != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The unique identifier for the revision associated with this import response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

        /// <summary>
        /// Gets and sets the property SignedUrl. 
        /// <para>
        /// The signed URL.
        /// </para>
        /// </summary>
        public string SignedUrl
        {
            get { return this._signedUrl; }
            set { this._signedUrl = value; }
        }

        // Check to see if SignedUrl property is set
        internal bool IsSetSignedUrl()
        {
            return this._signedUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SignedUrlExpiresAt. 
        /// <para>
        /// The time and date at which the signed URL expires, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? SignedUrlExpiresAt
        {
            get { return this._signedUrlExpiresAt; }
            set { this._signedUrlExpiresAt = value; }
        }

        // Check to see if SignedUrlExpiresAt property is set
        internal bool IsSetSignedUrlExpiresAt()
        {
            return this._signedUrlExpiresAt.HasValue; 
        }

    }
}