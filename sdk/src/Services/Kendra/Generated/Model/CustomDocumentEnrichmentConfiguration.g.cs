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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information for altering document metadata and content
    /// during the document ingestion process.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/custom-document-enrichment.html">Customizing
    /// document metadata during the ingestion process</a>.
    /// </para>
    /// </summary>
    public partial class CustomDocumentEnrichmentConfiguration
    {
        /// <summary>
        /// Gets and sets the property InlineConfigurations. 
        /// <para>
        /// Configuration information to alter document attributes or metadata fields and content
        /// when ingesting documents into Amazon Kendra.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<InlineCustomDocumentEnrichmentConfiguration> InlineConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<InlineCustomDocumentEnrichmentConfiguration>() : null;

        /// <summary>
        /// Checks to see if the InlineConfigurations property is set.
        /// </summary>
        internal bool IsSetInlineConfigurations() => this.InlineConfigurations != null && (this.InlineConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PostExtractionHookConfiguration. 
        /// <para>
        /// Configuration information for invoking a Lambda function in Lambda on the structured
        /// documents with their metadata and text extracted. You can use a Lambda function to
        /// apply advanced logic for creating, modifying, or deleting document metadata and content.
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/custom-document-enrichment.html#advanced-data-manipulation">Advanced
        /// data manipulation</a>.
        /// </para>
        /// </summary>
        public HookConfiguration PostExtractionHookConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PostExtractionHookConfiguration property is set.
        /// </summary>
        internal bool IsSetPostExtractionHookConfiguration() => this.PostExtractionHookConfiguration != null;

        /// <summary>
        /// Gets and sets the property PreExtractionHookConfiguration. 
        /// <para>
        /// Configuration information for invoking a Lambda function in Lambda on the original
        /// or raw documents before extracting their metadata and text. You can use a Lambda function
        /// to apply advanced logic for creating, modifying, or deleting document metadata and
        /// content. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/custom-document-enrichment.html#advanced-data-manipulation">Advanced
        /// data manipulation</a>.
        /// </para>
        /// </summary>
        public HookConfiguration PreExtractionHookConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PreExtractionHookConfiguration property is set.
        /// </summary>
        internal bool IsSetPreExtractionHookConfiguration() => this.PreExtractionHookConfiguration != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role with permission to run <c>PreExtractionHookConfiguration</c>
        /// and <c>PostExtractionHookConfiguration</c> for altering document metadata and content
        /// during the document ingestion process. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/iam-roles.html">an
        /// IAM roles for Amazon Kendra</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
