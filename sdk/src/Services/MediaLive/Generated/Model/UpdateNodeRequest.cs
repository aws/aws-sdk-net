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
    /// Container for the parameters to the UpdateNode operation.
    /// Change the settings for a Node.
    /// </summary>
    public partial class UpdateNodeRequest : AmazonMediaLiveRequest
    {
        private string _clusterId;
        private string _name;
        private string _nodeId;
        private NodeRole _role;
        private List<SdiSourceMappingUpdateRequest> _sdiSourceMappings = AWSConfigs.InitializeCollections ? new List<SdiSourceMappingUpdateRequest>() : null;

        /// <summary>
        /// Gets and sets the property ClusterId. The ID of the cluster
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. Include this parameter only if you want to change
        /// the current name of the Node. Specify a name that is unique in the Cluster. You can't
        /// change the name. Names are case-sensitive.
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
        /// Gets and sets the property NodeId. The ID of the node.
        /// </summary>
        [AWSProperty(Required=true)]
        public string NodeId
        {
            get { return this._nodeId; }
            set { this._nodeId = value; }
        }

        // Check to see if NodeId property is set
        internal bool IsSetNodeId()
        {
            return this._nodeId != null;
        }

        /// <summary>
        /// Gets and sets the property Role. The initial role of the Node in the Cluster. ACTIVE
        /// means the Node is available for encoding. BACKUP means the Node is a redundant Node
        /// and might get used if an ACTIVE Node fails.
        /// </summary>
        public NodeRole Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property SdiSourceMappings. The mappings of a SDI capture card port
        /// to a logical SDI data stream
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SdiSourceMappingUpdateRequest> SdiSourceMappings
        {
            get { return this._sdiSourceMappings; }
            set { this._sdiSourceMappings = value; }
        }

        // Check to see if SdiSourceMappings property is set
        internal bool IsSetSdiSourceMappings()
        {
            return this._sdiSourceMappings != null && (this._sdiSourceMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}