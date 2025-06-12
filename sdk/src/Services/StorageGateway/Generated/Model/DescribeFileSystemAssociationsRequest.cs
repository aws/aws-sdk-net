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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFileSystemAssociations operation.
    /// Gets the file system association information. This operation is only supported for
    /// FSx File Gateways.
    /// </summary>
    public partial class DescribeFileSystemAssociationsRequest : AmazonStorageGatewayRequest
    {
        private List<string> _fileSystemAssociationARNList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FileSystemAssociationARNList. 
        /// <para>
        /// An array containing the Amazon Resource Name (ARN) of each file system association
        /// to be described.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> FileSystemAssociationARNList
        {
            get { return this._fileSystemAssociationARNList; }
            set { this._fileSystemAssociationARNList = value; }
        }

        // Check to see if FileSystemAssociationARNList property is set
        internal bool IsSetFileSystemAssociationARNList()
        {
            return this._fileSystemAssociationARNList != null && (this._fileSystemAssociationARNList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}