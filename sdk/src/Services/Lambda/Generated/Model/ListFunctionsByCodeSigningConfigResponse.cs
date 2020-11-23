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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// This is the response object from the ListFunctionsByCodeSigningConfig operation.
    /// </summary>
    public partial class ListFunctionsByCodeSigningConfigResponse : AmazonWebServiceResponse
    {
        private List<string> _functionArns = new List<string>();
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property FunctionArns. 
        /// <para>
        /// The function ARNs. 
        /// </para>
        /// </summary>
        public List<string> FunctionArns
        {
            get { return this._functionArns; }
            set { this._functionArns = value; }
        }

        // Check to see if FunctionArns property is set
        internal bool IsSetFunctionArns()
        {
            return this._functionArns != null && this._functionArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// The pagination token that's included if more results are available.
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