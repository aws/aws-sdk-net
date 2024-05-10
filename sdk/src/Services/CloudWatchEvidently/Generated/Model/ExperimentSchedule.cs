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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// This structure contains the time and date that Evidently completed the analysis of
    /// the experiment.
    /// </summary>
    public partial class ExperimentSchedule
    {
        private DateTime? _analysisCompleteTime;

        /// <summary>
        /// Gets and sets the property AnalysisCompleteTime. 
        /// <para>
        /// The time and date that Evidently completed the analysis of the experiment.
        /// </para>
        /// </summary>
        public DateTime? AnalysisCompleteTime
        {
            get { return this._analysisCompleteTime; }
            set { this._analysisCompleteTime = value; }
        }

        // Check to see if AnalysisCompleteTime property is set
        internal bool IsSetAnalysisCompleteTime()
        {
            return this._analysisCompleteTime.HasValue; 
        }

    }
}