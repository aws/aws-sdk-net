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
    /// The parameters required to set up a source for your pipe.
    /// </summary>
    public partial class UpdatePipeSourceParameters
    {
        private UpdatePipeSourceActiveMQBrokerParameters _activeMQBrokerParameters;
        private UpdatePipeSourceDynamoDBStreamParameters _dynamoDBStreamParameters;
        private FilterCriteria _filterCriteria;
        private UpdatePipeSourceKinesisStreamParameters _kinesisStreamParameters;
        private UpdatePipeSourceManagedStreamingKafkaParameters _managedStreamingKafkaParameters;
        private UpdatePipeSourceRabbitMQBrokerParameters _rabbitMQBrokerParameters;
        private UpdatePipeSourceSelfManagedKafkaParameters _selfManagedKafkaParameters;
        private UpdatePipeSourceSqsQueueParameters _sqsQueueParameters;

        /// <summary>
        /// Gets and sets the property ActiveMQBrokerParameters. 
        /// <para>
        /// The parameters for using an Active MQ broker as a source.
        /// </para>
        /// </summary>
        public UpdatePipeSourceActiveMQBrokerParameters ActiveMQBrokerParameters
        {
            get { return this._activeMQBrokerParameters; }
            set { this._activeMQBrokerParameters = value; }
        }

        // Check to see if ActiveMQBrokerParameters property is set
        internal bool IsSetActiveMQBrokerParameters()
        {
            return this._activeMQBrokerParameters != null;
        }

        /// <summary>
        /// Gets and sets the property DynamoDBStreamParameters. 
        /// <para>
        /// The parameters for using a DynamoDB stream as a source.
        /// </para>
        /// </summary>
        public UpdatePipeSourceDynamoDBStreamParameters DynamoDBStreamParameters
        {
            get { return this._dynamoDBStreamParameters; }
            set { this._dynamoDBStreamParameters = value; }
        }

        // Check to see if DynamoDBStreamParameters property is set
        internal bool IsSetDynamoDBStreamParameters()
        {
            return this._dynamoDBStreamParameters != null;
        }

        /// <summary>
        /// Gets and sets the property FilterCriteria. 
        /// <para>
        /// The collection of event patterns used to filter events. For more information, see
        /// <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-and-event-patterns.html">Events
        /// and Event Patterns</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        public FilterCriteria FilterCriteria
        {
            get { return this._filterCriteria; }
            set { this._filterCriteria = value; }
        }

        // Check to see if FilterCriteria property is set
        internal bool IsSetFilterCriteria()
        {
            return this._filterCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisStreamParameters. 
        /// <para>
        /// The parameters for using a Kinesis stream as a source.
        /// </para>
        /// </summary>
        public UpdatePipeSourceKinesisStreamParameters KinesisStreamParameters
        {
            get { return this._kinesisStreamParameters; }
            set { this._kinesisStreamParameters = value; }
        }

        // Check to see if KinesisStreamParameters property is set
        internal bool IsSetKinesisStreamParameters()
        {
            return this._kinesisStreamParameters != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedStreamingKafkaParameters. 
        /// <para>
        /// The parameters for using an MSK stream as a source.
        /// </para>
        /// </summary>
        public UpdatePipeSourceManagedStreamingKafkaParameters ManagedStreamingKafkaParameters
        {
            get { return this._managedStreamingKafkaParameters; }
            set { this._managedStreamingKafkaParameters = value; }
        }

        // Check to see if ManagedStreamingKafkaParameters property is set
        internal bool IsSetManagedStreamingKafkaParameters()
        {
            return this._managedStreamingKafkaParameters != null;
        }

        /// <summary>
        /// Gets and sets the property RabbitMQBrokerParameters. 
        /// <para>
        /// The parameters for using a Rabbit MQ broker as a source.
        /// </para>
        /// </summary>
        public UpdatePipeSourceRabbitMQBrokerParameters RabbitMQBrokerParameters
        {
            get { return this._rabbitMQBrokerParameters; }
            set { this._rabbitMQBrokerParameters = value; }
        }

        // Check to see if RabbitMQBrokerParameters property is set
        internal bool IsSetRabbitMQBrokerParameters()
        {
            return this._rabbitMQBrokerParameters != null;
        }

        /// <summary>
        /// Gets and sets the property SelfManagedKafkaParameters. 
        /// <para>
        /// The parameters for using a self-managed Apache Kafka stream as a source.
        /// </para>
        /// </summary>
        public UpdatePipeSourceSelfManagedKafkaParameters SelfManagedKafkaParameters
        {
            get { return this._selfManagedKafkaParameters; }
            set { this._selfManagedKafkaParameters = value; }
        }

        // Check to see if SelfManagedKafkaParameters property is set
        internal bool IsSetSelfManagedKafkaParameters()
        {
            return this._selfManagedKafkaParameters != null;
        }

        /// <summary>
        /// Gets and sets the property SqsQueueParameters. 
        /// <para>
        /// The parameters for using a Amazon SQS stream as a source.
        /// </para>
        /// </summary>
        public UpdatePipeSourceSqsQueueParameters SqsQueueParameters
        {
            get { return this._sqsQueueParameters; }
            set { this._sqsQueueParameters = value; }
        }

        // Check to see if SqsQueueParameters property is set
        internal bool IsSetSqsQueueParameters()
        {
            return this._sqsQueueParameters != null;
        }

    }
}