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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _applicationSuccessFeedbackRoleArn;
        private string _firehoseFailureFeedbackRoleArn;
        private string _firehoseSuccessFeedbackRoleArn;
        private string _httpFailureFeedbackRoleArn;
        private string _httpSuccessFeedbackRoleArn;
        private string _kmsMasterKeyId;
        private string _owner;
        private string _sqsFailureFeedbackRoleArn;
        private string _sqsSuccessFeedbackRoleArn;
        private List<AwsSnsTopicSubscription> _subscription = AWSConfigs.InitializeCollections ? new List<AwsSnsTopicSubscription>() : null;
        private string _topicName;

        /// <summary>
        /// Gets and sets the property ApplicationSuccessFeedbackRoleArn. 
        /// <para>
        /// Indicates failed message delivery status for an Amazon SNS topic that is subscribed
        /// to a platform application endpoint. 
        /// </para>
        /// </summary>
        public string ApplicationSuccessFeedbackRoleArn
        {
            get { return this._applicationSuccessFeedbackRoleArn; }
            set { this._applicationSuccessFeedbackRoleArn = value; }
        }

        // Check to see if ApplicationSuccessFeedbackRoleArn property is set
        internal bool IsSetApplicationSuccessFeedbackRoleArn()
        {
            return this._applicationSuccessFeedbackRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property FirehoseFailureFeedbackRoleArn. 
        /// <para>
        /// Indicates failed message delivery status for an Amazon SNS topic that is subscribed
        /// to an Amazon Kinesis Data Firehose endpoint. 
        /// </para>
        /// </summary>
        public string FirehoseFailureFeedbackRoleArn
        {
            get { return this._firehoseFailureFeedbackRoleArn; }
            set { this._firehoseFailureFeedbackRoleArn = value; }
        }

        // Check to see if FirehoseFailureFeedbackRoleArn property is set
        internal bool IsSetFirehoseFailureFeedbackRoleArn()
        {
            return this._firehoseFailureFeedbackRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property FirehoseSuccessFeedbackRoleArn. 
        /// <para>
        /// Indicates successful message delivery status for an Amazon SNS topic that is subscribed
        /// to an Amazon Kinesis Data Firehose endpoint. 
        /// </para>
        /// </summary>
        public string FirehoseSuccessFeedbackRoleArn
        {
            get { return this._firehoseSuccessFeedbackRoleArn; }
            set { this._firehoseSuccessFeedbackRoleArn = value; }
        }

        // Check to see if FirehoseSuccessFeedbackRoleArn property is set
        internal bool IsSetFirehoseSuccessFeedbackRoleArn()
        {
            return this._firehoseSuccessFeedbackRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property HttpFailureFeedbackRoleArn. 
        /// <para>
        /// Indicates failed message delivery status for an Amazon SNS topic that is subscribed
        /// to an HTTP endpoint. 
        /// </para>
        /// </summary>
        public string HttpFailureFeedbackRoleArn
        {
            get { return this._httpFailureFeedbackRoleArn; }
            set { this._httpFailureFeedbackRoleArn = value; }
        }

        // Check to see if HttpFailureFeedbackRoleArn property is set
        internal bool IsSetHttpFailureFeedbackRoleArn()
        {
            return this._httpFailureFeedbackRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property HttpSuccessFeedbackRoleArn. 
        /// <para>
        /// Indicates successful message delivery status for an Amazon SNS topic that is subscribed
        /// to an HTTP endpoint. 
        /// </para>
        /// </summary>
        public string HttpSuccessFeedbackRoleArn
        {
            get { return this._httpSuccessFeedbackRoleArn; }
            set { this._httpSuccessFeedbackRoleArn = value; }
        }

        // Check to see if HttpSuccessFeedbackRoleArn property is set
        internal bool IsSetHttpSuccessFeedbackRoleArn()
        {
            return this._httpSuccessFeedbackRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsMasterKeyId. 
        /// <para>
        /// The ID of an Amazon Web Services managed key for Amazon SNS or a customer managed
        /// key.
        /// </para>
        /// </summary>
        public string KmsMasterKeyId
        {
            get { return this._kmsMasterKeyId; }
            set { this._kmsMasterKeyId = value; }
        }

        // Check to see if KmsMasterKeyId property is set
        internal bool IsSetKmsMasterKeyId()
        {
            return this._kmsMasterKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The subscription's owner.
        /// </para>
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property SqsFailureFeedbackRoleArn. 
        /// <para>
        /// Indicates failed message delivery status for an Amazon SNS topic that is subscribed
        /// to an Amazon SQS endpoint. 
        /// </para>
        /// </summary>
        public string SqsFailureFeedbackRoleArn
        {
            get { return this._sqsFailureFeedbackRoleArn; }
            set { this._sqsFailureFeedbackRoleArn = value; }
        }

        // Check to see if SqsFailureFeedbackRoleArn property is set
        internal bool IsSetSqsFailureFeedbackRoleArn()
        {
            return this._sqsFailureFeedbackRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SqsSuccessFeedbackRoleArn. 
        /// <para>
        /// Indicates successful message delivery status for an Amazon SNS topic that is subscribed
        /// to an Amazon SQS endpoint. 
        /// </para>
        /// </summary>
        public string SqsSuccessFeedbackRoleArn
        {
            get { return this._sqsSuccessFeedbackRoleArn; }
            set { this._sqsSuccessFeedbackRoleArn = value; }
        }

        // Check to see if SqsSuccessFeedbackRoleArn property is set
        internal bool IsSetSqsSuccessFeedbackRoleArn()
        {
            return this._sqsSuccessFeedbackRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Subscription. 
        /// <para>
        /// Subscription is an embedded property that describes the subscription endpoints of
        /// an Amazon SNS topic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsSnsTopicSubscription> Subscription
        {
            get { return this._subscription; }
            set { this._subscription = value; }
        }

        // Check to see if Subscription property is set
        internal bool IsSetSubscription()
        {
            return this._subscription != null && (this._subscription.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The name of the Amazon SNS topic.
        /// </para>
        /// </summary>
        public string TopicName
        {
            get { return this._topicName; }
            set { this._topicName = value; }
        }

        // Check to see if TopicName property is set
        internal bool IsSetTopicName()
        {
            return this._topicName != null;
        }

    }
}