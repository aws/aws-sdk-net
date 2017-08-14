/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines a point which a job can resume processing.
    /// </summary>
    public partial class JobBookmarkEntry
    {
        private int? _attempt;
        private string _jobBookmark;
        private string _jobName;
        private int? _run;
        private int? _version;

        /// <summary>
        /// Gets and sets the property Attempt. 
        /// <para>
        /// The attempt ID number.
        /// </para>
        /// </summary>
        public int Attempt
        {
            get { return this._attempt.GetValueOrDefault(); }
            set { this._attempt = value; }
        }

        // Check to see if Attempt property is set
        internal bool IsSetAttempt()
        {
            return this._attempt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobBookmark. 
        /// <para>
        /// The bookmark itself.
        /// </para>
        /// </summary>
        public string JobBookmark
        {
            get { return this._jobBookmark; }
            set { this._jobBookmark = value; }
        }

        // Check to see if JobBookmark property is set
        internal bool IsSetJobBookmark()
        {
            return this._jobBookmark != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// Name of the job in question.
        /// </para>
        /// </summary>
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property Run. 
        /// <para>
        /// The run ID number.
        /// </para>
        /// </summary>
        public int Run
        {
            get { return this._run.GetValueOrDefault(); }
            set { this._run = value; }
        }

        // Check to see if Run property is set
        internal bool IsSetRun()
        {
            return this._run.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version of the job.
        /// </para>
        /// </summary>
        public int Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}