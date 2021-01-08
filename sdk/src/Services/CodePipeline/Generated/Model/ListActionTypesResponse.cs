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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents the output of a <code>ListActionTypes</code> action.
    /// </summary>
    public partial class ListActionTypesResponse : AmazonWebServiceResponse
    {
        private List<ActionType> _actionTypes = new List<ActionType>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ActionTypes. 
        /// <para>
        /// Provides details of the action types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ActionType> ActionTypes
        {
            get { return this._actionTypes; }
            set { this._actionTypes = value; }
        }

        // Check to see if ActionTypes property is set
        internal bool IsSetActionTypes()
        {
            return this._actionTypes != null && this._actionTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the amount of returned information is significantly large, an identifier is also
        /// returned. It can be used in a subsequent list action types call to return the next
        /// set of action types in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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