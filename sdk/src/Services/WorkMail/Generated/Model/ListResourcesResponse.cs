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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// This is the response object from the ListResources operation.
    /// </summary>
    public partial class ListResourcesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Resource> _resources = new List<Resource>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token used to paginate through all the organization's resources. While results
        /// are still available, it has an associated value. When the last page is reached, the
        /// token is empty.
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

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// One page of the organization's resource representation.
        /// </para>
        /// </summary>
        public List<Resource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && this._resources.Count > 0; 
        }

    }
}