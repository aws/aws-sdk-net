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
    /// This is the response object from the GetUserDefinedFunctions operation.
    /// </summary>
    public partial class GetUserDefinedFunctionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<UserDefinedFunction> _userDefinedFunctions = new List<UserDefinedFunction>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, if the list of functions returned does not include the last
        /// requested function.
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
        /// Gets and sets the property UserDefinedFunctions. 
        /// <para>
        /// A list of requested function definitions.
        /// </para>
        /// </summary>
        public List<UserDefinedFunction> UserDefinedFunctions
        {
            get { return this._userDefinedFunctions; }
            set { this._userDefinedFunctions = value; }
        }

        // Check to see if UserDefinedFunctions property is set
        internal bool IsSetUserDefinedFunctions()
        {
            return this._userDefinedFunctions != null && this._userDefinedFunctions.Count > 0; 
        }

    }
}