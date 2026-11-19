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
    /// Describes the FPGAs for the instance type.
    /// </summary>
    public partial class FpgaInfo
    {
        /// <summary>
        /// Gets and sets the property Fpgas. 
        /// <para>
        /// Describes the FPGAs for the instance type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FpgaDeviceInfo> Fpgas { get; set; } = AWSConfigs.InitializeCollections ? new List<FpgaDeviceInfo>() : null;

        /// <summary>
        /// Checks to see if the Fpgas property is set.
        /// </summary>
        internal bool IsSetFpgas() => this.Fpgas != null && (this.Fpgas.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalFpgaMemoryInMiB. 
        /// <para>
        /// The total memory of all FPGA accelerators for the instance type.
        /// </para>
        /// </summary>
        public int? TotalFpgaMemoryInMiB { get; set; }

        /// <summary>
        /// Checks to see if the TotalFpgaMemoryInMiB property is set.
        /// </summary>
        internal bool IsSetTotalFpgaMemoryInMiB() => this.TotalFpgaMemoryInMiB.HasValue;
    }
}
