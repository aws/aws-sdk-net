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
    /// Information about the job error.
    /// </summary>
    public partial class Details
    {
        private ImportAssetFromSignedUrlJobErrorDetails _importAssetFromSignedUrlJobErrorDetails;
        private List<AssetSourceEntry> _importAssetsFromS3JobErrorDetails = new List<AssetSourceEntry>();

        /// <summary>
        /// Gets and sets the property ImportAssetFromSignedUrlJobErrorDetails. 
        /// <para>
        /// Information about the job error.
        /// </para>
        /// </summary>
        public ImportAssetFromSignedUrlJobErrorDetails ImportAssetFromSignedUrlJobErrorDetails
        {
            get { return this._importAssetFromSignedUrlJobErrorDetails; }
            set { this._importAssetFromSignedUrlJobErrorDetails = value; }
        }

        // Check to see if ImportAssetFromSignedUrlJobErrorDetails property is set
        internal bool IsSetImportAssetFromSignedUrlJobErrorDetails()
        {
            return this._importAssetFromSignedUrlJobErrorDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ImportAssetsFromS3JobErrorDetails. 
        /// <para>
        /// Details about the job error.
        /// </para>
        /// </summary>
        public List<AssetSourceEntry> ImportAssetsFromS3JobErrorDetails
        {
            get { return this._importAssetsFromS3JobErrorDetails; }
            set { this._importAssetsFromS3JobErrorDetails = value; }
        }

        // Check to see if ImportAssetsFromS3JobErrorDetails property is set
        internal bool IsSetImportAssetsFromS3JobErrorDetails()
        {
            return this._importAssetsFromS3JobErrorDetails != null && this._importAssetsFromS3JobErrorDetails.Count > 0; 
        }

    }
}