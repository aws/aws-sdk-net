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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the CreateNetwork operation.
    /// Create as many Networks as you need. You will associate one or more Clusters with
    /// each Network.Each Network provides MediaLive Anywhere with required information about
    /// the network in your organization that you are using for video encoding using MediaLive.
    /// </summary>
    public partial class CreateNetworkRequest : AmazonMediaLiveRequest
    {
        private List<IpPoolCreateRequest> _ipPools = AWSConfigs.InitializeCollections ? new List<IpPoolCreateRequest>() : null;
        private string _name;
        private string _requestId;
        private List<RouteCreateRequest> _routes = AWSConfigs.InitializeCollections ? new List<RouteCreateRequest>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property IpPools. An array of IpPoolCreateRequests that identify
        /// a collection of IP addresses in your network that you want to reserve for use in MediaLive
        /// Anywhere. MediaLiveAnywhere uses these IP addresses for Push inputs (in both Bridge
        /// and NATnetworks) and for output destinations (only in Bridge networks). EachIpPoolUpdateRequest
        /// specifies one CIDR block.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpPoolCreateRequest> IpPools
        {
            get { return this._ipPools; }
            set { this._ipPools = value; }
        }

        // Check to see if IpPools property is set
        internal bool IsSetIpPools()
        {
            return this._ipPools != null && (this._ipPools.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. Specify a name that is unique in the AWS account.
        /// We recommend that you assign a name that hints at the type of traffic on the network.
        /// Names are case-sensitive.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. An ID that you assign to a create request. This
        /// ID ensures idempotency when creating resources.
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Routes. An array of routes that MediaLive Anywhere needs
        /// to know about in order to route encoding traffic.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteCreateRequest> Routes
        {
            get { return this._routes; }
            set { this._routes = value; }
        }

        // Check to see if Routes property is set
        internal bool IsSetRoutes()
        {
            return this._routes != null && (this._routes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. A collection of key-value pairs.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}