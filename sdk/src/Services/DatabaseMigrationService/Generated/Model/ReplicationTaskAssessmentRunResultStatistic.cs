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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
        private int? _cancelled;
        private int? _error;
        private int? _failed;
        private int? _passed;
        private int? _skipped;
        private int? _warning;

        /// <summary>
        /// Gets and sets the property Cancelled. 
        /// <para>
        ///  The number of individual assessments that were cancelled during the assessment run.
        /// 
        /// </para>
        /// </summary>
        public int? Cancelled
        {
            get { return this._cancelled; }
            set { this._cancelled = value; }
        }

        // Check to see if Cancelled property is set
        internal bool IsSetCancelled()
        {
            return this._cancelled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The number of individual assessments that encountered a critical error and could not
        /// complete properly.
        /// </para>
        /// </summary>
        public int? Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// The number of individual assessments that failed to meet the criteria defined in the
        /// assessment run.
        /// </para>
        /// </summary>
        public int? Failed
        {
            get { return this._failed; }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Passed. 
        /// <para>
        /// The number of individual assessments that successfully passed all checks in the assessment
        /// run.
        /// </para>
        /// </summary>
        public int? Passed
        {
            get { return this._passed; }
            set { this._passed = value; }
        }

        // Check to see if Passed property is set
        internal bool IsSetPassed()
        {
            return this._passed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Skipped. 
        /// <para>
        /// The number of individual assessments that were skipped during the assessment run.
        /// </para>
        /// </summary>
        public int? Skipped
        {
            get { return this._skipped; }
            set { this._skipped = value; }
        }

        // Check to see if Skipped property is set
        internal bool IsSetSkipped()
        {
            return this._skipped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Warning. 
        /// <para>
        /// Indicates that the recent completed AssessmentRun triggered a warning.
        /// </para>
        /// </summary>
        public int? Warning
        {
            get { return this._warning; }
            set { this._warning = value; }
        }

        // Check to see if Warning property is set
        internal bool IsSetWarning()
        {
            return this._warning.HasValue; 
        }

    }
}