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
    /// Container for the parameters to the StartTopicReassignment operation. Initiates topic
    /// partition reassignment between broker types in a mixed-mode cluster.
    /// </summary>
    public partial class StartTopicReassignmentRequest : AmazonKafkaRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you retry a request with the same client token within 24 hours, the
        /// API returns the original response without creating a duplicate operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property TargetInstanceType. 
        /// <para>
        /// Instance type of the target brokers. Must exist in the cluster. Use Express instance
        /// type (e.g., express.m7g.large) for Standard-to-Express migration. Use Standard instance
        /// type (e.g., kafka.m7g.large) to move topics back to Standard.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string TargetInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the TargetInstanceType property is set.
        /// </summary>
        internal bool IsSetTargetInstanceType() => this.TargetInstanceType != null;

        /// <summary>
        /// Gets and sets the property TopicsToExclude. 
        /// <para>
        /// Regex patterns for topics to exclude from reassignment. Evaluated after include patterns.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TopicsToExclude { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TopicsToExclude property is set.
        /// </summary>
        internal bool IsSetTopicsToExclude() => this.TopicsToExclude != null && (this.TopicsToExclude.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopicsToInclude. 
        /// <para>
        /// Regex patterns for topics to reassign. Use ['.*'] for all topics. Max 10 patterns.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> TopicsToInclude { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TopicsToInclude property is set.
        /// </summary>
        internal bool IsSetTopicsToInclude() => this.TopicsToInclude != null && (this.TopicsToInclude.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
