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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ListResourceScanRelatedResources operation.
    /// Lists the related resources for a list of resources from a resource scan. The response
    /// indicates whether each returned resource is already managed by CloudFormation.
    /// </summary>
    public partial class ListResourceScanRelatedResourcesRequest : AmazonCloudFormationRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<ScannedResourceIdentifier> _resources = AWSConfigs.InitializeCollections ? new List<ScannedResourceIdentifier>() : null;
        private string _resourceScanId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  If the number of available results exceeds this maximum, the response includes a
        /// <c>NextToken</c> value that you can use for the <c>NextToken</c> parameter to get
        /// the next set of results. By default the <c>ListResourceScanRelatedResources</c> API
        /// action will return up to 100 results in each response. The maximum value is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// A string that identifies the next page of resource scan results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The list of resources for which you want to get the related resources. Up to 100 resources
        /// can be provided.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ScannedResourceIdentifier> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceScanId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource scan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceScanId
        {
            get { return this._resourceScanId; }
            set { this._resourceScanId = value; }
        }

        // Check to see if ResourceScanId property is set
        internal bool IsSetResourceScanId()
        {
            return this._resourceScanId != null;
        }

    }
}