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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLogPattern operation.
    /// Adds an log pattern to a <code>LogPatternSet</code>.
    /// </summary>
    public partial class CreateLogPatternRequest : AmazonApplicationInsightsRequest
    {
        private string _pattern;
        private string _patternName;
        private string _patternSetName;
        private int? _rank;
        private string _resourceGroupName;

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// The log pattern. The pattern must be DFA compatible. Patterns that utilize forward
        /// lookahead or backreference constructions are not supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string Pattern
        {
            get { return this._pattern; }
            set { this._pattern = value; }
        }

        // Check to see if Pattern property is set
        internal bool IsSetPattern()
        {
            return this._pattern != null;
        }

        /// <summary>
        /// Gets and sets the property PatternName. 
        /// <para>
        /// The name of the log pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string PatternName
        {
            get { return this._patternName; }
            set { this._patternName = value; }
        }

        // Check to see if PatternName property is set
        internal bool IsSetPatternName()
        {
            return this._patternName != null;
        }

        /// <summary>
        /// Gets and sets the property PatternSetName. 
        /// <para>
        /// The name of the log pattern set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public string PatternSetName
        {
            get { return this._patternSetName; }
            set { this._patternSetName = value; }
        }

        // Check to see if PatternSetName property is set
        internal bool IsSetPatternSetName()
        {
            return this._patternSetName != null;
        }

        /// <summary>
        /// Gets and sets the property Rank. 
        /// <para>
        /// Rank of the log pattern. Must be a value between <code>1</code> and <code>1,000,000</code>.
        /// The patterns are sorted by rank, so we recommend that you set your highest priority
        /// patterns with the lowest rank. A pattern of rank <code>1</code> will be the first
        /// to get matched to a log line. A pattern of rank <code>1,000,000</code> will be last
        /// to get matched. When you configure custom log patterns from the console, a <code>Low</code>
        /// severity pattern translates to a <code>750,000</code> rank. A <code>Medium</code>
        /// severity pattern translates to a <code>500,000</code> rank. And a <code>High</code>
        /// severity pattern translates to a <code>250,000</code> rank. Rank values less than
        /// <code>1</code> or greater than <code>1,000,000</code> are reserved for AWS-provided
        /// patterns. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int Rank
        {
            get { return this._rank.GetValueOrDefault(); }
            set { this._rank = value; }
        }

        // Check to see if Rank property is set
        internal bool IsSetRank()
        {
            return this._rank.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ResourceGroupName
        {
            get { return this._resourceGroupName; }
            set { this._resourceGroupName = value; }
        }

        // Check to see if ResourceGroupName property is set
        internal bool IsSetResourceGroupName()
        {
            return this._resourceGroupName != null;
        }

    }
}