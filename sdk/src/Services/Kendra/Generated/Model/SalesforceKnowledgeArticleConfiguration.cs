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
    /// Provides the configuration information for the knowledge article types that Amazon
    /// Kendra indexes. Amazon Kendra indexes standard knowledge articles and the standard
    /// fields of knowledge articles, or the custom fields of custom knowledge articles, but
    /// not both
    /// </summary>
    public partial class SalesforceKnowledgeArticleConfiguration
    {
        private List<SalesforceCustomKnowledgeArticleTypeConfiguration> _customKnowledgeArticleTypeConfigurations = AWSConfigs.InitializeCollections ? new List<SalesforceCustomKnowledgeArticleTypeConfiguration>() : null;
        private List<string> _includedStates = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SalesforceStandardKnowledgeArticleTypeConfiguration _standardKnowledgeArticleTypeConfiguration;

        /// <summary>
        /// Gets and sets the property CustomKnowledgeArticleTypeConfigurations. 
        /// <para>
        /// Configuration information for custom Salesforce knowledge articles.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<SalesforceCustomKnowledgeArticleTypeConfiguration> CustomKnowledgeArticleTypeConfigurations
        {
            get { return this._customKnowledgeArticleTypeConfigurations; }
            set { this._customKnowledgeArticleTypeConfigurations = value; }
        }

        // Check to see if CustomKnowledgeArticleTypeConfigurations property is set
        internal bool IsSetCustomKnowledgeArticleTypeConfigurations()
        {
            return this._customKnowledgeArticleTypeConfigurations != null && (this._customKnowledgeArticleTypeConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludedStates. 
        /// <para>
        /// Specifies the document states that should be included when Amazon Kendra indexes knowledge
        /// articles. You must specify at least one state.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3)]
        public List<string> IncludedStates
        {
            get { return this._includedStates; }
            set { this._includedStates = value; }
        }

        // Check to see if IncludedStates property is set
        internal bool IsSetIncludedStates()
        {
            return this._includedStates != null && (this._includedStates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StandardKnowledgeArticleTypeConfiguration. 
        /// <para>
        /// Configuration information for standard Salesforce knowledge articles.
        /// </para>
        /// </summary>
        public SalesforceStandardKnowledgeArticleTypeConfiguration StandardKnowledgeArticleTypeConfiguration
        {
            get { return this._standardKnowledgeArticleTypeConfiguration; }
            set { this._standardKnowledgeArticleTypeConfiguration = value; }
        }

        // Check to see if StandardKnowledgeArticleTypeConfiguration property is set
        internal bool IsSetStandardKnowledgeArticleTypeConfiguration()
        {
            return this._standardKnowledgeArticleTypeConfiguration != null;
        }

    }
}