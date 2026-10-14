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

namespace Amazon.PCS.Model
{
    /// <summary>
    /// This is the response object from the RegisterComputeNodeGroupInstance operation.
    /// </summary>
    public partial class RegisterComputeNodeGroupInstanceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster that the compute node registered into.
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property ComputeNodeGroupId. 
        /// <para>
        /// The ID of the compute node group that the compute node registered into.
        /// </para>
        /// </summary>
        public string ComputeNodeGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ComputeNodeGroupId property is set.
        /// </summary>
        internal bool IsSetComputeNodeGroupId() => this.ComputeNodeGroupId != null;

        /// <summary>
        /// Gets and sets the property ComputeNodeGroupName. 
        /// <para>
        /// The name of the compute node group that the compute node registered into.
        /// </para>
        /// </summary>
        public string ComputeNodeGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ComputeNodeGroupName property is set.
        /// </summary>
        internal bool IsSetComputeNodeGroupName() => this.ComputeNodeGroupName != null;

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The list of endpoints available for interaction with the scheduler.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Endpoint> Endpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<Endpoint>() : null;

        /// <summary>
        /// Checks to see if the Endpoints property is set.
        /// </summary>
        internal bool IsSetEndpoints() => this.Endpoints != null && (this.Endpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NodeID. 
        /// <para>
        /// The scheduler node ID for this instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NodeID { get; set; }

        /// <summary>
        /// Checks to see if the NodeID property is set.
        /// </summary>
        internal bool IsSetNodeID() => this.NodeID != null;

        /// <summary>
        /// Gets and sets the property NodeLifecycleActions. 
        /// <para>
        /// The node lifecycle actions configured for the node group, including scripts to run
        /// when a compute node finishes bootstrapping or becomes ready to accept jobs.
        /// </para>
        /// </summary>
        public NodeLifecycleActions NodeLifecycleActions { get; set; }

        /// <summary>
        /// Checks to see if the NodeLifecycleActions property is set.
        /// </summary>
        internal bool IsSetNodeLifecycleActions() => this.NodeLifecycleActions != null;

        /// <summary>
        /// Gets and sets the property SchedulerVersion. 
        /// <para>
        /// The scheduler version that the cluster is running. A compute node uses this value
        /// to run the matching scheduler version.
        /// </para>
        /// </summary>
        public string SchedulerVersion { get; set; }

        /// <summary>
        /// Checks to see if the SchedulerVersion property is set.
        /// </summary>
        internal bool IsSetSchedulerVersion() => this.SchedulerVersion != null;

        /// <summary>
        /// Gets and sets the property SharedSecret. 
        /// <para>
        /// For the Slurm scheduler, this is the shared Munge key the scheduler uses to authenticate
        /// compute node group instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string SharedSecret { get; set; }

        /// <summary>
        /// Checks to see if the SharedSecret property is set.
        /// </summary>
        internal bool IsSetSharedSecret() => this.SharedSecret != null;
    }
}
