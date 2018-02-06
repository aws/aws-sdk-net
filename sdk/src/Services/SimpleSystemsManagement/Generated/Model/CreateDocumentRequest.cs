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
    /// Container for the parameters to the CreateDocument operation.
    /// Creates a Systems Manager document.
    /// 
    ///  
    /// <para>
    /// After you create a document, you can use CreateAssociation to associate it with one
    /// or more running instances.
    /// </para>
    /// </summary>
    public partial class CreateDocumentRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _content;
        private DocumentFormat _documentFormat;
        private DocumentType _documentType;
        private string _name;
        private string _targetType;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateDocumentRequest() { }

        /// <summary>
        /// Instantiates CreateDocumentRequest with the parameterized properties
        /// </summary>
        /// <param name="name">A name for the Systems Manager document. <important> Do not use the following to begin the names of documents you create. They are reserved by AWS for use as document prefixes: <ul> <li>  <code>aws</code>  </li> <li>  <code>amazon</code>  </li> <li>  <code>amzn</code>  </li> </ul> </important></param>
        /// <param name="content">A valid JSON or YAML string.</param>
        public CreateDocumentRequest(string name, string content)
        {
            _name = name;
            _content = content;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// A valid JSON or YAML string.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DocumentFormat. 
        /// <para>
        /// Specify the document format for the request. The document format can be either JSON
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
        /// Gets and sets the property DocumentType. 
        /// <para>
        /// The type of document to create. Valid document types include: Policy, Automation,
        /// and Command.
        /// </para>
        /// </summary>
        public DocumentType DocumentType
        {
            get { return this._documentType; }
            set { this._documentType = value; }
        }

        // Check to see if DocumentType property is set
        internal bool IsSetDocumentType()
        {
            return this._documentType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the Systems Manager document.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not use the following to begin the names of documents you create. They are reserved
        /// by AWS for use as document prefixes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aws</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>amazon</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>amzn</code> 
        /// </para>
        ///  </li> </ul> </important>
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
        /// Gets and sets the property TargetType. 
        /// <para>
        /// Specify a target type to define the kinds of resources the document can run on. For
        /// example, to run a document on EC2 instances, specify the following value: /AWS::EC2::Instance.
        /// If you specify a value of '/' the document can run on all types of resources. If you
        /// don't specify a value, the document can't run on any resources. For a list of valid
        /// resource types, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">AWS
        /// Resource Types Reference</a> in the <i>AWS CloudFormation User Guide</i>. 
        /// </para>
        /// </summary>
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

    }
}