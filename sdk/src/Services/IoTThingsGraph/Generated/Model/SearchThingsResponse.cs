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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// This is the response object from the SearchThings operation.
    /// </summary>
    public partial class SearchThingsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Thing> _things = new List<Thing>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string to specify as <code>nextToken</code> when you request the next page of
        /// results.
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
        /// Gets and sets the property Things. 
        /// <para>
        /// An array of things in the result set.
        /// </para>
        /// </summary>
        public List<Thing> Things
        {
            get { return this._things; }
            set { this._things = value; }
        }

        // Check to see if Things property is set
        internal bool IsSetThings()
        {
            return this._things != null && this._things.Count > 0; 
        }

    }
}