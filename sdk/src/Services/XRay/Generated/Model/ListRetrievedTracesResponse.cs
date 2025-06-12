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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// This is the response object from the ListRetrievedTraces operation.
    /// </summary>
    public partial class ListRetrievedTracesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private RetrievalStatus _retrievalStatus;
        private TraceFormatType _traceFormat;
        private List<RetrievedTrace> _traces = AWSConfigs.InitializeCollections ? new List<RetrievedTrace>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  Specify the pagination token returned by a previous request to retrieve the next
        /// page of indexes. 
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
        /// Gets and sets the property RetrievalStatus. 
        /// <para>
        ///  Status of the retrieval. 
        /// </para>
        /// </summary>
        public RetrievalStatus RetrievalStatus
        {
            get { return this._retrievalStatus; }
            set { this._retrievalStatus = value; }
        }

        // Check to see if RetrievalStatus property is set
        internal bool IsSetRetrievalStatus()
        {
            return this._retrievalStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TraceFormat. 
        /// <para>
        ///  Format of the requested traces. 
        /// </para>
        /// </summary>
        public TraceFormatType TraceFormat
        {
            get { return this._traceFormat; }
            set { this._traceFormat = value; }
        }

        // Check to see if TraceFormat property is set
        internal bool IsSetTraceFormat()
        {
            return this._traceFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Traces. 
        /// <para>
        ///  Full traces for the specified requests. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<RetrievedTrace> Traces
        {
            get { return this._traces; }
            set { this._traces = value; }
        }

        // Check to see if Traces property is set
        internal bool IsSetTraces()
        {
            return this._traces != null && (this._traces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}