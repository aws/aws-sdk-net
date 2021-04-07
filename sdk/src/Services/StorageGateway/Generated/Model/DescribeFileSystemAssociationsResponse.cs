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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// This is the response object from the DescribeFileSystemAssociations operation.
    /// </summary>
    public partial class DescribeFileSystemAssociationsResponse : AmazonWebServiceResponse
    {
        private List<FileSystemAssociationInfo> _fileSystemAssociationInfoList = new List<FileSystemAssociationInfo>();

        /// <summary>
        /// Gets and sets the property FileSystemAssociationInfoList. 
        /// <para>
        /// An array containing the <code>FileSystemAssociationInfo</code> data type of each file
        /// system association to be described. 
        /// </para>
        /// </summary>
        public List<FileSystemAssociationInfo> FileSystemAssociationInfoList
        {
            get { return this._fileSystemAssociationInfoList; }
            set { this._fileSystemAssociationInfoList = value; }
        }

        // Check to see if FileSystemAssociationInfoList property is set
        internal bool IsSetFileSystemAssociationInfoList()
        {
            return this._fileSystemAssociationInfoList != null && this._fileSystemAssociationInfoList.Count > 0; 
        }

    }
}