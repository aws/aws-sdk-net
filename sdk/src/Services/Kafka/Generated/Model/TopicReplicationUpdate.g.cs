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
    /// Details for updating the topic replication of a replicator.
    /// </summary>
    public partial class TopicReplicationUpdate
    {
        /// <summary>
        /// Gets and sets the property CopyAccessControlListsForTopics. 
        /// <para>
        /// Whether to periodically configure remote topic ACLs to match their corresponding upstream
        /// topics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? CopyAccessControlListsForTopics { get; set; }

        /// <summary>
        /// Checks to see if the CopyAccessControlListsForTopics property is set.
        /// </summary>
        internal bool IsSetCopyAccessControlListsForTopics() => this.CopyAccessControlListsForTopics.HasValue;

        /// <summary>
        /// Gets and sets the property CopyTopicConfigurations. 
        /// <para>
        /// Whether to periodically configure remote topics to match their corresponding upstream
        /// topics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? CopyTopicConfigurations { get; set; }

        /// <summary>
        /// Checks to see if the CopyTopicConfigurations property is set.
        /// </summary>
        internal bool IsSetCopyTopicConfigurations() => this.CopyTopicConfigurations.HasValue;

        /// <summary>
        /// Gets and sets the property DetectAndCopyNewTopics. 
        /// <para>
        /// Whether to periodically check for new topics and partitions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? DetectAndCopyNewTopics { get; set; }

        /// <summary>
        /// Checks to see if the DetectAndCopyNewTopics property is set.
        /// </summary>
        internal bool IsSetDetectAndCopyNewTopics() => this.DetectAndCopyNewTopics.HasValue;

        /// <summary>
        /// Gets and sets the property TopicsToExclude. 
        /// <para>
        /// List of regular expression patterns indicating the topics that should not be replicated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> TopicsToExclude { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TopicsToExclude property is set.
        /// </summary>
        internal bool IsSetTopicsToExclude() => this.TopicsToExclude != null && (this.TopicsToExclude.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopicsToReplicate. 
        /// <para>
        /// List of regular expression patterns indicating the topics to copy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> TopicsToReplicate { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TopicsToReplicate property is set.
        /// </summary>
        internal bool IsSetTopicsToReplicate() => this.TopicsToReplicate != null && (this.TopicsToReplicate.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
