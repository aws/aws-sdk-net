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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the ListExports operation.
    /// </summary>
    public partial class ListExportsResponse : AmazonWebServiceResponse
    {
        private List<Export> _exports = new List<Export>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Exports. 
        /// <para>
        /// The output for the <a>ListExports</a> action.
        /// </para>
        /// </summary>
        public List<Export> Exports
        {
            get { return this._exports; }
            set { this._exports = value; }
        }

        // Check to see if Exports property is set
        internal bool IsSetExports()
        {
            return this._exports != null && this._exports.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the output exceeds 100 exported output values, a string that identifies the next
        /// page of exports. If there is no additional page, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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