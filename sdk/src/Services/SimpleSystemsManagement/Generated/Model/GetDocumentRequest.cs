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
    /// Container for the parameters to the GetDocument operation.
    /// Gets the contents of the specified Amazon Web Services Systems Manager document (SSM
    /// document).
    /// </summary>
    public partial class GetDocumentRequest : AmazonSimpleSystemsManagementRequest
    {
        private DocumentFormat _documentFormat;
        private string _documentVersion;
        private string _name;
        private string _versionName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetDocumentRequest() { }

        /// <summary>
        /// Instantiates GetDocumentRequest with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        public GetDocumentRequest(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Gets and sets the property DocumentFormat. 
        /// <para>
        /// Returns the document in the specified format. The document format can be either JSON
        /// or YAML. JSON is the default format.
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
        /// The document version for which you want information.
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
        /// Gets and sets the property VersionName. 
        /// <para>
        /// An optional field specifying the version of the artifact associated with the document.
        /// For example, 12.6. This value is unique across all versions of a document and can't
        /// be changed.
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