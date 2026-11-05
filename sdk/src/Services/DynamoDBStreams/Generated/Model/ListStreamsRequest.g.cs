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

namespace Amazon.DynamoDBStreams.Model
{
    /// <summary>
    /// Container for the parameters to the ListStreams operation. Returns an array of stream
    /// ARNs associated with the current account and endpoint. If the <c>TableName</c> parameter
    /// is present, then <c>ListStreams</c> will return only the streams ARNs for that table.
    /// <note> <para> You can call <c>ListStreams</c> at a maximum rate of 5 times per second.
    /// </para> </note>
    /// </summary>
    public partial class ListStreamsRequest : AmazonDynamoDBStreamsRequest
    {
        /// <summary>
        /// Gets and sets the property ExclusiveStartStreamArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the first item that this operation will evaluate.
        /// Use the value that was returned for <c>LastEvaluatedStreamArn</c> in the previous
        /// operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 37, Max = 1024)]
        public string ExclusiveStartStreamArn { get; set; }

        /// <summary>
        /// Checks to see if the ExclusiveStartStreamArn property is set.
        /// </summary>
        internal bool IsSetExclusiveStartStreamArn() => this.ExclusiveStartStreamArn != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of streams to return. The upper limit is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// If this parameter is provided, then only the streams associated with this table name
        /// are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
