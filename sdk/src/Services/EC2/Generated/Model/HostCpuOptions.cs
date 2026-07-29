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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Contains the CPU options for a Dedicated Host, including AMD Secure Encrypted Virtualization-Secure
    /// Nested Paging (AMD SEV-SNP) settings.
    /// </summary>
    public partial class HostCpuOptions
    {
        private AmdSevSnp _amdSevSnp;

        /// <summary>
        /// Gets and sets the property AmdSevSnp. 
        /// <para>
        /// Specifies whether AMD Secure Encrypted Virtualization-Secure Nested Paging (AMD SEV-SNP)
        /// is enabled or disabled for the Dedicated Host. If you don't specify a value, AMD SEV-SNP
        /// is <c>disabled</c>.
        /// </para>
        /// </summary>
        public AmdSevSnp AmdSevSnp
        {
            get { return this._amdSevSnp; }
            set { this._amdSevSnp = value; }
        }

        // Check to see if AmdSevSnp property is set
        internal bool IsSetAmdSevSnp()
        {
            return this._amdSevSnp != null;
        }

    }
}