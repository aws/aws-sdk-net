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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// A container for specifying the notification configuration of the bucket. If this element
    /// is empty, notifications are turned off for the bucket.
    /// </summary>
    public partial class GetBucketNotificationResponse : AmazonWebServiceResponse
    {
        private EventBridgeConfiguration _eventBridgeConfiguration;
        private List<LambdaFunctionConfiguration> _lambdaFunctionConfigurations = AWSConfigs.InitializeCollections ? new List<LambdaFunctionConfiguration>() : null;
        private List<QueueConfiguration> _queueConfigurations = AWSConfigs.InitializeCollections ? new List<QueueConfiguration>() : null;
        private List<TopicConfiguration> _topicConfigurations = AWSConfigs.InitializeCollections ? new List<TopicConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property EventBridgeConfiguration. 
        /// <para>
        /// Enables delivery of events to Amazon EventBridge.
        /// </para>
        /// </summary>
        public EventBridgeConfiguration EventBridgeConfiguration
        {
            get { return this._eventBridgeConfiguration; }
            set { this._eventBridgeConfiguration = value; }
        }

        // Check to see if EventBridgeConfiguration property is set
        internal bool IsSetEventBridgeConfiguration()
        {
            return this._eventBridgeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionConfigurations. 
        /// <para>
        /// Describes the Lambda functions to invoke and the events for which to invoke them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LambdaFunctionConfiguration> LambdaFunctionConfigurations
        {
            get { return this._lambdaFunctionConfigurations; }
            set { this._lambdaFunctionConfigurations = value; }
        }

        // Check to see if LambdaFunctionConfigurations property is set
        internal bool IsSetLambdaFunctionConfigurations()
        {
            return this._lambdaFunctionConfigurations != null && (this._lambdaFunctionConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueueConfigurations. 
        /// <para>
        /// The Amazon Simple Queue Service queues to publish messages to and the events for which
        /// to publish messages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QueueConfiguration> QueueConfigurations
        {
            get { return this._queueConfigurations; }
            set { this._queueConfigurations = value; }
        }

        // Check to see if QueueConfigurations property is set
        internal bool IsSetQueueConfigurations()
        {
            return this._queueConfigurations != null && (this._queueConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TopicConfigurations. 
        /// <para>
        /// The topic to which notifications are sent and the events for which notifications are
        /// generated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TopicConfiguration> TopicConfigurations
        {
            get { return this._topicConfigurations; }
            set { this._topicConfigurations = value; }
        }

        // Check to see if TopicConfigurations property is set
        internal bool IsSetTopicConfigurations()
        {
            return this._topicConfigurations != null && (this._topicConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}