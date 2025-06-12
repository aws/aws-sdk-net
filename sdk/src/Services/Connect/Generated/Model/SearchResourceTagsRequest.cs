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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the SearchResourceTags operation.
    /// Searches tags used in an Amazon Connect instance using optional search criteria.
    /// </summary>
    public partial class SearchResourceTagsRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _resourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ResourceTagsSearchCriteria _searchCriteria;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can find the instanceId in the
        /// Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=250)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
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
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2500)]
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
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The list of resource types to be used to search tags from. If not provided or if any
        /// empty list is provided, this API will search from all supported resource types. Note
        /// that lowercase and - are required.
        /// </para>
        ///  
        /// <para>
        ///  <b>Supported resource types</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// agent
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// agent-state
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// routing-profile
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// standard-queue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// security-profile
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// operating-hours
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// prompt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// contact-flow
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// flow- module
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// transfer-destination (also known as quick connect)
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SearchCriteria. 
        /// <para>
        /// The search criteria to be used to return tags.
        /// </para>
        /// </summary>
        public ResourceTagsSearchCriteria SearchCriteria
        {
            get { return this._searchCriteria; }
            set { this._searchCriteria = value; }
        }

        // Check to see if SearchCriteria property is set
        internal bool IsSetSearchCriteria()
        {
            return this._searchCriteria != null;
        }

    }
}