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
    /// Container for the parameters to the CreateQueue operation. Creates a job queue. You
    /// must associate 1 or more compute node groups with the queue. You can associate 1 compute
    /// node group with multiple queues.
    /// </summary>
    public partial class CreateQueueRequest : AmazonPCSRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. Idempotency ensures that an API request completes only once. With an
        /// idempotent request, if the original request completes successfully, the subsequent
        /// retries with the same client token return the result from the original successful
        /// request and they have no additional effect. If you don't specify a client token, the
        /// CLI and SDK automatically generate 1 for you.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The name or ID of the cluster for which to create a queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property ComputeNodeGroupConfigurations. 
        /// <para>
        /// The list of compute node group configurations to associate with the queue. Queues
        /// assign jobs to associated compute node groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComputeNodeGroupConfiguration> ComputeNodeGroupConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ComputeNodeGroupConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ComputeNodeGroupConfigurations property is set.
        /// </summary>
        internal bool IsSetComputeNodeGroupConfigurations() => this.ComputeNodeGroupConfigurations != null && (this.ComputeNodeGroupConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueueName. 
        /// <para>
        /// A name to identify the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 25)]
        public string QueueName { get; set; }

        /// <summary>
        /// Checks to see if the QueueName property is set.
        /// </summary>
        internal bool IsSetQueueName() => this.QueueName != null;

        /// <summary>
        /// Gets and sets the property SlurmConfiguration. 
        /// <para>
        /// Additional options related to the Slurm scheduler.
        /// </para>
        /// </summary>
        public QueueSlurmConfigurationRequest SlurmConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SlurmConfiguration property is set.
        /// </summary>
        internal bool IsSetSlurmConfiguration() => this.SlurmConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// 1 or more tags added to the resource. Each tag consists of a tag key and tag value.
        /// The tag value is optional and can be an empty string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
