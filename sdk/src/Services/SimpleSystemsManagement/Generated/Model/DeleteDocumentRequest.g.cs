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
    /// Container for the parameters to the DeleteDocument operation. Deletes the Amazon Web
    /// Services Systems Manager document (SSM document) and all managed node associations
    /// to the document. <para> Before you delete the document, we recommend that you use
    /// <a>DeleteAssociation</a> to disassociate all managed nodes that are associated with
    /// the document. </para>
    /// </summary>
    public partial class DeleteDocumentRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DeleteDocumentRequest() { }

        /// <summary>
        /// Instantiates DeleteDocumentRequest with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the document.</param>
        public DeleteDocumentRequest(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The version of the document that you want to delete. If not provided, all versions
        /// of the document are deleted.
        /// </para>
        /// </summary>
        public string DocumentVersion { get; set; }

        /// <summary>
        /// Checks to see if the DocumentVersion property is set.
        /// </summary>
        internal bool IsSetDocumentVersion() => this.DocumentVersion != null;

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// Some SSM document types require that you specify a <c>Force</c> flag before you can
        /// delete the document. For example, you must specify a <c>Force</c> flag to delete a
        /// document of type <c>ApplicationConfigurationSchema</c>. You can restrict access to
        /// the <c>Force</c> flag in an Identity and Access Management (IAM) policy.
        /// </para>
        /// </summary>
        public bool? Force { get; set; }

        /// <summary>
        /// Checks to see if the Force property is set.
        /// </summary>
        internal bool IsSetForce() => this.Force.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The version name of the document that you want to delete. If not provided, all versions
        /// of the document are deleted.
        /// </para>
        /// </summary>
        public string VersionName { get; set; }

        /// <summary>
        /// Checks to see if the VersionName property is set.
        /// </summary>
        internal bool IsSetVersionName() => this.VersionName != null;
    }
}
