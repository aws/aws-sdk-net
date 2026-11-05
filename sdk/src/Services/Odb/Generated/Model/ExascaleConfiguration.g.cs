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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// The Exascale storage configuration of an Exadata infrastructure.
    /// </summary>
    public partial class ExascaleConfiguration
    {
        /// <summary>
        /// Gets and sets the property AvailableStorageSizeInGBs. 
        /// <para>
        /// The amount of Exascale storage, in gigabytes (GB), that's available on the Exadata
        /// infrastructure.
        /// </para>
        /// </summary>
        public int? AvailableStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the AvailableStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetAvailableStorageSizeInGBs() => this.AvailableStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableVmStorageSizeInGBs. 
        /// <para>
        /// The amount of Exascale VM storage, in gigabytes (GB), that's available on the Exadata
        /// infrastructure.
        /// </para>
        /// </summary>
        public int? AvailableVmStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the AvailableVmStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetAvailableVmStorageSizeInGBs() => this.AvailableVmStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property TotalStorageSizeInGBs. 
        /// <para>
        /// The total amount of Exascale storage, in gigabytes (GB), configured on the Exadata
        /// infrastructure.
        /// </para>
        /// </summary>
        public int? TotalStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the TotalStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetTotalStorageSizeInGBs() => this.TotalStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property TotalVmStorageSizeInGBs. 
        /// <para>
        /// The total amount of Exascale VM storage, in gigabytes (GB), on the Exadata infrastructure.
        /// VM clusters use Exascale VM storage for their VM file systems and VM backups.
        /// </para>
        /// </summary>
        public int? TotalVmStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the TotalVmStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetTotalVmStorageSizeInGBs() => this.TotalVmStorageSizeInGBs.HasValue;
    }
}
