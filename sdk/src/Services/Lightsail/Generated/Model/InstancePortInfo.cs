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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes information about the instance ports.
    /// </summary>
    public partial class InstancePortInfo
    {
        private AccessDirection _accessDirection;
        private string _accessFrom;
        private PortAccessType _accessType;
        private string _commonName;
        private int? _fromPort;
        private NetworkProtocol _protocol;
        private int? _toPort;

        /// <summary>
        /// Gets and sets the property AccessDirection. 
        /// <para>
        /// The access direction (<code>inbound</code> or <code>outbound</code>).
        /// </para>
        /// </summary>
        public AccessDirection AccessDirection
        {
            get { return this._accessDirection; }
            set { this._accessDirection = value; }
        }

        // Check to see if AccessDirection property is set
        internal bool IsSetAccessDirection()
        {
            return this._accessDirection != null;
        }

        /// <summary>
        /// Gets and sets the property AccessFrom. 
        /// <para>
        /// The location from which access is allowed (e.g., <code>Anywhere (0.0.0.0/0)</code>).
        /// </para>
        /// </summary>
        public string AccessFrom
        {
            get { return this._accessFrom; }
            set { this._accessFrom = value; }
        }

        // Check to see if AccessFrom property is set
        internal bool IsSetAccessFrom()
        {
            return this._accessFrom != null;
        }

        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// The type of access (<code>Public</code> or <code>Private</code>).
        /// </para>
        /// </summary>
        public PortAccessType AccessType
        {
            get { return this._accessType; }
            set { this._accessType = value; }
        }

        // Check to see if AccessType property is set
        internal bool IsSetAccessType()
        {
            return this._accessType != null;
        }

        /// <summary>
        /// Gets and sets the property CommonName. 
        /// <para>
        /// The common name.
        /// </para>
        /// </summary>
        public string CommonName
        {
            get { return this._commonName; }
            set { this._commonName = value; }
        }

        // Check to see if CommonName property is set
        internal bool IsSetCommonName()
        {
            return this._commonName != null;
        }

        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// The first port in the range.
        /// </para>
        /// </summary>
        public int FromPort
        {
            get { return this._fromPort.GetValueOrDefault(); }
            set { this._fromPort = value; }
        }

        // Check to see if FromPort property is set
        internal bool IsSetFromPort()
        {
            return this._fromPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol. 
        /// </para>
        /// </summary>
        public NetworkProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// The last port in the range.
        /// </para>
        /// </summary>
        public int ToPort
        {
            get { return this._toPort.GetValueOrDefault(); }
            set { this._toPort = value; }
        }

        // Check to see if ToPort property is set
        internal bool IsSetToPort()
        {
            return this._toPort.HasValue; 
        }

    }
}