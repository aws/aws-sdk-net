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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// This is the response object from the ListEnvironmentHosts operation.
    /// </summary>
    public partial class ListEnvironmentHostsResponse : AmazonWebServiceResponse
    {
        private List<Host> _environmentHosts = AWSConfigs.InitializeCollections ? new List<Host>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EnvironmentHosts. 
        /// <para>
        /// A list of hosts in the environment.
        /// </para>
        /// </summary>
        public List<Host> EnvironmentHosts
        {
            get { return this._environmentHosts; }
            set { this._environmentHosts = value; }
        }

        // Check to see if EnvironmentHosts property is set
        internal bool IsSetEnvironmentHosts()
        {
            return this._environmentHosts != null && (this._environmentHosts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A unique pagination token for next page results. Make the call again using this token
        /// to retrieve the next page.
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