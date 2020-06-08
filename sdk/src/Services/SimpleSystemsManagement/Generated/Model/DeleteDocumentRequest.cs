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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDocument operation.
    /// Deletes the Systems Manager document and all instance associations to the document.
    /// 
    ///  
    /// <para>
    /// Before you delete the document, we recommend that you use <a>DeleteAssociation</a>
    /// to disassociate all instances that are associated with the document.
    /// </para>
    /// </summary>
    public partial class DeleteDocumentRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _documentVersion;
        private bool? _force;
        private string _name;
        private string _versionName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteDocumentRequest() { }

        /// <summary>
        /// Instantiates DeleteDocumentRequest with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the document.</param>
        public DeleteDocumentRequest(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The version of the document that you want to delete. If not provided, all versions
        /// of the document are deleted.
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
        /// Gets and sets the property Force. 
        /// <para>
        /// Some SSM document types require that you specify a <code>Force</code> flag before
        /// you can delete the document. For example, you must specify a <code>Force</code> flag
        /// to delete a document of type <code>ApplicationConfigurationSchema</code>. You can
        /// restrict access to the <code>Force</code> flag in an AWS Identity and Access Management
        /// (IAM) policy.
        /// </para>
        /// </summary>
        public bool Force
        {
            get { return this._force.GetValueOrDefault(); }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the document.
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
        /// The version name of the document that you want to delete. If not provided, all versions
        /// of the document are deleted.
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