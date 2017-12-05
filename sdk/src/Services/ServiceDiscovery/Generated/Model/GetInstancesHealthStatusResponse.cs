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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// This is the response object from the GetInstancesHealthStatus operation.
    /// </summary>
    public partial class GetInstancesHealthStatusResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private Dictionary<string, string> _status = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If more than <code>MaxResults</code> instances match the specified criteria, you can
        /// submit another <code>GetInstancesHealthStatus</code> request to get the next group
        /// of results. Specify the value of <code>NextToken</code> from the previous response
        /// in the next request.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// A complex type that contains the IDs and the health status of the instances that you
        /// specified in the <code>GetInstancesHealthStatus</code> request.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null && this._status.Count > 0; 
        }

    }
}