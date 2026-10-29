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
    /// This is the response object from the ListStreams operation.
    /// </summary>
    public partial class ListStreamsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property LastEvaluatedStreamArn. 
        /// <para>
        /// The stream ARN of the item where the operation stopped, inclusive of the previous
        /// result set. Use this value to start a new operation, excluding this value in the new
        /// request.
        /// </para>
        ///  
        /// <para>
        /// If <c>LastEvaluatedStreamArn</c> is empty, then the "last page" of results has been
        /// processed and there is no more data to be retrieved.
        /// </para>
        ///  
        /// <para>
        /// If <c>LastEvaluatedStreamArn</c> is not empty, it does not necessarily mean that there
        /// is more data in the result set. The only way to know when you have reached the end
        /// of the result set is when <c>LastEvaluatedStreamArn</c> is empty.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 37, Max = 1024)]
        public string LastEvaluatedStreamArn { get; set; }

        /// <summary>
        /// Checks to see if the LastEvaluatedStreamArn property is set.
        /// </summary>
        internal bool IsSetLastEvaluatedStreamArn() => this.LastEvaluatedStreamArn != null;

        /// <summary>
        /// Gets and sets the property Streams. 
        /// <para>
        /// A list of stream descriptors associated with the current account and endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StreamSummary> Streams { get; set; } = AWSConfigs.InitializeCollections ? new List<StreamSummary>() : null;

        /// <summary>
        /// Checks to see if the Streams property is set.
        /// </summary>
        internal bool IsSetStreams() => this.Streams != null && (this.Streams.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
