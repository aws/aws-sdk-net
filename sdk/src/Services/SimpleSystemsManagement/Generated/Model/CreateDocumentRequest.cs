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
    /// Container for the parameters to the CreateDocument operation.
    /// Creates a Amazon Web Services Systems Manager (SSM document). An SSM document defines
    /// the actions that Systems Manager performs on your managed nodes. For more information
    /// about SSM documents, including information about supported schemas, features, and
    /// syntax, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-ssm-docs.html">Amazon
    /// Web Services Systems Manager Documents</a> in the <i>Amazon Web Services Systems Manager
    /// User Guide</i>.
    /// </summary>
    public partial class CreateDocumentRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<AttachmentsSource> _attachments = new List<AttachmentsSource>();
        private string _content;
        private string _displayName;
        private DocumentFormat _documentFormat;
        private DocumentType _documentType;
        private string _name;
        private List<DocumentRequires> _requires = new List<DocumentRequires>();
        private List<Tag> _tags = new List<Tag>();
        private string _targetType;
        private string _versionName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateDocumentRequest() { }

        /// <summary>
        /// Instantiates CreateDocumentRequest with the parameterized properties
        /// </summary>
        /// <param name="name">A name for the SSM document. <important> You can't use the following strings as document name prefixes. These are reserved by Amazon Web Services for use as document name prefixes: <ul> <li>  <code>aws</code>  </li> <li>  <code>amazon</code>  </li> <li>  <code>amzn</code>  </li> </ul> </important></param>
        /// <param name="content">The content for the new SSM document in JSON or YAML format. The content of the document must not exceed 64KB. This quota also includes the content specified for input parameters at runtime. We recommend storing the contents for your new document in an external JSON or YAML file and referencing the file in a command. For examples, see the following topics in the <i>Amazon Web Services Systems Manager User Guide</i>. <ul> <li>  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/create-ssm-document-api.html">Create an SSM document (Amazon Web Services API)</a>  </li> <li>  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/create-ssm-document-cli.html">Create an SSM document (Amazon Web Services CLI)</a>  </li> <li>  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/create-ssm-document-api.html">Create an SSM document (API)</a>  </li> </ul></param>
        public CreateDocumentRequest(string name, string content)
        {
            _name = name;
            _content = content;
        }

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// A list of key-value pairs that describe attachments to a version of a document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<AttachmentsSource> Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null && this._attachments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content for the new SSM document in JSON or YAML format. The content of the document
        /// must not exceed 64KB. This quota also includes the content specified for input parameters
        /// at runtime. We recommend storing the contents for your new document in an external
        /// JSON or YAML file and referencing the file in a command.
        /// </para>
        ///  
        /// <para>
        /// For examples, see the following topics in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/create-ssm-document-api.html">Create
        /// an SSM document (Amazon Web Services API)</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/create-ssm-document-cli.html">Create
        /// an SSM document (Amazon Web Services CLI)</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/create-ssm-document-api.html">Create
        /// an SSM document (API)</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// An optional field where you can specify a friendly name for the SSM document. This
        /// value can differ for each version of the document. You can update this value at a
        /// later time using the <a>UpdateDocument</a> operation.
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
        /// Specify the document format for the request. The document format can be JSON, YAML,
        /// or TEXT. JSON is the default format.
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
        /// The type of document to create.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>DeploymentStrategy</code> document type is an internal-use-only document
        /// type reserved for AppConfig.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the SSM document.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can't use the following strings as document name prefixes. These are reserved
        /// by Amazon Web Services for use as document name prefixes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aws</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>amazon</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>amzn</code> 
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A list of SSM documents required by a document. This parameter is used exclusively
        /// by AppConfig. When a user creates an AppConfig configuration in an SSM document, the
        /// user must also specify a required document for validation purposes. In this case,
        /// an <code>ApplicationConfiguration</code> document requires an <code>ApplicationConfigurationSchema</code>
        /// document for validation purposes. For more information, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/what-is-appconfig.html">What
        /// is AppConfig?</a> in the <i>AppConfig User Guide</i>.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata that you assign to a resource. Tags enable you to categorize a resource
        /// in different ways, such as by purpose, owner, or environment. For example, you might
        /// want to tag an SSM document to identify the types of targets or the environment where
        /// it will run. In this case, you could specify the following key-value pairs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Key=OS,Value=Windows</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key=Environment,Value=Production</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// To add tags to an existing SSM document, use the <a>AddTagsToResource</a> operation.
        /// </para>
        ///  </note>
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
        /// Specify a target type to define the kinds of resources the document can run on. For
        /// example, to run a document on EC2 instances, specify the following value: <code>/AWS::EC2::Instance</code>.
        /// If you specify a value of '/' the document can run on all types of resources. If you
        /// don't specify a value, the document can't run on any resources. For a list of valid
        /// resource types, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Amazon
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
        /// An optional field specifying the version of the artifact you are creating with the
        /// document. For example, <code>Release12.1</code>. This value is unique across all versions
        /// of a document, and can't be changed.
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