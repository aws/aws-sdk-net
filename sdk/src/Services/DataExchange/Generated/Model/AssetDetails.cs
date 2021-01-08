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
    /// 
    /// </summary>
    public partial class AssetDetails
    {
        private S3SnapshotAsset _s3SnapshotAsset;

        /// <summary>
        /// Gets and sets the property S3SnapshotAsset.
        /// </summary>
        public S3SnapshotAsset S3SnapshotAsset
        {
            get { return this._s3SnapshotAsset; }
            set { this._s3SnapshotAsset = value; }
        }

        // Check to see if S3SnapshotAsset property is set
        internal bool IsSetS3SnapshotAsset()
        {
            return this._s3SnapshotAsset != null;
        }

    }
}