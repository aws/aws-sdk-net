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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// The result structure for the list webhooks request.
    /// </summary>
    public partial class ListWebhooksResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Webhook> _webhooks = new List<Webhook>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A pagination token. If non-null, the pagination token is returned in a result. Pass
        /// its value in another request to retrieve more entries. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2000)]
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
        ///  A list of webhooks. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Webhook> Webhooks
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