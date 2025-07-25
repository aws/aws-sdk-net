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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the ListDiscoveredResources operation.
    /// Returns a list of resource resource identifiers for the specified resource types for
    /// the resources of that type. A <i>resource identifier</i> includes the resource type,
    /// ID, and (if available) the custom resource name.
    /// 
    ///  
    /// <para>
    /// The results consist of resources that Config has <i>discovered</i>, including those
    /// that Config is not currently recording. You can narrow the results to include only
    /// resources that have specific resource IDs or a resource name.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can specify either resource IDs or a resource name, but not both, in the same
    /// request.
    /// </para>
    ///  </note> <important> 
    /// <para>
    ///  <i>CloudFormation stack recording behavior in Config</i> 
    /// </para>
    ///  
    /// <para>
    /// When a CloudFormation stack fails to create (for example, it enters the <c>ROLLBACK_FAILED</c>
    /// state), Config does not record a configuration item (CI) for that stack. Configuration
    /// items are only recorded for stacks that reach the following states:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>CREATE_COMPLETE</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UPDATE_COMPLETE</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UPDATE_ROLLBACK_COMPLETE</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UPDATE_ROLLBACK_FAILED</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DELETE_FAILED</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DELETE_COMPLETE</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Because no CI is created for a failed stack creation, you won't see configuration
    /// history for that stack in Config, even after the stack is deleted. This helps make
    /// sure that Config only tracks resources that were successfully provisioned.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ListDiscoveredResourcesRequest : AmazonConfigServiceRequest
    {
        private bool? _includeDeletedResources;
        private int? _limit;
        private string _nextToken;
        private List<string> _resourceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _resourceName;
        private ResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property IncludeDeletedResources. 
        /// <para>
        /// Specifies whether Config includes deleted resources in the results. By default, deleted
        /// resources are not included.
        /// </para>
        /// </summary>
        public bool? IncludeDeletedResources
        {
            get { return this._includeDeletedResources; }
            set { this._includeDeletedResources = value; }
        }

        // Check to see if IncludeDeletedResources property is set
        internal bool IsSetIncludeDeletedResources()
        {
            return this._includeDeletedResources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of resource identifiers returned on each page. The default is 100.
        /// You cannot specify a number greater than 100. If you specify 0, Config uses the default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> string returned on a previous page that you use to get the next
        /// page of results in a paginated response.
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

        /// <summary>
        /// Gets and sets the property ResourceIds. 
        /// <para>
        /// The IDs of only those resources that you want Config to list in the response. If you
        /// do not specify this parameter, Config lists all resources of the specified type that
        /// it has discovered. You can list a minimum of 1 resourceID and a maximum of 20 resourceIds.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceIds
        {
            get { return this._resourceIds; }
            set { this._resourceIds = value; }
        }

        // Check to see if ResourceIds property is set
        internal bool IsSetResourceIds()
        {
            return this._resourceIds != null && (this._resourceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The custom name of only those resources that you want Config to list in the response.
        /// If you do not specify this parameter, Config lists all resources of the specified
        /// type that it has discovered.
        /// </para>
        /// </summary>
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resources that you want Config to list in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}