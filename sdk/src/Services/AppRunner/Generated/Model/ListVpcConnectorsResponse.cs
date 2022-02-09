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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// This is the response object from the ListVpcConnectors operation.
    /// </summary>
    public partial class ListVpcConnectorsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<VpcConnector> _vpcConnectors = new List<VpcConnector>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that you can pass in a subsequent request to get the next result page. It's
        /// returned in a paginated request.
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
        /// Gets and sets the property VpcConnectors. 
        /// <para>
        /// A list of information records for VPC connectors. In a paginated request, the request
        /// returns up to <code>MaxResults</code> records for each call.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<VpcConnector> VpcConnectors
        {
            get { return this._vpcConnectors; }
            set { this._vpcConnectors = value; }
        }

        // Check to see if VpcConnectors property is set
        internal bool IsSetVpcConnectors()
        {
            return this._vpcConnectors != null && this._vpcConnectors.Count > 0; 
        }

    }
}