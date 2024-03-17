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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  GetBucketNotification response and response metadata.
    /// </summary>
    public class GetBucketNotificationResponse : AmazonWebServiceResponse
    {
        List<TopicConfiguration> _topicConfigurations = AWSConfigs.InitializeCollections ? new List<TopicConfiguration>() : null;
        /// <summary>
        /// Gets and sets the TopicConfigurations property. TopicConfigurations are configuration 
        /// for Amazon S3 events to be sent to Amazon SNS topics.
        /// </summary>
        public List<TopicConfiguration> TopicConfigurations 
        {
            get { return _topicConfigurations; }
            set {  _topicConfigurations = value; }
        }

        List<QueueConfiguration> _queueConfigurations = AWSConfigs.InitializeCollections ? new List<QueueConfiguration>() : null;
        /// <summary>
        /// Gets and sets the QueueConfigurations property. QueueConfigurations are configuration 
        /// for Amazon S3 events to be sent to Amazon SQS queues.
        /// </summary>
        public List<QueueConfiguration> QueueConfigurations
        {
            get { return _queueConfigurations; }
            set { _queueConfigurations = value; }
        }


        List<LambdaFunctionConfiguration> _lambdaFunctionConfigurations = AWSConfigs.InitializeCollections ? new List<LambdaFunctionConfiguration>() : null;
        /// <summary>
        /// Gets and sets the property LambdaFunctionConfigurations. 
        /// <para>
        /// Describes the Lambda functions to invoke and the events for which to invoke them.
        /// </para>
        /// </summary>
        public List<LambdaFunctionConfiguration> LambdaFunctionConfigurations
        {
            get { return _lambdaFunctionConfigurations; }
            set { _lambdaFunctionConfigurations = value; }
        }

        private EventBridgeConfiguration _eventBridgeConfiguration;
        /// <summary>
        /// Gets and sets the property EventBridgeConfiguration. 
        /// <para>
        /// Enables delivery of all bucket events to Amazon EventBridge.
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
    }
}
    
