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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// This is the response object from the ListRouterInputs operation.
    /// </summary>
    public partial class ListRouterInputsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ListedRouterInput> _routerInputs = AWSConfigs.InitializeCollections ? new List<ListedRouterInput>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results.
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
        /// Gets and sets the property RouterInputs. 
        /// <para>
        /// The summary information for the retrieved router inputs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ListedRouterInput> RouterInputs
        {
            get { return this._routerInputs; }
            set { this._routerInputs = value; }
        }

        // Check to see if RouterInputs property is set
        internal bool IsSetRouterInputs()
        {
            return this._routerInputs != null && (this._routerInputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}