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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the GetIpamResourceCidrs operation.
    /// Returns resource CIDRs managed by IPAM in a given scope. If an IPAM is associated
    /// with more than one resource discovery, the resource CIDRs across all of the resource
    /// discoveries is returned. A resource discovery is an IPAM component that enables IPAM
    /// to manage and monitor resources that belong to the owning account.
    /// </summary>
    public partial class GetIpamResourceCidrsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private string _ipamPoolId;
        private string _ipamScopeId;
        private int? _maxResults;
        private string _nextToken;
        private string _resourceId;
        private string _resourceOwner;
        private RequestIpamResourceTag _resourceTag;
        private IpamResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters for the request. For more information about filtering, see <a
        /// href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-filter.html">Filtering
        /// CLI output</a>.
        /// </para>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of the IPAM pool that the resource is in.
        /// </para>
        /// </summary>
        public string IpamPoolId
        {
            get { return this._ipamPoolId; }
            set { this._ipamPoolId = value; }
        }

        // Check to see if IpamPoolId property is set
        internal bool IsSetIpamPoolId()
        {
            return this._ipamPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property IpamScopeId. 
        /// <para>
        /// The ID of the scope that the resource is in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamScopeId
        {
            get { return this._ipamScopeId; }
            set { this._ipamScopeId = value; }
        }

        // Check to see if IpamScopeId property is set
        internal bool IsSetIpamScopeId()
        {
            return this._ipamScopeId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The token for the next page of results.
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceOwner. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the resource.
        /// </para>
        /// </summary>
        public string ResourceOwner
        {
            get { return this._resourceOwner; }
            set { this._resourceOwner = value; }
        }

        // Check to see if ResourceOwner property is set
        internal bool IsSetResourceOwner()
        {
            return this._resourceOwner != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTag. 
        /// <para>
        /// The resource tag.
        /// </para>
        /// </summary>
        public RequestIpamResourceTag ResourceTag
        {
            get { return this._resourceTag; }
            set { this._resourceTag = value; }
        }

        // Check to see if ResourceTag property is set
        internal bool IsSetResourceTag()
        {
            return this._resourceTag != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type.
        /// </para>
        /// </summary>
        public IpamResourceType ResourceType
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