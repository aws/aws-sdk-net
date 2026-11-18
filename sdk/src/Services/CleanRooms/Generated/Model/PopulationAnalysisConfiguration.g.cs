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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Contains the configuration that defines the analysis used to populate an intermediate
    /// table.
    /// </summary>
    public partial class PopulationAnalysisConfiguration
    {
        /// <summary>
        /// Gets and sets the property JobParameters. 
        /// <para>
        /// Specifies the PySpark job parameters for the population analysis. Use <c>jobParameters</c>
        /// instead of <c>sqlParameters</c> when you populate the intermediate table with results
        /// from a PySpark job.
        /// </para>
        /// </summary>
        public PopulationAnalysisJobParameters JobParameters { get; set; }

        /// <summary>
        /// Checks to see if the JobParameters property is set.
        /// </summary>
        internal bool IsSetJobParameters() => this.JobParameters != null;

        /// <summary>
        /// Gets and sets the property SqlParameters. 
        /// <para>
        /// The SQL parameters for the population analysis, including the query string or analysis
        /// template ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public PopulationAnalysisSqlParameters SqlParameters { get; set; }

        /// <summary>
        /// Checks to see if the SqlParameters property is set.
        /// </summary>
        internal bool IsSetSqlParameters() => this.SqlParameters != null;
    }
}
