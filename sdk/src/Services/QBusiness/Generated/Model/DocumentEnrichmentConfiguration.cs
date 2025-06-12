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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
    /// Provides the configuration information for altering document metadata and content
    /// during the document ingestion process.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/custom-document-enrichment.html">Custom
    /// document enrichment</a>.
    /// </para>
    /// </summary>
    public partial class DocumentEnrichmentConfiguration
    {
        private List<InlineDocumentEnrichmentConfiguration> _inlineConfigurations = AWSConfigs.InitializeCollections ? new List<InlineDocumentEnrichmentConfiguration>() : null;
        private HookConfiguration _postExtractionHookConfiguration;
        private HookConfiguration _preExtractionHookConfiguration;

        /// <summary>
        /// Gets and sets the property InlineConfigurations. 
        /// <para>
        /// Configuration information to alter document attributes or metadata fields and content
        /// when ingesting documents into Amazon Q Business.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<InlineDocumentEnrichmentConfiguration> InlineConfigurations
        {
            get { return this._inlineConfigurations; }
            set { this._inlineConfigurations = value; }
        }

        // Check to see if InlineConfigurations property is set
        internal bool IsSetInlineConfigurations()
        {
            return this._inlineConfigurations != null && (this._inlineConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PostExtractionHookConfiguration.
        /// </summary>
        public HookConfiguration PostExtractionHookConfiguration
        {
            get { return this._postExtractionHookConfiguration; }
            set { this._postExtractionHookConfiguration = value; }
        }

        // Check to see if PostExtractionHookConfiguration property is set
        internal bool IsSetPostExtractionHookConfiguration()
        {
            return this._postExtractionHookConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PreExtractionHookConfiguration.
        /// </summary>
        public HookConfiguration PreExtractionHookConfiguration
        {
            get { return this._preExtractionHookConfiguration; }
            set { this._preExtractionHookConfiguration = value; }
        }

        // Check to see if PreExtractionHookConfiguration property is set
        internal bool IsSetPreExtractionHookConfiguration()
        {
            return this._preExtractionHookConfiguration != null;
        }

    }
}