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
    /// Defines a point that a job can resume processing.
    /// </summary>
    public partial class JobBookmarkEntry
    {
        /// <summary>
        /// Gets and sets the property Attempt. 
        /// <para>
        /// The attempt ID number.
        /// </para>
        /// </summary>
        public int? Attempt { get; set; }

        /// <summary>
        /// Checks to see if the Attempt property is set.
        /// </summary>
        internal bool IsSetAttempt() => this.Attempt.HasValue;

        /// <summary>
        /// Gets and sets the property JobBookmark. 
        /// <para>
        /// The bookmark itself.
        /// </para>
        /// </summary>
        public string JobBookmark { get; set; }

        /// <summary>
        /// Checks to see if the JobBookmark property is set.
        /// </summary>
        internal bool IsSetJobBookmark() => this.JobBookmark != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job in question.
        /// </para>
        /// </summary>
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property PreviousRunId. 
        /// <para>
        /// The unique run identifier associated with the previous job run.
        /// </para>
        /// </summary>
        public string PreviousRunId { get; set; }

        /// <summary>
        /// Checks to see if the PreviousRunId property is set.
        /// </summary>
        internal bool IsSetPreviousRunId() => this.PreviousRunId != null;

        /// <summary>
        /// Gets and sets the property Run. 
        /// <para>
        /// The run ID number.
        /// </para>
        /// </summary>
        public int? Run { get; set; }

        /// <summary>
        /// Checks to see if the Run property is set.
        /// </summary>
        internal bool IsSetRun() => this.Run.HasValue;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The run ID number.
        /// </para>
        /// </summary>
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the job.
        /// </para>
        /// </summary>
        public int? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
