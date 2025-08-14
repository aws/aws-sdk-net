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
    /// Container for the parameters to the PutBucketNotification operation.
    /// <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Enables notifications of specified events for a bucket. For more information about
    /// event notifications, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
    /// Event Notifications</a>.
    /// </para>
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
    /// configuration will be an empty <c>NotificationConfiguration</c>.
    /// </para>
    ///  
    /// <para>
    ///  <c>&lt;NotificationConfiguration&gt;</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>&lt;/NotificationConfiguration&gt;</c> 
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
    /// For more information about the number of event notification configurations that you
    /// can create per bucket, see <a href="https://docs.aws.amazon.com/general/latest/gr/s3.html#limits_s3">Amazon
    /// S3 service quotas</a> in <i>Amazon Web Services General Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// By default, only the bucket owner can configure notifications on a bucket. However,
    /// bucket owners can use a bucket policy to grant permission to other users to set this
    /// configuration with the required <c>s3:PutBucketNotification</c> permission.
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
    /// If the configuration in the request body includes only one <c>TopicConfiguration</c>
    /// specifying only the <c>s3:ReducedRedundancyLostObject</c> event type, the response
    /// will also include the <c>x-amz-sns-test-message-id</c> header containing the message
    /// ID of the test notification sent to the topic.
    /// </para>
    ///  
    /// <para>
    /// The following action is related to <c>PutBucketNotificationConfiguration</c>:
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
        private string _bucketName;
        private EventBridgeConfiguration _eventBridgeConfiguration;
        private string _expectedBucketOwner;
        private List<LambdaFunctionConfiguration> _lambdaFunctionConfigurations = AWSConfigs.InitializeCollections ? new List<LambdaFunctionConfiguration>() : null;
        private List<QueueConfiguration> _queueConfigurations = AWSConfigs.InitializeCollections ? new List<QueueConfiguration>() : null;
        private bool? _skipDestinationValidation;
        private List<TopicConfiguration> _topicConfigurations = AWSConfigs.InitializeCollections ? new List<TopicConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

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
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <c>403 Forbidden</c> (access denied).
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return this._expectedBucketOwner != null;
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
        /// Gets and sets the property SkipDestinationValidation. 
        /// <para>
        /// Skips validation of Amazon SQS, Amazon SNS, and Lambda destinations. True or false
        /// value.
        /// </para>
        /// </summary>
        public bool? SkipDestinationValidation
        {
            get { return this._skipDestinationValidation; }
            set { this._skipDestinationValidation = value; }
        }

        // Check to see if SkipDestinationValidation property is set
        internal bool IsSetSkipDestinationValidation()
        {
            return this._skipDestinationValidation.HasValue; 
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