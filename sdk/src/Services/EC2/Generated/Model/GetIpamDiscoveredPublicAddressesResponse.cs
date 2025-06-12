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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetIpamDiscoveredPublicAddresses operation.
    /// </summary>
    public partial class GetIpamDiscoveredPublicAddressesResponse : AmazonWebServiceResponse
    {
        private List<IpamDiscoveredPublicAddress> _ipamDiscoveredPublicAddresses = AWSConfigs.InitializeCollections ? new List<IpamDiscoveredPublicAddress>() : null;
        private string _nextToken;
        private DateTime? _oldestSampleTime;

        /// <summary>
        /// Gets and sets the property IpamDiscoveredPublicAddresses. 
        /// <para>
        /// IPAM discovered public addresses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpamDiscoveredPublicAddress> IpamDiscoveredPublicAddresses
        {
            get { return this._ipamDiscoveredPublicAddresses; }
            set { this._ipamDiscoveredPublicAddresses = value; }
        }

        // Check to see if IpamDiscoveredPublicAddresses property is set
        internal bool IsSetIpamDiscoveredPublicAddresses()
        {
            return this._ipamDiscoveredPublicAddresses != null && (this._ipamDiscoveredPublicAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is <c>null</c> when
        /// there are no more results to return.
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
        /// Gets and sets the property OldestSampleTime. 
        /// <para>
        /// The oldest successful resource discovery time.
        /// </para>
        /// </summary>
        public DateTime? OldestSampleTime
        {
            get { return this._oldestSampleTime; }
            set { this._oldestSampleTime = value; }
        }

        // Check to see if OldestSampleTime property is set
        internal bool IsSetOldestSampleTime()
        {
            return this._oldestSampleTime.HasValue; 
        }

    }
}