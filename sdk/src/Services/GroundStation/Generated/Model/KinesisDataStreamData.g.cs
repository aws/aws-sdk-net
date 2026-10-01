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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Information for telemetry delivery to Kinesis Data Streams.
    /// </summary>
    public partial class KinesisDataStreamData
    {
        /// <summary>
        /// Gets and sets the property KinesisDataStreamArn. 
        /// <para>
        /// ARN of the Kinesis Data Stream to deliver telemetry to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 37, Max = 275)]
        public string KinesisDataStreamArn { get; set; }

        /// <summary>
        /// Checks to see if the KinesisDataStreamArn property is set.
        /// </summary>
        internal bool IsSetKinesisDataStreamArn() => this.KinesisDataStreamArn != null;

        /// <summary>
        /// Gets and sets the property KinesisRoleArn. 
        /// <para>
        /// ARN of the IAM Role used by AWS Ground Station to deliver telemetry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 30, Max = 165)]
        public string KinesisRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the KinesisRoleArn property is set.
        /// </summary>
        internal bool IsSetKinesisRoleArn() => this.KinesisRoleArn != null;
    }
}
