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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateKinesisStreamingDestination operation. The
    /// command to update the Kinesis stream destination.
    /// </summary>
    public partial class UpdateKinesisStreamingDestinationRequest : AmazonDynamoDBRequest
    {
        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the Kinesis stream input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 37, Max = 1024)]
        public string StreamArn { get; set; }

        /// <summary>
        /// Checks to see if the StreamArn property is set.
        /// </summary>
        internal bool IsSetStreamArn() => this.StreamArn != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The table name for the Kinesis streaming destination input. You can also provide the
        /// ARN of the table in this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property UpdateKinesisStreamingConfiguration. 
        /// <para>
        /// The command to update the Kinesis stream configuration.
        /// </para>
        /// </summary>
        public UpdateKinesisStreamingConfiguration UpdateKinesisStreamingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the UpdateKinesisStreamingConfiguration property is set.
        /// </summary>
        internal bool IsSetUpdateKinesisStreamingConfiguration() => this.UpdateKinesisStreamingConfiguration != null;
    }
}
