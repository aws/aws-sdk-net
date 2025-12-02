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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// The response from the ListDurableExecutionsByFunction operation, containing a list
    /// of durable executions and pagination information.
    /// </summary>
    public partial class ListDurableExecutionsByFunctionResponse : AmazonWebServiceResponse
    {
        private List<Execution> _durableExecutions = AWSConfigs.InitializeCollections ? new List<Execution>() : null;
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property DurableExecutions. 
        /// <para>
        /// List of durable execution summaries matching the filter criteria.
        /// </para>
        /// </summary>
        public List<Execution> DurableExecutions
        {
            get { return this._durableExecutions; }
            set { this._durableExecutions = value; }
        }

        // Check to see if DurableExecutions property is set
        internal bool IsSetDurableExecutions()
        {
            return this._durableExecutions != null && (this._durableExecutions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// Pagination token for retrieving additional results. Present only if there are more
        /// results available.
        /// </para>
        /// </summary>
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

    }
}