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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// This is the response object from the ListWebhooks operation.
    /// </summary>
    public partial class ListWebhooksResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ListWebhookItem> _webhooks = new List<ListWebhookItem>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the amount of returned information is significantly large, an identifier is also
        /// returned and can be used in a subsequent ListWebhooks call to return the next set
        /// of webhooks in the list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Webhooks. 
        /// <para>
        /// The JSON detail returned for each webhook in the list output for the ListWebhooks
        /// call.
        /// </para>
        /// </summary>
        public List<ListWebhookItem> Webhooks
        {
            get { return this._webhooks; }
            set { this._webhooks = value; }
        }

        // Check to see if Webhooks property is set
        internal bool IsSetWebhooks()
        {
            return this._webhooks != null && this._webhooks.Count > 0; 
        }

    }
}