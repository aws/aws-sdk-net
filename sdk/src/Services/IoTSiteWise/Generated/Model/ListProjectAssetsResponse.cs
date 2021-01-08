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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the ListProjectAssets operation.
    /// </summary>
    public partial class ListProjectAssetsResponse : AmazonWebServiceResponse
    {
        private List<string> _assetIds = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AssetIds. 
        /// <para>
        /// A list that contains the IDs of each asset associated with the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AssetIds
        {
            get { return this._assetIds; }
            set { this._assetIds = value; }
        }

        // Check to see if AssetIds property is set
        internal bool IsSetAssetIds()
        {
            return this._assetIds != null && this._assetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or null if there are no additional results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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