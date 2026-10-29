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
    /// Version information about the document.
    /// </summary>
    public partial class DocumentVersionInfo
    {
        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the document was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

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
        /// Gets and sets the property IsDefaultVersion. 
        /// <para>
        /// An identifier for the default version of the document.
        /// </para>
        /// </summary>
        public bool? IsDefaultVersion { get; set; }

        /// <summary>
        /// Checks to see if the IsDefaultVersion property is set.
        /// </summary>
        internal bool IsSetIsDefaultVersion() => this.IsDefaultVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The document name.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReviewStatus. 
        /// <para>
        /// The current status of the approval review for the latest version of the document.
        /// </para>
        /// </summary>
        public ReviewStatus ReviewStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReviewStatus property is set.
        /// </summary>
        internal bool IsSetReviewStatus() => this.ReviewStatus != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the SSM document, such as <c>Creating</c>, <c>Active</c>, <c>Failed</c>,
        /// and <c>Deleting</c>.
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
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The version of the artifact associated with the document. For example, 12.6. This
        /// value is unique across all versions of a document, and can't be changed.
        /// </para>
        /// </summary>
        public string VersionName { get; set; }

        /// <summary>
        /// Checks to see if the VersionName property is set.
        /// </summary>
        internal bool IsSetVersionName() => this.VersionName != null;
    }
}
