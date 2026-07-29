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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the CreateContainerAssociation operation.
    /// Creates a container association for Network Firewall. A container association links
    /// container clusters (ECS or EKS) to Network Firewall, enabling dynamic IP resolution
    /// for firewall rules based on container attributes.
    /// 
    ///  
    /// <para>
    /// To manage a container association's tags, use the standard Amazon Web Services resource
    /// tagging operations, <a>ListTagsForResource</a>, <a>TagResource</a>, and <a>UntagResource</a>.
    /// </para>
    ///  
    /// <para>
    /// To retrieve information about container associations, use <a>ListContainerAssociations</a>
    /// and <a>DescribeContainerAssociation</a>.
    /// </para>
    /// </summary>
    public partial class CreateContainerAssociationRequest : AmazonNetworkFirewallRequest
    {
        private string _containerAssociationName;
        private List<ContainerMonitoringConfiguration> _containerMonitoringConfigurations = AWSConfigs.InitializeCollections ? new List<ContainerMonitoringConfiguration>() : null;
        private string _description;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private ContainerMonitoringType _type;

        /// <summary>
        /// Gets and sets the property ContainerAssociationName. 
        /// <para>
        /// The descriptive name of the container association. You can't change the name of a
        /// container association after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ContainerAssociationName
        {
            get { return this._containerAssociationName; }
            set { this._containerAssociationName = value; }
        }

        // Check to see if ContainerAssociationName property is set
        internal bool IsSetContainerAssociationName()
        {
            return this._containerAssociationName != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerMonitoringConfigurations. 
        /// <para>
        /// The list of container monitoring configurations that define which clusters and container
        /// attributes to monitor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ContainerMonitoringConfiguration> ContainerMonitoringConfigurations
        {
            get { return this._containerMonitoringConfigurations; }
            set { this._containerMonitoringConfigurations = value; }
        }

        // Check to see if ContainerMonitoringConfigurations property is set
        internal bool IsSetContainerMonitoringConfigurations()
        {
            return this._containerMonitoringConfigurations != null && (this._containerMonitoringConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the container association.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of container orchestration platform for the clusters in this association.
        /// Valid values are <c>ECS</c> and <c>EKS</c>. You can't change the type after creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContainerMonitoringType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}