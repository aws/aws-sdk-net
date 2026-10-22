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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Fleet configuration details.
    /// </summary>
    public partial class FleetConfiguration
    {
        /// <summary>
        /// Gets and sets the property CustomerManaged. 
        /// <para>
        /// The customer managed fleets within a fleet configuration.
        /// </para>
        /// </summary>
        public CustomerManagedFleetConfiguration CustomerManaged { get; set; }

        /// <summary>
        /// Checks to see if the CustomerManaged property is set.
        /// </summary>
        internal bool IsSetCustomerManaged() => this.CustomerManaged != null;

        /// <summary>
        /// Gets and sets the property ServiceManagedEc2. 
        /// <para>
        /// The service managed Amazon EC2 instances for a fleet configuration.
        /// </para>
        /// </summary>
        public ServiceManagedEc2FleetConfiguration ServiceManagedEc2 { get; set; }

        /// <summary>
        /// Checks to see if the ServiceManagedEc2 property is set.
        /// </summary>
        internal bool IsSetServiceManagedEc2() => this.ServiceManagedEc2 != null;
    }
}
