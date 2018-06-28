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
    /// DescribeSMBFileSharesOutput
    /// </summary>
    public partial class DescribeSMBFileSharesResponse : AmazonWebServiceResponse
    {
        private List<SMBFileShareInfo> _smbFileShareInfoList = new List<SMBFileShareInfo>();

        /// <summary>
        /// Gets and sets the property SMBFileShareInfoList. 
        /// <para>
        /// An array containing a description for each requested file share. 
        /// </para>
        /// </summary>
        public List<SMBFileShareInfo> SMBFileShareInfoList
        {
            get { return this._smbFileShareInfoList; }
            set { this._smbFileShareInfoList = value; }
        }

        // Check to see if SMBFileShareInfoList property is set
        internal bool IsSetSMBFileShareInfoList()
        {
            return this._smbFileShareInfoList != null && this._smbFileShareInfoList.Count > 0; 
        }

    }
}