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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The configuration details for a service managed Amazon EC2 fleet.
    /// </summary>
    public partial class ServiceManagedEc2FleetConfiguration
    {
        private ServiceManagedEc2InstanceCapabilities _instanceCapabilities;
        private ServiceManagedEc2InstanceMarketOptions _instanceMarketOptions;

        /// <summary>
        /// Gets and sets the property InstanceCapabilities. 
        /// <para>
        /// The Amazon EC2 instance capabilities.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceManagedEc2InstanceCapabilities InstanceCapabilities
        {
            get { return this._instanceCapabilities; }
            set { this._instanceCapabilities = value; }
        }

        // Check to see if InstanceCapabilities property is set
        internal bool IsSetInstanceCapabilities()
        {
            return this._instanceCapabilities != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceMarketOptions. 
        /// <para>
        /// The Amazon EC2 market type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceManagedEc2InstanceMarketOptions InstanceMarketOptions
        {
            get { return this._instanceMarketOptions; }
            set { this._instanceMarketOptions = value; }
        }

        // Check to see if InstanceMarketOptions property is set
        internal bool IsSetInstanceMarketOptions()
        {
            return this._instanceMarketOptions != null;
        }

    }
}