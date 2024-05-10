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
    /// This is the response object from the DescribeSlackWorkspaces operation.
    /// </summary>
    public partial class DescribeSlackWorkspacesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SlackWorkspace> _slackWorkspaces = AWSConfigs.InitializeCollections ? new List<SlackWorkspace>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. An optional token returned from a prior request.
        /// Use this token for pagination of results from this action. If this parameter is specified,
        /// the response includes only results beyond the token, up to the value specified by
        /// MaxResults.
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

        /// <summary>
        /// Gets and sets the property SlackWorkspaces. A list of Slack Workspaces registered
        /// with AWS Chatbot.
        /// </summary>
        public List<SlackWorkspace> SlackWorkspaces
        {
            get { return this._slackWorkspaces; }
            set { this._slackWorkspaces = value; }
        }

        // Check to see if SlackWorkspaces property is set
        internal bool IsSetSlackWorkspaces()
        {
            return this._slackWorkspaces != null && (this._slackWorkspaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}