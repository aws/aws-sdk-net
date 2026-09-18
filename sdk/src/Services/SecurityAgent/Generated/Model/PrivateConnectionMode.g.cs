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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// The configuration for a private connection. Specify either a service-managed or a
    /// self-managed mode.
    /// </summary>
    public partial class PrivateConnectionMode
    {
        /// <summary>
        /// Gets and sets the property SelfManaged. 
        /// <para>
        /// The configuration for a self-managed private connection, where you manage your own
        /// resource configuration.
        /// </para>
        /// </summary>
        public SelfManagedInput SelfManaged { get; set; }

        /// <summary>
        /// Checks to see if the SelfManaged property is set.
        /// </summary>
        internal bool IsSetSelfManaged() => this.SelfManaged != null;

        /// <summary>
        /// Gets and sets the property ServiceManaged. 
        /// <para>
        /// The configuration for a service-managed private connection, where the service manages
        /// the resource gateway lifecycle.
        /// </para>
        /// </summary>
        public ServiceManagedInput ServiceManaged { get; set; }

        /// <summary>
        /// Checks to see if the ServiceManaged property is set.
        /// </summary>
        internal bool IsSetServiceManaged() => this.ServiceManaged != null;
    }
}
