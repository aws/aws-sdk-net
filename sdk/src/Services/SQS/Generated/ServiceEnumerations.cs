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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SQS
{

    /// <summary>
    /// Constants used for properties of type MessageSystemAttributeName.
    /// </summary>
    public class MessageSystemAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant All for MessageSystemAttributeName
        /// </summary>
        public static readonly MessageSystemAttributeName All = new MessageSystemAttributeName("All");
        /// <summary>
        /// Constant ApproximateFirstReceiveTimestamp for MessageSystemAttributeName
        /// </summary>
        public static readonly MessageSystemAttributeName ApproximateFirstReceiveTimestamp = new MessageSystemAttributeName("ApproximateFirstReceiveTimestamp");
        /// <summary>
        /// Constant ApproximateReceiveCount for MessageSystemAttributeName
        /// </summary>
        public static readonly MessageSystemAttributeName ApproximateReceiveCount = new MessageSystemAttributeName("ApproximateReceiveCount");
        /// <summary>
        /// Constant AWSTraceHeader for MessageSystemAttributeName
        /// </summary>
        public static readonly MessageSystemAttributeName AWSTraceHeader = new MessageSystemAttributeName("AWSTraceHeader");
        /// <summary>
        /// Constant DeadLetterQueueSourceArn for MessageSystemAttributeName
        /// </summary>
        public static readonly MessageSystemAttributeName DeadLetterQueueSourceArn = new MessageSystemAttributeName("DeadLetterQueueSourceArn");
        /// <summary>
        /// Constant MessageDeduplicationId for MessageSystemAttributeName
        /// </summary>
        public static readonly MessageSystemAttributeName MessageDeduplicationId = new MessageSystemAttributeName("MessageDeduplicationId");
        /// <summary>
        /// Constant MessageGroupId for MessageSystemAttributeName
        /// </summary>
        public static readonly MessageSystemAttributeName MessageGroupId = new MessageSystemAttributeName("MessageGroupId");
        /// <summary>
        /// Constant SenderId for MessageSystemAttributeName
        /// </summary>
        public static readonly MessageSystemAttributeName SenderId = new MessageSystemAttributeName("SenderId");
        /// <summary>
        /// Constant SentTimestamp for MessageSystemAttributeName
        /// </summary>
        public static readonly MessageSystemAttributeName SentTimestamp = new MessageSystemAttributeName("SentTimestamp");
        /// <summary>
        /// Constant SequenceNumber for MessageSystemAttributeName
        /// </summary>
        public static readonly MessageSystemAttributeName SequenceNumber = new MessageSystemAttributeName("SequenceNumber");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageSystemAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageSystemAttributeName FindValue(string value)
        {
            return FindValue<MessageSystemAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageSystemAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageSystemAttributeNameForSends.
    /// </summary>
    public class MessageSystemAttributeNameForSends : ConstantClass
    {

        /// <summary>
        /// Constant AWSTraceHeader for MessageSystemAttributeNameForSends
        /// </summary>
        public static readonly MessageSystemAttributeNameForSends AWSTraceHeader = new MessageSystemAttributeNameForSends("AWSTraceHeader");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageSystemAttributeNameForSends(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageSystemAttributeNameForSends FindValue(string value)
        {
            return FindValue<MessageSystemAttributeNameForSends>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageSystemAttributeNameForSends(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueueAttributeName.
    /// </summary>
    public class QueueAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant All for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName All = new QueueAttributeName("All");
        /// <summary>
        /// Constant ApproximateNumberOfMessages for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName ApproximateNumberOfMessages = new QueueAttributeName("ApproximateNumberOfMessages");
        /// <summary>
        /// Constant ApproximateNumberOfMessagesDelayed for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName ApproximateNumberOfMessagesDelayed = new QueueAttributeName("ApproximateNumberOfMessagesDelayed");
        /// <summary>
        /// Constant ApproximateNumberOfMessagesNotVisible for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName ApproximateNumberOfMessagesNotVisible = new QueueAttributeName("ApproximateNumberOfMessagesNotVisible");
        /// <summary>
        /// Constant ContentBasedDeduplication for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName ContentBasedDeduplication = new QueueAttributeName("ContentBasedDeduplication");
        /// <summary>
        /// Constant CreatedTimestamp for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName CreatedTimestamp = new QueueAttributeName("CreatedTimestamp");
        /// <summary>
        /// Constant DeduplicationScope for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName DeduplicationScope = new QueueAttributeName("DeduplicationScope");
        /// <summary>
        /// Constant DelaySeconds for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName DelaySeconds = new QueueAttributeName("DelaySeconds");
        /// <summary>
        /// Constant FifoQueue for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName FifoQueue = new QueueAttributeName("FifoQueue");
        /// <summary>
        /// Constant FifoThroughputLimit for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName FifoThroughputLimit = new QueueAttributeName("FifoThroughputLimit");
        /// <summary>
        /// Constant KmsDataKeyReusePeriodSeconds for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName KmsDataKeyReusePeriodSeconds = new QueueAttributeName("KmsDataKeyReusePeriodSeconds");
        /// <summary>
        /// Constant KmsMasterKeyId for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName KmsMasterKeyId = new QueueAttributeName("KmsMasterKeyId");
        /// <summary>
        /// Constant LastModifiedTimestamp for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName LastModifiedTimestamp = new QueueAttributeName("LastModifiedTimestamp");
        /// <summary>
        /// Constant MaximumMessageSize for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName MaximumMessageSize = new QueueAttributeName("MaximumMessageSize");
        /// <summary>
        /// Constant MessageRetentionPeriod for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName MessageRetentionPeriod = new QueueAttributeName("MessageRetentionPeriod");
        /// <summary>
        /// Constant Policy for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName Policy = new QueueAttributeName("Policy");
        /// <summary>
        /// Constant QueueArn for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName QueueArn = new QueueAttributeName("QueueArn");
        /// <summary>
        /// Constant ReceiveMessageWaitTimeSeconds for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName ReceiveMessageWaitTimeSeconds = new QueueAttributeName("ReceiveMessageWaitTimeSeconds");
        /// <summary>
        /// Constant RedriveAllowPolicy for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName RedriveAllowPolicy = new QueueAttributeName("RedriveAllowPolicy");
        /// <summary>
        /// Constant RedrivePolicy for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName RedrivePolicy = new QueueAttributeName("RedrivePolicy");
        /// <summary>
        /// Constant SqsManagedSseEnabled for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName SqsManagedSseEnabled = new QueueAttributeName("SqsManagedSseEnabled");
        /// <summary>
        /// Constant VisibilityTimeout for QueueAttributeName
        /// </summary>
        public static readonly QueueAttributeName VisibilityTimeout = new QueueAttributeName("VisibilityTimeout");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueueAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueueAttributeName FindValue(string value)
        {
            return FindValue<QueueAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueueAttributeName(string value)
        {
            return FindValue(value);
        }
    }

}