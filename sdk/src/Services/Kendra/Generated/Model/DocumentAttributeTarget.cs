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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// The target document attribute or metadata field you want to alter when ingesting documents
    /// into Amazon Kendra.
    /// 
    ///  
    /// <para>
    /// For example, you can delete customer identification numbers associated with the documents,
    /// stored in the document metadata field called 'Customer_ID'. You set the target key
    /// as 'Customer_ID' and the deletion flag to <c>TRUE</c>. This removes all customer ID
    /// values in the field 'Customer_ID'. This would scrub personally identifiable information
    /// from each document's metadata.
    /// </para>
    ///  
    /// <para>
    /// Amazon Kendra cannot create a target field if it has not already been created as an
    /// index field. After you create your index field, you can create a document metadata
    /// field using <c>DocumentAttributeTarget</c>. Amazon Kendra then will map your newly
    /// created metadata field to your index field.
    /// </para>
    ///  
    /// <para>
    /// You can also use this with <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_DocumentAttributeCondition.html">DocumentAttributeCondition</a>.
    /// </para>
    /// </summary>
    public partial class DocumentAttributeTarget
    {
        private string _targetDocumentAttributeKey;
        private DocumentAttributeValue _targetDocumentAttributeValue;
        private bool? _targetDocumentAttributeValueDeletion;

        /// <summary>
        /// Gets and sets the property TargetDocumentAttributeKey. 
        /// <para>
        /// The identifier of the target document attribute or metadata field.
        /// </para>
        ///  
        /// <para>
        /// For example, 'Department' could be an identifier for the target attribute or metadata
        /// field that includes the department names associated with the documents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string TargetDocumentAttributeKey
        {
            get { return this._targetDocumentAttributeKey; }
            set { this._targetDocumentAttributeKey = value; }
        }

        // Check to see if TargetDocumentAttributeKey property is set
        internal bool IsSetTargetDocumentAttributeKey()
        {
            return this._targetDocumentAttributeKey != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDocumentAttributeValue. 
        /// <para>
        /// The target value you want to create for the target attribute.
        /// </para>
        ///  
        /// <para>
        /// For example, 'Finance' could be the target value for the target attribute key 'Department'.
        /// </para>
        /// </summary>
        public DocumentAttributeValue TargetDocumentAttributeValue
        {
            get { return this._targetDocumentAttributeValue; }
            set { this._targetDocumentAttributeValue = value; }
        }

        // Check to see if TargetDocumentAttributeValue property is set
        internal bool IsSetTargetDocumentAttributeValue()
        {
            return this._targetDocumentAttributeValue != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDocumentAttributeValueDeletion. 
        /// <para>
        ///  <c>TRUE</c> to delete the existing target value for your specified target attribute
        /// key. You cannot create a target value and set this to <c>TRUE</c>. To create a target
        /// value (<c>TargetDocumentAttributeValue</c>), set this to <c>FALSE</c>.
        /// </para>
        /// </summary>
        public bool? TargetDocumentAttributeValueDeletion
        {
            get { return this._targetDocumentAttributeValueDeletion; }
            set { this._targetDocumentAttributeValueDeletion = value; }
        }

        // Check to see if TargetDocumentAttributeValueDeletion property is set
        internal bool IsSetTargetDocumentAttributeValueDeletion()
        {
            return this._targetDocumentAttributeValueDeletion.HasValue; 
        }

    }
}