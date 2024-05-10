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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
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
namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// An object that defines an Amazon Kinesis Data Firehose destination for email events.
    /// You can use Amazon Kinesis Data Firehose to stream data to other services, such as
    /// Amazon S3 and Amazon Redshift.
    /// </summary>
    public partial class KinesisFirehoseDestination
    {
        private string _deliveryStreamArn;
        private string _iamRoleArn;

        /// <summary>
        /// Gets and sets the property DeliveryStreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Kinesis Data Firehose stream that Amazon
        /// Pinpoint sends email events to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeliveryStreamArn
        {
            get { return this._deliveryStreamArn; }
            set { this._deliveryStreamArn = value; }
        }

        // Check to see if DeliveryStreamArn property is set
        internal bool IsSetDeliveryStreamArn()
        {
            return this._deliveryStreamArn != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Amazon Pinpoint uses when sending
        /// email events to the Amazon Kinesis Data Firehose stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

    }
}