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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// This is the response object from the ListPartnerEventSources operation.
    /// </summary>
    public partial class ListPartnerEventSourcesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PartnerEventSource> _partnerEventSources = new List<PartnerEventSource>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token you can use in a subsequent operation to retrieve the next set of results.
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
        /// Gets and sets the property PartnerEventSources. 
        /// <para>
        /// The list of partner event sources returned by the operation.
        /// </para>
        /// </summary>
        public List<PartnerEventSource> PartnerEventSources
        {
            get { return this._partnerEventSources; }
            set { this._partnerEventSources = value; }
        }

        // Check to see if PartnerEventSources property is set
        internal bool IsSetPartnerEventSources()
        {
            return this._partnerEventSources != null && this._partnerEventSources.Count > 0; 
        }

    }
}