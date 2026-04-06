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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Private Connection mode — either service-managed or self-managed.
    /// </summary>
    public partial class PrivateConnectionMode
    {
        private SelfManagedInput _selfManaged;
        private ServiceManagedInput _serviceManaged;

        /// <summary>
        /// Gets and sets the property SelfManaged. 
        /// <para>
        /// Caller manages their own resource configuration.
        /// </para>
        /// </summary>
        public SelfManagedInput SelfManaged
        {
            get { return this._selfManaged; }
            set { this._selfManaged = value; }
        }

        // Check to see if SelfManaged property is set
        internal bool IsSetSelfManaged()
        {
            return this._selfManaged != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceManaged. 
        /// <para>
        /// Service manages the Resource Gateway lifecycle.
        /// </para>
        /// </summary>
        public ServiceManagedInput ServiceManaged
        {
            get { return this._serviceManaged; }
            set { this._serviceManaged = value; }
        }

        // Check to see if ServiceManaged property is set
        internal bool IsSetServiceManaged()
        {
            return this._serviceManaged != null;
        }

    }
}