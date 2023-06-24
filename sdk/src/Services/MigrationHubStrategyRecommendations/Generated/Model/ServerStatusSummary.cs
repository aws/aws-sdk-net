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
    /// The status summary of the server analysis.
    /// </summary>
    public partial class ServerStatusSummary
    {
        private int? _count;
        private RunTimeAssessmentStatus _runTimeAssessmentStatus;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of servers successfully analyzed, partially successful or failed analysis.
        /// </para>
        /// </summary>
        public int Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunTimeAssessmentStatus. 
        /// <para>
        /// The status of the run time.
        /// </para>
        /// </summary>
        public RunTimeAssessmentStatus RunTimeAssessmentStatus
        {
            get { return this._runTimeAssessmentStatus; }
            set { this._runTimeAssessmentStatus = value; }
        }

        // Check to see if RunTimeAssessmentStatus property is set
        internal bool IsSetRunTimeAssessmentStatus()
        {
            return this._runTimeAssessmentStatus != null;
        }

    }
}