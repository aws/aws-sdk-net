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
    /// Configures ENA Express for UDP network traffic from your launch template.
    /// </summary>
    public partial class EnaSrdUdpSpecificationRequest
    {
        private bool? _enaSrdUdpEnabled;

        /// <summary>
        /// Gets and sets the property EnaSrdUdpEnabled. 
        /// <para>
        /// Indicates whether UDP traffic uses ENA Express for your instance. To ensure that UDP
        /// traffic can use ENA Express when you launch an instance, you must also set <b>EnaSrdEnabled</b>
        /// in the <b>EnaSrdSpecificationRequest</b> to <c>true</c>.
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