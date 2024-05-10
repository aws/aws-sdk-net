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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// This is the response object from the PutFile operation.
    /// </summary>
    public partial class PutFileResponse : AmazonWebServiceResponse
    {
        private string _blobId;
        private string _commitId;
        private string _treeId;

        /// <summary>
        /// Gets and sets the property BlobId. 
        /// <para>
        /// The ID of the blob, which is its SHA-1 pointer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BlobId
        {
            get { return this._blobId; }
            set { this._blobId = value; }
        }

        // Check to see if BlobId property is set
        internal bool IsSetBlobId()
        {
            return this._blobId != null;
        }

        /// <summary>
        /// Gets and sets the property CommitId. 
        /// <para>
        /// The full SHA ID of the commit that contains this file change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CommitId
        {
            get { return this._commitId; }
            set { this._commitId = value; }
        }

        // Check to see if CommitId property is set
        internal bool IsSetCommitId()
        {
            return this._commitId != null;
        }

        /// <summary>
        /// Gets and sets the property TreeId. 
        /// <para>
        /// The full SHA-1 pointer of the tree information for the commit that contains this file
        /// change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TreeId
        {
            get { return this._treeId; }
            set { this._treeId = value; }
        }

        // Check to see if TreeId property is set
        internal bool IsSetTreeId()
        {
            return this._treeId != null;
        }

    }
}