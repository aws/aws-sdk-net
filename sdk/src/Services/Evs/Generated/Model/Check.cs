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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// A check on the environment to identify environment health and validate VMware VCF
    /// licensing compliance.
    /// </summary>
    public partial class Check
    {
        private DateTime? _impairedSince;
        private CheckResult _result;
        private CheckType _type;

        /// <summary>
        /// Gets and sets the property ImpairedSince. 
        /// <para>
        /// The time when environment health began to be impaired.
        /// </para>
        /// </summary>
        public DateTime? ImpairedSince
        {
            get { return this._impairedSince; }
            set { this._impairedSince = value; }
        }

        // Check to see if ImpairedSince property is set
        internal bool IsSetImpairedSince()
        {
            return this._impairedSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        ///  The check result.
        /// </para>
        /// </summary>
        public CheckResult Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The check type. Amazon EVS performs the following checks.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KEY_REUSE</c>: checks that the VCF license key is not used by another Amazon EVS
        /// environment. This check fails if a used license is added to the environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KEY_COVERAGE</c>: checks that your VCF license key allocates sufficient vCPU cores
        /// for all deployed hosts. The check fails when any assigned hosts in the EVS environment
        /// are not covered by license keys, or when any unassigned hosts cannot be covered by
        /// available vCPU cores in keys.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REACHABILITY</c>: checks that the Amazon EVS control plane has a persistent connection
        /// to SDDC Manager. If Amazon EVS cannot reach the environment, this check fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOST_COUNT</c>: Checks that your environment has a minimum of 4 hosts, which is
        /// a requirement for VCF 5.2.1.
        /// </para>
        ///  
        /// <para>
        /// If this check fails, you will need to add hosts so that your environment meets this
        /// minimum requirement. Amazon EVS only supports environments with 4-16 hosts.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CheckType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}