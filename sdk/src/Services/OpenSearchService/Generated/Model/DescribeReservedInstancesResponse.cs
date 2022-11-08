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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for results from <code>DescribeReservedInstances</code>
    /// </summary>
    public partial class DescribeReservedInstancesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ReservedInstance> _reservedInstances = new List<ReservedInstance>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page.
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

        /// <summary>
        /// Gets and sets the property ReservedInstances. 
        /// <para>
        /// List of Reserved Instances in the current Region.
        /// </para>
        /// </summary>
        public List<ReservedInstance> ReservedInstances
        {
            get { return this._reservedInstances; }
            set { this._reservedInstances = value; }
        }

        // Check to see if ReservedInstances property is set
        internal bool IsSetReservedInstances()
        {
            return this._reservedInstances != null && this._reservedInstances.Count > 0; 
        }

    }
}