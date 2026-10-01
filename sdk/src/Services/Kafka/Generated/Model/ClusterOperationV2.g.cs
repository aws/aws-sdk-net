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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Returns information about a cluster operation.
    /// </summary>
    public partial class ClusterOperationV2
    {
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// ARN of the cluster.
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property ClusterType. 
        /// <para>
        /// Type of the backend cluster.
        /// </para>
        /// </summary>
        public ClusterType ClusterType { get; set; }

        /// <summary>
        /// Checks to see if the ClusterType property is set.
        /// </summary>
        internal bool IsSetClusterType() => this.ClusterType != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the operation finished.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// If cluster operation failed from an error, it describes the error.
        /// </para>
        /// </summary>
        public ErrorInfo ErrorInfo { get; set; }

        /// <summary>
        /// Checks to see if the ErrorInfo property is set.
        /// </summary>
        internal bool IsSetErrorInfo() => this.ErrorInfo != null;

        /// <summary>
        /// Gets and sets the property OperationArn. 
        /// <para>
        /// ARN of the cluster operation.
        /// </para>
        /// </summary>
        public string OperationArn { get; set; }

        /// <summary>
        /// Checks to see if the OperationArn property is set.
        /// </summary>
        internal bool IsSetOperationArn() => this.OperationArn != null;

        /// <summary>
        /// Gets and sets the property OperationState. 
        /// <para>
        /// State of the cluster operation.
        /// </para>
        /// </summary>
        public string OperationState { get; set; }

        /// <summary>
        /// Checks to see if the OperationState property is set.
        /// </summary>
        internal bool IsSetOperationState() => this.OperationState != null;

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// Type of the cluster operation.
        /// </para>
        /// </summary>
        public string OperationType { get; set; }

        /// <summary>
        /// Checks to see if the OperationType property is set.
        /// </summary>
        internal bool IsSetOperationType() => this.OperationType != null;

        /// <summary>
        /// Gets and sets the property Provisioned. 
        /// <para>
        /// Properties of a provisioned cluster.
        /// </para>
        /// </summary>
        public ClusterOperationV2Provisioned Provisioned { get; set; }

        /// <summary>
        /// Checks to see if the Provisioned property is set.
        /// </summary>
        internal bool IsSetProvisioned() => this.Provisioned != null;

        /// <summary>
        /// Gets and sets the property Serverless. 
        /// <para>
        /// Properties of a serverless cluster.
        /// </para>
        /// </summary>
        public ClusterOperationV2Serverless Serverless { get; set; }

        /// <summary>
        /// Checks to see if the Serverless property is set.
        /// </summary>
        internal bool IsSetServerless() => this.Serverless != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time at which operation was started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
