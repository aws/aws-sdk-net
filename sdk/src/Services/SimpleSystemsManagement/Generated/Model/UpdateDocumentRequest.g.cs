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
    /// Container for the parameters to the UpdateDocument operation. Updates one or more
    /// values for an SSM document.
    /// </summary>
    public partial class UpdateDocumentRequest : AmazonSimpleSystemsManagementRequest
    {
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
        /// A valid JSON or YAML string.
        /// </para>
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
        /// The friendly name of the SSM document that you want to update. This value can differ
        /// for each version of the document. If you don't specify a value for this parameter
        /// in your request, the existing value is applied to the new document version.
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
        /// Specify the document format for the new document version. The document format can
        /// be JSON, YAML, or TEXT. JSON is the default format.
        /// </para>
        /// </summary>
        public DocumentFormat DocumentFormat { get; set; }

        /// <summary>
        /// Checks to see if the DocumentFormat property is set.
        /// </summary>
        internal bool IsSetDocumentFormat() => this.DocumentFormat != null;

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The version of the document that you want to update. Currently, Systems Manager supports
        /// updating only the latest version of the document. You can specify the version number
        /// of the latest version or use the <c>$LATEST</c> variable.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you change a document version for a State Manager association, Systems Manager
        /// immediately runs the association unless you previously specifed the <c>apply-only-at-cron-interval</c>
        /// parameter.
        /// </para>
        ///  </note>
        /// </summary>
        public string DocumentVersion { get; set; }

        /// <summary>
        /// Checks to see if the DocumentVersion property is set.
        /// </summary>
        internal bool IsSetDocumentVersion() => this.DocumentVersion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SSM document that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// Specify a new target type for the document.
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
        /// An optional field specifying the version of the artifact you are updating with the
        /// document. For example, 12.6. This value is unique across all versions of a document,
        /// and can't be changed.
        /// </para>
        /// </summary>
        public string VersionName { get; set; }

        /// <summary>
        /// Checks to see if the VersionName property is set.
        /// </summary>
        internal bool IsSetVersionName() => this.VersionName != null;
    }
}
