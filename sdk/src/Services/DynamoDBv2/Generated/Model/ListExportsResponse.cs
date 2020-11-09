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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// This is the response object from the ListExports operation.
    /// </summary>
    public partial class ListExportsResponse : AmazonWebServiceResponse
    {
        private List<ExportSummary> _exportSummaries = new List<ExportSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ExportSummaries. 
        /// <para>
        /// A list of <code>ExportSummary</code> objects.
        /// </para>
        /// </summary>
        public List<ExportSummary> ExportSummaries
        {
            get { return this._exportSummaries; }
            set { this._exportSummaries = value; }
        }

        // Check to see if ExportSummaries property is set
        internal bool IsSetExportSummaries()
        {
            return this._exportSummaries != null && this._exportSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If this value is returned, there are additional results to be displayed. To retrieve
        /// them, call <code>ListExports</code> again, with <code>NextToken</code> set to this
        /// value.
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

    }
}