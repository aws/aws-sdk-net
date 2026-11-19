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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The CPU configuration for capacity provider instances, including nested virtualization.
    /// </summary>
    public partial class CpuOptions
    {
        /// <summary>
        /// Gets and sets the property NestedVirtualization. 
        /// <para>
        /// Specifies whether your agents can use hardware virtualization on their instances.
        /// The following values are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c> – Your agents can use hardware virtualization on their instances.
        /// To use this value, choose the <c>LINUX_X86_64</c> operating system and instance types
        /// that support nested virtualization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> – Your agents can't use hardware virtualization on their instances.
        /// This is the default.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public NestedVirtualization NestedVirtualization { get; set; }

        /// <summary>
        /// Checks to see if the NestedVirtualization property is set.
        /// </summary>
        internal bool IsSetNestedVirtualization() => this.NestedVirtualization != null;
    }
}
