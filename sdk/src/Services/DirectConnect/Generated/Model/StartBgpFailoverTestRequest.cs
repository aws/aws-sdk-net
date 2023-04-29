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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the StartBgpFailoverTest operation.
    /// Starts the virtual interface failover test that verifies your configuration meets
    /// your resiliency requirements by placing the BGP peering session in the DOWN state.
    /// You can then send traffic to verify that there are no outages.
    /// 
    ///  
    /// <para>
    /// You can run the test on public, private, transit, and hosted virtual interfaces.
    /// </para>
    ///  
    /// <para>
    /// You can use <a href="https://docs.aws.amazon.com/directconnect/latest/APIReference/API_ListVirtualInterfaceTestHistory.html">ListVirtualInterfaceTestHistory</a>
    /// to view the virtual interface test history.
    /// </para>
    ///  
    /// <para>
    /// If you need to stop the test before the test interval completes, use <a href="https://docs.aws.amazon.com/directconnect/latest/APIReference/API_StopBgpFailoverTest.html">StopBgpFailoverTest</a>.
    /// </para>
    /// </summary>
    public partial class StartBgpFailoverTestRequest : AmazonDirectConnectRequest
    {
        private List<string> _bgpPeers = new List<string>();
        private int? _testDurationInMinutes;
        private string _virtualInterfaceId;

        /// <summary>
        /// Gets and sets the property BgpPeers. 
        /// <para>
        /// The BGP peers to place in the DOWN state.
        /// </para>
        /// </summary>
        public List<string> BgpPeers
        {
            get { return this._bgpPeers; }
            set { this._bgpPeers = value; }
        }

        // Check to see if BgpPeers property is set
        internal bool IsSetBgpPeers()
        {
            return this._bgpPeers != null && this._bgpPeers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TestDurationInMinutes. 
        /// <para>
        /// The time in minutes that the virtual interface failover test will last.
        /// </para>
        ///  
        /// <para>
        /// Maximum value: 4,320 minutes (72 hours).
        /// </para>
        ///  
        /// <para>
        /// Default: 180 minutes (3 hours).
        /// </para>
        /// </summary>
        public int TestDurationInMinutes
        {
            get { return this._testDurationInMinutes.GetValueOrDefault(); }
            set { this._testDurationInMinutes = value; }
        }

        // Check to see if TestDurationInMinutes property is set
        internal bool IsSetTestDurationInMinutes()
        {
            return this._testDurationInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VirtualInterfaceId. 
        /// <para>
        /// The ID of the virtual interface you want to test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VirtualInterfaceId
        {
            get { return this._virtualInterfaceId; }
            set { this._virtualInterfaceId = value; }
        }

        // Check to see if VirtualInterfaceId property is set
        internal bool IsSetVirtualInterfaceId()
        {
            return this._virtualInterfaceId != null;
        }

    }
}