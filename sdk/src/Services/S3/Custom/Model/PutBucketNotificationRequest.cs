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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketNotification operation.
    /// Enables notifications of specified events for a bucket. For more information about
    /// event notifications, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
    /// Event Notifications</a>.
    /// 
    ///  
    /// <para>
    /// Using this API, you can replace an existing notification configuration. The configuration
    /// is an XML file that defines the event types that you want Amazon S3 to publish and
    /// the destination where you want Amazon S3 to publish an event notification when it
    /// detects an event of the specified type.
    /// </para>
    ///  
    /// <para>
    /// By default, your bucket has no event notifications configured. That is, the notification
    /// configuration will be an empty <code>NotificationConfiguration</code>.
    /// </para>
    ///  
    /// <para>
    ///  <code>&lt;NotificationConfiguration&gt;</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>&lt;/NotificationConfiguration&gt;</code> 
    /// </para>
    ///  
    /// <para>
    /// This action replaces the existing notification configuration with the configuration
    /// you include in the request body.
    /// </para>
    ///  
    /// <para>
    /// After Amazon S3 receives this request, it first verifies that any Amazon Simple Notification
    /// Service (Amazon SNS) or Amazon Simple Queue Service (Amazon SQS) destination exists,
    /// and that the bucket owner has permission to publish to it by sending a test notification.
    /// In the case of Lambda destinations, Amazon S3 verifies that the Lambda function permissions
    /// grant Amazon S3 permission to invoke the function from the Amazon S3 bucket. For more
    /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
    /// Notifications for Amazon S3 Events</a>.
    /// </para>
    ///  
    /// <para>
    /// You can disable notifications by adding the empty NotificationConfiguration element.
    /// </para>
    ///  
    /// <para>
    /// By default, only the bucket owner can configure notifications on a bucket. However,
    /// bucket owners can use a bucket policy to grant permission to other users to set this
    /// configuration with <code>s3:PutBucketNotification</code> permission.
    /// </para>
    ///  <note> 
    /// <para>
    /// The PUT notification is an atomic operation. For example, suppose your notification
    /// configuration includes SNS topic, SQS queue, and Lambda function configurations. When
    /// you send a PUT request with this configuration, Amazon S3 sends test messages to your
    /// SNS topic. If the message fails, the entire PUT action will fail, and Amazon S3 will
    /// not add the configuration to your bucket.
    /// </para>
    ///  </note> 
    /// <para>
    /// If the configuration in the request body includes only one <code>TopicConfiguration</code>
    /// specifying only the <code>s3:ReducedRedundancyLostObject</code> event type, the response
    /// will also include the <code>x-amz-sns-test-message-id</code> header containing the
    /// message ID of the test notification sent to the topic.
    /// </para>
    ///  
    /// <para>
    /// The following action is related to <code>PutBucketNotificationConfiguration</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketNotificationConfiguration.html">GetBucketNotificationConfiguration</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutBucketNotificationRequest : AmazonWebServiceRequest
    {
        private ChecksumAlgorithm _checksumAlgorithm;
        private string expectedBucketOwner;
        private bool? _skipDestinationValidation;
        private EventBridgeConfiguration _eventBridgeConfiguration;

        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        public string BucketName { get; set; }        

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm.
        /// </summary>
        public ChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this._checksumAlgorithm; }
            set { this._checksumAlgorithm = value; }
        }

        // Check to see if ChecksumAlgorithm property is set
        internal bool IsSetChecksumAlgorithm()
        {
            return this._checksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the TopicConfigurations property. TopicConfigurations are configuration for Amazon S3 
        /// events to be sent to Amazon SNS topics.
        /// </summary>
        public List<TopicConfiguration> TopicConfigurations {get; set;}

        internal bool IsSetTopicConfigurations()
        {
            return this.TopicConfigurations != null && TopicConfigurations.Count > 0;
        }

        /// <summary>
        /// Gets and sets the QueueConfigurations property. QueueConfigurations are configuration for Amazon S3 
        /// events to be sent to Amazon SQS queues.
        /// </summary>
        public List<QueueConfiguration> QueueConfigurations { get; set; }

        internal bool IsSetQueueConfigurations()
        {
            return this.QueueConfigurations != null && QueueConfigurations.Count > 0;
        }

        /// <summary>
        /// Gets and sets the LambdaFunctionConfigurations property. LambdaFunctionConfigurations are configuration for 
        /// Amazon S3 events to be sent to an Amazon Lambda cloud function.
        /// </summary>
        public List<LambdaFunctionConfiguration> LambdaFunctionConfigurations { get; set; }

        internal bool IsSetLambdaFunctionConfigurations()
        {
            return this.LambdaFunctionConfigurations != null && LambdaFunctionConfigurations.Count > 0;
        }

        /// <summary>
        /// The account ID of the expected bucket owner. 
        /// If the bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        /// <summary>
        /// Checks to see if ExpectedBucketOwner is set.
        /// </summary>
        /// <returns>true, if ExpectedBucketOwner property is set.</returns>
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }

        /// <summary>
        /// Gets and sets the property SkipDestinationValidation. 
        /// <para>
        /// Skips validation of Amazon SQS, Amazon SNS, and Lambda destinations
        /// </para>
        /// </summary>
        public bool SkipDestinationValidation
        {
            get { return this._skipDestinationValidation.GetValueOrDefault(); }
            set { this._skipDestinationValidation = value; }
        }

        // Check to see if SkipDestinationValidation property is set
        internal bool IsSetSkipDestinationValidation()
        {
            return this._skipDestinationValidation.HasValue;
        }

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
