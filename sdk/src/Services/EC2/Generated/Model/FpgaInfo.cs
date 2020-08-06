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
    /// Describes the FPGAs for the instance type.
    /// </summary>
    public partial class FpgaInfo
    {
        private List<FpgaDeviceInfo> _fpgas = new List<FpgaDeviceInfo>();
        private int? _totalFpgaMemoryInMiB;

        /// <summary>
        /// Gets and sets the property Fpgas. 
        /// <para>
        /// Describes the FPGAs for the instance type.
        /// </para>
        /// </summary>
        public List<FpgaDeviceInfo> Fpgas
        {
            get { return this._fpgas; }
            set { this._fpgas = value; }
        }

        // Check to see if Fpgas property is set
        internal bool IsSetFpgas()
        {
            return this._fpgas != null && this._fpgas.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TotalFpgaMemoryInMiB. 
        /// <para>
        /// The total memory of all FPGA accelerators for the instance type.
        /// </para>
        /// </summary>
        public int TotalFpgaMemoryInMiB
        {
            get { return this._totalFpgaMemoryInMiB.GetValueOrDefault(); }
            set { this._totalFpgaMemoryInMiB = value; }
        }

        // Check to see if TotalFpgaMemoryInMiB property is set
        internal bool IsSetTotalFpgaMemoryInMiB()
        {
            return this._totalFpgaMemoryInMiB.HasValue; 
        }

    }
}