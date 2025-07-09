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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAnalyzer operation.
    /// Creates an analyzer for your account.
    /// </summary>
    public partial class CreateAnalyzerRequest : AmazonAccessAnalyzerRequest
    {
        private string _analyzerName;
        private List<InlineArchiveRule> _archiveRules = AWSConfigs.InitializeCollections ? new List<InlineArchiveRule>() : null;
        private string _clientToken;
        private AnalyzerConfiguration _configuration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Type _type;

        /// <summary>
        /// Gets and sets the property AnalyzerName. 
        /// <para>
        /// The name of the analyzer to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AnalyzerName
        {
            get { return this._analyzerName; }
            set { this._analyzerName = value; }
        }

        // Check to see if AnalyzerName property is set
        internal bool IsSetAnalyzerName()
        {
            return this._analyzerName != null;
        }

        /// <summary>
        /// Gets and sets the property ArchiveRules. 
        /// <para>
        /// Specifies the archive rules to add for the analyzer. Archive rules automatically archive
        /// findings that meet the criteria you define for the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InlineArchiveRule> ArchiveRules
        {
            get { return this._archiveRules; }
            set { this._archiveRules = value; }
        }

        // Check to see if ArchiveRules property is set
        internal bool IsSetArchiveRules()
        {
            return this._archiveRules != null && (this._archiveRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A client token.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Specifies the configuration of the analyzer. If the analyzer is an unused access analyzer,
        /// the specified scope of unused access is used for the configuration. If the analyzer
        /// is an internal access analyzer, the specified internal access analysis rules are used
        /// for the configuration.
        /// </para>
        /// </summary>
        public AnalyzerConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs to apply to the analyzer. You can use the set of Unicode
        /// letters, digits, whitespace, <c>_</c>, <c>.</c>, <c>/</c>, <c>=</c>, <c>+</c>, and
        /// <c>-</c>.
        /// </para>
        ///  
        /// <para>
        /// For the tag key, you can specify a value that is 1 to 128 characters in length and
        /// cannot be prefixed with <c>aws:</c>.
        /// </para>
        ///  
        /// <para>
        /// For the tag value, you can specify a value that is 0 to 256 characters in length.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of analyzer to create. You can create only one analyzer per account per Region.
        /// You can create up to 5 analyzers per organization per Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Type Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}