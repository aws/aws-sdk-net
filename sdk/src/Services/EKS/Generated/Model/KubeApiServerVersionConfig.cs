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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// The Kubernetes API server version-specific configuration defaults and constraints.
    /// </summary>
    public partial class KubeApiServerVersionConfig
    {
        private DurationParameterConfig _eventTtl;
        private PortRangeParameterConfig _serviceNodePortRange;

        /// <summary>
        /// Gets and sets the property EventTtl. 
        /// <para>
        /// The event TTL configuration with default value and constraints.
        /// </para>
        /// </summary>
        public DurationParameterConfig EventTtl
        {
            get { return this._eventTtl; }
            set { this._eventTtl = value; }
        }

        // Check to see if EventTtl property is set
        internal bool IsSetEventTtl()
        {
            return this._eventTtl != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNodePortRange. 
        /// <para>
        /// The service node port range configuration with default value and constraints.
        /// </para>
        /// </summary>
        public PortRangeParameterConfig ServiceNodePortRange
        {
            get { return this._serviceNodePortRange; }
            set { this._serviceNodePortRange = value; }
        }

        // Check to see if ServiceNodePortRange property is set
        internal bool IsSetServiceNodePortRange()
        {
            return this._serviceNodePortRange != null;
        }

    }
}