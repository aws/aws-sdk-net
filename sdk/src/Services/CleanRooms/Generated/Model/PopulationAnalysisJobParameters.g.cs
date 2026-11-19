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
    /// Contains the PySpark job parameters used to populate an intermediate table, including
    /// the ARN of the analysis template that defines the job. Use these parameters instead
    /// of SQL parameters when the analysis you use to populate the intermediate table is
    /// a PySpark analysis template.
    /// </summary>
    public partial class PopulationAnalysisJobParameters
    {
        /// <summary>
        /// Gets and sets the property AnalysisTemplateArn. 
        /// <para>
        /// Specifies the ARN of the PySpark analysis template that populates the intermediate
        /// table. Provide this ARN in <c>jobParameters</c> when you populate the intermediate
        /// table with results from a PySpark job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 200)]
        public string AnalysisTemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisTemplateArn property is set.
        /// </summary>
        internal bool IsSetAnalysisTemplateArn() => this.AnalysisTemplateArn != null;
    }
}
