/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ListRunsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _runArnList = new List<string>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  When a response is generated, if there is more data to be listed, this parameter
        /// is present in the response and contains the value to use for the <b>nextToken</b>
        /// parameter in a subsequent pagination request. If there is no more data to be listed,
        /// this parameter is set to 'null'.
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
        /// Gets and sets the property RunArnList. 
        /// <para>
        /// A list of ARNs specifying the assessment runs returned by the action.
        /// </para>
        /// </summary>
        public List<string> RunArnList
        {
            get { return this._runArnList; }
            set { this._runArnList = value; }
        }

        // Check to see if RunArnList property is set
        internal bool IsSetRunArnList()
        {
            return this._runArnList != null && this._runArnList.Count > 0; 
        }

    }
}