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
    /// Placeholder documentation for CreateNetworkResponse
    /// </summary>
    public partial class CreateNetworkResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private List<string> _associatedClusterIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _id;
        private List<IpPool> _ipPools = AWSConfigs.InitializeCollections ? new List<IpPool>() : null;
        private string _name;
        private List<Route> _routes = AWSConfigs.InitializeCollections ? new List<Route>() : null;
        private NetworkState _state;

        /// <summary>
        /// Gets and sets the property Arn. The ARN of this Network. It is automatically assigned
        /// when the Network is created.
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedClusterIds.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedClusterIds
        {
            get { return this._associatedClusterIds; }
            set { this._associatedClusterIds = value; }
        }

        // Check to see if AssociatedClusterIds property is set
        internal bool IsSetAssociatedClusterIds()
        {
            return this._associatedClusterIds != null && (this._associatedClusterIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. The ID of the Network. Unique in the AWS account. The
        /// ID is the resource-id portion of the ARN.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IpPools. An array of IpPools in your organization's network
        /// that identify a collection of IP addresses in this network that are reserved for use
        /// in MediaLive Anywhere. MediaLive Anywhere uses these IP addresses for Push inputs
        /// (in both Bridge and NAT networks) and for output destinations (only in Bridge networks).
        /// Each IpPool specifies one CIDR block.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpPool> IpPools
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
        /// Gets and sets the property Name. The name that you specified for the Network.
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
        /// Gets and sets the property Routes. An array of routes that MediaLive Anywhere needs
        /// to know about in order to route encoding traffic.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Route> Routes
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
        /// Gets and sets the property State. The current state of the Network. Only MediaLive
        /// Anywhere can change the state.
        /// </summary>
        public NetworkState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}