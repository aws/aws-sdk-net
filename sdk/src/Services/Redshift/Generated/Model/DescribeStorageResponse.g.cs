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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the DescribeStorage operation.
    /// </summary>
    public partial class DescribeStorageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property TotalBackupSizeInMegaBytes. 
        /// <para>
        /// The total amount of storage currently used for snapshots.
        /// </para>
        /// </summary>
        public double? TotalBackupSizeInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalBackupSizeInMegaBytes property is set.
        /// </summary>
        internal bool IsSetTotalBackupSizeInMegaBytes() => this.TotalBackupSizeInMegaBytes.HasValue;

        /// <summary>
        /// Gets and sets the property TotalProvisionedStorageInMegaBytes. 
        /// <para>
        /// The total amount of storage currently provisioned.
        /// </para>
        /// </summary>
        public double? TotalProvisionedStorageInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalProvisionedStorageInMegaBytes property is set.
        /// </summary>
        internal bool IsSetTotalProvisionedStorageInMegaBytes() => this.TotalProvisionedStorageInMegaBytes.HasValue;
    }
}
