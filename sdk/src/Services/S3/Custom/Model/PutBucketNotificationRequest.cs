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
    /// <note> 
    /// <para>
    /// This operation is not supported by directory buckets.
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
    /// For more information about the number of event notification configurations that you
    /// can create per bucket, see <a href="https://docs.aws.amazon.com/general/latest/gr/s3.html#limits_s3">Amazon
    /// S3 service quotas</a> in <i>Amazon Web Services General Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// By default, only the bucket owner can configure notifications on a bucket. However,
    /// bucket owners can use a bucket policy to grant permission to other users to set this
    /// configuration with the required <code>s3:PutBucketNotification</code> permission.
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
    }
}
