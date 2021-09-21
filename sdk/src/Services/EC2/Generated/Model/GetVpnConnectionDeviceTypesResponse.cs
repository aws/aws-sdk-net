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
    /// This is the response object from the GetVpnConnectionDeviceTypes operation.
    /// </summary>
    public partial class GetVpnConnectionDeviceTypesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<VpnConnectionDeviceType> _vpnConnectionDeviceTypes = new List<VpnConnectionDeviceType>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>NextToken</code> value to include in a future <code>GetVpnConnectionDeviceTypes</code>
        /// request. When the results of a <code>GetVpnConnectionDeviceTypes</code> request exceed
        /// <code>MaxResults</code>, this value can be used to retrieve the next page of results.
        /// This value is null when there are no more results to return.
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
        /// Gets and sets the property VpnConnectionDeviceTypes. 
        /// <para>
        /// List of customer gateway devices that have a sample configuration file available for
        /// use.
        /// </para>
        /// </summary>
        public List<VpnConnectionDeviceType> VpnConnectionDeviceTypes
        {
            get { return this._vpnConnectionDeviceTypes; }
            set { this._vpnConnectionDeviceTypes = value; }
        }

        // Check to see if VpnConnectionDeviceTypes property is set
        internal bool IsSetVpnConnectionDeviceTypes()
        {
            return this._vpnConnectionDeviceTypes != null && this._vpnConnectionDeviceTypes.Count > 0; 
        }

    }
}