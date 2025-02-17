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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Contains details about the maintenance settings for the table bucket.
    /// </summary>
    public partial class TableBucketMaintenanceSettings
    {
        private IcebergUnreferencedFileRemovalSettings _icebergUnreferencedFileRemoval;

        /// <summary>
        /// Gets and sets the property IcebergUnreferencedFileRemoval. 
        /// <para>
        /// The unreferenced file removal settings for the table bucket.
        /// </para>
        /// </summary>
        public IcebergUnreferencedFileRemovalSettings IcebergUnreferencedFileRemoval
        {
            get { return this._icebergUnreferencedFileRemoval; }
            set { this._icebergUnreferencedFileRemoval = value; }
        }

        // Check to see if IcebergUnreferencedFileRemoval property is set
        internal bool IsSetIcebergUnreferencedFileRemoval()
        {
            return this._icebergUnreferencedFileRemoval != null;
        }

    }
}