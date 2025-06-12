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
    /// Container for the parameters to the RefreshCache operation.
    /// Refreshes the cached inventory of objects for the specified file share. This operation
    /// finds objects in the Amazon S3 bucket that were added, removed, or replaced since
    /// the gateway last listed the bucket's contents and cached the results. This operation
    /// does not import files into the S3 File Gateway cache storage. It only updates the
    /// cached inventory to reflect changes in the inventory of the objects in the S3 bucket.
    /// This operation is only supported in the S3 File Gateway types.
    /// 
    ///  
    /// <para>
    /// You can subscribe to be notified through an Amazon CloudWatch event when your <c>RefreshCache</c>
    /// operation completes. For more information, see <a href="https://docs.aws.amazon.com/filegateway/latest/files3/monitoring-file-gateway.html#get-notification">Getting
    /// notified about file operations</a> in the <i>Amazon S3 File Gateway User Guide</i>.
    /// This operation is Only supported for S3 File Gateways.
    /// </para>
    ///  
    /// <para>
    /// When this API is called, it only initiates the refresh operation. When the API call
    /// completes and returns a success code, it doesn't necessarily mean that the file refresh
    /// has completed. You should use the refresh-complete notification to determine that
    /// the operation has completed before you check for new files on the gateway file share.
    /// You can subscribe to be notified through a CloudWatch event when your <c>RefreshCache</c>
    /// operation completes.
    /// </para>
    ///  
    /// <para>
    /// Throttle limit: This API is asynchronous, so the gateway will accept no more than
    /// two refreshes at any time. We recommend using the refresh-complete CloudWatch event
    /// notification before issuing additional requests. For more information, see <a href="https://docs.aws.amazon.com/filegateway/latest/files3/monitoring-file-gateway.html#get-notification">Getting
    /// notified about file operations</a> in the <i>Amazon S3 File Gateway User Guide</i>.
    /// </para>
    ///  <important> <ul> <li> 
    /// <para>
    /// Wait at least 60 seconds between consecutive RefreshCache API requests.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you invoke the RefreshCache API when two requests are already being processed,
    /// any new request will cause an <c>InvalidGatewayRequestException</c> error because
    /// too many requests were sent to the server.
    /// </para>
    ///  </li> </ul> </important> <note> 
    /// <para>
    /// The S3 bucket name does not need to be included when entering the list of folders
    /// in the FolderList parameter.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/filegateway/latest/files3/monitoring-file-gateway.html#get-notification">Getting
    /// notified about file operations</a> in the <i>Amazon S3 File Gateway User Guide</i>.
    /// </para>
    /// </summary>
    public partial class RefreshCacheRequest : AmazonStorageGatewayRequest
    {
        private string _fileShareARN;
        private List<string> _folderList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _recursive;

        /// <summary>
        /// Gets and sets the property FileShareARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the file share you want to refresh.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string FileShareARN
        {
            get { return this._fileShareARN; }
            set { this._fileShareARN = value; }
        }

        // Check to see if FileShareARN property is set
        internal bool IsSetFileShareARN()
        {
            return this._fileShareARN != null;
        }

        /// <summary>
        /// Gets and sets the property FolderList. 
        /// <para>
        /// A comma-separated list of the paths of folders to refresh in the cache. The default
        /// is [<c>"/"</c>]. The default refreshes objects and folders at the root of the Amazon
        /// S3 bucket. If <c>Recursive</c> is set to <c>true</c>, the entire S3 bucket that the
        /// file share has access to is refreshed.
        /// </para>
        ///  
        /// <para>
        /// Do not include <c>/</c> when specifying folder names. For example, you would specify
        /// <c>samplefolder</c> rather than <c>samplefolder/</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> FolderList
        {
            get { return this._folderList; }
            set { this._folderList = value; }
        }

        // Check to see if FolderList property is set
        internal bool IsSetFolderList()
        {
            return this._folderList != null && (this._folderList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Recursive. 
        /// <para>
        /// A value that specifies whether to recursively refresh folders in the cache. The refresh
        /// includes folders that were in the cache the last time the gateway listed the folder's
        /// contents. If this value set to <c>true</c>, each folder that is listed in <c>FolderList</c>
        /// is recursively updated. Otherwise, subfolders listed in <c>FolderList</c> are not
        /// refreshed. Only objects that are in folders listed directly under <c>FolderList</c>
        /// are found and used for the update. The default is <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>true</c> | <c>false</c> 
        /// </para>
        /// </summary>
        public bool? Recursive
        {
            get { return this._recursive; }
            set { this._recursive = value; }
        }

        // Check to see if Recursive property is set
        internal bool IsSetRecursive()
        {
            return this._recursive.HasValue; 
        }

    }
}