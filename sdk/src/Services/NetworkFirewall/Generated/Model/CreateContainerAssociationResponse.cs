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
    /// This is the response object from the CreateContainerAssociation operation.
    /// </summary>
    public partial class CreateContainerAssociationResponse : AmazonWebServiceResponse
    {
        private string _containerAssociationArn;
        private string _containerAssociationName;
        private List<ContainerMonitoringConfiguration> _containerMonitoringConfigurations = AWSConfigs.InitializeCollections ? new List<ContainerMonitoringConfiguration>() : null;
        private string _description;
        private ContainerAssociationStatus _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private ContainerMonitoringType _type;
        private string _updateToken;

        /// <summary>
        /// Gets and sets the property ContainerAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ContainerAssociationArn
        {
            get { return this._containerAssociationArn; }
            set { this._containerAssociationArn = value; }
        }

        // Check to see if ContainerAssociationArn property is set
        internal bool IsSetContainerAssociationArn()
        {
            return this._containerAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerAssociationName. 
        /// <para>
        /// The descriptive name of the container association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// The container monitoring configurations for this container association.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the container association.
        /// </para>
        /// </summary>
        public ContainerAssociationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs associated with the resource.
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
        /// The type of container orchestration platform. Either <c>ECS</c> or <c>EKS</c>.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic locking. Network Firewall returns a token to your requests
        /// that access the container association. The token marks the state of the container
        /// association resource at the time of the request. To make an update to the container
        /// association, provide the token in your request. Network Firewall uses the token to
        /// ensure that the container association hasn't changed since you last retrieved it.
        /// If it has changed, the operation fails with an <c>InvalidTokenException</c>. If this
        /// happens, retrieve the container association again to get a current copy of it with
        /// a new token. Reapply your changes as needed, then try the operation again using the
        /// new token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string UpdateToken
        {
            get { return this._updateToken; }
            set { this._updateToken = value; }
        }

        // Check to see if UpdateToken property is set
        internal bool IsSetUpdateToken()
        {
            return this._updateToken != null;
        }

    }
}