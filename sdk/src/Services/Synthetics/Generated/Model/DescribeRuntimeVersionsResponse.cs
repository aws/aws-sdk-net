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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// This is the response object from the DescribeRuntimeVersions operation.
    /// </summary>
    public partial class DescribeRuntimeVersionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RuntimeVersion> _runtimeVersions = new List<RuntimeVersion>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates that there is more data available. You can use this token in
        /// a subsequent <code>DescribeRuntimeVersions</code> operation to retrieve the next set
        /// of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=252)]
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
        /// Gets and sets the property RuntimeVersions. 
        /// <para>
        /// An array of objects that display the details about each Synthetics canary runtime
        /// version.
        /// </para>
        /// </summary>
        public List<RuntimeVersion> RuntimeVersions
        {
            get { return this._runtimeVersions; }
            set { this._runtimeVersions = value; }
        }

        // Check to see if RuntimeVersions property is set
        internal bool IsSetRuntimeVersions()
        {
            return this._runtimeVersions != null && this._runtimeVersions.Count > 0; 
        }

    }
}