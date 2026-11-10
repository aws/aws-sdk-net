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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// A single destination that receives game session placement insight logs for a game
    /// session queue.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon CloudWatch Logs vended log charges apply to each destination. Amazon S3 and
    /// Amazon Data Firehose destinations also incur their own service charges. For more information,
    /// see <a href="http://aws.amazon.com/cloudwatch/pricing/">Amazon CloudWatch Pricing</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class LogDeliveryDestination
    {
        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource that receives the game session placement
        /// insight logs. This resource must match the type that you specify in <c>LogDestination</c>.
        /// This value is required for <c>FIREHOSE</c> destinations. For <c>CLOUDWATCH</c> and
        /// <c>S3</c>, you can omit this value; Amazon GameLift Servers then creates a destination
        /// resource of the specified type on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string DestinationArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationArn property is set.
        /// </summary>
        internal bool IsSetDestinationArn() => this.DestinationArn != null;

        /// <summary>
        /// Gets and sets the property LogDestination. 
        /// <para>
        /// The type of Amazon Web Services resource that receives the game session placement
        /// insight logs. This value is required. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CLOUDWATCH</c> -- an Amazon CloudWatch Logs log group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3</c> -- an Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FIREHOSE</c> -- an Amazon Data Firehose delivery stream.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public LogDeliveryDestinationType LogDestination { get; set; }

        /// <summary>
        /// Checks to see if the LogDestination property is set.
        /// </summary>
        internal bool IsSetLogDestination() => this.LogDestination != null;
    }
}
