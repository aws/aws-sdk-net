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
    /// Container for the parameters to the RefreshCache operation.
    /// Refreshes the cache for the specified file share. This operation finds objects in
    /// the Amazon S3 bucket that were added, removed or replaced since the gateway last listed
    /// the bucket's contents and cached the results. This operation is only supported in
    /// the file gateway type. You can subscribe to be notified through an Amazon CloudWatch
    /// event when your RefreshCache operation completes. For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/monitoring-file-gateway.html#get-notification">Getting
    /// Notified About File Operations</a>.
    /// 
    ///  
    /// <para>
    /// When this API is called, it only initiates the refresh operation. When the API call
    /// completes and returns a success code, it doesn't necessarily mean that the file refresh
    /// has completed. You should use the refresh-complete notification to determine that
    /// the operation has completed before you check for new files on the gateway file share.
    /// You can subscribe to be notified through an CloudWatch event when your <code>RefreshCache</code>
    /// operation completes. 
    /// </para>
    ///  
    /// <para>
    /// Throttle limit: This API is asynchronous so the gateway will accept no more than two
    /// refreshes at any time. We recommend using the refresh-complete CloudWatch event notification
    /// before issuing additional requests. For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/monitoring-file-gateway.html#get-notification">Getting
    /// Notified About File Operations</a>.
    /// </para>
    ///  
    /// <para>
    /// If you invoke the RefreshCache API when two requests are already being processed,
    /// any new request will cause an <code>InvalidGatewayRequestException</code> error because
    /// too many requests were sent to the server.
    /// </para>
    ///  
    /// <para>
    /// For more information, see "https://docs.aws.amazon.com/storagegateway/latest/userguide/monitoring-file-gateway.html#get-notification".
    /// </para>
    /// </summary>
    public partial class RefreshCacheRequest : AmazonStorageGatewayRequest
    {
        private string _fileShareARN;
        private List<string> _folderList = new List<string>();
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
        /// is [<code>"/"</code>]. The default refreshes objects and folders at the root of the
        /// Amazon S3 bucket. If <code>Recursive</code> is set to "true", the entire S3 bucket
        /// that the file share has access to is refreshed.
        /// </para>
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
            return this._folderList != null && this._folderList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Recursive. 
        /// <para>
        /// A value that specifies whether to recursively refresh folders in the cache. The refresh
        /// includes folders that were in the cache the last time the gateway listed the folder's
        /// contents. If this value set to "true", each folder that is listed in <code>FolderList</code>
        /// is recursively updated. Otherwise, subfolders listed in <code>FolderList</code> are
        /// not refreshed. Only objects that are in folders listed directly under <code>FolderList</code>
        /// are found and used for the update. The default is "true".
        /// </para>
        /// </summary>
        public bool Recursive
        {
            get { return this._recursive.GetValueOrDefault(); }
            set { this._recursive = value; }
        }

        // Check to see if Recursive property is set
        internal bool IsSetRecursive()
        {
            return this._recursive.HasValue; 
        }

    }
}