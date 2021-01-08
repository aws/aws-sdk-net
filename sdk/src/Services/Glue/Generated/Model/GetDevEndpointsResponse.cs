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
    /// This is the response object from the GetDevEndpoints operation.
    /// </summary>
    public partial class GetDevEndpointsResponse : AmazonWebServiceResponse
    {
        private List<DevEndpoint> _devEndpoints = new List<DevEndpoint>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DevEndpoints. 
        /// <para>
        /// A list of <code>DevEndpoint</code> definitions.
        /// </para>
        /// </summary>
        public List<DevEndpoint> DevEndpoints
        {
            get { return this._devEndpoints; }
            set { this._devEndpoints = value; }
        }

        // Check to see if DevEndpoints property is set
        internal bool IsSetDevEndpoints()
        {
            return this._devEndpoints != null && this._devEndpoints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, if not all <code>DevEndpoint</code> definitions have yet been
        /// returned.
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