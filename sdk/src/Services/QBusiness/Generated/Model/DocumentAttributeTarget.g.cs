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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// The target document attribute or metadata field you want to alter when ingesting documents
    /// into Amazon Q Business.
    /// 
    ///  
    /// <para>
    /// For example, you can delete all customer identification numbers associated with the
    /// documents, stored in the document metadata field called 'Customer_ID' by setting the
    /// target key as 'Customer_ID' and the deletion flag to <c>TRUE</c>. This removes all
    /// customer ID values in the field 'Customer_ID'. This would scrub personally identifiable
    /// information from each document's metadata.
    /// </para>
    ///  
    /// <para>
    /// Amazon Q Business can't create a target field if it has not already been created as
    /// an index field. After you create your index field, you can create a document metadata
    /// field using <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_DocumentAttributeTarget.html">
    /// <c>DocumentAttributeTarget</c> </a>. Amazon Q Business will then map your newly created
    /// document attribute to your index field.
    /// </para>
    ///  
    /// <para>
    /// You can also use this with <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_DocumentAttributeCondition.html">
    /// <c>DocumentAttributeCondition</c> </a>.
    /// </para>
    /// </summary>
    public partial class DocumentAttributeTarget
    {
        /// <summary>
        /// Gets and sets the property AttributeValueOperator. 
        /// <para>
        ///  <c>TRUE</c> to delete the existing target value for your specified target attribute
        /// key. You cannot create a target value and set this to <c>TRUE</c>.
        /// </para>
        /// </summary>
        public AttributeValueOperator AttributeValueOperator { get; set; }

        /// <summary>
        /// Checks to see if the AttributeValueOperator property is set.
        /// </summary>
        internal bool IsSetAttributeValueOperator() => this.AttributeValueOperator != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The identifier of the target document attribute or metadata field. For example, 'Department'
        /// could be an identifier for the target attribute or metadata field that includes the
        /// department names associated with the documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Value.
        /// </summary>
        public DocumentAttributeValue Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
