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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Returns information about a cluster operation.
    /// </summary>
    public partial class ClusterOperationInfo
    {
        private string _clientRequestId;
        private string _clusterArn;
        private DateTime? _creationTime;
        private DateTime? _endTime;
        private ErrorInfo _errorInfo;
        private string _operationArn;
        private string _operationState;
        private List<ClusterOperationStep> _operationSteps = AWSConfigs.InitializeCollections ? new List<ClusterOperationStep>() : null;
        private string _operationType;
        private MutableClusterInfo _sourceClusterInfo;
        private MutableClusterInfo _targetClusterInfo;
        private VpcConnectionInfo _vpcConnectionInfo;

        /// <summary>
        /// Gets and sets the property ClientRequestId.             
        /// <para>
        /// The ID of the API request that triggered this operation.
        /// </para>
        /// </summary>
        public string ClientRequestId
        {
            get { return this._clientRequestId; }
            set { this._clientRequestId = value; }
        }

        // Check to see if ClientRequestId property is set
        internal bool IsSetClientRequestId()
        {
            return this._clientRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterArn.             
        /// <para>
        /// ARN of the cluster.
        /// </para>
        /// </summary>
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime.             
        /// <para>
        /// The time that the operation was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime.             
        /// <para>
        /// The time at which the operation finished.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorInfo.             
        /// <para>
        /// Describes the error if the operation fails.
        /// </para>
        /// </summary>
        public ErrorInfo ErrorInfo
        {
            get { return this._errorInfo; }
            set { this._errorInfo = value; }
        }

        // Check to see if ErrorInfo property is set
        internal bool IsSetErrorInfo()
        {
            return this._errorInfo != null;
        }

        /// <summary>
        /// Gets and sets the property OperationArn.             
        /// <para>
        /// ARN of the cluster operation.
        /// </para>
        /// </summary>
        public string OperationArn
        {
            get { return this._operationArn; }
            set { this._operationArn = value; }
        }

        // Check to see if OperationArn property is set
        internal bool IsSetOperationArn()
        {
            return this._operationArn != null;
        }

        /// <summary>
        /// Gets and sets the property OperationState.             
        /// <para>
        /// State of the cluster operation.
        /// </para>
        /// </summary>
        public string OperationState
        {
            get { return this._operationState; }
            set { this._operationState = value; }
        }

        // Check to see if OperationState property is set
        internal bool IsSetOperationState()
        {
            return this._operationState != null;
        }

        /// <summary>
        /// Gets and sets the property OperationSteps.             
        /// <para>
        /// Steps completed during the operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterOperationStep> OperationSteps
        {
            get { return this._operationSteps; }
            set { this._operationSteps = value; }
        }

        // Check to see if OperationSteps property is set
        internal bool IsSetOperationSteps()
        {
            return this._operationSteps != null && (this._operationSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OperationType.             
        /// <para>
        /// Type of the cluster operation.
        /// </para>
        /// </summary>
        public string OperationType
        {
            get { return this._operationType; }
            set { this._operationType = value; }
        }

        // Check to see if OperationType property is set
        internal bool IsSetOperationType()
        {
            return this._operationType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceClusterInfo.             
        /// <para>
        /// Information about cluster attributes before a cluster is updated.
        /// </para>
        /// </summary>
        public MutableClusterInfo SourceClusterInfo
        {
            get { return this._sourceClusterInfo; }
            set { this._sourceClusterInfo = value; }
        }

        // Check to see if SourceClusterInfo property is set
        internal bool IsSetSourceClusterInfo()
        {
            return this._sourceClusterInfo != null;
        }

        /// <summary>
        /// Gets and sets the property TargetClusterInfo.             
        /// <para>
        /// Information about cluster attributes after a cluster is updated.
        /// </para>
        /// </summary>
        public MutableClusterInfo TargetClusterInfo
        {
            get { return this._targetClusterInfo; }
            set { this._targetClusterInfo = value; }
        }

        // Check to see if TargetClusterInfo property is set
        internal bool IsSetTargetClusterInfo()
        {
            return this._targetClusterInfo != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConnectionInfo.             
        /// <para>
        /// Description of the VPC connection for CreateVpcConnection and DeleteVpcConnection
        /// operations.
        /// </para>
        /// </summary>
        public VpcConnectionInfo VpcConnectionInfo
        {
            get { return this._vpcConnectionInfo; }
            set { this._vpcConnectionInfo = value; }
        }

        // Check to see if VpcConnectionInfo property is set
        internal bool IsSetVpcConnectionInfo()
        {
            return this._vpcConnectionInfo != null;
        }

    }
}