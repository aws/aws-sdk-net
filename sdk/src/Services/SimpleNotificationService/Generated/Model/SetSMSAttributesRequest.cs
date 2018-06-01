/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the SetSMSAttributes operation.
    /// Use this request to set the default settings for sending SMS messages and receiving
    /// daily SMS usage reports.
    /// 
    ///  
    /// <para>
    /// You can override some of these settings for a single message when you use the <code>Publish</code>
    /// action with the <code>MessageAttributes.entry.N</code> parameter. For more information,
    /// see <a href="http://docs.aws.amazon.com/sns/latest/dg/sms_publish-to-phone.html">Sending
    /// an SMS Message</a> in the <i>Amazon SNS Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class SetSMSAttributesRequest : AmazonSimpleNotificationServiceRequest
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The default settings for sending SMS messages from your account. You can set values
        /// for the following attribute names:
        /// </para>
        ///  
        /// <para>
        ///  <code>MonthlySpendLimit</code> – The maximum amount in USD that you are willing to
        /// spend each month to send SMS messages. When Amazon SNS determines that sending an
        /// SMS message would incur a cost that exceeds this limit, it stops sending SMS messages
        /// within minutes.
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon SNS stops sending SMS messages within minutes of the limit being crossed. During
        /// that interval, if you continue to send SMS messages, you will incur costs that exceed
        /// your limit.
        /// </para>
        ///  </important> 
        /// <para>
        /// By default, the spend limit is set to the maximum allowed by Amazon SNS. If you want
        /// to raise the limit, submit an <a href="https://console.aws.amazon.com/support/home#/case/create?issueType=service-limit-increase&amp;limitType=service-code-sns">SNS
        /// Limit Increase case</a>. For <b>New limit value</b>, enter your desired monthly spend
        /// limit. In the <b>Use Case Description</b> field, explain that you are requesting an
        /// SMS monthly spend limit increase.
        /// </para>
        ///  
        /// <para>
        ///  <code>DeliveryStatusIAMRole</code> – The ARN of the IAM role that allows Amazon SNS
        /// to write logs about SMS deliveries in CloudWatch Logs. For each SMS message that you
        /// send, Amazon SNS writes a log that includes the message price, the success or failure
        /// status, the reason for failure (if the message failed), the message dwell time, and
        /// other information.
        /// </para>
        ///  
        /// <para>
        ///  <code>DeliveryStatusSuccessSamplingRate</code> – The percentage of successful SMS
        /// deliveries for which Amazon SNS will write logs in CloudWatch Logs. The value can
        /// be an integer from 0 - 100. For example, to write logs only for failed deliveries,
        /// set this value to <code>0</code>. To write logs for 10% of your successful deliveries,
        /// set it to <code>10</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>DefaultSenderID</code> – A string, such as your business brand, that is displayed
        /// as the sender on the receiving device. Support for sender IDs varies by country. The
        /// sender ID can be 1 - 11 alphanumeric characters, and it must contain at least one
        /// letter.
        /// </para>
        ///  
        /// <para>
        ///  <code>DefaultSMSType</code> – The type of SMS message that you will send by default.
        /// You can assign the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Promotional</code> – (Default) Noncritical messages, such as marketing messages.
        /// Amazon SNS optimizes the message delivery to incur the lowest cost.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Transactional</code> – Critical messages that support customer transactions,
        /// such as one-time passcodes for multi-factor authentication. Amazon SNS optimizes the
        /// message delivery to achieve the highest reliability.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>UsageReportS3Bucket</code> – The name of the Amazon S3 bucket to receive daily
        /// SMS usage reports from Amazon SNS. Each day, Amazon SNS will deliver a usage report
        /// as a CSV file to the bucket. The report includes the following information for each
        /// SMS message that was successfully delivered by your account:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Time that the message was published (in UTC)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Destination phone number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message type
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delivery status
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message price (in USD)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Part number (a message is split into multiple parts if it is too long for a single
        /// message)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Total number of parts
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To receive the report, the bucket must have a policy that allows the Amazon SNS service
        /// principle to perform the <code>s3:PutObject</code> and <code>s3:GetBucketLocation</code>
        /// actions.
        /// </para>
        ///  
        /// <para>
        /// For an example bucket policy and usage report, see <a href="http://docs.aws.amazon.com/sns/latest/dg/sms_stats.html">Monitoring
        /// SMS Activity</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

    }
}