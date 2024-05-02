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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
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
namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// Provides information of the IP address.
    /// </summary>
    public partial class IpAddressMember
    {
        private AllocationType _allocationType;
        private string _ipAddress;
        private bool? _primary;

        /// <summary>
        /// Gets and sets the property AllocationType. 
        /// <para>
        /// The type of allocation for the IP address.
        /// </para>
        /// </summary>
        public AllocationType AllocationType
        {
            get { return this._allocationType; }
            set { this._allocationType = value; }
        }

        // Check to see if AllocationType property is set
        internal bool IsSetAllocationType()
        {
            return this._allocationType != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address.
        /// </para>
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Primary. 
        /// <para>
        /// The primary IP address.
        /// </para>
        /// </summary>
        public bool? Primary
        {
            get { return this._primary; }
            set { this._primary = value; }
        }

        // Check to see if Primary property is set
        internal bool IsSetPrimary()
        {
            return this._primary.HasValue; 
        }

    }
}