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
    /// This is the response object from the ResetGraph operation.
    /// </summary>
    public partial class ResetGraphResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _buildNumber;
        private DateTime? _createTime;
        private bool? _deletionProtection;
        private string _endpoint;
        private string _id;
        private string _kmsKeyIdentifier;
        private string _name;
        private int? _provisionedMemory;
        private bool? _publicConnectivity;
        private int? _replicaCount;
        private string _sourceSnapshotId;
        private GraphStatus _status;
        private string _statusReason;
        private VectorSearchConfiguration _vectorSearchConfiguration;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN associated with the graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property BuildNumber. 
        /// <para>
        /// The build number of the graph.
        /// </para>
        /// </summary>
        public string BuildNumber
        {
            get { return this._buildNumber; }
            set { this._buildNumber = value; }
        }

        // Check to see if BuildNumber property is set
        internal bool IsSetBuildNumber()
        {
            return this._buildNumber != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the graph was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// If <c>true</c>, deletion protection is enabled for the graph.
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
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The graph endpoint.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The ID of the KMS key used to encrypt and decrypt graph data.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property ProvisionedMemory. 
        /// <para>
        /// The number of memory-optimized Neptune Capacity Units (m-NCUs) allocated to the graph.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=24576)]
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
        /// If <c>true</c>, the graph has a public endpoint, otherwise not.
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
        /// The number of replicas for the graph.
        /// </para>
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
        /// Gets and sets the property SourceSnapshotId. 
        /// <para>
        /// The ID of the snapshot from which the graph was created, if any.
        /// </para>
        /// </summary>
        public string SourceSnapshotId
        {
            get { return this._sourceSnapshotId; }
            set { this._sourceSnapshotId = value; }
        }

        // Check to see if SourceSnapshotId property is set
        internal bool IsSetSourceSnapshotId()
        {
            return this._sourceSnapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the graph.
        /// </para>
        /// </summary>
        public GraphStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason that the graph has this status.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property VectorSearchConfiguration.
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