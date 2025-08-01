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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
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
    /// Container for the parameters to the CreateGraph operation.
    /// Creates a new Neptune Analytics graph.
    /// </summary>
    public partial class CreateGraphRequest : AmazonNeptuneGraphRequest
    {
        private bool? _deletionProtection;
        private string _graphName;
        private string _kmsKeyIdentifier;
        private int? _provisionedMemory;
        private bool? _publicConnectivity;
        private int? _replicaCount;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private VectorSearchConfiguration _vectorSearchConfiguration;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates whether or not to enable deletion protection on the graph. The graph can’t
        /// be deleted when deletion protection is enabled. (<c>true</c> or <c>false</c>).
        /// </para>
        /// </summary>
        public bool? DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

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
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string GraphName
        {
            get { return this._graphName; }
            set { this._graphName = value; }
        }

        // Check to see if GraphName property is set
        internal bool IsSetGraphName()
        {
            return this._graphName != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// Specifies a KMS key to use to encrypt data in the new graph.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string KmsKeyIdentifier
        {
            get { return this._kmsKeyIdentifier; }
            set { this._kmsKeyIdentifier = value; }
        }

        // Check to see if KmsKeyIdentifier property is set
        internal bool IsSetKmsKeyIdentifier()
        {
            return this._kmsKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedMemory. 
        /// <para>
        /// The provisioned memory-optimized Neptune Capacity Units (m-NCUs) to use for the graph.
        /// Min = 16
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=24576)]
        public int? ProvisionedMemory
        {
            get { return this._provisionedMemory; }
            set { this._provisionedMemory = value; }
        }

        // Check to see if ProvisionedMemory property is set
        internal bool IsSetProvisionedMemory()
        {
            return this._provisionedMemory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublicConnectivity. 
        /// <para>
        /// Specifies whether or not the graph can be reachable over the internet. All access
        /// to graphs is IAM authenticated. (<c>true</c> to enable, or <c>false</c> to disable.
        /// </para>
        /// </summary>
        public bool? PublicConnectivity
        {
            get { return this._publicConnectivity; }
            set { this._publicConnectivity = value; }
        }

        // Check to see if PublicConnectivity property is set
        internal bool IsSetPublicConnectivity()
        {
            return this._publicConnectivity.HasValue; 
        }

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
        [AWSProperty(Min=0, Max=2)]
        public int? ReplicaCount
        {
            get { return this._replicaCount; }
            set { this._replicaCount = value; }
        }

        // Check to see if ReplicaCount property is set
        internal bool IsSetReplicaCount()
        {
            return this._replicaCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Adds metadata tags to the new graph. These tags can also be used with cost allocation
        /// reporting, or used in a Condition statement in an IAM policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property VectorSearchConfiguration. 
        /// <para>
        /// Specifies the number of dimensions for vector embeddings that will be loaded into
        /// the graph. The value is specified as <c>dimension=</c>value. Max = 65,535
        /// </para>
        /// </summary>
        public VectorSearchConfiguration VectorSearchConfiguration
        {
            get { return this._vectorSearchConfiguration; }
            set { this._vectorSearchConfiguration = value; }
        }

        // Check to see if VectorSearchConfiguration property is set
        internal bool IsSetVectorSearchConfiguration()
        {
            return this._vectorSearchConfiguration != null;
        }

    }
}