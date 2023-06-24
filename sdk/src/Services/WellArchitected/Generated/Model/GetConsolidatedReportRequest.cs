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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the GetConsolidatedReport operation.
    /// Get a consolidated report of your workloads.
    /// 
    ///  
    /// <para>
    /// You can optionally choose to include workloads that have been shared with you.
    /// </para>
    /// </summary>
    public partial class GetConsolidatedReportRequest : AmazonWellArchitectedRequest
    {
        private ReportFormat _format;
        private bool? _includeSharedResources;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the consolidated report.
        /// </para>
        ///  
        /// <para>
        /// For <code>PDF</code>, <code>Base64String</code> is returned. For <code>JSON</code>,
        /// <code>Metrics</code> is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReportFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeSharedResources. 
        /// <para>
        /// Set to <code>true</code> to have shared resources included in the report.
        /// </para>
        /// </summary>
        public bool IncludeSharedResources
        {
            get { return this._includeSharedResources.GetValueOrDefault(); }
            set { this._includeSharedResources = value; }
        }

        // Check to see if IncludeSharedResources property is set
        internal bool IsSetIncludeSharedResources()
        {
            return this._includeSharedResources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
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

    }
}