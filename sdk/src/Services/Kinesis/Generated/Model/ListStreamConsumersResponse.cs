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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// This is the response object from the ListStreamConsumers operation.
    /// </summary>
    public partial class ListStreamConsumersResponse : AmazonWebServiceResponse
    {
        private List<Consumer> _consumers = AWSConfigs.InitializeCollections ? new List<Consumer>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Consumers. 
        /// <para>
        /// An array of JSON objects. Each object represents one registered consumer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Consumer> Consumers
        {
            get { return this._consumers; }
            set { this._consumers = value; }
        }

        // Check to see if Consumers property is set
        internal bool IsSetConsumers()
        {
            return this._consumers != null && (this._consumers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of consumers that are registered with the data stream is greater than
        /// the default value for the <c>MaxResults</c> parameter, or if you explicitly specify
        /// a value for <c>MaxResults</c> that is less than the number of registered consumers,
        /// the response includes a pagination token named <c>NextToken</c>. You can specify this
        /// <c>NextToken</c> value in a subsequent call to <c>ListStreamConsumers</c> to list
        /// the next set of registered consumers. For more information about the use of this pagination
        /// token when calling the <c>ListStreamConsumers</c> operation, see <a>ListStreamConsumersInput$NextToken</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Tokens expire after 300 seconds. When you obtain a value for <c>NextToken</c> in the
        /// response to a call to <c>ListStreamConsumers</c>, you have 300 seconds to use that
        /// value. If you specify an expired token in a call to <c>ListStreamConsumers</c>, you
        /// get <c>ExpiredNextTokenException</c>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=1048576)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}