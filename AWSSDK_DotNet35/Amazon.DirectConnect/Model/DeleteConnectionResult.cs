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
    /// A connection represents the physical network connection between the AWS Direct Connect
    /// location and the customer.
    /// </summary>
    public partial class DeleteConnectionResult : AmazonWebServiceResponse
    {
        private string _bandwidth;
        private string _connectionId;
        private string _connectionName;
        private ConnectionState _connectionState;
        private string _location;
        private string _ownerAccount;
        private string _partnerName;
        private string _region;
        private int? _vlan;

        /// <summary>
        /// Gets and sets the property Bandwidth. 
        /// <para>
        /// Bandwidth of the connection.
        /// </para>
        ///  
        /// <para>
        /// Example: 1Gbps (for regular connections), or 500Mbps (for hosted connections)
        /// </para>
        ///  
        /// <para>
        /// Default: None
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
        /// Gets and sets the property ConnectionId.
        /// </summary>
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionName.
        /// </summary>
        public string ConnectionName
        {
            get { return this._connectionName; }
            set { this._connectionName = value; }
        }

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this._connectionName != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionState.
        /// </summary>
        public ConnectionState ConnectionState
        {
            get { return this._connectionState; }
            set { this._connectionState = value; }
        }

        // Check to see if ConnectionState property is set
        internal bool IsSetConnectionState()
        {
            return this._connectionState != null;
        }

        /// <summary>
        /// Gets and sets the property Location.
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
        /// Gets and sets the property OwnerAccount.
        /// </summary>
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property PartnerName.
        /// </summary>
        public string PartnerName
        {
            get { return this._partnerName; }
            set { this._partnerName = value; }
        }

        // Check to see if PartnerName property is set
        internal bool IsSetPartnerName()
        {
            return this._partnerName != null;
        }

        /// <summary>
        /// Gets and sets the property Region.
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

        /// <summary>
        /// Gets and sets the property Vlan.
        /// </summary>
        public int Vlan
        {
            get { return this._vlan.GetValueOrDefault(); }
            set { this._vlan = value; }
        }

        // Check to see if Vlan property is set
        internal bool IsSetVlan()
        {
            return this._vlan.HasValue; 
        }

    }
}