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

namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// This is the response object from the ResetGraph operation.
    /// </summary>
    public partial class ResetGraphResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN associated with the graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BuildNumber. 
        /// <para>
        /// The build number of the graph.
        /// </para>
        /// </summary>
        public string BuildNumber { get; set; }

        /// <summary>
        /// Checks to see if the BuildNumber property is set.
        /// </summary>
        internal bool IsSetBuildNumber() => this.BuildNumber != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the graph was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// If <c>true</c>, deletion protection is enabled for the graph.
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The graph endpoint.
        /// </para>
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The ID of the KMS key used to encrypt and decrypt graph data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKmsKeyIdentifier() => this.KmsKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProvisionedMemory. 
        /// <para>
        /// The number of memory-optimized Neptune Capacity Units (m-NCUs) allocated to the graph.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 24576)]
        public int? ProvisionedMemory { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedMemory property is set.
        /// </summary>
        internal bool IsSetProvisionedMemory() => this.ProvisionedMemory.HasValue;

        /// <summary>
        /// Gets and sets the property PublicConnectivity. 
        /// <para>
        /// If <c>true</c>, the graph has a public endpoint, otherwise not.
        /// </para>
        /// </summary>
        public bool? PublicConnectivity { get; set; }

        /// <summary>
        /// Checks to see if the PublicConnectivity property is set.
        /// </summary>
        internal bool IsSetPublicConnectivity() => this.PublicConnectivity.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicaCount. 
        /// <para>
        /// The number of replicas for the graph.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaCount property is set.
        /// </summary>
        internal bool IsSetReplicaCount() => this.ReplicaCount.HasValue;

        /// <summary>
        /// Gets and sets the property SourceSnapshotId. 
        /// <para>
        /// The ID of the snapshot from which the graph was created, if any.
        /// </para>
        /// </summary>
        public string SourceSnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SourceSnapshotId property is set.
        /// </summary>
        internal bool IsSetSourceSnapshotId() => this.SourceSnapshotId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the graph.
        /// </para>
        /// </summary>
        public GraphStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason that the graph has this status.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property VectorSearchConfiguration.
        /// </summary>
        public VectorSearchConfiguration VectorSearchConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VectorSearchConfiguration property is set.
        /// </summary>
        internal bool IsSetVectorSearchConfiguration() => this.VectorSearchConfiguration != null;
    }
}
