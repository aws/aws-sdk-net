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
    /// Details about topic replication.
    /// </summary>
    public partial class TopicReplication
    {
        private bool? _copyAccessControlListsForTopics;
        private bool? _copyTopicConfigurations;
        private bool? _detectAndCopyNewTopics;
        private ReplicationStartingPosition _startingPosition;
        private ReplicationTopicNameConfiguration _topicNameConfiguration;
        private List<string> _topicsToExclude = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _topicsToReplicate = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CopyAccessControlListsForTopics. 
        /// <para>
        /// Whether to periodically configure remote topic ACLs to match their corresponding upstream
        /// topics.
        /// </para>
        /// </summary>
        public bool? CopyAccessControlListsForTopics
        {
            get { return this._copyAccessControlListsForTopics; }
            set { this._copyAccessControlListsForTopics = value; }
        }

        // Check to see if CopyAccessControlListsForTopics property is set
        internal bool IsSetCopyAccessControlListsForTopics()
        {
            return this._copyAccessControlListsForTopics.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CopyTopicConfigurations. 
        /// <para>
        /// Whether to periodically configure remote topics to match their corresponding upstream
        /// topics.
        /// </para>
        /// </summary>
        public bool? CopyTopicConfigurations
        {
            get { return this._copyTopicConfigurations; }
            set { this._copyTopicConfigurations = value; }
        }

        // Check to see if CopyTopicConfigurations property is set
        internal bool IsSetCopyTopicConfigurations()
        {
            return this._copyTopicConfigurations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DetectAndCopyNewTopics. 
        /// <para>
        /// Whether to periodically check for new topics and partitions.
        /// </para>
        /// </summary>
        public bool? DetectAndCopyNewTopics
        {
            get { return this._detectAndCopyNewTopics; }
            set { this._detectAndCopyNewTopics = value; }
        }

        // Check to see if DetectAndCopyNewTopics property is set
        internal bool IsSetDetectAndCopyNewTopics()
        {
            return this._detectAndCopyNewTopics.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartingPosition. 
        /// <para>
        /// Configuration for specifying the position in the topics to start replicating from.
        /// </para>
        /// </summary>
        public ReplicationStartingPosition StartingPosition
        {
            get { return this._startingPosition; }
            set { this._startingPosition = value; }
        }

        // Check to see if StartingPosition property is set
        internal bool IsSetStartingPosition()
        {
            return this._startingPosition != null;
        }

        /// <summary>
        /// Gets and sets the property TopicNameConfiguration. 
        /// <para>
        /// Configuration for specifying replicated topic names should be the same as their corresponding
        /// upstream topics or prefixed with source cluster alias.
        /// </para>
        /// </summary>
        public ReplicationTopicNameConfiguration TopicNameConfiguration
        {
            get { return this._topicNameConfiguration; }
            set { this._topicNameConfiguration = value; }
        }

        // Check to see if TopicNameConfiguration property is set
        internal bool IsSetTopicNameConfiguration()
        {
            return this._topicNameConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TopicsToExclude. 
        /// <para>
        /// List of regular expression patterns indicating the topics that should not be replicated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TopicsToExclude
        {
            get { return this._topicsToExclude; }
            set { this._topicsToExclude = value; }
        }

        // Check to see if TopicsToExclude property is set
        internal bool IsSetTopicsToExclude()
        {
            return this._topicsToExclude != null && (this._topicsToExclude.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TopicsToReplicate. 
        /// <para>
        /// List of regular expression patterns indicating the topics to copy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TopicsToReplicate
        {
            get { return this._topicsToReplicate; }
            set { this._topicsToReplicate = value; }
        }

        // Check to see if TopicsToReplicate property is set
        internal bool IsSetTopicsToReplicate()
        {
            return this._topicsToReplicate != null && (this._topicsToReplicate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}