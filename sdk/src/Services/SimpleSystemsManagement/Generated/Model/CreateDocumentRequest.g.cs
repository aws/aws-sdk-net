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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateDocument operation. Creates a Amazon Web
    /// Services Systems Manager (SSM document). An SSM document defines the actions that
    /// Systems Manager performs on your managed nodes. For more information about SSM documents,
    /// including information about supported schemas, features, and syntax, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/documents.html">Amazon
    /// Web Services Systems Manager Documents</a> in the <i>Amazon Web Services Systems Manager
    /// User Guide</i>.
    /// </summary>
    public partial class CreateDocumentRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CreateDocumentRequest() { }

        /// <summary>
        /// Instantiates CreateDocumentRequest with the parameterized properties
        /// </summary>
        /// <param name="name">A name for the SSM document.   <important>   You can't use the following strings as document name prefixes. These are reserved by Amazon Web Services for use as document name prefixes:   <ul>      <li>            <c>aws</c>         </li>      <li>            <c>amazon</c>         </li>      <li>            <c>amzn</c>         </li>      <li>            <c>AWSEC2</c>         </li>      <li>            <c>AWSConfigRemediation</c>         </li>      <li>            <c>AWSSupport</c>         </li>   </ul>   </important></param>
        /// <param name="content">The content for the new SSM document in JSON or YAML format. The content of the document   must not exceed 64KB. This quota also includes the content specified for input parameters at   runtime. We recommend storing the contents for your new document in an external JSON or YAML file   and referencing the file in a command.   For examples, see the following topics in the <i>Amazon Web Services Systems Manager User Guide</i>.   <ul>   <li>         <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/documents-using.html#create-ssm-console">Create an SSM   document (console)</a>         </li>   <li>         <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/documents-using.html#create-ssm-document-cli">Create an   SSM document (command line)</a>         </li>   <li>         <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/documents-using.html#create-ssm-document-api">Create an   SSM document (API)</a>         </li>   </ul></param>
        public CreateDocumentRequest(string name, string content)
        {
            this.Name = name;
            this.Content = content;
        }

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// A list of key-value pairs that describe attachments to a version of a document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<AttachmentsSource> Attachments { get; set; } = AWSConfigs.InitializeCollections ? new List<AttachmentsSource>() : null;

        /// <summary>
        /// Checks to see if the Attachments property is set.
        /// </summary>
        internal bool IsSetAttachments() => this.Attachments != null && (this.Attachments.Count > 0 || !AWSConfigs.InitializeCollections);

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
        ///  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/documents-using.html#create-ssm-console">Create
        /// an SSM document (console)</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/documents-using.html#create-ssm-document-cli">Create
        /// an SSM document (command line)</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/documents-using.html#create-ssm-document-api">Create
        /// an SSM document (API)</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// An optional field where you can specify a friendly name for the SSM document. This
        /// value can differ for each version of the document. You can update this value at a
        /// later time using the <a>UpdateDocument</a> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property DocumentFormat. 
        /// <para>
        /// Specify the document format for the request. The document format can be JSON, YAML,
        /// or TEXT. JSON is the default format.
        /// </para>
        /// </summary>
        public DocumentFormat DocumentFormat { get; set; }

        /// <summary>
        /// Checks to see if the DocumentFormat property is set.
        /// </summary>
        internal bool IsSetDocumentFormat() => this.DocumentFormat != null;

        /// <summary>
        /// Gets and sets the property DocumentType. 
        /// <para>
        /// The type of document to create.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>DeploymentStrategy</c> document type is an internal-use-only document type
        /// reserved for AppConfig.
        /// </para>
        ///  </note>
        /// </summary>
        public DocumentType DocumentType { get; set; }

        /// <summary>
        /// Checks to see if the DocumentType property is set.
        /// </summary>
        internal bool IsSetDocumentType() => this.DocumentType != null;

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
        ///  <c>aws</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>amazon</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>amzn</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWSEC2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWSConfigRemediation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWSSupport</c> 
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Requires. 
        /// <para>
        /// A list of SSM documents required by a document. This parameter is used exclusively
        /// by AppConfig. When a user creates an AppConfig configuration in an SSM document, the
        /// user must also specify a required document for validation purposes. In this case,
        /// an <c>ApplicationConfiguration</c> document requires an <c>ApplicationConfigurationSchema</c>
        /// document for validation purposes. For more information, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/what-is-appconfig.html">What
        /// is AppConfig?</a> in the <i>AppConfig User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<DocumentRequires> Requires { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentRequires>() : null;

        /// <summary>
        /// Checks to see if the Requires property is set.
        /// </summary>
        internal bool IsSetRequires() => this.Requires != null && (this.Requires.Count > 0 || !AWSConfigs.InitializeCollections);

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
        ///  <c>Key=OS,Value=Windows</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=Environment,Value=Production</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// To add tags to an existing SSM document, use the <a>AddTagsToResource</a> operation.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// Specify a target type to define the kinds of resources the document can run on. For
        /// example, to run a document on EC2 instances, specify the following value: <c>/AWS::EC2::Instance</c>.
        /// If you specify a value of '/' the document can run on all types of resources. If you
        /// don't specify a value, the document can't run on any resources. For a list of valid
        /// resource types, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Amazon
        /// Web Services resource and property types reference</a> in the <i>CloudFormation User
        /// Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// An optional field specifying the version of the artifact you are creating with the
        /// document. For example, <c>Release12.1</c>. This value is unique across all versions
        /// of a document, and can't be changed.
        /// </para>
        /// </summary>
        public string VersionName { get; set; }

        /// <summary>
        /// Checks to see if the VersionName property is set.
        /// </summary>
        internal bool IsSetVersionName() => this.VersionName != null;
    }
}
