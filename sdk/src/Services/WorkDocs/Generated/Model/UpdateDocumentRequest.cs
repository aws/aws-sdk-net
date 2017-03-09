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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDocument operation.
    /// Updates the specified attributes of the specified document. The user must have access
    /// to both the document and its parent folder, if applicable.
    /// </summary>
    public partial class UpdateDocumentRequest : AmazonWorkDocsRequest
    {
        private string _documentId;
        private string _name;
        private string _parentFolderId;
        private ResourceStateType _resourceState;

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The ID of the document.
        /// </para>
        /// </summary>
        public string DocumentId
        {
            get { return this._documentId; }
            set { this._documentId = value; }
        }

        // Check to see if DocumentId property is set
        internal bool IsSetDocumentId()
        {
            return this._documentId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the document.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ParentFolderId. 
        /// <para>
        /// The ID of the parent folder.
        /// </para>
        /// </summary>
        public string ParentFolderId
        {
            get { return this._parentFolderId; }
            set { this._parentFolderId = value; }
        }

        // Check to see if ParentFolderId property is set
        internal bool IsSetParentFolderId()
        {
            return this._parentFolderId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceState. 
        /// <para>
        /// The resource state of the document. Note that only ACTIVE and RECYCLED are supported.
        /// </para>
        /// </summary>
        public ResourceStateType ResourceState
        {
            get { return this._resourceState; }
            set { this._resourceState = value; }
        }

        // Check to see if ResourceState property is set
        internal bool IsSetResourceState()
        {
            return this._resourceState != null;
        }

    }
}