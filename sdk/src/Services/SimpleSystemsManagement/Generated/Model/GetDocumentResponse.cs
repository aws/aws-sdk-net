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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the GetDocument operation.
    /// </summary>
    public partial class GetDocumentResponse : AmazonWebServiceResponse
    {
        private List<AttachmentContent> _attachmentsContent = AWSConfigs.InitializeCollections ? new List<AttachmentContent>() : null;
        private string _content;
        private DateTime? _createdDate;
        private string _displayName;
        private DocumentFormat _documentFormat;
        private DocumentType _documentType;
        private string _documentVersion;
        private string _name;
        private List<DocumentRequires> _requires = AWSConfigs.InitializeCollections ? new List<DocumentRequires>() : null;
        private ReviewStatus _reviewStatus;
        private DocumentStatus _status;
        private string _statusInformation;
        private string _versionName;

        /// <summary>
        /// Gets and sets the property AttachmentsContent. 
        /// <para>
        /// A description of the document attachments, including names, locations, sizes, and
        /// so on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttachmentContent> AttachmentsContent
        {
            get { return this._attachmentsContent; }
            set { this._attachmentsContent = value; }
        }

        // Check to see if AttachmentsContent property is set
        internal bool IsSetAttachmentsContent()
        {
            return this._attachmentsContent != null && (this._attachmentsContent.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The contents of the SSM document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the SSM document was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The friendly name of the SSM document. This value can differ for each version of the
        /// document. If you want to update this value, see <a>UpdateDocument</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
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
        /// The name of the SSM document.
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
        /// Gets and sets the property Requires. 
        /// <para>
        /// A list of SSM documents required by a document. For example, an <c>ApplicationConfiguration</c>
        /// document requires an <c>ApplicationConfigurationSchema</c> document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<DocumentRequires> Requires
        {
            get { return this._requires; }
            set { this._requires = value; }
        }

        // Check to see if Requires property is set
        internal bool IsSetRequires()
        {
            return this._requires != null && (this._requires.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReviewStatus. 
        /// <para>
        /// The current review status of a new custom Systems Manager document (SSM document)
        /// created by a member of your organization, or of the latest version of an existing
        /// SSM document.
        /// </para>
        ///  
        /// <para>
        /// Only one version of an SSM document can be in the APPROVED state at a time. When a
        /// new version is approved, the status of the previous version changes to REJECTED.
        /// </para>
        ///  
        /// <para>
        /// Only one version of an SSM document can be in review, or PENDING, at a time.
        /// </para>
        /// </summary>
        public ReviewStatus ReviewStatus
        {
            get { return this._reviewStatus; }
            set { this._reviewStatus = value; }
        }

        // Check to see if ReviewStatus property is set
        internal bool IsSetReviewStatus()
        {
            return this._reviewStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the SSM document, such as <c>Creating</c>, <c>Active</c>, <c>Updating</c>,
        /// <c>Failed</c>, and <c>Deleting</c>.
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
        /// A message returned by Amazon Web Services Systems Manager that explains the <c>Status</c>
        /// value. For example, a <c>Failed</c> status might be explained by the <c>StatusInformation</c>
        /// message, "The specified S3 bucket doesn't exist. Verify that the URL of the S3 bucket
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
        /// The version of the artifact associated with the document. For example, 12.6. This
        /// value is unique across all versions of a document, and can't be changed.
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