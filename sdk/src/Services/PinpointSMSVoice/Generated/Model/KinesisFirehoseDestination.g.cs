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

namespace Amazon.PinpointSMSVoice.Model
{
    /// <summary>
    /// An object that contains information about an event destination that sends data to
    /// Amazon Kinesis Data Firehose.
    /// </summary>
    public partial class KinesisFirehoseDestination
    {
        /// <summary>
        /// Gets and sets the property DeliveryStreamArn. The Amazon Resource Name (ARN) of an
        /// IAM role that can write data to an Amazon Kinesis Data Firehose stream.
        /// </summary>
        public string DeliveryStreamArn { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStreamArn property is set.
        /// </summary>
        internal bool IsSetDeliveryStreamArn() => this.DeliveryStreamArn != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. The Amazon Resource Name (ARN) of the Amazon
        /// Kinesis Data Firehose destination that you want to use in the event destination.
        /// </summary>
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;
    }
}
