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
    /// ENA Express is compatible with both TCP and UDP transport protocols. When it's enabled,
    /// TCP traffic automatically uses it. However, some UDP-based applications are designed
    /// to handle network packets that are out of order, without a need for retransmission,
    /// such as live video broadcasting or other near-real-time applications. For UDP traffic,
    /// you can specify whether to use ENA Express, based on your application environment
    /// needs.
    /// </summary>
    public partial class AttachmentEnaSrdUdpSpecification
    {
        private bool? _enaSrdUdpEnabled;

        /// <summary>
        /// Gets and sets the property EnaSrdUdpEnabled. 
        /// <para>
        /// Indicates whether UDP traffic to and from the instance uses ENA Express. To specify
        /// this setting, you must first enable ENA Express.
        /// </para>
        /// </summary>
        public bool? EnaSrdUdpEnabled
        {
            get { return this._enaSrdUdpEnabled; }
            set { this._enaSrdUdpEnabled = value; }
        }

        // Check to see if EnaSrdUdpEnabled property is set
        internal bool IsSetEnaSrdUdpEnabled()
        {
            return this._enaSrdUdpEnabled.HasValue; 
        }

    }
}