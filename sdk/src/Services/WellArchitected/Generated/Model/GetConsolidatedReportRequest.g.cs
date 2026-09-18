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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the GetConsolidatedReport operation. Get a consolidated
    /// report of your workloads. <para> You can optionally choose to include workloads that
    /// have been shared with you. </para>
    /// </summary>
    public partial class GetConsolidatedReportRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the consolidated report.
        /// </para>
        ///  
        /// <para>
        /// For <c>PDF</c>, <c>Base64String</c> is returned. For <c>JSON</c>, <c>Metrics</c> is
        /// returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property IncludeSharedResources. 
        /// <para>
        /// Set to <c>true</c> to have shared resources included in the report.
        /// </para>
        /// </summary>
        public bool? IncludeSharedResources { get; set; }

        /// <summary>
        /// Checks to see if the IncludeSharedResources property is set.
        /// </summary>
        internal bool IsSetIncludeSharedResources() => this.IncludeSharedResources.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
