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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes configuration settings related to network traffic of an App Runner service.
    /// Consists of embedded objects for each configurable network feature.
    /// </summary>
    public partial class NetworkConfiguration
    {
        private EgressConfiguration _egressConfiguration;
        private IngressConfiguration _ingressConfiguration;

        /// <summary>
        /// Gets and sets the property EgressConfiguration. 
        /// <para>
        /// Network configuration settings for outbound message traffic.
        /// </para>
        /// </summary>
        public EgressConfiguration EgressConfiguration
        {
            get { return this._egressConfiguration; }
            set { this._egressConfiguration = value; }
        }

        // Check to see if EgressConfiguration property is set
        internal bool IsSetEgressConfiguration()
        {
            return this._egressConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property IngressConfiguration. 
        /// <para>
        /// Network configuration settings for inbound message traffic.
        /// </para>
        /// </summary>
        public IngressConfiguration IngressConfiguration
        {
            get { return this._ingressConfiguration; }
            set { this._ingressConfiguration = value; }
        }

        // Check to see if IngressConfiguration property is set
        internal bool IsSetIngressConfiguration()
        {
            return this._ingressConfiguration != null;
        }

    }
}