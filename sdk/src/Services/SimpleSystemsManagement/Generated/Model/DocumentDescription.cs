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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Describes an Amazon Web Services Systems Manager document (SSM document).
    /// </summary>
    public partial class DocumentDescription
    {
        private string _approvedVersion;
        private List<AttachmentInformation> _attachmentsInformation = new List<AttachmentInformation>();
        private string _author;
        private List<string> _category = new List<string>();
        private List<string> _categoryEnum = new List<string>();
        private DateTime? _createdDate;
        private string _defaultVersion;
        private string _description;
        private string _displayName;
        private DocumentFormat _documentFormat;
        private DocumentType _documentType;
        private string _documentVersion;
        private string _hash;
        private DocumentHashType _hashType;
        private string _latestVersion;
        private string _name;
        private string _owner;
        private List<DocumentParameter> _parameters = new List<DocumentParameter>();
        private string _pendingReviewVersion;
        private List<string> _platformTypes = new List<string>();
        private List<DocumentRequires> _requires = new List<DocumentRequires>();
        private List<ReviewInformation> _reviewInformation = new List<ReviewInformation>();
        private ReviewStatus _reviewStatus;
        private string _schemaVersion;
        private string _sha1;
        private DocumentStatus _status;
        private string _statusInformation;
        private List<Tag> _tags = new List<Tag>();
        private string _targetType;
        private string _versionName;

        /// <summary>
        /// Gets and sets the property ApprovedVersion. 
        /// <para>
        /// The version of the document currently approved for use in the organization.
        /// </para>
        /// </summary>
        public string ApprovedVersion
        {
            get { return this._approvedVersion; }
            set { this._approvedVersion = value; }
        }

        // Check to see if ApprovedVersion property is set
        internal bool IsSetApprovedVersion()
        {
            return this._approvedVersion != null;
        }

        /// <summary>
        /// Gets and sets the property AttachmentsInformation. 
        /// <para>
        /// Details about the document attachments, including names, locations, sizes, and so
        /// on.
        /// </para>
        /// </summary>
        public List<AttachmentInformation> AttachmentsInformation
        {
            get { return this._attachmentsInformation; }
            set { this._attachmentsInformation = value; }
        }

        // Check to see if AttachmentsInformation property is set
        internal bool IsSetAttachmentsInformation()
        {
            return this._attachmentsInformation != null && this._attachmentsInformation.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Author. 
        /// <para>
        /// The user in your organization who created the document.
        /// </para>
        /// </summary>
        public string Author
        {
            get { return this._author; }
            set { this._author = value; }
        }

        // Check to see if Author property is set
        internal bool IsSetAuthor()
        {
            return this._author != null;
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The classification of a document to help you identify and categorize its use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null && this._category.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CategoryEnum. 
        /// <para>
        /// The value that identifies a document's category.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> CategoryEnum
        {
            get { return this._categoryEnum; }
            set { this._categoryEnum = value; }
        }

        // Check to see if CategoryEnum property is set
        internal bool IsSetCategoryEnum()
        {
            return this._categoryEnum != null && this._categoryEnum.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date when the document was created.
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultVersion. 
        /// <para>
        /// The default version.
        /// </para>
        /// </summary>
        public string DefaultVersion
        {
            get { return this._defaultVersion; }
            set { this._defaultVersion = value; }
        }

        // Check to see if DefaultVersion property is set
        internal bool IsSetDefaultVersion()
        {
            return this._defaultVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the document. 
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
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
        /// The type of document.
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
        /// Gets and sets the property Hash. 
        /// <para>
        /// The Sha256 or Sha1 hash created by the system when the document was created. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Sha1 hashes have been deprecated.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Hash
        {
            get { return this._hash; }
            set { this._hash = value; }
        }

        // Check to see if Hash property is set
        internal bool IsSetHash()
        {
            return this._hash != null;
        }

        /// <summary>
        /// Gets and sets the property HashType. 
        /// <para>
        /// The hash type of the document. Valid values include <code>Sha256</code> or <code>Sha1</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Sha1 hashes have been deprecated.
        /// </para>
        ///  </note>
        /// </summary>
        public DocumentHashType HashType
        {
            get { return this._hashType; }
            set { this._hashType = value; }
        }

        // Check to see if HashType property is set
        internal bool IsSetHashType()
        {
            return this._hashType != null;
        }

        /// <summary>
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// The latest version of the document.
        /// </para>
        /// </summary>
        public string LatestVersion
        {
            get { return this._latestVersion; }
            set { this._latestVersion = value; }
        }

        // Check to see if LatestVersion property is set
        internal bool IsSetLatestVersion()
        {
            return this._latestVersion != null;
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// The Amazon Web Services user that created the document.
        /// </para>
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A description of the parameters for a document.
        /// </para>
        /// </summary>
        public List<DocumentParameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PendingReviewVersion. 
        /// <para>
        /// The version of the document that is currently under review.
        /// </para>
        /// </summary>
        public string PendingReviewVersion
        {
            get { return this._pendingReviewVersion; }
            set { this._pendingReviewVersion = value; }
        }

        // Check to see if PendingReviewVersion property is set
        internal bool IsSetPendingReviewVersion()
        {
            return this._pendingReviewVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformTypes. 
        /// <para>
        /// The list of operating system (OS) platforms compatible with this SSM document. 
        /// </para>
        /// </summary>
        public List<string> PlatformTypes
        {
            get { return this._platformTypes; }
            set { this._platformTypes = value; }
        }

        // Check to see if PlatformTypes property is set
        internal bool IsSetPlatformTypes()
        {
            return this._platformTypes != null && this._platformTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Requires. 
        /// <para>
        /// A list of SSM documents required by a document. For example, an <code>ApplicationConfiguration</code>
        /// document requires an <code>ApplicationConfigurationSchema</code> document.
        /// </para>
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
            return this._requires != null && this._requires.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReviewInformation. 
        /// <para>
        /// Details about the review of a document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ReviewInformation> ReviewInformation
        {
            get { return this._reviewInformation; }
            set { this._reviewInformation = value; }
        }

        // Check to see if ReviewInformation property is set
        internal bool IsSetReviewInformation()
        {
            return this._reviewInformation != null && this._reviewInformation.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReviewStatus. 
        /// <para>
        /// The current status of the review.
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
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version.
        /// </para>
        /// </summary>
        public string SchemaVersion
        {
            get { return this._schemaVersion; }
            set { this._schemaVersion = value; }
        }

        // Check to see if SchemaVersion property is set
        internal bool IsSetSchemaVersion()
        {
            return this._schemaVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Sha1. 
        /// <para>
        /// The SHA1 hash of the document, which you can use for verification.
        /// </para>
        /// </summary>
        public string Sha1
        {
            get { return this._sha1; }
            set { this._sha1 = value; }
        }

        // Check to see if Sha1 property is set
        internal bool IsSetSha1()
        {
            return this._sha1 != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the SSM document.
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
        /// A message returned by Amazon Web Services Systems Manager that explains the <code>Status</code>
        /// value. For example, a <code>Failed</code> status might be explained by the <code>StatusInformation</code>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags, or metadata, that have been applied to the document.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The target type which defines the kinds of resources the document can run on. For
        /// example, <code>/AWS::EC2::Instance</code>. For a list of valid resource types, see
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Amazon
        /// Web Services resource and property types reference</a> in the <i>CloudFormation User
        /// Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public string TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The version of the artifact associated with the document.
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