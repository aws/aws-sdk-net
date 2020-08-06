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
    /// An object that defines the log patterns that belongs to a <code>LogPatternSet</code>.
    /// </summary>
    public partial class LogPattern
    {
        private string _pattern;
        private string _patternName;
        private string _patternSetName;
        private int? _rank;

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// A regular expression that defines the log pattern. A log pattern can contains at many
        /// as 50 characters, and it cannot be empty.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// The name of the log pattern. A log pattern name can contains at many as 50 characters,
        /// and it cannot be empty. The characters can be Unicode letters, digits or one of the
        /// following symbols: period, dash, underscore.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// The name of the log pattern. A log pattern name can contains at many as 30 characters,
        /// and it cannot be empty. The characters can be Unicode letters, digits or one of the
        /// following symbols: period, dash, underscore.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
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
        /// Rank of the log pattern.
        /// </para>
        /// </summary>
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

    }
}