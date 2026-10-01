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
    /// Provides the configuration information for applying basic logic to alter document
    /// metadata and content when ingesting documents into Amazon Q Business.
    /// 
    ///  
    /// <para>
    /// To apply advanced logic, to go beyond what you can do with basic logic, see <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_HookConfiguration.html">
    /// <c>HookConfiguration</c> </a>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/custom-document-enrichment.html">Custom
    /// document enrichment</a>. 
    /// </para>
    /// </summary>
    public partial class InlineDocumentEnrichmentConfiguration
    {
        /// <summary>
        /// Gets and sets the property Condition.
        /// </summary>
        public DocumentAttributeCondition Condition { get; set; }

        /// <summary>
        /// Checks to see if the Condition property is set.
        /// </summary>
        internal bool IsSetCondition() => this.Condition != null;

        /// <summary>
        /// Gets and sets the property DocumentContentOperator. 
        /// <para>
        ///  <c>TRUE</c> to delete content if the condition used for the target attribute is met.
        /// </para>
        /// </summary>
        public DocumentContentOperator DocumentContentOperator { get; set; }

        /// <summary>
        /// Checks to see if the DocumentContentOperator property is set.
        /// </summary>
        internal bool IsSetDocumentContentOperator() => this.DocumentContentOperator != null;

        /// <summary>
        /// Gets and sets the property Target.
        /// </summary>
        public DocumentAttributeTarget Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
