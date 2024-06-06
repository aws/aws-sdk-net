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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
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
namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the SetSubscriptionAttributes operation.
    /// Allows a subscription owner to set an attribute of the subscription to a new value.
    /// </summary>
    public partial class SetSubscriptionAttributesRequest : AmazonSimpleNotificationServiceRequest
    {
        private string _attributeName;
        private string _attributeValue;
        private string _subscriptionArn;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SetSubscriptionAttributesRequest() { }

        /// <summary>
        /// Instantiates SetSubscriptionAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="subscriptionArn">The ARN of the subscription to modify.</param>
        /// <param name="attributeName">A map of attributes with their corresponding values. The following lists the names, descriptions, and values of the special request parameters that this action uses: <ul> <li>  <c>DeliveryPolicy</c> – The policy that defines how Amazon SNS retries failed deliveries to HTTP/S endpoints. </li> <li>  <c>FilterPolicy</c> – The simple JSON object that lets your subscriber receive only a subset of messages, rather than receiving every message published to the topic. </li> <li>  <c>FilterPolicyScope</c> – This attribute lets you choose the filtering scope by using one of the following string value types: <ul> <li>  <c>MessageAttributes</c> (default) – The filter is applied on the message attributes. </li> <li>  <c>MessageBody</c> – The filter is applied on the message body. </li> </ul> </li> <li>  <c>RawMessageDelivery</c> – When set to <c>true</c>, enables raw message delivery to Amazon SQS or HTTP/S endpoints. This eliminates the need for the endpoints to process JSON formatting, which is otherwise created for Amazon SNS metadata. </li> <li>  <c>RedrivePolicy</c> – When specified, sends undeliverable messages to the specified Amazon SQS dead-letter queue. Messages that can't be delivered due to client errors (for example, when the subscribed endpoint is unreachable) or server errors (for example, when the service that powers the subscribed endpoint becomes unavailable) are held in the dead-letter queue for further analysis or reprocessing. </li> </ul> The following attribute applies only to Amazon Data Firehose delivery stream subscriptions: <ul> <li>  <c>SubscriptionRoleArn</c> – The ARN of the IAM role that has the following: <ul> <li> Permission to write to the Firehose delivery stream </li> <li> Amazon SNS listed as a trusted entity </li> </ul> Specifying a valid ARN for this attribute is required for Firehose delivery stream subscriptions. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-firehose-as-subscriber.html">Fanout to Firehose delivery streams</a> in the <i>Amazon SNS Developer Guide</i>. </li> </ul></param>
        /// <param name="attributeValue">The new value for the attribute in JSON format.</param>
        public SetSubscriptionAttributesRequest(string subscriptionArn, string attributeName, string attributeValue)
        {
            _subscriptionArn = subscriptionArn;
            _attributeName = attributeName;
            _attributeValue = attributeValue;
        }

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// A map of attributes with their corresponding values.
        /// </para>
        ///  
        /// <para>
        /// The following lists the names, descriptions, and values of the special request parameters
        /// that this action uses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DeliveryPolicy</c> – The policy that defines how Amazon SNS retries failed deliveries
        /// to HTTP/S endpoints.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FilterPolicy</c> – The simple JSON object that lets your subscriber receive only
        /// a subset of messages, rather than receiving every message published to the topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FilterPolicyScope</c> – This attribute lets you choose the filtering scope by
        /// using one of the following string value types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MessageAttributes</c> (default) – The filter is applied on the message attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MessageBody</c> – The filter is applied on the message body.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>RawMessageDelivery</c> – When set to <c>true</c>, enables raw message delivery
        /// to Amazon SQS or HTTP/S endpoints. This eliminates the need for the endpoints to process
        /// JSON formatting, which is otherwise created for Amazon SNS metadata.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RedrivePolicy</c> – When specified, sends undeliverable messages to the specified
        /// Amazon SQS dead-letter queue. Messages that can't be delivered due to client errors
        /// (for example, when the subscribed endpoint is unreachable) or server errors (for example,
        /// when the service that powers the subscribed endpoint becomes unavailable) are held
        /// in the dead-letter queue for further analysis or reprocessing.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attribute applies only to Amazon Data Firehose delivery stream subscriptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SubscriptionRoleArn</c> – The ARN of the IAM role that has the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Permission to write to the Firehose delivery stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SNS listed as a trusted entity
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Specifying a valid ARN for this attribute is required for Firehose delivery stream
        /// subscriptions. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-firehose-as-subscriber.html">Fanout
        /// to Firehose delivery streams</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeValue. 
        /// <para>
        /// The new value for the attribute in JSON format.
        /// </para>
        /// </summary>
        public string AttributeValue
        {
            get { return this._attributeValue; }
            set { this._attributeValue = value; }
        }

        // Check to see if AttributeValue property is set
        internal bool IsSetAttributeValue()
        {
            return this._attributeValue != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionArn. 
        /// <para>
        /// The ARN of the subscription to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubscriptionArn
        {
            get { return this._subscriptionArn; }
            set { this._subscriptionArn = value; }
        }

        // Check to see if SubscriptionArn property is set
        internal bool IsSetSubscriptionArn()
        {
            return this._subscriptionArn != null;
        }

    }
}