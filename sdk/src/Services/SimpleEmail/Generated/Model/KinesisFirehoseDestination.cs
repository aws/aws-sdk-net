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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Contains the delivery stream ARN and the IAM role ARN associated with an Amazon Kinesis
    /// Firehose event destination.
    /// 
    ///  
    /// <para>
    /// Event destinations, such as Amazon Kinesis Firehose, are associated with configuration
    /// sets, which enable you to publish email sending events. For information about using
    /// configuration sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class KinesisFirehoseDestination
    {
        private string _deliveryStreamARN;
        private string _iamRoleARN;

        /// <summary>
        /// Gets and sets the property DeliveryStreamARN. 
        /// <para>
        /// The ARN of the Amazon Kinesis Firehose stream that email sending events should be
        /// published to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeliveryStreamARN
        {
            get { return this._deliveryStreamARN; }
            set { this._deliveryStreamARN = value; }
        }

        // Check to see if DeliveryStreamARN property is set
        internal bool IsSetDeliveryStreamARN()
        {
            return this._deliveryStreamARN != null;
        }

        /// <summary>
        /// Gets and sets the property IAMRoleARN. 
        /// <para>
        /// The ARN of the IAM role under which Amazon SES publishes email sending events to the
        /// Amazon Kinesis Firehose stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IAMRoleARN
        {
            get { return this._iamRoleARN; }
            set { this._iamRoleARN = value; }
        }

        // Check to see if IAMRoleARN property is set
        internal bool IsSetIAMRoleARN()
        {
            return this._iamRoleARN != null;
        }

    }
}