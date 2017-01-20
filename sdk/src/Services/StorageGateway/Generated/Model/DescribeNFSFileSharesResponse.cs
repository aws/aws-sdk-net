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
    /// DescribeNFSFileSharesOutput
    /// </summary>
    public partial class DescribeNFSFileSharesResponse : AmazonWebServiceResponse
    {
        private List<NFSFileShareInfo> _nfsFileShareInfoList = new List<NFSFileShareInfo>();

        /// <summary>
        /// Gets and sets the property NFSFileShareInfoList. 
        /// <para>
        /// An array containing a description for each requested file share. 
        /// </para>
        /// </summary>
        public List<NFSFileShareInfo> NFSFileShareInfoList
        {
            get { return this._nfsFileShareInfoList; }
            set { this._nfsFileShareInfoList = value; }
        }

        // Check to see if NFSFileShareInfoList property is set
        internal bool IsSetNFSFileShareInfoList()
        {
            return this._nfsFileShareInfoList != null && this._nfsFileShareInfoList.Count > 0; 
        }

    }
}