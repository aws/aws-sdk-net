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
    /// An interconnect is a connection that can host other connections.
    /// 
    ///  
    /// <para>
    /// Like a standard AWS Direct Connect connection, an interconnect represents the physical
    /// connection between an AWS Direct Connect partner's network and a specific Direct Connect
    /// location. An AWS Direct Connect partner who owns an interconnect can provision hosted
    /// connections on the interconnect for their end customers, thereby providing the end
    /// customers with connectivity to AWS services.
    /// </para>
    ///  
    /// <para>
    /// The resources of the interconnect, including bandwidth and VLAN numbers, are shared
    /// by all of the hosted connections on the interconnect, and the owner of the interconnect
    /// determines how these resources are assigned.
    /// </para>
    /// </summary>
    public partial class CreateInterconnectResult : AmazonWebServiceResponse
    {
        private string _bandwidth;
        private string _interconnectId;
        private string _interconnectName;
        private InterconnectState _interconnectState;
        private string _location;
        private string _region;

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
        /// Gets and sets the property InterconnectId.
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

    }
}