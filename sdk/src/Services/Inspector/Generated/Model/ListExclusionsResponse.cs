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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This is the response object from the ListExclusions operation.
    /// </summary>
    public partial class ListExclusionsResponse : AmazonWebServiceResponse
    {
        private List<string> _exclusionArns = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ExclusionArns. 
        /// <para>
        /// A list of exclusions' ARNs returned by the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<string> ExclusionArns
        {
            get { return this._exclusionArns; }
            set { this._exclusionArns = value; }
        }

        // Check to see if ExclusionArns property is set
        internal bool IsSetExclusionArns()
        {
            return this._exclusionArns != null && this._exclusionArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When a response is generated, if there is more data to be listed, this parameters
        /// is present in the response and contains the value to use for the nextToken parameter
        /// in a subsequent pagination request. If there is no more data to be listed, this parameter
        /// is set to null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
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