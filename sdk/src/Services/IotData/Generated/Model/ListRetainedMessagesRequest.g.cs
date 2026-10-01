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

namespace Amazon.IotData.Model
{
    /// <summary>
    /// Container for the parameters to the ListRetainedMessages operation. Lists summary
    /// information about the retained messages stored for the account. <para> This action
    /// returns only the topic names of the retained messages. It doesn't return any message
    /// payloads. Although this action doesn't return a message payload, it can still incur
    /// messaging costs. </para> <para> To get the message payload of a retained message,
    /// call <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_iotdata_GetRetainedMessage.html">GetRetainedMessage</a>
    /// with the topic name of the retained message. </para> <para> Requires permission to
    /// access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html">ListRetainedMessages</a>
    /// action. </para> <para> For more information about messaging costs, see <a href="http://aws.amazon.com/iot-core/pricing/#Messaging">Amazon
    /// Web Services IoT Core pricing - Messaging</a>. </para>
    /// </summary>
    public partial class ListRetainedMessagesRequest : AmazonIotDataRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return at one time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// To retrieve the next set of results, the <c>nextToken</c> value from a previous response;
        /// otherwise <b>null</b> to receive the first set of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
