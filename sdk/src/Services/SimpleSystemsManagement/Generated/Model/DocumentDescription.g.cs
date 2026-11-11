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
    /// Describes an Amazon Web Services Systems Manager document (SSM document).
    /// </summary>
    public partial class DocumentDescription
    {
        /// <summary>
        /// Gets and sets the property ApprovedVersion. 
        /// <para>
        /// The version of the document currently approved for use in the organization.
        /// </para>
        /// </summary>
        public string ApprovedVersion { get; set; }

        /// <summary>
        /// Checks to see if the ApprovedVersion property is set.
        /// </summary>
        internal bool IsSetApprovedVersion() => this.ApprovedVersion != null;

        /// <summary>
        /// Gets and sets the property AttachmentsInformation. 
        /// <para>
        /// Details about the document attachments, including names, locations, sizes, and so
        /// on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttachmentInformation> AttachmentsInformation { get; set; } = AWSConfigs.InitializeCollections ? new List<AttachmentInformation>() : null;

        /// <summary>
        /// Checks to see if the AttachmentsInformation property is set.
        /// </summary>
        internal bool IsSetAttachmentsInformation() => this.AttachmentsInformation != null && (this.AttachmentsInformation.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Author. 
        /// <para>
        /// The user in your organization who created the document.
        /// </para>
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Checks to see if the Author property is set.
        /// </summary>
        internal bool IsSetAuthor() => this.Author != null;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The classification of a document to help you identify and categorize its use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<string> Category { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null && (this.Category.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CategoryEnum. 
        /// <para>
        /// The value that identifies a document's category.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<string> CategoryEnum { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CategoryEnum property is set.
        /// </summary>
        internal bool IsSetCategoryEnum() => this.CategoryEnum != null && (this.CategoryEnum.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date when the document was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultVersion. 
        /// <para>
        /// The default version.
        /// </para>
        /// </summary>
        public string DefaultVersion { get; set; }

        /// <summary>
        /// Checks to see if the DefaultVersion property is set.
        /// </summary>
        internal bool IsSetDefaultVersion() => this.DefaultVersion != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the document. 
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The friendly name of the SSM document. This value can differ for each version of the
        /// document. If you want to update this value, see <a>UpdateDocument</a>.
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
        /// The document format, either JSON or YAML.
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
        /// The type of document.
        /// </para>
        /// </summary>
        public DocumentType DocumentType { get; set; }

        /// <summary>
        /// Checks to see if the DocumentType property is set.
        /// </summary>
        internal bool IsSetDocumentType() => this.DocumentType != null;

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The document version.
        /// </para>
        /// </summary>
        public string DocumentVersion { get; set; }

        /// <summary>
        /// Checks to see if the DocumentVersion property is set.
        /// </summary>
        internal bool IsSetDocumentVersion() => this.DocumentVersion != null;

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
        [AWSProperty(Min = 0, Max = 256)]
        public string Hash { get; set; }

        /// <summary>
        /// Checks to see if the Hash property is set.
        /// </summary>
        internal bool IsSetHash() => this.Hash != null;

        /// <summary>
        /// Gets and sets the property HashType. 
        /// <para>
        /// The hash type of the document. Valid values include <c>Sha256</c> or <c>Sha1</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Sha1 hashes have been deprecated.
        /// </para>
        ///  </note>
        /// </summary>
        public DocumentHashType HashType { get; set; }

        /// <summary>
        /// Checks to see if the HashType property is set.
        /// </summary>
        internal bool IsSetHashType() => this.HashType != null;

        /// <summary>
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// The latest version of the document.
        /// </para>
        /// </summary>
        public string LatestVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersion property is set.
        /// </summary>
        internal bool IsSetLatestVersion() => this.LatestVersion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SSM document.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The Amazon Web Services user that created the document.
        /// </para>
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A description of the parameters for a document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentParameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentParameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PendingReviewVersion. 
        /// <para>
        /// The version of the document that is currently under review.
        /// </para>
        /// </summary>
        public string PendingReviewVersion { get; set; }

        /// <summary>
        /// Checks to see if the PendingReviewVersion property is set.
        /// </summary>
        internal bool IsSetPendingReviewVersion() => this.PendingReviewVersion != null;

        /// <summary>
        /// Gets and sets the property PlatformTypes. 
        /// <para>
        /// The list of operating system (OS) platforms compatible with this SSM document. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PlatformTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PlatformTypes property is set.
        /// </summary>
        internal bool IsSetPlatformTypes() => this.PlatformTypes != null && (this.PlatformTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Requires. 
        /// <para>
        /// A list of SSM documents required by a document. For example, an <c>ApplicationConfiguration</c>
        /// document requires an <c>ApplicationConfigurationSchema</c> document.
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
        /// Gets and sets the property ReviewInformation. 
        /// <para>
        /// Details about the review of a document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<ReviewInformation> ReviewInformation { get; set; } = AWSConfigs.InitializeCollections ? new List<ReviewInformation>() : null;

        /// <summary>
        /// Checks to see if the ReviewInformation property is set.
        /// </summary>
        internal bool IsSetReviewInformation() => this.ReviewInformation != null && (this.ReviewInformation.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReviewStatus. 
        /// <para>
        /// The current status of the review.
        /// </para>
        /// </summary>
        public ReviewStatus ReviewStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReviewStatus property is set.
        /// </summary>
        internal bool IsSetReviewStatus() => this.ReviewStatus != null;

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version.
        /// </para>
        /// </summary>
        public string SchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the SchemaVersion property is set.
        /// </summary>
        internal bool IsSetSchemaVersion() => this.SchemaVersion != null;

        /// <summary>
        /// Gets and sets the property Sha1. 
        /// <para>
        /// The SHA1 hash of the document, which you can use for verification.
        /// </para>
        /// </summary>
        public string Sha1 { get; set; }

        /// <summary>
        /// Checks to see if the Sha1 property is set.
        /// </summary>
        internal bool IsSetSha1() => this.Sha1 != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the SSM document.
        /// </para>
        /// </summary>
        public DocumentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusInformation. 
        /// <para>
        /// A message returned by Amazon Web Services Systems Manager that explains the <c>Status</c>
        /// value. For example, a <c>Failed</c> status might be explained by the <c>StatusInformation</c>
        /// message, "The specified S3 bucket doesn't exist. Verify that the URL of the S3 bucket
        /// is correct."
        /// </para>
        /// </summary>
        public string StatusInformation { get; set; }

        /// <summary>
        /// Checks to see if the StatusInformation property is set.
        /// </summary>
        internal bool IsSetStatusInformation() => this.StatusInformation != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags, or metadata, that have been applied to the document.
        /// </para>
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
        /// The target type which defines the kinds of resources the document can run on. For
        /// example, <c>/AWS::EC2::Instance</c>. For a list of valid resource types, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Amazon
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
        /// The version of the artifact associated with the document.
        /// </para>
        /// </summary>
        public string VersionName { get; set; }

        /// <summary>
        /// Checks to see if the VersionName property is set.
        /// </summary>
        internal bool IsSetVersionName() => this.VersionName != null;
    }
}
