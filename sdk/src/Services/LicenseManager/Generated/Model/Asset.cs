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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Asset.
    /// </summary>
    public partial class Asset
    {
        private string _assetArn;
        private DateTime? _latestAssetDiscoveryTime;

        /// <summary>
        /// Gets and sets the property AssetArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the asset.
        /// </para>
        /// </summary>
        public string AssetArn
        {
            get { return this._assetArn; }
            set { this._assetArn = value; }
        }

        // Check to see if AssetArn property is set
        internal bool IsSetAssetArn()
        {
            return this._assetArn != null;
        }

        /// <summary>
        /// Gets and sets the property LatestAssetDiscoveryTime. 
        /// <para>
        /// Latest asset discovery time.
        /// </para>
        /// </summary>
        public DateTime LatestAssetDiscoveryTime
        {
            get { return this._latestAssetDiscoveryTime.GetValueOrDefault(); }
            set { this._latestAssetDiscoveryTime = value; }
        }

        // Check to see if LatestAssetDiscoveryTime property is set
        internal bool IsSetLatestAssetDiscoveryTime()
        {
            return this._latestAssetDiscoveryTime.HasValue; 
        }

    }
}