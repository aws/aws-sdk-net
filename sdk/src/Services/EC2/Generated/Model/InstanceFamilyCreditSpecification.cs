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
    /// Describes the default credit option for CPU usage of a burstable performance instance
    /// family.
    /// </summary>
    public partial class InstanceFamilyCreditSpecification
    {
        private string _cpuCredits;
        private UnlimitedSupportedInstanceFamily _instanceFamily;

        /// <summary>
        /// Gets and sets the property CpuCredits. 
        /// <para>
        /// The default credit option for CPU usage of the instance family. Valid values are <c>standard</c>
        /// and <c>unlimited</c>.
        /// </para>
        /// </summary>
        public string CpuCredits
        {
            get { return this._cpuCredits; }
            set { this._cpuCredits = value; }
        }

        // Check to see if CpuCredits property is set
        internal bool IsSetCpuCredits()
        {
            return this._cpuCredits != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceFamily. 
        /// <para>
        /// The instance family.
        /// </para>
        /// </summary>
        public UnlimitedSupportedInstanceFamily InstanceFamily
        {
            get { return this._instanceFamily; }
            set { this._instanceFamily = value; }
        }

        // Check to see if InstanceFamily property is set
        internal bool IsSetInstanceFamily()
        {
            return this._instanceFamily != null;
        }

    }
}