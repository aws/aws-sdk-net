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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Describes the properties of the Dedicated Host.
    /// </summary>
    public partial class Host
    {
        /// <summary>
        /// Gets and sets the property EC2InstanceId. 
        /// <para>
        /// The ID of Amazon EC2 instance.
        /// </para>
        /// </summary>
        public string EC2InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the EC2InstanceId property is set.
        /// </summary>
        internal bool IsSetEC2InstanceId() => this.EC2InstanceId != null;

        /// <summary>
        /// Gets and sets the property HostIp. 
        /// <para>
        /// The IP address of the Dedicated Host. 
        /// </para>
        /// </summary>
        public string HostIp { get; set; }

        /// <summary>
        /// Checks to see if the HostIp property is set.
        /// </summary>
        internal bool IsSetHostIp() => this.HostIp != null;

        /// <summary>
        /// Gets and sets the property HostName. 
        /// <para>
        /// The name of the Dedicated Host.
        /// </para>
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// Checks to see if the HostName property is set.
        /// </summary>
        internal bool IsSetHostName() => this.HostName != null;

        /// <summary>
        /// Gets and sets the property HostRole. 
        /// <para>
        /// The role of the Dedicated Host.
        /// </para>
        /// </summary>
        public HostRole HostRole { get; set; }

        /// <summary>
        /// Checks to see if the HostRole property is set.
        /// </summary>
        internal bool IsSetHostRole() => this.HostRole != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID of the instance on the Dedicated Host.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property OsVersion. 
        /// <para>
        /// The version of the operating system.
        /// </para>
        /// </summary>
        public string OsVersion { get; set; }

        /// <summary>
        /// Checks to see if the OsVersion property is set.
        /// </summary>
        internal bool IsSetOsVersion() => this.OsVersion != null;
    }
}
