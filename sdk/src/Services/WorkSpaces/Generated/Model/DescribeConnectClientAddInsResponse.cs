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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// This is the response object from the DescribeConnectClientAddIns operation.
    /// </summary>
    public partial class DescribeConnectClientAddInsResponse : AmazonWebServiceResponse
    {
        private List<ConnectClientAddIn> _addIns = new List<ConnectClientAddIn>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AddIns. 
        /// <para>
        /// Information about client add-ins.
        /// </para>
        /// </summary>
        public List<ConnectClientAddIn> AddIns
        {
            get { return this._addIns; }
            set { this._addIns = value; }
        }

        // Check to see if AddIns property is set
        internal bool IsSetAddIns()
        {
            return this._addIns != null && this._addIns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is null when there
        /// are no more results to return. 
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