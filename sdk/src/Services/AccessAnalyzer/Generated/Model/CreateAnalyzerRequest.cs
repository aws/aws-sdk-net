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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAnalyzer operation.
    /// Creates an analyzer for your account.
    /// </summary>
    public partial class CreateAnalyzerRequest : AmazonAccessAnalyzerRequest
    {
        private string _analyzerName;
        private List<InlineArchiveRule> _archiveRules = new List<InlineArchiveRule>();
        private string _clientToken;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
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
        /// </summary>
        public List<InlineArchiveRule> ArchiveRules
        {
            get { return this._archiveRules; }
            set { this._archiveRules = value; }
        }

        // Check to see if ArchiveRules property is set
        internal bool IsSetArchiveRules()
        {
            return this._archiveRules != null && this._archiveRules.Count > 0; 
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the analyzer.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of analyzer to create. Only ACCOUNT and ORGANIZATION analyzers are supported.
        /// You can create only one analyzer per account per Region. You can create up to 5 analyzers
        /// per organization per Region.
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