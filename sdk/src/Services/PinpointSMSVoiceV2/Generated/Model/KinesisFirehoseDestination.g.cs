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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Contains the delivery stream Amazon Resource Name (ARN), and the ARN of the Identity
    /// and Access Management (IAM) role associated with a Firehose event destination.
    /// 
    ///  
    /// <para>
    /// Event destinations, such as Firehose, are associated with configuration sets, which
    /// enable you to publish message sending events.
    /// </para>
    /// </summary>
    public partial class KinesisFirehoseDestination
    {
        /// <summary>
        /// Gets and sets the property DeliveryStreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the delivery stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string DeliveryStreamArn { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStreamArn property is set.
        /// </summary>
        internal bool IsSetDeliveryStreamArn() => this.DeliveryStreamArn != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of an Identity and Access Management role that is able to write event data
        /// to an Amazon Data Firehose destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;
    }
}
