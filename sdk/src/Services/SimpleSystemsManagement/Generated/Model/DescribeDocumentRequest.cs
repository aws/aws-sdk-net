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
    /// Container for the parameters to the DescribeDocument operation.
    /// Describes the specified Amazon Web Services Systems Manager document (SSM document).
    /// </summary>
    public partial class DescribeDocumentRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _documentVersion;
        private string _name;
        private string _versionName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeDocumentRequest() { }

        /// <summary>
        /// Instantiates DescribeDocumentRequest with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the SSM document. <note> If you're calling a shared SSM document from a different Amazon Web Services account, <c>Name</c> is the full Amazon Resource Name (ARN) of the document. </note></param>
        public DescribeDocumentRequest(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The document version for which you want information. Can be a specific version or
        /// the default version.
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
        ///  <note> 
        /// <para>
        /// If you're calling a shared SSM document from a different Amazon Web Services account,
        /// <c>Name</c> is the full Amazon Resource Name (ARN) of the document.
        /// </para>
        ///  </note>
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
        /// For example, 12.6. This value is unique across all versions of a document, and can't
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