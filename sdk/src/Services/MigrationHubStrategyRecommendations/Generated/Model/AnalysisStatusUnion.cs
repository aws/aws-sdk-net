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
    /// A combination of existing analysis statuses.
    /// </summary>
    public partial class AnalysisStatusUnion
    {
        private RuntimeAnalysisStatus _runtimeAnalysisStatus;
        private SrcCodeOrDbAnalysisStatus _srcCodeOrDbAnalysisStatus;

        /// <summary>
        /// Gets and sets the property RuntimeAnalysisStatus. 
        /// <para>
        /// The status of the analysis.
        /// </para>
        /// </summary>
        public RuntimeAnalysisStatus RuntimeAnalysisStatus
        {
            get { return this._runtimeAnalysisStatus; }
            set { this._runtimeAnalysisStatus = value; }
        }

        // Check to see if RuntimeAnalysisStatus property is set
        internal bool IsSetRuntimeAnalysisStatus()
        {
            return this._runtimeAnalysisStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SrcCodeOrDbAnalysisStatus. 
        /// <para>
        /// The status of the source code or database analysis.
        /// </para>
        /// </summary>
        public SrcCodeOrDbAnalysisStatus SrcCodeOrDbAnalysisStatus
        {
            get { return this._srcCodeOrDbAnalysisStatus; }
            set { this._srcCodeOrDbAnalysisStatus = value; }
        }

        // Check to see if SrcCodeOrDbAnalysisStatus property is set
        internal bool IsSetSrcCodeOrDbAnalysisStatus()
        {
            return this._srcCodeOrDbAnalysisStatus != null;
        }

    }
}