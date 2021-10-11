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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// This is the response object from the GetBatchImportJobs operation.
    /// </summary>
    public partial class GetBatchImportJobsResponse : AmazonWebServiceResponse
    {
        private List<BatchImport> _batchImports = new List<BatchImport>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BatchImports. 
        /// <para>
        /// An array containing the details of each batch import job.
        /// </para>
        /// </summary>
        public List<BatchImport> BatchImports
        {
            get { return this._batchImports; }
            set { this._batchImports = value; }
        }

        // Check to see if BatchImports property is set
        internal bool IsSetBatchImports()
        {
            return this._batchImports != null && this._batchImports.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token for the subsequent resquest.
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