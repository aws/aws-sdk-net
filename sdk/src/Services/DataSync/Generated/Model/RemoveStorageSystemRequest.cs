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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveStorageSystem operation.
    /// Permanently removes a storage system resource from DataSync Discovery, including the
    /// associated discovery jobs, collected data, and recommendations.
    /// </summary>
    public partial class RemoveStorageSystemRequest : AmazonDataSyncRequest
    {
        private string _storageSystemArn;

        /// <summary>
        /// Gets and sets the property StorageSystemArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the storage system that you want to permanently
        /// remove from DataSync Discovery.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string StorageSystemArn
        {
            get { return this._storageSystemArn; }
            set { this._storageSystemArn = value; }
        }

        // Check to see if StorageSystemArn property is set
        internal bool IsSetStorageSystemArn()
        {
            return this._storageSystemArn != null;
        }

    }
}