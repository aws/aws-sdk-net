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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters for using an MSK stream as a source.
    /// </summary>
    public partial class PipeSourceManagedStreamingKafkaParameters
    {
        private int? _batchSize;
        private string _consumerGroupID;
        private MSKAccessCredentials _credentials;
        private int? _maximumBatchingWindowInSeconds;
        private MSKStartPosition _startingPosition;
        private string _topicName;

        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        /// The maximum number of records to include in each batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int BatchSize
        {
            get { return this._batchSize.GetValueOrDefault(); }
            set { this._batchSize = value; }
        }

        // Check to see if BatchSize property is set
        internal bool IsSetBatchSize()
        {
            return this._batchSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConsumerGroupID. 
        /// <para>
        /// The name of the destination queue to consume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ConsumerGroupID
        {
            get { return this._consumerGroupID; }
            set { this._consumerGroupID = value; }
        }

        // Check to see if ConsumerGroupID property is set
        internal bool IsSetConsumerGroupID()
        {
            return this._consumerGroupID != null;
        }

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The credentials needed to access the resource.
        /// </para>
        /// </summary>
        public MSKAccessCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumBatchingWindowInSeconds. 
        /// <para>
        /// The maximum length of a time to wait for events.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public int MaximumBatchingWindowInSeconds
        {
            get { return this._maximumBatchingWindowInSeconds.GetValueOrDefault(); }
            set { this._maximumBatchingWindowInSeconds = value; }
        }

        // Check to see if MaximumBatchingWindowInSeconds property is set
        internal bool IsSetMaximumBatchingWindowInSeconds()
        {
            return this._maximumBatchingWindowInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartingPosition. 
        /// <para>
        /// (Streams only) The position in a stream from which to start reading.
        /// </para>
        /// </summary>
        public MSKStartPosition StartingPosition
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
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The name of the topic that the pipe will read from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=249)]
        public string TopicName
        {
            get { return this._topicName; }
            set { this._topicName = value; }
        }

        // Check to see if TopicName property is set
        internal bool IsSetTopicName()
        {
            return this._topicName != null;
        }

    }
}