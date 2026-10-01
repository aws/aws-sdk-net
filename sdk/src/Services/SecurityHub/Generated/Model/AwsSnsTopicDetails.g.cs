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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about an Amazon SNS topic to which notifications can be published.
    /// </summary>
    public partial class AwsSnsTopicDetails
    {
        /// <summary>
        /// Gets and sets the property ApplicationSuccessFeedbackRoleArn. 
        /// <para>
        /// Indicates failed message delivery status for an Amazon SNS topic that is subscribed
        /// to a platform application endpoint. 
        /// </para>
        /// </summary>
        public string ApplicationSuccessFeedbackRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationSuccessFeedbackRoleArn property is set.
        /// </summary>
        internal bool IsSetApplicationSuccessFeedbackRoleArn() => this.ApplicationSuccessFeedbackRoleArn != null;

        /// <summary>
        /// Gets and sets the property FirehoseFailureFeedbackRoleArn. 
        /// <para>
        /// Indicates failed message delivery status for an Amazon SNS topic that is subscribed
        /// to an Amazon Kinesis Data Firehose endpoint. 
        /// </para>
        /// </summary>
        public string FirehoseFailureFeedbackRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the FirehoseFailureFeedbackRoleArn property is set.
        /// </summary>
        internal bool IsSetFirehoseFailureFeedbackRoleArn() => this.FirehoseFailureFeedbackRoleArn != null;

        /// <summary>
        /// Gets and sets the property FirehoseSuccessFeedbackRoleArn. 
        /// <para>
        /// Indicates successful message delivery status for an Amazon SNS topic that is subscribed
        /// to an Amazon Kinesis Data Firehose endpoint. 
        /// </para>
        /// </summary>
        public string FirehoseSuccessFeedbackRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the FirehoseSuccessFeedbackRoleArn property is set.
        /// </summary>
        internal bool IsSetFirehoseSuccessFeedbackRoleArn() => this.FirehoseSuccessFeedbackRoleArn != null;

        /// <summary>
        /// Gets and sets the property HttpFailureFeedbackRoleArn. 
        /// <para>
        /// Indicates failed message delivery status for an Amazon SNS topic that is subscribed
        /// to an HTTP endpoint. 
        /// </para>
        /// </summary>
        public string HttpFailureFeedbackRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the HttpFailureFeedbackRoleArn property is set.
        /// </summary>
        internal bool IsSetHttpFailureFeedbackRoleArn() => this.HttpFailureFeedbackRoleArn != null;

        /// <summary>
        /// Gets and sets the property HttpSuccessFeedbackRoleArn. 
        /// <para>
        /// Indicates successful message delivery status for an Amazon SNS topic that is subscribed
        /// to an HTTP endpoint. 
        /// </para>
        /// </summary>
        public string HttpSuccessFeedbackRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the HttpSuccessFeedbackRoleArn property is set.
        /// </summary>
        internal bool IsSetHttpSuccessFeedbackRoleArn() => this.HttpSuccessFeedbackRoleArn != null;

        /// <summary>
        /// Gets and sets the property KmsMasterKeyId. 
        /// <para>
        /// The ID of an Amazon Web Services managed key for Amazon SNS or a customer managed
        /// key.
        /// </para>
        /// </summary>
        public string KmsMasterKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsMasterKeyId property is set.
        /// </summary>
        internal bool IsSetKmsMasterKeyId() => this.KmsMasterKeyId != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The subscription's owner.
        /// </para>
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property SqsFailureFeedbackRoleArn. 
        /// <para>
        /// Indicates failed message delivery status for an Amazon SNS topic that is subscribed
        /// to an Amazon SQS endpoint. 
        /// </para>
        /// </summary>
        public string SqsFailureFeedbackRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the SqsFailureFeedbackRoleArn property is set.
        /// </summary>
        internal bool IsSetSqsFailureFeedbackRoleArn() => this.SqsFailureFeedbackRoleArn != null;

        /// <summary>
        /// Gets and sets the property SqsSuccessFeedbackRoleArn. 
        /// <para>
        /// Indicates successful message delivery status for an Amazon SNS topic that is subscribed
        /// to an Amazon SQS endpoint. 
        /// </para>
        /// </summary>
        public string SqsSuccessFeedbackRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the SqsSuccessFeedbackRoleArn property is set.
        /// </summary>
        internal bool IsSetSqsSuccessFeedbackRoleArn() => this.SqsSuccessFeedbackRoleArn != null;

        /// <summary>
        /// Gets and sets the property Subscription. 
        /// <para>
        /// Subscription is an embedded property that describes the subscription endpoints of
        /// an Amazon SNS topic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsSnsTopicSubscription> Subscription { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsSnsTopicSubscription>() : null;

        /// <summary>
        /// Checks to see if the Subscription property is set.
        /// </summary>
        internal bool IsSetSubscription() => this.Subscription != null && (this.Subscription.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The name of the Amazon SNS topic.
        /// </para>
        /// </summary>
        public string TopicName { get; set; }

        /// <summary>
        /// Checks to see if the TopicName property is set.
        /// </summary>
        internal bool IsSetTopicName() => this.TopicName != null;
    }
}
