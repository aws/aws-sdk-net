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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// This is the response object from the ListFunctionDefinitions operation.
    /// </summary>
    public partial class ListFunctionDefinitionsResponse : AmazonWebServiceResponse
    {
        private List<DefinitionInformation> _definitions = new List<DefinitionInformation>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Definitions. Definitions
        /// </summary>
        public List<DefinitionInformation> Definitions
        {
            get { return this._definitions; }
            set { this._definitions = value; }
        }

        // Check to see if Definitions property is set
        internal bool IsSetDefinitions()
        {
            return this._definitions != null && this._definitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. The token for the next set of results, or ''null''
        /// if there are no additional results.
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