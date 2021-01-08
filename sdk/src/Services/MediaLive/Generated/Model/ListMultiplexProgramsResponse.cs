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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for ListMultiplexProgramsResponse
    /// </summary>
    public partial class ListMultiplexProgramsResponse : AmazonWebServiceResponse
    {
        private List<MultiplexProgramSummary> _multiplexPrograms = new List<MultiplexProgramSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MultiplexPrograms. List of multiplex programs.
        /// </summary>
        public List<MultiplexProgramSummary> MultiplexPrograms
        {
            get { return this._multiplexPrograms; }
            set { this._multiplexPrograms = value; }
        }

        // Check to see if MultiplexPrograms property is set
        internal bool IsSetMultiplexPrograms()
        {
            return this._multiplexPrograms != null && this._multiplexPrograms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. Token for the next ListMultiplexProgram request.
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