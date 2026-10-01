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
    /// Container for the parameters to the CreateGraph operation. Creates a new Neptune Analytics
    /// graph.
    /// </summary>
    public partial class CreateGraphRequest : AmazonNeptuneGraphRequest
    {
        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates whether or not to enable deletion protection on the graph. The graph can’t
        /// be deleted when deletion protection is enabled. (<c>true</c> or <c>false</c>).
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property GraphName. 
        /// <para>
        /// A name for the new Neptune Analytics graph to be created.
        /// </para>
        ///  
        /// <para>
        /// The name must contain from 1 to 63 letters, numbers, or hyphens, and its first character
        /// must be a letter. It cannot end with a hyphen or contain two consecutive hyphens.
        /// Only lowercase letters are allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string GraphName { get; set; }

        /// <summary>
        /// Checks to see if the GraphName property is set.
        /// </summary>
        internal bool IsSetGraphName() => this.GraphName != null;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// Specifies a KMS key to use to encrypt data in the new graph.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKmsKeyIdentifier() => this.KmsKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property ProvisionedMemory. 
        /// <para>
        /// The provisioned memory-optimized Neptune Capacity Units (m-NCUs) to use for the graph.
        /// Min = 16
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 24576)]
        public int? ProvisionedMemory { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedMemory property is set.
        /// </summary>
        internal bool IsSetProvisionedMemory() => this.ProvisionedMemory.HasValue;

        /// <summary>
        /// Gets and sets the property PublicConnectivity. 
        /// <para>
        /// Specifies whether or not the graph can be reachable over the internet. All access
        /// to graphs is IAM authenticated. (<c>true</c> to enable, or <c>false</c> to disable.
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
        /// The number of replicas in other AZs. Min =0, Max = 2, Default = 1.
        /// </para>
        ///  <important> 
        /// <para>
        ///  Additional charges equivalent to the m-NCUs selected for the graph apply for each
        /// replica. 
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaCount property is set.
        /// </summary>
        internal bool IsSetReplicaCount() => this.ReplicaCount.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Adds metadata tags to the new graph. These tags can also be used with cost allocation
        /// reporting, or used in a Condition statement in an IAM policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VectorSearchConfiguration. 
        /// <para>
        /// Specifies the number of dimensions for vector embeddings that will be loaded into
        /// the graph. The value is specified as <c>dimension=</c>value. Max = 65,535
        /// </para>
        /// </summary>
        public VectorSearchConfiguration VectorSearchConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VectorSearchConfiguration property is set.
        /// </summary>
        internal bool IsSetVectorSearchConfiguration() => this.VectorSearchConfiguration != null;
    }
}
