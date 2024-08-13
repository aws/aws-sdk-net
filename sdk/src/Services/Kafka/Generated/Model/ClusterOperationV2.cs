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
    public partial class ClusterOperationV2
    {
        private string _clusterArn;
        private ClusterType _clusterType;
        private DateTime? _endTime;
        private ErrorInfo _errorInfo;
        private string _operationArn;
        private string _operationState;
        private string _operationType;
        private ClusterOperationV2Provisioned _provisioned;
        private ClusterOperationV2Serverless _serverless;
        private DateTime? _startTime;

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
        /// Gets and sets the property ClusterType.             
        /// <para>
        /// Type of the backend cluster.
        /// </para>
        /// </summary>
        public ClusterType ClusterType
        {
            get { return this._clusterType; }
            set { this._clusterType = value; }
        }

        // Check to see if ClusterType property is set
        internal bool IsSetClusterType()
        {
            return this._clusterType != null;
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
        /// If cluster operation failed from an error, it describes the error.
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
        /// Gets and sets the property Provisioned.             
        /// <para>
        /// Properties of a provisioned cluster.
        /// </para>
        /// </summary>
        public ClusterOperationV2Provisioned Provisioned
        {
            get { return this._provisioned; }
            set { this._provisioned = value; }
        }

        // Check to see if Provisioned property is set
        internal bool IsSetProvisioned()
        {
            return this._provisioned != null;
        }

        /// <summary>
        /// Gets and sets the property Serverless.             
        /// <para>
        /// Properties of a serverless cluster.
        /// </para>
        /// </summary>
        public ClusterOperationV2Serverless Serverless
        {
            get { return this._serverless; }
            set { this._serverless = value; }
        }

        // Check to see if Serverless property is set
        internal bool IsSetServerless()
        {
            return this._serverless != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime.             
        /// <para>
        /// The time at which operation was started.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}