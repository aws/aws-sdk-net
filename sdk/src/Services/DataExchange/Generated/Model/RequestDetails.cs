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

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// The details for the request.
    /// </summary>
    public partial class RequestDetails
    {
        private CreateS3DataAccessFromS3BucketRequestDetails _createS3DataAccessFromS3Bucket;
        private ExportAssetsToS3RequestDetails _exportAssetsToS3;
        private ExportAssetToSignedUrlRequestDetails _exportAssetToSignedUrl;
        private ExportRevisionsToS3RequestDetails _exportRevisionsToS3;
        private ImportAssetFromApiGatewayApiRequestDetails _importAssetFromApiGatewayApi;
        private ImportAssetFromSignedUrlRequestDetails _importAssetFromSignedUrl;
        private ImportAssetsFromLakeFormationTagPolicyRequestDetails _importAssetsFromLakeFormationTagPolicy;
        private ImportAssetsFromRedshiftDataSharesRequestDetails _importAssetsFromRedshiftDataShares;
        private ImportAssetsFromS3RequestDetails _importAssetsFromS3;

        /// <summary>
        /// Gets and sets the property CreateS3DataAccessFromS3Bucket. 
        /// <para>
        /// Details of the request to create S3 data access from the Amazon S3 bucket.
        /// </para>
        /// </summary>
        public CreateS3DataAccessFromS3BucketRequestDetails CreateS3DataAccessFromS3Bucket
        {
            get { return this._createS3DataAccessFromS3Bucket; }
            set { this._createS3DataAccessFromS3Bucket = value; }
        }

        // Check to see if CreateS3DataAccessFromS3Bucket property is set
        internal bool IsSetCreateS3DataAccessFromS3Bucket()
        {
            return this._createS3DataAccessFromS3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property ExportAssetsToS3. 
        /// <para>
        /// Details about the export to Amazon S3 request.
        /// </para>
        /// </summary>
        public ExportAssetsToS3RequestDetails ExportAssetsToS3
        {
            get { return this._exportAssetsToS3; }
            set { this._exportAssetsToS3 = value; }
        }

        // Check to see if ExportAssetsToS3 property is set
        internal bool IsSetExportAssetsToS3()
        {
            return this._exportAssetsToS3 != null;
        }

        /// <summary>
        /// Gets and sets the property ExportAssetToSignedUrl. 
        /// <para>
        /// Details about the export to signed URL request.
        /// </para>
        /// </summary>
        public ExportAssetToSignedUrlRequestDetails ExportAssetToSignedUrl
        {
            get { return this._exportAssetToSignedUrl; }
            set { this._exportAssetToSignedUrl = value; }
        }

        // Check to see if ExportAssetToSignedUrl property is set
        internal bool IsSetExportAssetToSignedUrl()
        {
            return this._exportAssetToSignedUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ExportRevisionsToS3. 
        /// <para>
        /// Details about the export to Amazon S3 request.
        /// </para>
        /// </summary>
        public ExportRevisionsToS3RequestDetails ExportRevisionsToS3
        {
            get { return this._exportRevisionsToS3; }
            set { this._exportRevisionsToS3 = value; }
        }

        // Check to see if ExportRevisionsToS3 property is set
        internal bool IsSetExportRevisionsToS3()
        {
            return this._exportRevisionsToS3 != null;
        }

        /// <summary>
        /// Gets and sets the property ImportAssetFromApiGatewayApi. 
        /// <para>
        /// Details about the import from signed URL request.
        /// </para>
        /// </summary>
        public ImportAssetFromApiGatewayApiRequestDetails ImportAssetFromApiGatewayApi
        {
            get { return this._importAssetFromApiGatewayApi; }
            set { this._importAssetFromApiGatewayApi = value; }
        }

        // Check to see if ImportAssetFromApiGatewayApi property is set
        internal bool IsSetImportAssetFromApiGatewayApi()
        {
            return this._importAssetFromApiGatewayApi != null;
        }

        /// <summary>
        /// Gets and sets the property ImportAssetFromSignedUrl. 
        /// <para>
        /// Details about the import from Amazon S3 request.
        /// </para>
        /// </summary>
        public ImportAssetFromSignedUrlRequestDetails ImportAssetFromSignedUrl
        {
            get { return this._importAssetFromSignedUrl; }
            set { this._importAssetFromSignedUrl = value; }
        }

        // Check to see if ImportAssetFromSignedUrl property is set
        internal bool IsSetImportAssetFromSignedUrl()
        {
            return this._importAssetFromSignedUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ImportAssetsFromLakeFormationTagPolicy. 
        /// <para>
        /// Request details for the ImportAssetsFromLakeFormationTagPolicy job.
        /// </para>
        /// </summary>
        public ImportAssetsFromLakeFormationTagPolicyRequestDetails ImportAssetsFromLakeFormationTagPolicy
        {
            get { return this._importAssetsFromLakeFormationTagPolicy; }
            set { this._importAssetsFromLakeFormationTagPolicy = value; }
        }

        // Check to see if ImportAssetsFromLakeFormationTagPolicy property is set
        internal bool IsSetImportAssetsFromLakeFormationTagPolicy()
        {
            return this._importAssetsFromLakeFormationTagPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ImportAssetsFromRedshiftDataShares. 
        /// <para>
        /// Details from an import from Amazon Redshift datashare request.
        /// </para>
        /// </summary>
        public ImportAssetsFromRedshiftDataSharesRequestDetails ImportAssetsFromRedshiftDataShares
        {
            get { return this._importAssetsFromRedshiftDataShares; }
            set { this._importAssetsFromRedshiftDataShares = value; }
        }

        // Check to see if ImportAssetsFromRedshiftDataShares property is set
        internal bool IsSetImportAssetsFromRedshiftDataShares()
        {
            return this._importAssetsFromRedshiftDataShares != null;
        }

        /// <summary>
        /// Gets and sets the property ImportAssetsFromS3. 
        /// <para>
        /// Details about the import asset from API Gateway API request.
        /// </para>
        /// </summary>
        public ImportAssetsFromS3RequestDetails ImportAssetsFromS3
        {
            get { return this._importAssetsFromS3; }
            set { this._importAssetsFromS3 = value; }
        }

        // Check to see if ImportAssetsFromS3 property is set
        internal bool IsSetImportAssetsFromS3()
        {
            return this._importAssetsFromS3 != null;
        }

    }
}