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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  Specify the pagination token returned by a previous request to retrieve the next
        /// page of indexes. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RetrievalStatus. 
        /// <para>
        ///  Status of the retrieval. 
        /// </para>
        /// </summary>
        public RetrievalStatus RetrievalStatus { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalStatus property is set.
        /// </summary>
        internal bool IsSetRetrievalStatus() => this.RetrievalStatus != null;

        /// <summary>
        /// Gets and sets the property TraceFormat. 
        /// <para>
        ///  Format of the requested traces. 
        /// </para>
        /// </summary>
        public TraceFormatType TraceFormat { get; set; }

        /// <summary>
        /// Checks to see if the TraceFormat property is set.
        /// </summary>
        internal bool IsSetTraceFormat() => this.TraceFormat != null;

        /// <summary>
        /// Gets and sets the property Traces. 
        /// <para>
        ///  Full traces for the specified requests. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<RetrievedTrace> Traces { get; set; } = AWSConfigs.InitializeCollections ? new List<RetrievedTrace>() : null;

        /// <summary>
        /// Checks to see if the Traces property is set.
        /// </summary>
        internal bool IsSetTraces() => this.Traces != null && (this.Traces.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
