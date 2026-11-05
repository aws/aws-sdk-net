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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the StopJobUpgradeAnalysis operation. Stops an in-progress
    /// upgrade analysis.
    /// </summary>
    public partial class StopJobUpgradeAnalysisRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property AnalysisId. 
        /// <para>
        /// The unique identifier of the analysis to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 39, Max = 39)]
        public string AnalysisId { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisId property is set.
        /// </summary>
        internal bool IsSetAnalysisId() => this.AnalysisId != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job associated with the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;
    }
}
