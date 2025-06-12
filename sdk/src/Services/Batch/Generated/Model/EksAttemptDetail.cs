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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents the details of a job attempt for a job attempt by an Amazon
    /// EKS container.
    /// </summary>
    public partial class EksAttemptDetail
    {
        private List<EksAttemptContainerDetail> _containers = AWSConfigs.InitializeCollections ? new List<EksAttemptContainerDetail>() : null;
        private string _eksClusterArn;
        private List<EksAttemptContainerDetail> _initContainers = AWSConfigs.InitializeCollections ? new List<EksAttemptContainerDetail>() : null;
        private string _nodeName;
        private string _podName;
        private string _podNamespace;
        private long? _startedAt;
        private string _statusReason;
        private long? _stoppedAt;

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// The details for the final status of the containers for this job attempt.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EksAttemptContainerDetail> Containers
        {
            get { return this._containers; }
            set { this._containers = value; }
        }

        // Check to see if Containers property is set
        internal bool IsSetContainers()
        {
            return this._containers != null && (this._containers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EksClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon EKS cluster.
        /// </para>
        /// </summary>
        public string EksClusterArn
        {
            get { return this._eksClusterArn; }
            set { this._eksClusterArn = value; }
        }

        // Check to see if EksClusterArn property is set
        internal bool IsSetEksClusterArn()
        {
            return this._eksClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property InitContainers. 
        /// <para>
        /// The details for the init containers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EksAttemptContainerDetail> InitContainers
        {
            get { return this._initContainers; }
            set { this._initContainers = value; }
        }

        // Check to see if InitContainers property is set
        internal bool IsSetInitContainers()
        {
            return this._initContainers != null && (this._initContainers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The name of the node for this job attempt.
        /// </para>
        /// </summary>
        public string NodeName
        {
            get { return this._nodeName; }
            set { this._nodeName = value; }
        }

        // Check to see if NodeName property is set
        internal bool IsSetNodeName()
        {
            return this._nodeName != null;
        }

        /// <summary>
        /// Gets and sets the property PodName. 
        /// <para>
        /// The name of the pod for this job attempt.
        /// </para>
        /// </summary>
        public string PodName
        {
            get { return this._podName; }
            set { this._podName = value; }
        }

        // Check to see if PodName property is set
        internal bool IsSetPodName()
        {
            return this._podName != null;
        }

        /// <summary>
        /// Gets and sets the property PodNamespace. 
        /// <para>
        /// The namespace of the Amazon EKS cluster that the pod exists in.
        /// </para>
        /// </summary>
        public string PodNamespace
        {
            get { return this._podNamespace; }
            set { this._podNamespace = value; }
        }

        // Check to see if PodNamespace property is set
        internal bool IsSetPodNamespace()
        {
            return this._podNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the attempt was started (when the attempt
        /// transitioned from the <c>STARTING</c> state to the <c>RUNNING</c> state).
        /// </para>
        /// </summary>
        public long? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short, human-readable string to provide additional details for the current status
        /// of the job attempt.
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
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the attempt was stopped. This happens
        /// when the attempt transitioned from the <c>RUNNING</c> state to a terminal state, such
        /// as <c>SUCCEEDED</c> or <c>FAILED</c>.
        /// </para>
        /// </summary>
        public long? StoppedAt
        {
            get { return this._stoppedAt; }
            set { this._stoppedAt = value; }
        }

        // Check to see if StoppedAt property is set
        internal bool IsSetStoppedAt()
        {
            return this._stoppedAt.HasValue; 
        }

    }
}