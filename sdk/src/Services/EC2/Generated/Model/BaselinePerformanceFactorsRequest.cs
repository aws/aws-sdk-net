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
    /// The baseline performance to consider, using an instance family as a baseline reference.
    /// The instance family establishes the lowest acceptable level of performance. Amazon
    /// EC2 uses this baseline to guide instance type selection, but there is no guarantee
    /// that the selected instance types will always exceed the baseline for every application.
    /// 
    ///  
    /// <para>
    /// Currently, this parameter only supports CPU performance as a baseline performance
    /// factor. For example, specifying <c>c6i</c> would use the CPU performance of the <c>c6i</c>
    /// family as the baseline reference.
    /// </para>
    /// </summary>
    public partial class BaselinePerformanceFactorsRequest
    {
        private CpuPerformanceFactorRequest _cpu;

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The CPU performance to consider, using an instance family as the baseline reference.
        /// </para>
        /// </summary>
        public CpuPerformanceFactorRequest Cpu
        {
            get { return this._cpu; }
            set { this._cpu = value; }
        }

        // Check to see if Cpu property is set
        internal bool IsSetCpu()
        {
            return this._cpu != null;
        }

    }
}