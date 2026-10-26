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
    /// Container for the parameters to the CreateCluster operation. Create a new Cluster.
    /// </summary>
    public partial class CreateClusterRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterType. Specify a type. All the Nodes that you later
        /// add to this Cluster must be this type of hardware. One Cluster instance can't contain
        /// different hardware types. You won't be able to change this parameter after you create
        /// the Cluster.
        /// </summary>
        public ClusterType ClusterType { get; set; }

        /// <summary>
        /// Checks to see if the ClusterType property is set.
        /// </summary>
        internal bool IsSetClusterType() => this.ClusterType != null;

        /// <summary>
        /// Gets and sets the property InstanceRoleArn. The ARN of the IAM role for the Node in
        /// this Cluster. The role must include all the operations that you expect these Node
        /// to perform. If necessary, create a role in IAM, then attach it here.
        /// </summary>
        public string InstanceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRoleArn property is set.
        /// </summary>
        internal bool IsSetInstanceRoleArn() => this.InstanceRoleArn != null;

        /// <summary>
        /// Gets and sets the property Name. Specify a name that is unique in the AWS account.
        /// We recommend that you assign a name that hints at the types of Nodes in the Cluster.
        /// Names are case-sensitive.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkSettings. Network settings that connect the Nodes
        /// in the Cluster to one or more of the Networks that the Cluster is associated with.
        /// </summary>
        public ClusterNetworkSettingsCreateRequest NetworkSettings { get; set; }

        /// <summary>
        /// Checks to see if the NetworkSettings property is set.
        /// </summary>
        internal bool IsSetNetworkSettings() => this.NetworkSettings != null;

        /// <summary>
        /// Gets and sets the property RequestId. The unique ID of the request.
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property Tags. A collection of key-value pairs.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
