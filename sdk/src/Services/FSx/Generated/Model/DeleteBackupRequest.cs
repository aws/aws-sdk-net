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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBackup operation.
    /// Deletes an Amazon FSx backup. After deletion, the backup no longer exists, and its
    /// data is gone.
    /// 
    ///  
    /// <para>
    /// The <c>DeleteBackup</c> call returns instantly. The backup won't show up in later
    /// <c>DescribeBackups</c> calls.
    /// </para>
    ///  <important> 
    /// <para>
    /// The data in a deleted backup is also deleted and can't be recovered by any means.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteBackupRequest : AmazonFSxRequest
    {
        private string _backupId;
        private string _clientRequestToken;

        /// <summary>
        /// Gets and sets the property BackupId. 
        /// <para>
        /// The ID of the backup that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=128)]
        public string BackupId
        {
            get { return this._backupId; }
            set { this._backupId = value; }
        }

        // Check to see if BackupId property is set
        internal bool IsSetBackupId()
        {
            return this._backupId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A string of up to 63 ASCII characters that Amazon FSx uses to ensure idempotent deletion.
        /// This parameter is automatically filled on your behalf when using the CLI or SDK.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

    }
}