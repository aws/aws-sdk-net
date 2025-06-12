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
    /// Placeholder documentation for UpdateClusterResponse
    /// </summary>
    public partial class UpdateClusterResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private List<string> _channelIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ClusterType _clusterType;
        private string _id;
        private string _name;
        private ClusterNetworkSettings _networkSettings;
        private ClusterState _state;

        /// <summary>
        /// Gets and sets the property Arn. The ARN of the Cluster.
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
        /// Gets and sets the property ChannelIds. An array of the IDs of the Channels that are
        /// associated with this Cluster. One Channel is associated with the Cluster as follows:
        /// A Channel belongs to a ChannelPlacementGroup. A ChannelPlacementGroup is attached
        /// to a Node. A Node belongs to a Cluster.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ChannelIds
        {
            get { return this._channelIds; }
            set { this._channelIds = value; }
        }

        // Check to see if ChannelIds property is set
        internal bool IsSetChannelIds()
        {
            return this._channelIds != null && (this._channelIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClusterType. The hardware type for the Cluster
        /// </summary>
        public ClusterType ClusterType
        {
            get { return this._clusterType; }
            set { this._clusterType = value; }
        }

        // Check to see if ClusterType property is set
        internal bool IsSetClusterType()
        {
            return this._clusterType != null;
        }

        /// <summary>
        /// Gets and sets the property Id. The unique ID of the Cluster.
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
        /// Gets and sets the property Name. The user-specified name of the Cluster.
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
        /// Gets and sets the property NetworkSettings. Network settings that connect the Nodes
        /// in the Cluster to one or more of the Networks that the Cluster is associated with.
        /// </summary>
        public ClusterNetworkSettings NetworkSettings
        {
            get { return this._networkSettings; }
            set { this._networkSettings = value; }
        }

        // Check to see if NetworkSettings property is set
        internal bool IsSetNetworkSettings()
        {
            return this._networkSettings != null;
        }

        /// <summary>
        /// Gets and sets the property State. The current state of the Cluster.
        /// </summary>
        public ClusterState State
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