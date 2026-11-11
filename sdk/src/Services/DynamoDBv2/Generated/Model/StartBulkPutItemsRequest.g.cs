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
    /// Container for the parameters to the StartBulkPutItems operation. Starts an asynchronous
    /// bulk operation that reads items from Amazon S3 and writes them to an existing DynamoDB
    /// table, so you can efficiently load or migrate large datasets.
    /// </summary>
    public partial class StartBulkPutItemsRequest : AmazonDynamoDBRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that ensures the bulk operation starts no more
        /// than one time. During the 8 hours after the initial request, repeated requests that
        /// use the same token and parameters return the same bulk operation. If a request reuses
        /// the token with different parameters, DynamoDB returns an <c>IdempotentParameterMismatchException</c>.
        /// If you omit the token, an Amazon Web Services SDK automatically generates one.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property InputS3Configuration. 
        /// <para>
        /// The Amazon S3 location, data format, and compression settings for the input objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InputS3Configuration InputS3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the InputS3Configuration property is set.
        /// </summary>
        internal bool IsSetInputS3Configuration() => this.InputS3Configuration != null;

        /// <summary>
        /// Gets and sets the property MaxWriteRequestUnits. 
        /// <para>
        /// The maximum rate, in write request units per second, at which the bulk operation attempts
        /// to write. The value must be at least 1,024. With this setting, you limit only the
        /// bulk operation; the table's provisioned or on-demand capacity settings don't change.
        /// The actual write rate can be lower.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1024)]
        public long? MaxWriteRequestUnits { get; set; }

        /// <summary>
        /// Checks to see if the MaxWriteRequestUnits property is set.
        /// </summary>
        internal bool IsSetMaxWriteRequestUnits() => this.MaxWriteRequestUnits.HasValue;

        /// <summary>
        /// Gets and sets the property OutputS3Configuration. 
        /// <para>
        /// The Amazon S3 location, encryption settings, and output types for the bulk operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputS3Configuration OutputS3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3Configuration property is set.
        /// </summary>
        internal bool IsSetOutputS3Configuration() => this.OutputS3Configuration != null;

        /// <summary>
        /// Gets and sets the property PerformanceTier. 
        /// <para>
        /// The performance tier for the bulk operation. Valid values are <c>STANDARD</c> and
        /// <c>ACCELERATED</c>. If you don't specify a value, the operation uses <c>STANDARD</c>.
        /// </para>
        /// </summary>
        public BulkOperationPerformanceTier PerformanceTier { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceTier property is set.
        /// </summary>
        internal bool IsSetPerformanceTier() => this.PerformanceTier != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name or ARN of the existing DynamoDB table that receives the items.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
