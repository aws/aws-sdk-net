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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the ListExportErrors operation.
    /// List export errors.
    /// </summary>
    public partial class ListExportErrorsRequest : AmazonMgnRequest
    {
        private string _exportid;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ExportID. 
        /// <para>
        /// List export errors request export id.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=24, Max=24)]
        public string ExportID
        {
            get { return this._exportid; }
            set { this._exportid = value; }
        }

        // Check to see if ExportID property is set
        internal bool IsSetExportID()
        {
            return this._exportid != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// List export errors request max results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// <para>
        /// List export errors request next token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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