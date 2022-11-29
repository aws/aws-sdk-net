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
    /// ENA Express uses Amazon Web Services Scalable Reliable Datagram (SRD) technology to
    /// increase the maximum bandwidth used per stream and minimize tail latency of network
    /// traffic between EC2 instances. With ENA Express, you can communicate between two EC2
    /// instances in the same subnet within the same account, or in different accounts. Both
    /// sending and receiving instances must have ENA Express enabled.
    /// 
    ///  
    /// <para>
    /// To improve the reliability of network packet delivery, ENA Express reorders network
    /// packets on the receiving end by default. However, some UDP-based applications are
    /// designed to handle network packets that are out of order to reduce the overhead for
    /// packet delivery at the network layer. When ENA Express is enabled, you can specify
    /// whether UDP network traffic uses it.
    /// </para>
    /// </summary>
    public partial class EnaSrdSpecification
    {
        private bool? _enaSrdEnabled;
        private EnaSrdUdpSpecification _enaSrdUdpSpecification;

        /// <summary>
        /// Gets and sets the property EnaSrdEnabled. 
        /// <para>
        /// Indicates whether ENA Express is enabled for the network interface.
        /// </para>
        /// </summary>
        public bool EnaSrdEnabled
        {
            get { return this._enaSrdEnabled.GetValueOrDefault(); }
            set { this._enaSrdEnabled = value; }
        }

        // Check to see if EnaSrdEnabled property is set
        internal bool IsSetEnaSrdEnabled()
        {
            return this._enaSrdEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnaSrdUdpSpecification. 
        /// <para>
        /// Configures ENA Express for UDP network traffic.
        /// </para>
        /// </summary>
        public EnaSrdUdpSpecification EnaSrdUdpSpecification
        {
            get { return this._enaSrdUdpSpecification; }
            set { this._enaSrdUdpSpecification = value; }
        }

        // Check to see if EnaSrdUdpSpecification property is set
        internal bool IsSetEnaSrdUdpSpecification()
        {
            return this._enaSrdUdpSpecification != null;
        }

    }
}