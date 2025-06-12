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
    /// Container for the parameters to the UpdateDocument operation.
    /// Updates one or more values for an SSM document.
    /// </summary>
    public partial class UpdateDocumentRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<AttachmentsSource> _attachments = AWSConfigs.InitializeCollections ? new List<AttachmentsSource>() : null;
        private string _content;
        private string _displayName;
        private DocumentFormat _documentFormat;
        private string _documentVersion;
        private string _name;
        private string _targetType;
        private string _versionName;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// A list of key-value pairs that describe attachments to a version of a document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._attachments != null && (this._attachments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// A valid JSON or YAML string.
        /// </para>
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
        /// The friendly name of the SSM document that you want to update. This value can differ
        /// for each version of the document. If you don't specify a value for this parameter
        /// in your request, the existing value is applied to the new document version.
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
        /// Specify the document format for the new document version. Systems Manager supports
        /// JSON and YAML documents. JSON is the default format.
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
        /// The name of the SSM document that you want to update.
        /// </para>
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
        /// Gets and sets the property TargetType. 
        /// <para>
        /// Specify a new target type for the document.
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
        /// An optional field specifying the version of the artifact you are updating with the
        /// document. For example, 12.6. This value is unique across all versions of a document,
        /// and can't be changed.
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