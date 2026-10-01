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

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// The combination of the existing analyzers.
    /// </summary>
    public partial class AnalyzerNameUnion
    {
        /// <summary>
        /// Gets and sets the property BinaryAnalyzerName. 
        /// <para>
        /// The binary analyzer names.
        /// </para>
        /// </summary>
        public BinaryAnalyzerName BinaryAnalyzerName { get; set; }

        /// <summary>
        /// Checks to see if the BinaryAnalyzerName property is set.
        /// </summary>
        internal bool IsSetBinaryAnalyzerName() => this.BinaryAnalyzerName != null;

        /// <summary>
        /// Gets and sets the property RunTimeAnalyzerName. 
        /// <para>
        /// The assessment analyzer names.
        /// </para>
        /// </summary>
        public RunTimeAnalyzerName RunTimeAnalyzerName { get; set; }

        /// <summary>
        /// Checks to see if the RunTimeAnalyzerName property is set.
        /// </summary>
        internal bool IsSetRunTimeAnalyzerName() => this.RunTimeAnalyzerName != null;

        /// <summary>
        /// Gets and sets the property SourceCodeAnalyzerName. 
        /// <para>
        /// The source code analyzer names.
        /// </para>
        /// </summary>
        public SourceCodeAnalyzerName SourceCodeAnalyzerName { get; set; }

        /// <summary>
        /// Checks to see if the SourceCodeAnalyzerName property is set.
        /// </summary>
        internal bool IsSetSourceCodeAnalyzerName() => this.SourceCodeAnalyzerName != null;
    }
}
