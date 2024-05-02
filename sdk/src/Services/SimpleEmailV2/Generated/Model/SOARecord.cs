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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains information about the start of authority (SOA) record associated
    /// with the identity.
    /// </summary>
    public partial class SOARecord
    {
        private string _adminEmail;
        private string _primaryNameServer;
        private long? _serialNumber;

        /// <summary>
        /// Gets and sets the property AdminEmail. 
        /// <para>
        /// Administrative contact email from the SOA record.
        /// </para>
        /// </summary>
        public string AdminEmail
        {
            get { return this._adminEmail; }
            set { this._adminEmail = value; }
        }

        // Check to see if AdminEmail property is set
        internal bool IsSetAdminEmail()
        {
            return this._adminEmail != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryNameServer. 
        /// <para>
        /// Primary name server specified in the SOA record.
        /// </para>
        /// </summary>
        public string PrimaryNameServer
        {
            get { return this._primaryNameServer; }
            set { this._primaryNameServer = value; }
        }

        // Check to see if PrimaryNameServer property is set
        internal bool IsSetPrimaryNameServer()
        {
            return this._primaryNameServer != null;
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// Serial number from the SOA record.
        /// </para>
        /// </summary>
        public long? SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this._serialNumber.HasValue; 
        }

    }
}