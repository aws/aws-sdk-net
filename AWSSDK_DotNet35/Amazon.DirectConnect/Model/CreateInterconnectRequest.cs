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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInterconnect operation.
    /// Creates a new interconnect between a AWS Direct Connect partner's network and a specific
    /// AWS Direct Connect location.
    /// 
    ///  
    /// <para>
    /// An interconnect is a connection which is capable of hosting other connections. The
    /// AWS Direct Connect partner can use an interconnect to provide sub-1Gbps AWS Direct
    /// Connect service to tier 2 customers who do not have their own connections. Like a
    /// standard connection, an interconnect links the AWS Direct Connect partner's network
    /// to an AWS Direct Connect location over a standard 1 Gbps or 10 Gbps Ethernet fiber-optic
    /// cable. One end is connected to the partner's router, the other to an AWS Direct Connect
    /// router.
    /// </para>
    ///  
    /// <para>
    /// For each end customer, the AWS Direct Connect partner provisions a connection on their
    /// interconnect by calling AllocateConnectionOnInterconnect. The end customer can then
    /// connect to AWS resources by creating a virtual interface on their connection, using
    /// the VLAN assigned to them by the AWS Direct Connect partner.
    /// </para>
    /// </summary>
    public partial class CreateInterconnectRequest : AmazonDirectConnectRequest
    {
        private string _bandwidth;
        private string _interconnectName;
        private string _location;

        /// <summary>
        /// Gets and sets the property Bandwidth. 
        /// <para>
        /// The port bandwidth
        /// </para>
        ///  
        /// <para>
        /// Example: 1Gbps
        /// </para>
        ///  
        /// <para>
        /// Default: None
        /// </para>
        ///  
        /// <para>
        /// Available values: 1Gbps,10Gbps
        /// </para>
        /// </summary>
        public string Bandwidth
        {
            get { return this._bandwidth; }
            set { this._bandwidth = value; }
        }

        // Check to see if Bandwidth property is set
        internal bool IsSetBandwidth()
        {
            return this._bandwidth != null;
        }

        /// <summary>
        /// Gets and sets the property InterconnectName. 
        /// <para>
        /// The name of the interconnect.
        /// </para>
        ///  
        /// <para>
        /// Example: "<i>1G Interconnect to AWS</i>"
        /// </para>
        ///  
        /// <para>
        /// Default: None
        /// </para>
        /// </summary>
        public string InterconnectName
        {
            get { return this._interconnectName; }
            set { this._interconnectName = value; }
        }

        // Check to see if InterconnectName property is set
        internal bool IsSetInterconnectName()
        {
            return this._interconnectName != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Where the interconnect is located
        /// </para>
        ///  
        /// <para>
        /// Example: EqSV5
        /// </para>
        ///  
        /// <para>
        /// Default: None
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}