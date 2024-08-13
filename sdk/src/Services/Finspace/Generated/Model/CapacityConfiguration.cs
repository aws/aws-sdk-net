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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// A structure for the metadata of a cluster. It includes information like the CPUs needed,
    /// memory of instances, and number of instances.
    /// </summary>
    public partial class CapacityConfiguration
    {
        private int? _nodeCount;
        private string _nodeType;

        /// <summary>
        /// Gets and sets the property NodeCount. 
        /// <para>
        /// The number of instances running in a cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? NodeCount
        {
            get { return this._nodeCount; }
            set { this._nodeCount = value; }
        }

        // Check to see if NodeCount property is set
        internal bool IsSetNodeCount()
        {
            return this._nodeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The type that determines the hardware of the host computer used for your cluster instance.
        /// Each node type offers different memory and storage capabilities. Choose a node type
        /// based on the requirements of the application or software that you plan to run on your
        /// instance.
        /// </para>
        ///  
        /// <para>
        /// You can only specify one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>kx.s.large</c> – The node type with a configuration of 12 GiB memory and 2 vCPUs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kx.s.xlarge</c> – The node type with a configuration of 27 GiB memory and 4 vCPUs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kx.s.2xlarge</c> – The node type with a configuration of 54 GiB memory and 8 vCPUs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kx.s.4xlarge</c> – The node type with a configuration of 108 GiB memory and 16
        /// vCPUs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kx.s.8xlarge</c> – The node type with a configuration of 216 GiB memory and 32
        /// vCPUs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kx.s.16xlarge</c> – The node type with a configuration of 432 GiB memory and 64
        /// vCPUs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kx.s.32xlarge</c> – The node type with a configuration of 864 GiB memory and 128
        /// vCPUs.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }

    }
}