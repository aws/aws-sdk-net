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
    /// Container for the parameters to the EvictFilesFailingUpload operation.
    /// Starts a process that cleans the specified file share's cache of file entries that
    /// are failing upload to Amazon S3. This API operation reports success if the request
    /// is received with valid arguments, and there are no other cache clean operations currently
    /// in-progress for the specified file share. After a successful request, the cache clean
    /// operation occurs asynchronously and reports progress using CloudWatch logs and notifications.
    /// 
    ///  <important> 
    /// <para>
    /// If <c>ForceRemove</c> is set to <c>True</c>, the cache clean operation will delete
    /// file data from the gateway which might otherwise be recoverable. We recommend using
    /// this operation only after all other methods to clear files failing upload have been
    /// exhausted, and if your business need outweighs the potential data loss.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class EvictFilesFailingUploadRequest : AmazonStorageGatewayRequest
    {
        private string _fileShareARN;
        private bool? _forceRemove;

        /// <summary>
        /// Gets and sets the property FileShareARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the file share for which you want to start the cache
        /// clean operation.
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
        /// Gets and sets the property ForceRemove. 
        /// <para>
        /// Specifies whether cache entries with full or partial file data currently stored on
        /// the gateway will be forcibly removed by the cache clean operation.
        /// </para>
        ///  
        /// <para>
        /// Valid arguments:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>False</c> - The cache clean operation skips cache entries failing upload if they
        /// are associated with data currently stored on the gateway. This preserves the cached
        /// data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>True</c> - The cache clean operation removes cache entries failing upload even
        /// if they are associated with data currently stored on the gateway. This deletes the
        /// cached data.
        /// </para>
        ///  <important> 
        /// <para>
        /// If <c>ForceRemove</c> is set to <c>True</c>, the cache clean operation will delete
        /// file data from the gateway which might otherwise be recoverable.
        /// </para>
        ///  </important> </li> </ul>
        /// </summary>
        public bool? ForceRemove
        {
            get { return this._forceRemove; }
            set { this._forceRemove = value; }
        }

        // Check to see if ForceRemove property is set
        internal bool IsSetForceRemove()
        {
            return this._forceRemove.HasValue; 
        }

    }
}