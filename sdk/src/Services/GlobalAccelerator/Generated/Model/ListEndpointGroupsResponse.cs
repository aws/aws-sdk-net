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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// This is the response object from the ListEndpointGroups operation.
    /// </summary>
    public partial class ListEndpointGroupsResponse : AmazonWebServiceResponse
    {
        private List<EndpointGroup> _endpointGroups = new List<EndpointGroup>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EndpointGroups. 
        /// <para>
        /// The list of the endpoint groups associated with a listener.
        /// </para>
        /// </summary>
        public List<EndpointGroup> EndpointGroups
        {
            get { return this._endpointGroups; }
            set { this._endpointGroups = value; }
        }

        // Check to see if EndpointGroups property is set
        internal bool IsSetEndpointGroups()
        {
            return this._endpointGroups != null && this._endpointGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. You receive this token from a previous call.
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