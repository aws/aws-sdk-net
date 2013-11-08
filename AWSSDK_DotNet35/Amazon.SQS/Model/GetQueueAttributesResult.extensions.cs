/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.SQS.Util;
using Amazon.Util;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Get Queue Attributes Result
    /// </summary>
    public partial class GetQueueAttributesResult
    {
        /// <summary>
        /// Gets the visibility timeout from the Attributes collection.
        /// </summary>
        public int VisibilityTimeout
        {
            get
            {
                int value;
                if (!int.TryParse(getAttributeValue(SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT), out value))
                    value = 0;
                return value;
            }
        }

        /// <summary>
        /// Gets the delay in seconds from the Attributes collection.
        /// </summary>
        public int DelaySeconds
        {
            get
            {
                int value;
                if (!int.TryParse(getAttributeValue(SQSConstants.ATTRIBUTE_DELAY_SECONDS), out value))
                    value = 0;
                return value;
            }
        }

        /// <summary>
        /// Gets the maximum message size from the Attributes collection.
        /// </summary>
        public int MaximumMessageSize
        {
            get
            {
                int value;
                if (!int.TryParse(getAttributeValue(SQSConstants.ATTRIBUTE_MAXIMUM_MESSAGE_SIZE), out value))
                    value = 0;
                return value;
            }
        }

        /// <summary>
        /// Returns the message retention period from the Attributes collection.
        /// </summary>
        public int MessageRetentionPeriod
        {
            get
            {
                int value;
                if (!int.TryParse(getAttributeValue(SQSConstants.ATTRIBUTE_MESSAGE_RETENTION_PERIOD), out value))
                    value = 0;
                return value;
            }
        }


        /// <summary>
        /// Gets the approximate number of messages from the Attributes collection.
        /// </summary>
        public int ApproximateNumberOfMessages
        {
            get
            {
                int value;
                if (!int.TryParse(getAttributeValue(SQSConstants.ATTRIBUTE_APPROXIMATE_NUMBER_OF_MESSAGES), out value))
                    value = 0;
                return value;
            }
        }

        /// <summary>
        /// Gets the approximate number of messages not visible from the Attributes collection.
        /// </summary>
        public int ApproximateNumberOfMessagesNotVisible
        {
            get
            {
                int value;
                if (!int.TryParse(getAttributeValue(SQSConstants.ATTRIBUTE_APPROXIMATE_NUMBER_OF_MESSAGES_NOT_VISIBLE), out value))
                    value = 0;
                return value;
            }
        }

        /// <summary>
        /// Gets the approximate number of messages delayed from the Attributes collection.
        /// </summary>
        public int ApproximateNumberOfMessagesDelayed
        {
            get
            {
                int value;
                if (!int.TryParse(getAttributeValue(SQSConstants.ATTRIBUTE_APPROXIMATE_NUMBER_OF_MESSAGES_DELAYED), out value))
                    value = 0;
                return value;
            }
        }

        /// <summary>
        /// Gets the created timestamp from the Attributes collection.
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get
            {
                int value;
                if (!int.TryParse(getAttributeValue(SQSConstants.ATTRIBUTE_CREATED_TIMESTAMP), out value))
                    value = 0;
                return AWSSDKUtils.ConvertFromUnixEpochSeconds(value);
            }
        }

        /// <summary>
        /// Gets the last modified timestamp from the Attributes collection.
        /// </summary>
        public DateTime LastModifiedTimestamp
        {
            get
            {
                int value;
                if (!int.TryParse(getAttributeValue(SQSConstants.ATTRIBUTE_LAST_MODIFIED_TIMESTAMP), out value))
                    value = 0;
                return AWSSDKUtils.ConvertFromUnixEpochSeconds(value);
            }
        }

        /// <summary>
        /// Gets the queue arn from the Attributes collection.
        /// </summary>
        public string QueueARN
        {
            get
            {
                return getAttributeValue(SQSConstants.ATTRIBUTE_QUEUE_ARN);
            }
        }

        /// <summary>
        /// Gets the queue access policy from the Attributes collection.
        /// </summary>
        public string Policy
        {
            get
            {
                return getAttributeValue(SQSConstants.ATTRIBUTE_POLICY);
            }
        }

        private string getAttributeValue(string field)
        {
            string value = null;
            this.attributes.TryGetValue(field, out value);
            return value;
        }
    }
}
