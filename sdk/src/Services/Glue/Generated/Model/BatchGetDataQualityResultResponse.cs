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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the BatchGetDataQualityResult operation.
    /// </summary>
    public partial class BatchGetDataQualityResultResponse : AmazonWebServiceResponse
    {
        private List<DataQualityResult> _results = new List<DataQualityResult>();
        private List<string> _resultsNotFound = new List<string>();

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// A list of <code>DataQualityResult</code> objects representing the data quality results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DataQualityResult> Results
        {
            get { return this._results; }
            set { this._results = value; }
        }

        // Check to see if Results property is set
        internal bool IsSetResults()
        {
            return this._results != null && this._results.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResultsNotFound. 
        /// <para>
        /// A list of result IDs for which results were not found.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> ResultsNotFound
        {
            get { return this._resultsNotFound; }
            set { this._resultsNotFound = value; }
        }

        // Check to see if ResultsNotFound property is set
        internal bool IsSetResultsNotFound()
        {
            return this._resultsNotFound != null && this._resultsNotFound.Count > 0; 
        }

    }
}