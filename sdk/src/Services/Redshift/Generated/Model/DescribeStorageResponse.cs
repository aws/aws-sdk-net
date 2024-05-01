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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
        private double? _totalBackupSizeInMegaBytes;
        private double? _totalProvisionedStorageInMegaBytes;

        /// <summary>
        /// Gets and sets the property TotalBackupSizeInMegaBytes. 
        /// <para>
        /// The total amount of storage currently used for snapshots.
        /// </para>
        /// </summary>
        public double? TotalBackupSizeInMegaBytes
        {
            get { return this._totalBackupSizeInMegaBytes; }
            set { this._totalBackupSizeInMegaBytes = value; }
        }

        // Check to see if TotalBackupSizeInMegaBytes property is set
        internal bool IsSetTotalBackupSizeInMegaBytes()
        {
            return this._totalBackupSizeInMegaBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalProvisionedStorageInMegaBytes. 
        /// <para>
        /// The total amount of storage currently provisioned.
        /// </para>
        /// </summary>
        public double? TotalProvisionedStorageInMegaBytes
        {
            get { return this._totalProvisionedStorageInMegaBytes; }
            set { this._totalProvisionedStorageInMegaBytes = value; }
        }

        // Check to see if TotalProvisionedStorageInMegaBytes property is set
        internal bool IsSetTotalProvisionedStorageInMegaBytes()
        {
            return this._totalProvisionedStorageInMegaBytes.HasValue; 
        }

    }
}