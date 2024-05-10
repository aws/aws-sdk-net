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
    /// Provides the configuration information for applying basic logic to alter document
    /// metadata and content when ingesting documents into Amazon Kendra. To apply advanced
    /// logic, to go beyond what you can do with basic logic, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_HookConfiguration.html">HookConfiguration</a>.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/custom-document-enrichment.html">Customizing
    /// document metadata during the ingestion process</a>.
    /// </para>
    /// </summary>
    public partial class InlineCustomDocumentEnrichmentConfiguration
    {
        private DocumentAttributeCondition _condition;
        private bool? _documentContentDeletion;
        private DocumentAttributeTarget _target;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// Configuration of the condition used for the target document attribute or metadata
        /// field when ingesting documents into Amazon Kendra.
        /// </para>
        /// </summary>
        public DocumentAttributeCondition Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentContentDeletion. 
        /// <para>
        ///  <c>TRUE</c> to delete content if the condition used for the target attribute is met.
        /// </para>
        /// </summary>
        public bool? DocumentContentDeletion
        {
            get { return this._documentContentDeletion; }
            set { this._documentContentDeletion = value; }
        }

        // Check to see if DocumentContentDeletion property is set
        internal bool IsSetDocumentContentDeletion()
        {
            return this._documentContentDeletion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// Configuration of the target document attribute or metadata field when ingesting documents
        /// into Amazon Kendra. You can also include a value.
        /// </para>
        /// </summary>
        public DocumentAttributeTarget Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}