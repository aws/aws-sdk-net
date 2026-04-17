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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The network interface configuration for a Amazon SageMaker HyperPod cluster instance
    /// group.
    /// </summary>
    public partial class ClusterNetworkInterface
    {
        private ClusterInterfaceType _interfaceType;

        /// <summary>
        /// Gets and sets the property InterfaceType. 
        /// <para>
        /// The type of network interface for the instance group. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>efa</c> – An EFA with ENA interface, which provides both the EFA device for low-latency,
        /// high-throughput communication and the ENA device for IP networking.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>efa-only</c> – An EFA-only interface, which provides only the EFA device capabilities
        /// without the ENA device for traditional IP networking.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/efa.html">Elastic
        /// Fabric Adapter</a>.
        /// </para>
        /// </summary>
        public ClusterInterfaceType InterfaceType
        {
            get { return this._interfaceType; }
            set { this._interfaceType = value; }
        }

        // Check to see if InterfaceType property is set
        internal bool IsSetInterfaceType()
        {
            return this._interfaceType != null;
        }

    }
}