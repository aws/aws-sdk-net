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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// The object containing the result statistics for a completed assessment run.
    /// </summary>
    public partial class ReplicationTaskAssessmentRunResultStatistic
    {
        /// <summary>
        /// Gets and sets the property Cancelled. 
        /// <para>
        ///  The number of individual assessments that were cancelled during the assessment run.
        /// 
        /// </para>
        /// </summary>
        public int? Cancelled { get; set; }

        /// <summary>
        /// Checks to see if the Cancelled property is set.
        /// </summary>
        internal bool IsSetCancelled() => this.Cancelled.HasValue;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The number of individual assessments that encountered a critical error and could not
        /// complete properly.
        /// </para>
        /// </summary>
        public int? Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error.HasValue;

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// The number of individual assessments that failed to meet the criteria defined in the
        /// assessment run.
        /// </para>
        /// </summary>
        public int? Failed { get; set; }

        /// <summary>
        /// Checks to see if the Failed property is set.
        /// </summary>
        internal bool IsSetFailed() => this.Failed.HasValue;

        /// <summary>
        /// Gets and sets the property Passed. 
        /// <para>
        /// The number of individual assessments that successfully passed all checks in the assessment
        /// run.
        /// </para>
        /// </summary>
        public int? Passed { get; set; }

        /// <summary>
        /// Checks to see if the Passed property is set.
        /// </summary>
        internal bool IsSetPassed() => this.Passed.HasValue;

        /// <summary>
        /// Gets and sets the property Skipped. 
        /// <para>
        /// The number of individual assessments that were skipped during the assessment run.
        /// </para>
        /// </summary>
        public int? Skipped { get; set; }

        /// <summary>
        /// Checks to see if the Skipped property is set.
        /// </summary>
        internal bool IsSetSkipped() => this.Skipped.HasValue;

        /// <summary>
        /// Gets and sets the property Warning. 
        /// <para>
        /// Indicates that the recent completed AssessmentRun triggered a warning.
        /// </para>
        /// </summary>
        public int? Warning { get; set; }

        /// <summary>
        /// Checks to see if the Warning property is set.
        /// </summary>
        internal bool IsSetWarning() => this.Warning.HasValue;
    }
}
