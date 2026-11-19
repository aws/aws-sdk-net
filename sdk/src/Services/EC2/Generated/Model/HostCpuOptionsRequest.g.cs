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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains the CPU configuration options for a Dedicated Host allocation request. Options
    /// include AMD Secure Encrypted Virtualization-Secure Nested Paging (AMD SEV-SNP) settings.
    /// </summary>
    public partial class HostCpuOptionsRequest
    {
        /// <summary>
        /// Gets and sets the property AmdSevSnp. 
        /// <para>
        /// Specifies whether AMD Secure Encrypted Virtualization-Secure Nested Paging (AMD SEV-SNP)
        /// is enabled or disabled for the Dedicated Host. If you don't specify a value, AMD SEV-SNP
        /// is <c>disabled</c>.
        /// </para>
        /// </summary>
        public AmdSevSnp AmdSevSnp { get; set; }

        /// <summary>
        /// Checks to see if the AmdSevSnp property is set.
        /// </summary>
        internal bool IsSetAmdSevSnp() => this.AmdSevSnp != null;
    }
}
