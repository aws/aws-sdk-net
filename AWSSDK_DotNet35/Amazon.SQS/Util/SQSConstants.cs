/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2012-09-15
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.SQS.Util
{
    public static class SQSConstants
    {
        /// <summary>
        /// Used in <c>GetQueueAttributes</c> to return all values.
        /// </summary>
        public const string ATTRIBUTE_ALL = "All";

        /// <summary>
        /// The length of time (in seconds) that a message received from a queue will be invisible to other receiving components when they ask to receive messages.
        /// </summary>
        public const string ATTRIBUTE_VISIBILITY_TIMEOUT = "VisibilityTimeout";

        /// <summary>
        /// The approximate number of visible messages in a queue
        /// </summary>
        public const string ATTRIBUTE_APPROXIMATE_NUMBER_OF_MESSAGES = "ApproximateNumberOfMessages";

        /// <summary>
        /// The approximate number of messages that are not timed-out and not deleted.
        /// </summary>
        public const string ATTRIBUTE_APPROXIMATE_NUMBER_OF_MESSAGES_NOT_VISIBLE = "ApproximateNumberOfMessagesNotVisible";

        /// <summary>
        /// The approximate number of messages that are delayed from delivery.
        /// </summary>
        public const string ATTRIBUTE_APPROXIMATE_NUMBER_OF_MESSAGES_DELAYED = "ApproximateNumberOfMessagesDelayed";

        /// <summary>
        /// The time when the queue was created (epoch time in seconds).
        /// </summary>
        public const string ATTRIBUTE_CREATED_TIMESTAMP = "CreatedTimestamp";

        /// <summary>
        /// The time when the queue was last changed (epoch time in seconds).
        /// </summary>
        public const string ATTRIBUTE_LAST_MODIFIED_TIMESTAMP = "LastModifiedTimestamp";

        /// <summary>
        /// The queue's Amazon resource name (ARN).
        /// </summary>
        public const string ATTRIBUTE_QUEUE_ARN = "QueueArn";

        /// <summary>
        /// The limit of how many bytes a message can contain before Amazon SQS rejects it.
        /// </summary>
        public const string ATTRIBUTE_MAXIMUM_MESSAGE_SIZE = "MaximumMessageSize";

        /// <summary>
        /// The number of seconds Amazon SQS retains a message.
        /// </summary>
        public const string ATTRIBUTE_MESSAGE_RETENTION_PERIOD = "MessageRetentionPeriod";

        /// <summary>
        /// The queue's policy.
        /// </summary>
        public const string ATTRIBUTE_POLICY = "Policy";

        /// <summary>
        /// The number of seconds to delay a message from being available to be processed.
        /// </summary>
        public const string ATTRIBUTE_DELAY_SECONDS = "DelaySeconds";

        /// <summary>
        /// The number of milliseconds the oldest message has been on the queue. 
        /// </summary>
        public const string ATTRIBUTE_OLDEST_MESSAGE_AGE = "OldestMessageAge";
    }
}
