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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DescribeFleetInstances operation.
    /// </summary>
    public partial class DescribeFleetInstancesResponse : AmazonWebServiceResponse
    {
        private List<ActiveInstance> _activeInstances = new List<ActiveInstance>();
        private string _fleetId;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ActiveInstances. 
        /// <para>
        /// The running instances. This list is refreshed periodically and might be out of date.
        /// </para>
        /// </summary>
        public List<ActiveInstance> ActiveInstances
        {
            get { return this._activeInstances; }
            set { this._activeInstances = value; }
        }

        // Check to see if ActiveInstances property is set
        internal bool IsSetActiveInstances()
        {
            return this._activeInstances != null && this._activeInstances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// The ID of the EC2 Fleet.
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results.
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