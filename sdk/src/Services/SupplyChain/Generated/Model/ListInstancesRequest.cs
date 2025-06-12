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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// Container for the parameters to the ListInstances operation.
    /// List all Amazon Web Services Supply Chain instances for a specific account. Enables
    /// you to programmatically list all Amazon Web Services Supply Chain instances based
    /// on their account ID, instance name, and state of the instance (active or delete).
    /// </summary>
    public partial class ListInstancesRequest : AmazonSupplyChainRequest
    {
        private List<string> _instanceNameFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _instanceStateFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property InstanceNameFilter. 
        /// <para>
        /// The filter to ListInstances based on their names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> InstanceNameFilter
        {
            get { return this._instanceNameFilter; }
            set { this._instanceNameFilter = value; }
        }

        // Check to see if InstanceNameFilter property is set
        internal bool IsSetInstanceNameFilter()
        {
            return this._instanceNameFilter != null && (this._instanceNameFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceStateFilter. 
        /// <para>
        /// The filter to ListInstances based on their state.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=6)]
        public List<string> InstanceStateFilter
        {
            get { return this._instanceStateFilter; }
            set { this._instanceStateFilter = value; }
        }

        // Check to see if InstanceStateFilter property is set
        internal bool IsSetInstanceStateFilter()
        {
            return this._instanceStateFilter != null && (this._instanceStateFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specify the maximum number of instances to fetch in this paginated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
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
        /// The pagination token to fetch the next page of instances.
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

    }
}