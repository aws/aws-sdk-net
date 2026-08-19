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

namespace Amazon.SimpleDBv2.Model
{
    /// <summary>
    /// This is the response object from the ListExports operation.
    /// </summary>
    public partial class ListExportsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ExportSummaries. List of export summaries containing export
        /// ARN, status, request timestamp, and associated domain name.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public List<ExportSummary> ExportSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<ExportSummary>() : null;

        /// <summary>
        /// Checks to see if the ExportSummaries property is set.
        /// </summary>
        internal bool IsSetExportSummaries() => this.ExportSummaries != null && (this.ExportSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. A pagination token indicating that more results
        /// are available. To retrieve the next page of results, provide this token in a subsequent
        /// ListExports request. If null or empty, there are no more results to retrieve.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
