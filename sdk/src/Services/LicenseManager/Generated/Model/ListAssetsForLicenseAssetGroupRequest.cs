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
    /// Container for the parameters to the ListAssetsForLicenseAssetGroup operation.
    /// Lists assets for a license asset group.
    /// </summary>
    public partial class ListAssetsForLicenseAssetGroupRequest : AmazonLicenseManagerRequest
    {
        private string _assetType;
        private string _licenseAssetGroupArn;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AssetType. 
        /// <para>
        /// Asset type. The possible values are <c>Instance</c> | <c>License</c> | <c>LicenseConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssetType
        {
            get { return this._assetType; }
            set { this._assetType = value; }
        }

        // Check to see if AssetType property is set
        internal bool IsSetAssetType()
        {
            return this._assetType != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseAssetGroupArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license asset group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LicenseAssetGroupArn
        {
            get { return this._licenseAssetGroupArn; }
            set { this._licenseAssetGroupArn = value; }
        }

        // Check to see if LicenseAssetGroupArn property is set
        internal bool IsSetLicenseAssetGroupArn()
        {
            return this._licenseAssetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token for the next set of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}