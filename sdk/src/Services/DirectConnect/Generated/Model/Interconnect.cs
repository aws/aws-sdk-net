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
    /// Information about an interconnect.
    /// </summary>
    public partial class Interconnect
    {
        private string _awsDevice;
        private string _awsDeviceV2;
        private string _bandwidth;
        private HasLogicalRedundancy _hasLogicalRedundancy;
        private string _interconnectId;
        private string _interconnectName;
        private InterconnectState _interconnectState;
        private bool? _jumboFrameCapable;
        private string _lagId;
        private DateTime? _loaIssueTime;
        private string _location;
        private string _region;

        /// <summary>
        /// Gets and sets the property AwsDevice. 
        /// <para>
        /// The Direct Connect endpoint on which the physical connection terminates.
        /// </para>
        /// </summary>
        public string AwsDevice
        {
            get { return this._awsDevice; }
            set { this._awsDevice = value; }
        }

        // Check to see if AwsDevice property is set
        internal bool IsSetAwsDevice()
        {
            return this._awsDevice != null;
        }

        /// <summary>
        /// Gets and sets the property AwsDeviceV2. 
        /// <para>
        /// The Direct Connect endpoint on which the physical connection terminates.
        /// </para>
        /// </summary>
        public string AwsDeviceV2
        {
            get { return this._awsDeviceV2; }
            set { this._awsDeviceV2 = value; }
        }

        // Check to see if AwsDeviceV2 property is set
        internal bool IsSetAwsDeviceV2()
        {
            return this._awsDeviceV2 != null;
        }

        /// <summary>
        /// Gets and sets the property Bandwidth. 
        /// <para>
        /// The bandwidth of the connection.
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
        /// Gets and sets the property HasLogicalRedundancy. 
        /// <para>
        /// Indicates whether the interconnect supports a secondary BGP in the same address family
        /// (IPv4/IPv6).
        /// </para>
        /// </summary>
        public HasLogicalRedundancy HasLogicalRedundancy
        {
            get { return this._hasLogicalRedundancy; }
            set { this._hasLogicalRedundancy = value; }
        }

        // Check to see if HasLogicalRedundancy property is set
        internal bool IsSetHasLogicalRedundancy()
        {
            return this._hasLogicalRedundancy != null;
        }

        /// <summary>
        /// Gets and sets the property InterconnectId. 
        /// <para>
        /// The ID of the interconnect.
        /// </para>
        /// </summary>
        public string InterconnectId
        {
            get { return this._interconnectId; }
            set { this._interconnectId = value; }
        }

        // Check to see if InterconnectId property is set
        internal bool IsSetInterconnectId()
        {
            return this._interconnectId != null;
        }

        /// <summary>
        /// Gets and sets the property InterconnectName. 
        /// <para>
        /// The name of the interconnect.
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
        /// Gets and sets the property InterconnectState. 
        /// <para>
        /// The state of the interconnect. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>requested</code>: The initial state of an interconnect. The interconnect stays
        /// in the requested state until the Letter of Authorization (LOA) is sent to the customer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>pending</code>: The interconnect is approved, and is being initialized.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>available</code>: The network link is up, and the interconnect is ready for
        /// use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>down</code>: The network link is down.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>deleting</code>: The interconnect is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>deleted</code>: The interconnect is deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>unknown</code>: The state of the interconnect is not available.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InterconnectState InterconnectState
        {
            get { return this._interconnectState; }
            set { this._interconnectState = value; }
        }

        // Check to see if InterconnectState property is set
        internal bool IsSetInterconnectState()
        {
            return this._interconnectState != null;
        }

        /// <summary>
        /// Gets and sets the property JumboFrameCapable. 
        /// <para>
        /// Indicates whether jumbo frames (9001 MTU) are supported.
        /// </para>
        /// </summary>
        public bool JumboFrameCapable
        {
            get { return this._jumboFrameCapable.GetValueOrDefault(); }
            set { this._jumboFrameCapable = value; }
        }

        // Check to see if JumboFrameCapable property is set
        internal bool IsSetJumboFrameCapable()
        {
            return this._jumboFrameCapable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LagId. 
        /// <para>
        /// The ID of the LAG.
        /// </para>
        /// </summary>
        public string LagId
        {
            get { return this._lagId; }
            set { this._lagId = value; }
        }

        // Check to see if LagId property is set
        internal bool IsSetLagId()
        {
            return this._lagId != null;
        }

        /// <summary>
        /// Gets and sets the property LoaIssueTime. 
        /// <para>
        /// The time of the most recent call to <a>DescribeLoa</a> for this connection.
        /// </para>
        /// </summary>
        public DateTime LoaIssueTime
        {
            get { return this._loaIssueTime.GetValueOrDefault(); }
            set { this._loaIssueTime = value; }
        }

        // Check to see if LoaIssueTime property is set
        internal bool IsSetLoaIssueTime()
        {
            return this._loaIssueTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the connection.
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

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The AWS Region where the connection is located.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}