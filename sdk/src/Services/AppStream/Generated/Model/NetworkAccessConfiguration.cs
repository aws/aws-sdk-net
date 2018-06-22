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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// The network details of the fleet instance for the streaming session.
    /// </summary>
    public partial class NetworkAccessConfiguration
    {
        private string _eniId;
        private string _eniPrivateIpAddress;

        /// <summary>
        /// Gets and sets the property EniId. 
        /// <para>
        /// The resource identifier of the elastic network interface that is attached to instances
        /// in your VPC. All network interfaces have the eni-xxxxxxxx resource identifier.
        /// </para>
        /// </summary>
        public string EniId
        {
            get { return this._eniId; }
            set { this._eniId = value; }
        }

        // Check to see if EniId property is set
        internal bool IsSetEniId()
        {
            return this._eniId != null;
        }

        /// <summary>
        /// Gets and sets the property EniPrivateIpAddress. 
        /// <para>
        /// The private IP address of the elastic network interface that is attached to instances
        /// in your VPC.
        /// </para>
        /// </summary>
        public string EniPrivateIpAddress
        {
            get { return this._eniPrivateIpAddress; }
            set { this._eniPrivateIpAddress = value; }
        }

        // Check to see if EniPrivateIpAddress property is set
        internal bool IsSetEniPrivateIpAddress()
        {
            return this._eniPrivateIpAddress != null;
        }

    }
}