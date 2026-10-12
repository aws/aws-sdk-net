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

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Contains progress metrics for a data transformation job, including counts of files
    /// scanned, converted, and failed.
    /// </summary>
    public partial class TransformationJobProgressReport
    {
        /// <summary>
        /// Gets and sets the property TotalFilesConverted. 
        /// <para>
        /// The total number of source files successfully converted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? TotalFilesConverted { get; set; }

        /// <summary>
        /// Checks to see if the TotalFilesConverted property is set.
        /// </summary>
        internal bool IsSetTotalFilesConverted() => this.TotalFilesConverted.HasValue;

        /// <summary>
        /// Gets and sets the property TotalFilesFailed. 
        /// <para>
        /// The total number of source files that failed conversion.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? TotalFilesFailed { get; set; }

        /// <summary>
        /// Checks to see if the TotalFilesFailed property is set.
        /// </summary>
        internal bool IsSetTotalFilesFailed() => this.TotalFilesFailed.HasValue;

        /// <summary>
        /// Gets and sets the property TotalFilesScanned. 
        /// <para>
        /// The total number of source files scanned by the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? TotalFilesScanned { get; set; }

        /// <summary>
        /// Checks to see if the TotalFilesScanned property is set.
        /// </summary>
        internal bool IsSetTotalFilesScanned() => this.TotalFilesScanned.HasValue;

        /// <summary>
        /// Gets and sets the property TotalResourcesGenerated. 
        /// <para>
        /// The total number of FHIR R4 resources generated across all converted files.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? TotalResourcesGenerated { get; set; }

        /// <summary>
        /// Checks to see if the TotalResourcesGenerated property is set.
        /// </summary>
        internal bool IsSetTotalResourcesGenerated() => this.TotalResourcesGenerated.HasValue;
    }
}
