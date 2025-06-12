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
    /// Information about an address range that is provisioned for use with your Amazon Web
    /// Services resources through bring your own IP addresses (BYOIP).
    /// </summary>
    public partial class ByoipCidr
    {
        private List<AsnAssociation> _asnAssociations = AWSConfigs.InitializeCollections ? new List<AsnAssociation>() : null;
        private string _cidr;
        private string _description;
        private string _networkBorderGroup;
        private ByoipCidrState _state;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property AsnAssociations. 
        /// <para>
        /// The BYOIP CIDR associations with ASNs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AsnAssociation> AsnAssociations
        {
            get { return this._asnAssociations; }
            set { this._asnAssociations = value; }
        }

        // Check to see if AsnAssociations property is set
        internal bool IsSetAsnAssociations()
        {
            return this._asnAssociations != null && (this._asnAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The address range, in CIDR notation.
        /// </para>
        /// </summary>
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the address range.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// If you have <a href="https://docs.aws.amazon.com/local-zones/latest/ug/how-local-zones-work.html">Local
        /// Zones</a> enabled, you can choose a network border group for Local Zones when you
        /// provision and advertise a BYOIPv4 CIDR. Choose the network border group carefully
        /// as the EIP and the Amazon Web Services resource it is associated with must reside
        /// in the same network border group.
        /// </para>
        ///  
        /// <para>
        /// You can provision BYOIP address ranges to and advertise them in the following Local
        /// Zone network border groups:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// us-east-1-dfw-2
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// us-west-2-lax-1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// us-west-2-phx-2
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You cannot provision or advertise BYOIPv6 address ranges in Local Zones at this time.
        /// </para>
        ///  </note>
        /// </summary>
        public string NetworkBorderGroup
        {
            get { return this._networkBorderGroup; }
            set { this._networkBorderGroup = value; }
        }

        // Check to see if NetworkBorderGroup property is set
        internal bool IsSetNetworkBorderGroup()
        {
            return this._networkBorderGroup != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the address range.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>advertised</c>: The address range is being advertised to the internet by Amazon
        /// Web Services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deprovisioned</c>: The address range is deprovisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed-deprovision</c>: The request to deprovision the address range was unsuccessful.
        /// Ensure that all EIPs from the range have been deallocated and try again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed-provision</c>: The request to provision the address range was unsuccessful.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending-deprovision</c>: You’ve submitted a request to deprovision an address
        /// range and it's pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending-provision</c>: You’ve submitted a request to provision an address range
        /// and it's pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>provisioned</c>: The address range is provisioned and can be advertised. The range
        /// is not currently advertised.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>provisioned-not-publicly-advertisable</c>: The address range is provisioned and
        /// cannot be advertised.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ByoipCidrState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Upon success, contains the ID of the address pool. Otherwise, contains an error message.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}