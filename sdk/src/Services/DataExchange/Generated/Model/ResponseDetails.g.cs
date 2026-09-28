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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Details for the response.
    /// </summary>
    public partial class ResponseDetails
    {
        /// <summary>
        /// Gets and sets the property CreateS3DataAccessFromS3Bucket. 
        /// <para>
        /// Response details from the CreateS3DataAccessFromS3Bucket job.
        /// </para>
        /// </summary>
        public CreateS3DataAccessFromS3BucketResponseDetails CreateS3DataAccessFromS3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the CreateS3DataAccessFromS3Bucket property is set.
        /// </summary>
        internal bool IsSetCreateS3DataAccessFromS3Bucket() => this.CreateS3DataAccessFromS3Bucket != null;

        /// <summary>
        /// Gets and sets the property ExportAssetToSignedUrl. 
        /// <para>
        /// Details for the export to signed URL response.
        /// </para>
        /// </summary>
        public ExportAssetToSignedUrlResponseDetails ExportAssetToSignedUrl { get; set; }

        /// <summary>
        /// Checks to see if the ExportAssetToSignedUrl property is set.
        /// </summary>
        internal bool IsSetExportAssetToSignedUrl() => this.ExportAssetToSignedUrl != null;

        /// <summary>
        /// Gets and sets the property ExportAssetsToS3. 
        /// <para>
        /// Details for the export to Amazon S3 response.
        /// </para>
        /// </summary>
        public ExportAssetsToS3ResponseDetails ExportAssetsToS3 { get; set; }

        /// <summary>
        /// Checks to see if the ExportAssetsToS3 property is set.
        /// </summary>
        internal bool IsSetExportAssetsToS3() => this.ExportAssetsToS3 != null;

        /// <summary>
        /// Gets and sets the property ExportRevisionsToS3. 
        /// <para>
        /// Details for the export revisions to Amazon S3 response.
        /// </para>
        /// </summary>
        public ExportRevisionsToS3ResponseDetails ExportRevisionsToS3 { get; set; }

        /// <summary>
        /// Checks to see if the ExportRevisionsToS3 property is set.
        /// </summary>
        internal bool IsSetExportRevisionsToS3() => this.ExportRevisionsToS3 != null;

        /// <summary>
        /// Gets and sets the property ImportAssetFromApiGatewayApi. 
        /// <para>
        /// The response details.
        /// </para>
        /// </summary>
        public ImportAssetFromApiGatewayApiResponseDetails ImportAssetFromApiGatewayApi { get; set; }

        /// <summary>
        /// Checks to see if the ImportAssetFromApiGatewayApi property is set.
        /// </summary>
        internal bool IsSetImportAssetFromApiGatewayApi() => this.ImportAssetFromApiGatewayApi != null;

        /// <summary>
        /// Gets and sets the property ImportAssetFromSignedUrl. 
        /// <para>
        /// Details for the import from signed URL response.
        /// </para>
        /// </summary>
        public ImportAssetFromSignedUrlResponseDetails ImportAssetFromSignedUrl { get; set; }

        /// <summary>
        /// Checks to see if the ImportAssetFromSignedUrl property is set.
        /// </summary>
        internal bool IsSetImportAssetFromSignedUrl() => this.ImportAssetFromSignedUrl != null;

        /// <summary>
        /// Gets and sets the property ImportAssetsFromLakeFormationTagPolicy. 
        /// <para>
        /// Response details from the ImportAssetsFromLakeFormationTagPolicy job.
        /// </para>
        /// </summary>
        public ImportAssetsFromLakeFormationTagPolicyResponseDetails ImportAssetsFromLakeFormationTagPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ImportAssetsFromLakeFormationTagPolicy property is set.
        /// </summary>
        internal bool IsSetImportAssetsFromLakeFormationTagPolicy() => this.ImportAssetsFromLakeFormationTagPolicy != null;

        /// <summary>
        /// Gets and sets the property ImportAssetsFromRedshiftDataShares. 
        /// <para>
        /// Details from an import from Amazon Redshift datashare response.
        /// </para>
        /// </summary>
        public ImportAssetsFromRedshiftDataSharesResponseDetails ImportAssetsFromRedshiftDataShares { get; set; }

        /// <summary>
        /// Checks to see if the ImportAssetsFromRedshiftDataShares property is set.
        /// </summary>
        internal bool IsSetImportAssetsFromRedshiftDataShares() => this.ImportAssetsFromRedshiftDataShares != null;

        /// <summary>
        /// Gets and sets the property ImportAssetsFromS3. 
        /// <para>
        /// Details for the import from Amazon S3 response.
        /// </para>
        /// </summary>
        public ImportAssetsFromS3ResponseDetails ImportAssetsFromS3 { get; set; }

        /// <summary>
        /// Checks to see if the ImportAssetsFromS3 property is set.
        /// </summary>
        internal bool IsSetImportAssetsFromS3() => this.ImportAssetsFromS3 != null;
    }
}
