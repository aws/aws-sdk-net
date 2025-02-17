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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// The following elements are returned by the service.
    /// </summary>
    public partial class ListMultiRegionEndpointsResponse : AmazonWebServiceResponse
    {
        private List<MultiRegionEndpoint> _multiRegionEndpoints = AWSConfigs.InitializeCollections ? new List<MultiRegionEndpoint>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MultiRegionEndpoints. 
        /// <para>
        /// An array that contains key multi-region endpoint (global-endpoint) properties.
        /// </para>
        /// </summary>
        public List<MultiRegionEndpoint> MultiRegionEndpoints
        {
            get { return this._multiRegionEndpoints; }
            set { this._multiRegionEndpoints = value; }
        }

        // Check to see if MultiRegionEndpoints property is set
        internal bool IsSetMultiRegionEndpoints()
        {
            return this._multiRegionEndpoints != null && (this._multiRegionEndpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token indicating that there are additional multi-region endpoints (global-endpoints)
        /// available to be listed. Pass this token to a subsequent <c>ListMultiRegionEndpoints</c>
        /// call to retrieve the next page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
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