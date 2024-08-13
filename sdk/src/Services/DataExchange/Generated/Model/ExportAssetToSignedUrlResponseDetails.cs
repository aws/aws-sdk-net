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
    /// The details of the export to signed URL response.
    /// </summary>
    public partial class ExportAssetToSignedUrlResponseDetails
    {
        private string _assetId;
        private string _dataSetId;
        private string _revisionId;
        private string _signedUrl;
        private DateTime? _signedUrlExpiresAt;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The unique identifier for the asset associated with this export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The unique identifier for the data set associated with this export job.
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
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The unique identifier for the revision associated with this export response.
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
        /// The signed URL for the export request.
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
        /// The date and time that the signed URL expires, in ISO 8601 format.
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