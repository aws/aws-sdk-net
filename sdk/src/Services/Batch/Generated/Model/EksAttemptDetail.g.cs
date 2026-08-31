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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents the details of a job attempt for a job attempt by an Amazon
    /// EKS container.
    /// </summary>
    public partial class EksAttemptDetail
    {
        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// The details for the final status of the containers for this job attempt.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EksAttemptContainerDetail> Containers { get; set; } = AWSConfigs.InitializeCollections ? new List<EksAttemptContainerDetail>() : null;

        /// <summary>
        /// Checks to see if the Containers property is set.
        /// </summary>
        internal bool IsSetContainers() => this.Containers != null && (this.Containers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EksClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon EKS cluster.
        /// </para>
        /// </summary>
        public string EksClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the EksClusterArn property is set.
        /// </summary>
        internal bool IsSetEksClusterArn() => this.EksClusterArn != null;

        /// <summary>
        /// Gets and sets the property InitContainers. 
        /// <para>
        /// The details for the init containers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EksAttemptContainerDetail> InitContainers { get; set; } = AWSConfigs.InitializeCollections ? new List<EksAttemptContainerDetail>() : null;

        /// <summary>
        /// Checks to see if the InitContainers property is set.
        /// </summary>
        internal bool IsSetInitContainers() => this.InitContainers != null && (this.InitContainers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The name of the node for this job attempt.
        /// </para>
        /// </summary>
        public string NodeName { get; set; }

        /// <summary>
        /// Checks to see if the NodeName property is set.
        /// </summary>
        internal bool IsSetNodeName() => this.NodeName != null;

        /// <summary>
        /// Gets and sets the property PodName. 
        /// <para>
        /// The name of the pod for this job attempt.
        /// </para>
        /// </summary>
        public string PodName { get; set; }

        /// <summary>
        /// Checks to see if the PodName property is set.
        /// </summary>
        internal bool IsSetPodName() => this.PodName != null;

        /// <summary>
        /// Gets and sets the property PodNamespace. 
        /// <para>
        /// The namespace of the Amazon EKS cluster that the pod exists in.
        /// </para>
        /// </summary>
        public string PodNamespace { get; set; }

        /// <summary>
        /// Checks to see if the PodNamespace property is set.
        /// </summary>
        internal bool IsSetPodNamespace() => this.PodNamespace != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the attempt was started (when the attempt
        /// transitioned from the <c>STARTING</c> state to the <c>RUNNING</c> state).
        /// </para>
        /// </summary>
        public long? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short, human-readable string to provide additional details for the current status
        /// of the job attempt.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the attempt was stopped. This happens
        /// when the attempt transitioned from the <c>RUNNING</c> state to a terminal state, such
        /// as <c>SUCCEEDED</c> or <c>FAILED</c>.
        /// </para>
        /// </summary>
        public long? StoppedAt { get; set; }

        /// <summary>
        /// Checks to see if the StoppedAt property is set.
        /// </summary>
        internal bool IsSetStoppedAt() => this.StoppedAt.HasValue;
    }
}
