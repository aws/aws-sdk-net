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
    /// Describes the name of a SSM document.
    /// </summary>
    public partial class DocumentIdentifier
    {
        private string _author;
        private DateTime? _createdDate;
        private string _displayName;
        private DocumentFormat _documentFormat;
        private DocumentType _documentType;
        private string _documentVersion;
        private string _name;
        private string _owner;
        private List<string> _platformTypes = new List<string>();
        private List<DocumentRequires> _requires = new List<DocumentRequires>();
        private ReviewStatus _reviewStatus;
        private string _schemaVersion;
        private List<Tag> _tags = new List<Tag>();
        private string _targetType;
        private string _versionName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DocumentIdentifier() { }

        /// <summary>
        /// Instantiates DocumentIdentifier with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        public DocumentIdentifier(string name)
        {
            _name = name;
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
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the SSM document was created.
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// An optional field where you can specify a friendly name for the SSM document. This
        /// value can differ for each version of the document. If you want to update this value,
        /// see <a>UpdateDocument</a>.
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
        /// Gets and sets the property PlatformTypes. 
        /// <para>
        /// The operating system platform. 
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
        /// Gets and sets the property ReviewStatus. 
        /// <para>
        /// The current status of a document review.
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
        /// An optional field specifying the version of the artifact associated with the document.
        /// For example, "Release 12, Update 6". This value is unique across all versions of a
        /// document, and can't be changed.
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