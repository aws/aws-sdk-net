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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the SearchResourceTags operation. Searches tags used
    /// in an Connect Customer instance using optional search criteria.
    /// </summary>
    public partial class SearchResourceTagsRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can find the instanceId in the
        /// Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 250)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2500)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

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
        ///  </li> <li> 
        /// <para>
        /// metric
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypes property is set.
        /// </summary>
        internal bool IsSetResourceTypes() => this.ResourceTypes != null && (this.ResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SearchCriteria. 
        /// <para>
        /// The search criteria to be used to return tags.
        /// </para>
        /// </summary>
        public ResourceTagsSearchCriteria SearchCriteria { get; set; }

        /// <summary>
        /// Checks to see if the SearchCriteria property is set.
        /// </summary>
        internal bool IsSetSearchCriteria() => this.SearchCriteria != null;
    }
}
