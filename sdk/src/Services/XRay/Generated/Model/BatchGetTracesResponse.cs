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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.XRay.Model
{
    /// <summary>
    /// This is the response object from the BatchGetTraces operation.
    /// </summary>
    public partial class BatchGetTracesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Trace> _traces = new List<Trace>();
        private List<string> _unprocessedTraceIds = new List<string>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token. Not used.
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

        /// <summary>
        /// Gets and sets the property Traces. 
        /// <para>
        /// Full traces for the specified requests.
        /// </para>
        /// </summary>
        public List<Trace> Traces
        {
            get { return this._traces; }
            set { this._traces = value; }
        }

        // Check to see if Traces property is set
        internal bool IsSetTraces()
        {
            return this._traces != null && this._traces.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedTraceIds. 
        /// <para>
        /// Trace IDs of requests that haven't been processed.
        /// </para>
        /// </summary>
        public List<string> UnprocessedTraceIds
        {
            get { return this._unprocessedTraceIds; }
            set { this._unprocessedTraceIds = value; }
        }

        // Check to see if UnprocessedTraceIds property is set
        internal bool IsSetUnprocessedTraceIds()
        {
            return this._unprocessedTraceIds != null && this._unprocessedTraceIds.Count > 0; 
        }

    }
}