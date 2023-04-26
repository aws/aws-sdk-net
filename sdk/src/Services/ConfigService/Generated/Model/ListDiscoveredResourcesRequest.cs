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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the ListDiscoveredResources operation.
    /// Accepts a resource type and returns a list of resource identifiers for the resources
    /// of that type. A resource identifier includes the resource type, ID, and (if available)
    /// the custom resource name. The results consist of resources that Config has discovered,
    /// including those that Config is not currently recording. You can narrow the results
    /// to include only resources that have specific resource IDs or a resource name.
    /// 
    ///  <note> 
    /// <para>
    /// You can specify either resource IDs or a resource name, but not both, in the same
    /// request.
    /// </para>
    ///  </note> 
    /// <para>
    /// The response is paginated. By default, Config lists 100 resource identifiers on each
    /// page. You can customize this number with the <code>limit</code> parameter. The response
    /// includes a <code>nextToken</code> string. To get the next page of results, run the
    /// request again and specify the string for the <code>nextToken</code> parameter.
    /// </para>
    /// </summary>
    public partial class ListDiscoveredResourcesRequest : AmazonConfigServiceRequest
    {
        private bool? _includeDeletedResources;
        private int? _limit;
        private string _nextToken;
        private List<string> _resourceIds = new List<string>();
        private string _resourceName;
        private ResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property IncludeDeletedResources. 
        /// <para>
        /// Specifies whether Config includes deleted resources in the results. By default, deleted
        /// resources are not included.
        /// </para>
        /// </summary>
        public bool IncludeDeletedResources
        {
            get { return this._includeDeletedResources.GetValueOrDefault(); }
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
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
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
        /// The <code>nextToken</code> string returned on a previous page that you use to get
        /// the next page of results in a paginated response.
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
        /// </summary>
        public List<string> ResourceIds
        {
            get { return this._resourceIds; }
            set { this._resourceIds = value; }
        }

        // Check to see if ResourceIds property is set
        internal bool IsSetResourceIds()
        {
            return this._resourceIds != null && this._resourceIds.Count > 0; 
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