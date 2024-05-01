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
    /// The condition used for the target document attribute or metadata field when ingesting
    /// documents into Amazon Kendra. You use this with <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_DocumentAttributeTarget.html">DocumentAttributeTarget
    /// to apply the condition</a>.
    /// 
    ///  
    /// <para>
    /// For example, you can create the 'Department' target field and have it prefill department
    /// names associated with the documents based on information in the 'Source_URI' field.
    /// Set the condition that if the 'Source_URI' field contains 'financial' in its URI value,
    /// then prefill the target field 'Department' with the target value 'Finance' for the
    /// document.
    /// </para>
    ///  
    /// <para>
    /// Amazon Kendra cannot create a target field if it has not already been created as an
    /// index field. After you create your index field, you can create a document metadata
    /// field using <c>DocumentAttributeTarget</c>. Amazon Kendra then will map your newly
    /// created metadata field to your index field.
    /// </para>
    /// </summary>
    public partial class DocumentAttributeCondition
    {
        private string _conditionDocumentAttributeKey;
        private DocumentAttributeValue _conditionOnValue;
        private ConditionOperator _operator;

        /// <summary>
        /// Gets and sets the property ConditionDocumentAttributeKey. 
        /// <para>
        /// The identifier of the document attribute used for the condition.
        /// </para>
        ///  
        /// <para>
        /// For example, 'Source_URI' could be an identifier for the attribute or metadata field
        /// that contains source URIs associated with the documents.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kendra currently does not support <c>_document_body</c> as an attribute key
        /// used for the condition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string ConditionDocumentAttributeKey
        {
            get { return this._conditionDocumentAttributeKey; }
            set { this._conditionDocumentAttributeKey = value; }
        }

        // Check to see if ConditionDocumentAttributeKey property is set
        internal bool IsSetConditionDocumentAttributeKey()
        {
            return this._conditionDocumentAttributeKey != null;
        }

        /// <summary>
        /// Gets and sets the property ConditionOnValue. 
        /// <para>
        /// The value used by the operator.
        /// </para>
        ///  
        /// <para>
        /// For example, you can specify the value 'financial' for strings in the 'Source_URI'
        /// field that partially match or contain this value.
        /// </para>
        /// </summary>
        public DocumentAttributeValue ConditionOnValue
        {
            get { return this._conditionOnValue; }
            set { this._conditionOnValue = value; }
        }

        // Check to see if ConditionOnValue property is set
        internal bool IsSetConditionOnValue()
        {
            return this._conditionOnValue != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The condition operator.
        /// </para>
        ///  
        /// <para>
        /// For example, you can use 'Contains' to partially match a string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConditionOperator Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

    }
}