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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the credit option for CPU usage of a T2, T3, or T3a instance.
    /// </summary>
    public partial class CreditSpecification
    {
        private string _cpuCredits;

        /// <summary>
        /// Gets and sets the property CpuCredits. 
        /// <para>
        /// The credit option for CPU usage of a T2, T3, or T3a instance. Valid values are <code>standard</code>
        /// and <code>unlimited</code>.
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

    }
}