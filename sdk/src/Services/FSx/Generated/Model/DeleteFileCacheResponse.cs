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
    /// This is the response object from the DeleteFileCache operation.
    /// </summary>
    public partial class DeleteFileCacheResponse : AmazonWebServiceResponse
    {
        private string _fileCacheId;
        private FileCacheLifecycle _lifecycle;

        /// <summary>
        /// Gets and sets the property FileCacheId. 
        /// <para>
        /// The ID of the cache that's being deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=21)]
        public string FileCacheId
        {
            get { return this._fileCacheId; }
            set { this._fileCacheId = value; }
        }

        // Check to see if FileCacheId property is set
        internal bool IsSetFileCacheId()
        {
            return this._fileCacheId != null;
        }

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The cache lifecycle for the deletion request. If the <c>DeleteFileCache</c> operation
        /// is successful, this status is <c>DELETING</c>.
        /// </para>
        /// </summary>
        public FileCacheLifecycle Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

    }
}