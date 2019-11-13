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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// The details for the request.
    /// </summary>
    public partial class RequestDetails
    {
        private ExportAssetsToS3RequestDetails _exportAssetsToS3;
        private ExportAssetToSignedUrlRequestDetails _exportAssetToSignedUrl;
        private ImportAssetFromSignedUrlRequestDetails _importAssetFromSignedUrl;
        private ImportAssetsFromS3RequestDetails _importAssetsFromS3;

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
        /// Gets and sets the property ImportAssetFromSignedUrl. 
        /// <para>
        /// Details about the import from signed URL request.
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
        /// Gets and sets the property ImportAssetsFromS3. 
        /// <para>
        /// Details about the import from Amazon S3 request.
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