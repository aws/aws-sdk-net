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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// This is the response object from the CreateNode operation.
    /// </summary>
    public partial class CreateNodeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. The ARN of the Node. It is automatically assigned
        /// when the Node is created.
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ChannelPlacementGroups. An array of IDs. Each ID is one
        /// ChannelPlacementGroup that is associated with this Node. Empty if the Node is not
        /// yet associated with any groups.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ChannelPlacementGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ChannelPlacementGroups property is set.
        /// </summary>
        internal bool IsSetChannelPlacementGroups() => this.ChannelPlacementGroups != null && (this.ChannelPlacementGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClusterId. The ID of the Cluster that the Node belongs
        /// to.
        /// </summary>
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property ConnectionState. The current connection state of the Node.
        /// </summary>
        public NodeConnectionState ConnectionState { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionState property is set.
        /// </summary>
        internal bool IsSetConnectionState() => this.ConnectionState != null;

        /// <summary>
        /// Gets and sets the property Id. The unique ID of the Node. Unique in the Cluster. The
        /// ID is the resource-id portion of the ARN.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InstanceArn. The ARN of the EC2 instance hosting the Node.
        /// </summary>
        public string InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceArn property is set.
        /// </summary>
        internal bool IsSetInstanceArn() => this.InstanceArn != null;

        /// <summary>
        /// Gets and sets the property Name. The name that you specified for the Node.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NodeInterfaceMappings. Documentation update needed
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeInterfaceMapping> NodeInterfaceMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<NodeInterfaceMapping>() : null;

        /// <summary>
        /// Checks to see if the NodeInterfaceMappings property is set.
        /// </summary>
        internal bool IsSetNodeInterfaceMappings() => this.NodeInterfaceMappings != null && (this.NodeInterfaceMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Role. The initial role current role of the Node in the
        /// Cluster. ACTIVE means the Node is available for encoding. BACKUP means the Node is
        /// a redundant Node and might get used if an ACTIVE Node fails.
        /// </summary>
        public NodeRole Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property SdiSourceMappings. An array of SDI source mappings. Each
        /// mapping connects one logical SdiSource to the physical SDI card and port that the
        /// physical SDI source uses.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SdiSourceMapping> SdiSourceMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<SdiSourceMapping>() : null;

        /// <summary>
        /// Checks to see if the SdiSourceMappings property is set.
        /// </summary>
        internal bool IsSetSdiSourceMappings() => this.SdiSourceMappings != null && (this.SdiSourceMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property State. The current state of the Node.
        /// </summary>
        public NodeState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
