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
    /// Version information about the document.
    /// </summary>
    public partial class DocumentVersionInfo
    {
        private DateTime? _createdDate;
        private DocumentFormat _documentFormat;
        private string _documentVersion;
        private bool? _isDefaultVersion;
        private string _name;
        private DocumentStatus _status;
        private string _statusInformation;
        private string _versionName;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the document was created.
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
        /// Gets and sets the property IsDefaultVersion. 
        /// <para>
        /// An identifier for the default version of the document.
        /// </para>
        /// </summary>
        public bool IsDefaultVersion
        {
            get { return this._isDefaultVersion.GetValueOrDefault(); }
            set { this._isDefaultVersion = value; }
        }

        // Check to see if IsDefaultVersion property is set
        internal bool IsSetIsDefaultVersion()
        {
            return this._isDefaultVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The document name.
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
        /// <code>Failed</code>, and <code>Deleting</code>.
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