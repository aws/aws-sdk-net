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
    /// Container for the parameters to the CreateConnection operation.
    /// Creates a new connection between the customer network and a specific AWS Direct Connect
    /// location.
    /// 
    ///  
    /// <para>
    /// A connection links your internal network to an AWS Direct Connect location over a
    /// standard 1 gigabit or 10 gigabit Ethernet fiber-optic cable. One end of the cable
    /// is connected to your router, the other to an AWS Direct Connect router. An AWS Direct
    /// Connect location provides access to Amazon Web Services in the region it is associated
    /// with. You can establish connections with AWS Direct Connect locations in multiple
    /// regions, but a connection in one region does not provide connectivity to other regions.
    /// </para>
    ///  
    /// <para>
    /// You can automatically add the new connection to a link aggregation group (LAG) by
    /// specifying a LAG ID in the request. This ensures that the new connection is allocated
    /// on the same AWS Direct Connect endpoint that hosts the specified LAG. If there are
    /// no available ports on the endpoint, the request fails and no connection will be created.
    /// </para>
    /// </summary>
    public partial class CreateConnectionRequest : AmazonDirectConnectRequest
    {
        private string _bandwidth;
        private string _connectionName;
        private string _lagId;
        private string _location;

        /// <summary>
        /// Gets and sets the property Bandwidth.
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
        /// Gets and sets the property LagId.
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

    }
}