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
    /// The storage details for an Exascale storage vault.
    /// </summary>
    public partial class ExascaleDbStorageDetails
    {
        /// <summary>
        /// Gets and sets the property AvailableSizeInGBs. 
        /// <para>
        /// The available storage size, in gigabytes (GB).
        /// </para>
        /// </summary>
        public int? AvailableSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the AvailableSizeInGBs property is set.
        /// </summary>
        internal bool IsSetAvailableSizeInGBs() => this.AvailableSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property TotalSizeInGBs. 
        /// <para>
        /// The total storage size, in gigabytes (GB).
        /// </para>
        /// </summary>
        public int? TotalSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the TotalSizeInGBs property is set.
        /// </summary>
        internal bool IsSetTotalSizeInGBs() => this.TotalSizeInGBs.HasValue;
    }
}
