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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// This is the response object from the DescribeFolderContents operation.
    /// </summary>
    public partial class DescribeFolderContentsResponse : AmazonWebServiceResponse
    {
        private List<DocumentMetadata> _documents = new List<DocumentMetadata>();
        private List<FolderMetadata> _folders = new List<FolderMetadata>();
        private string _marker;

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// The documents in the specified folder.
        /// </para>
        /// </summary>
        public List<DocumentMetadata> Documents
        {
            get { return this._documents; }
            set { this._documents = value; }
        }

        // Check to see if Documents property is set
        internal bool IsSetDocuments()
        {
            return this._documents != null && this._documents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Folders. 
        /// <para>
        /// The subfolders in the specified folder.
        /// </para>
        /// </summary>
        public List<FolderMetadata> Folders
        {
            get { return this._folders; }
            set { this._folders = value; }
        }

        // Check to see if Folders property is set
        internal bool IsSetFolders()
        {
            return this._folders != null && this._folders.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The marker to use when requesting the next set of results. If there are no additional
        /// results, the string is empty.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}