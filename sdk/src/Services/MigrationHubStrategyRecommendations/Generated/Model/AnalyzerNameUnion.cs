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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// The combination of the existing analyzers.
    /// </summary>
    public partial class AnalyzerNameUnion
    {
        private BinaryAnalyzerName _binaryAnalyzerName;
        private RunTimeAnalyzerName _runTimeAnalyzerName;
        private SourceCodeAnalyzerName _sourceCodeAnalyzerName;

        /// <summary>
        /// Gets and sets the property BinaryAnalyzerName. 
        /// <para>
        /// The binary analyzer names.
        /// </para>
        /// </summary>
        public BinaryAnalyzerName BinaryAnalyzerName
        {
            get { return this._binaryAnalyzerName; }
            set { this._binaryAnalyzerName = value; }
        }

        // Check to see if BinaryAnalyzerName property is set
        internal bool IsSetBinaryAnalyzerName()
        {
            return this._binaryAnalyzerName != null;
        }

        /// <summary>
        /// Gets and sets the property RunTimeAnalyzerName. 
        /// <para>
        /// The assessment analyzer names.
        /// </para>
        /// </summary>
        public RunTimeAnalyzerName RunTimeAnalyzerName
        {
            get { return this._runTimeAnalyzerName; }
            set { this._runTimeAnalyzerName = value; }
        }

        // Check to see if RunTimeAnalyzerName property is set
        internal bool IsSetRunTimeAnalyzerName()
        {
            return this._runTimeAnalyzerName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCodeAnalyzerName. 
        /// <para>
        /// The source code analyzer names.
        /// </para>
        /// </summary>
        public SourceCodeAnalyzerName SourceCodeAnalyzerName
        {
            get { return this._sourceCodeAnalyzerName; }
            set { this._sourceCodeAnalyzerName = value; }
        }

        // Check to see if SourceCodeAnalyzerName property is set
        internal bool IsSetSourceCodeAnalyzerName()
        {
            return this._sourceCodeAnalyzerName != null;
        }

    }
}