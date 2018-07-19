/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeNFSFileShares operation.
    /// Gets a description for one or more Network File System (NFS) file shares from a file
    /// gateway. This operation is only supported in the file gateway type.
    /// </summary>
    public partial class DescribeNFSFileSharesRequest : AmazonStorageGatewayRequest
    {
        private List<string> _fileShareARNList = new List<string>();

        /// <summary>
        /// Gets and sets the property FileShareARNList. 
        /// <para>
        /// An array containing the Amazon Resource Name (ARN) of each file share to be described.
        /// 
        /// </para>
        /// </summary>
        public List<string> FileShareARNList
        {
            get { return this._fileShareARNList; }
            set { this._fileShareARNList = value; }
        }

        // Check to see if FileShareARNList property is set
        internal bool IsSetFileShareARNList()
        {
            return this._fileShareARNList != null && this._fileShareARNList.Count > 0; 
        }

    }
}