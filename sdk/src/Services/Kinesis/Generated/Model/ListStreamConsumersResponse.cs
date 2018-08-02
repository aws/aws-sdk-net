/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// This is the response object from the ListStreamConsumers operation.
    /// </summary>
    public partial class ListStreamConsumersResponse : AmazonWebServiceResponse
    {
        private List<Consumer> _consumers = new List<Consumer>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Consumers. 
        /// <para>
        /// An array of JSON objects. Each object represents one registered consumer.
        /// </para>
        /// </summary>
        public List<Consumer> Consumers
        {
            get { return this._consumers; }
            set { this._consumers = value; }
        }

        // Check to see if Consumers property is set
        internal bool IsSetConsumers()
        {
            return this._consumers != null && this._consumers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of consumers that are registered with the data stream is greater than
        /// the default value for the <code>MaxResults</code> parameter, or if you explicitly
        /// specify a value for <code>MaxResults</code> that is less than the number of registered
        /// consumers, the response includes a pagination token named <code>NextToken</code>.
        /// You can specify this <code>NextToken</code> value in a subsequent call to <code>ListStreamConsumers</code>
        /// to list the next set of registered consumers. For more information about the use of
        /// this pagination token when calling the <code>ListStreamConsumers</code> operation,
        /// see <a>ListStreamConsumersInput$NextToken</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Tokens expire after 300 seconds. When you obtain a value for <code>NextToken</code>
        /// in the response to a call to <code>ListStreamConsumers</code>, you have 300 seconds
        /// to use that value. If you specify an expired token in a call to <code>ListStreamConsumers</code>,
        /// you get <code>ExpiredNextTokenException</code>.
        /// </para>
        ///  </important>
        /// </summary>
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