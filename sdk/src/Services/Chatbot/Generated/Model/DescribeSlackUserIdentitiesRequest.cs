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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
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
namespace Amazon.Chatbot.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSlackUserIdentities operation.
    /// Lists all Slack user identities with a mapped role.
    /// </summary>
    public partial class DescribeSlackUserIdentitiesRequest : AmazonChatbotRequest
    {
        private string _chatConfigurationArn;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ChatConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SlackChannelConfiguration associated with the
        /// user identities to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=1169)]
        public string ChatConfigurationArn
        {
            get { return this._chatConfigurationArn; }
            set { this._chatConfigurationArn = value; }
        }

        // Check to see if ChatConfigurationArn property is set
        internal bool IsSetChatConfigurationArn()
        {
            return this._chatConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to include in the response. If more results exist than
        /// the specified MaxResults value, a token is included in the response so that the remaining
        /// results can be retrieved. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  An optional token returned from a prior request. Use this token for pagination of
        /// results from this action. If this parameter is specified, the response includes only
        /// results beyond the token, up to the value specified by MaxResults. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1276)]
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