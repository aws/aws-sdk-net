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

namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// Describes the properties of the Dedicated Host.
    /// </summary>
    public partial class Host
    {
        private string _hostIp;
        private string _hostName;
        private HostRole _hostRole;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property HostIp. 
        /// <para>
        /// The IP address of the Dedicated Host. 
        /// </para>
        /// </summary>
        public string HostIp
        {
            get { return this._hostIp; }
            set { this._hostIp = value; }
        }

        // Check to see if HostIp property is set
        internal bool IsSetHostIp()
        {
            return this._hostIp != null;
        }

        /// <summary>
        /// Gets and sets the property HostName. 
        /// <para>
        /// The name of the Dedicated Host.
        /// </para>
        /// </summary>
        public string HostName
        {
            get { return this._hostName; }
            set { this._hostName = value; }
        }

        // Check to see if HostName property is set
        internal bool IsSetHostName()
        {
            return this._hostName != null;
        }

        /// <summary>
        /// Gets and sets the property HostRole. 
        /// <para>
        /// The role of the Dedicated Host.
        /// </para>
        /// </summary>
        public HostRole HostRole
        {
            get { return this._hostRole; }
            set { this._hostRole = value; }
        }

        // Check to see if HostRole property is set
        internal bool IsSetHostRole()
        {
            return this._hostRole != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID of the instance on the Dedicated Host.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}