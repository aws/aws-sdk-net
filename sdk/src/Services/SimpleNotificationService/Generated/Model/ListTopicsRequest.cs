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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
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
namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the ListTopics operation.
    /// Returns a list of the requester's topics. Each call returns a limited list of topics,
    /// up to 100. If there are more topics, a <c>NextToken</c> is also returned. Use the
    /// <c>NextToken</c> parameter in a new <c>ListTopics</c> call to get further results.
    /// 
    ///  
    /// <para>
    /// This action is throttled at 30 transactions per second (TPS).
    /// </para>
    /// </summary>
    public partial class ListTopicsRequest : AmazonSimpleNotificationServiceRequest
    {
        private string _nextToken;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ListTopicsRequest() { }

        /// <summary>
        /// Instantiates ListTopicsRequest with the parameterized properties
        /// </summary>
        /// <param name="nextToken">Token returned by the previous <c>ListTopics</c> request.</param>
        public ListTopicsRequest(string nextToken)
        {
            _nextToken = nextToken;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token returned by the previous <c>ListTopics</c> request.
        /// </para>
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