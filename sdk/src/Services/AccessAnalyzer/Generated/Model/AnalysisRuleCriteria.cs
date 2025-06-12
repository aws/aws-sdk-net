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
    /// The criteria for an analysis rule for an analyzer. The criteria determine which entities
    /// will generate findings.
    /// </summary>
    public partial class AnalysisRuleCriteria
    {
        private List<string> _accountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Dictionary<string, string>> _resourceTags = AWSConfigs.InitializeCollections ? new List<Dictionary<string, string>>() : null;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// A list of Amazon Web Services account IDs to apply to the analysis rule criteria.
        /// The accounts cannot include the organization analyzer owner account. Account IDs can
        /// only be applied to the analysis rule criteria for organization-level analyzers. The
        /// list cannot include more than 2,000 account IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && (this._accountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// An array of key-value pairs to match for your resources. You can use the set of Unicode
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
        /// If the specified tag value is 0 characters, the rule is applied to all principals
        /// with the specified tag key.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dictionary<string, string>> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && (this._resourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}