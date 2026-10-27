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
    /// This is the response object from the UpdateKinesisStreamingDestination operation.
    /// </summary>
    public partial class UpdateKinesisStreamingDestinationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DestinationStatus. 
        /// <para>
        /// The status of the attempt to update the Kinesis streaming destination output.
        /// </para>
        /// </summary>
        public DestinationStatus DestinationStatus { get; set; }

        /// <summary>
        /// Checks to see if the DestinationStatus property is set.
        /// </summary>
        internal bool IsSetDestinationStatus() => this.DestinationStatus != null;

        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The ARN for the Kinesis stream input.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 37, Max = 1024)]
        public string StreamArn { get; set; }

        /// <summary>
        /// Checks to see if the StreamArn property is set.
        /// </summary>
        internal bool IsSetStreamArn() => this.StreamArn != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The table name for the Kinesis streaming destination output.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property UpdateKinesisStreamingConfiguration. 
        /// <para>
        /// The command to update the Kinesis streaming destination configuration.
        /// </para>
        /// </summary>
        public UpdateKinesisStreamingConfiguration UpdateKinesisStreamingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the UpdateKinesisStreamingConfiguration property is set.
        /// </summary>
        internal bool IsSetUpdateKinesisStreamingConfiguration() => this.UpdateKinesisStreamingConfiguration != null;
    }
}
