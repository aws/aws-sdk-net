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
    /// A combination of existing analysis statuses.
    /// </summary>
    public partial class AnalysisStatusUnion
    {
        /// <summary>
        /// Gets and sets the property RuntimeAnalysisStatus. 
        /// <para>
        /// The status of the analysis.
        /// </para>
        /// </summary>
        public RuntimeAnalysisStatus RuntimeAnalysisStatus { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeAnalysisStatus property is set.
        /// </summary>
        internal bool IsSetRuntimeAnalysisStatus() => this.RuntimeAnalysisStatus != null;

        /// <summary>
        /// Gets and sets the property SrcCodeOrDbAnalysisStatus. 
        /// <para>
        /// The status of the source code or database analysis.
        /// </para>
        /// </summary>
        public SrcCodeOrDbAnalysisStatus SrcCodeOrDbAnalysisStatus { get; set; }

        /// <summary>
        /// Checks to see if the SrcCodeOrDbAnalysisStatus property is set.
        /// </summary>
        internal bool IsSetSrcCodeOrDbAnalysisStatus() => this.SrcCodeOrDbAnalysisStatus != null;
    }
}
