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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeScanJob operation.
    /// Returns scan job details for the specified ScanJobID.
    /// </summary>
    public partial class DescribeScanJobRequest : AmazonBackupRequest
    {
        private string _scanJobId;

        /// <summary>
        /// Gets and sets the property ScanJobId. 
        /// <para>
        /// Uniquely identifies a request to Backup to scan a resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScanJobId
        {
            get { return this._scanJobId; }
            set { this._scanJobId = value; }
        }

        // Check to see if ScanJobId property is set
        internal bool IsSetScanJobId()
        {
            return this._scanJobId != null;
        }

    }
}