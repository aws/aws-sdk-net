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
    /// Describes a data quality result.
    /// </summary>
    public partial class DataQualityResultDescription
    {
        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The table name associated with the data quality result.
        /// </para>
        /// </summary>
        public DataSource DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The job name associated with the data quality result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobRunId. 
        /// <para>
        /// The job run ID associated with the data quality result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string JobRunId { get; set; }

        /// <summary>
        /// Checks to see if the JobRunId property is set.
        /// </summary>
        internal bool IsSetJobRunId() => this.JobRunId != null;

        /// <summary>
        /// Gets and sets the property ResultId. 
        /// <para>
        /// The unique result ID for this data quality result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ResultId { get; set; }

        /// <summary>
        /// Checks to see if the ResultId property is set.
        /// </summary>
        internal bool IsSetResultId() => this.ResultId != null;

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The time that the run started for this data quality result.
        /// </para>
        /// </summary>
        public DateTime? StartedOn { get; set; }

        /// <summary>
        /// Checks to see if the StartedOn property is set.
        /// </summary>
        internal bool IsSetStartedOn() => this.StartedOn.HasValue;
    }
}
