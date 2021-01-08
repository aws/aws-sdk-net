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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// The result structure for the list backend environments result.
    /// </summary>
    public partial class ListBackendEnvironmentsResponse : AmazonWebServiceResponse
    {
        private List<BackendEnvironment> _backendEnvironments = new List<BackendEnvironment>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BackendEnvironments. 
        /// <para>
        ///  The list of backend environments for an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BackendEnvironment> BackendEnvironments
        {
            get { return this._backendEnvironments; }
            set { this._backendEnvironments = value; }
        }

        // Check to see if BackendEnvironments property is set
        internal bool IsSetBackendEnvironments()
        {
            return this._backendEnvironments != null && this._backendEnvironments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A pagination token. If a non-null pagination token is returned in a result, pass
        /// its value in another request to retrieve more entries. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2000)]
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