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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the GetDocument operation.
    /// </summary>
    public partial class GetDocumentResponse : AmazonWebServiceResponse
    {
        private List<AttachmentContent> _attachmentsContent = new List<AttachmentContent>();
        private string _content;
        private DocumentFormat _documentFormat;
        private DocumentType _documentType;
        private string _documentVersion;
        private string _name;
        private DocumentStatus _status;
        private string _statusInformation;
        private string _versionName;

        /// <summary>
        /// Gets and sets the property AttachmentsContent. 
        /// <para>
        /// A description of the document attachments, including names, locations, sizes, etc.
        /// </para>
        /// </summary>
        public List<AttachmentContent> AttachmentsContent
        {
            get { return this._attachmentsContent; }
            set { this._attachmentsContent = value; }
        }

        // Check to see if AttachmentsContent property is set
        internal bool IsSetAttachmentsContent()
        {
            return this._attachmentsContent != null && this._attachmentsContent.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The contents of the Systems Manager document.
        /// </para>
        /// </summary>
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentFormat. 
        /// <para>
        /// The document format, either JSON or YAML.
        /// </para>
        /// </summary>
        public DocumentFormat DocumentFormat
        {
            get { return this._documentFormat; }
            set { this._documentFormat = value; }
        }

        // Check to see if DocumentFormat property is set
        internal bool IsSetDocumentFormat()
        {
            return this._documentFormat != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentType. 
        /// <para>
        /// The document type.
        /// </para>
        /// </summary>
        public DocumentType DocumentType
        {
            get { return this._documentType; }
            set { this._documentType = value; }
        }

        // Check to see if DocumentType property is set
        internal bool IsSetDocumentType()
        {
            return this._documentType != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The document version.
        /// </para>
        /// </summary>
        public string DocumentVersion
        {
            get { return this._documentVersion; }
            set { this._documentVersion = value; }
        }

        // Check to see if DocumentVersion property is set
        internal bool IsSetDocumentVersion()
        {
            return this._documentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Systems Manager document.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Systems Manager document, such as <code>Creating</code>, <code>Active</code>,
        /// <code>Updating</code>, <code>Failed</code>, and <code>Deleting</code>.
        /// </para>
        /// </summary>
        public DocumentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusInformation. 
        /// <para>
        /// A message returned by AWS Systems Manager that explains the <code>Status</code> value.
        /// For example, a <code>Failed</code> status might be explained by the <code>StatusInformation</code>
        /// message, "The specified S3 bucket does not exist. Verify that the URL of the S3 bucket
        /// is correct."
        /// </para>
        /// </summary>
        public string StatusInformation
        {
            get { return this._statusInformation; }
            set { this._statusInformation = value; }
        }

        // Check to see if StatusInformation property is set
        internal bool IsSetStatusInformation()
        {
            return this._statusInformation != null;
        }

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The version of the artifact associated with the document. For example, "Release 12,
        /// Update 6". This value is unique across all versions of a document, and cannot be changed.
        /// </para>
        /// </summary>
        public string VersionName
        {
            get { return this._versionName; }
            set { this._versionName = value; }
        }

        // Check to see if VersionName property is set
        internal bool IsSetVersionName()
        {
            return this._versionName != null;
        }

    }
}