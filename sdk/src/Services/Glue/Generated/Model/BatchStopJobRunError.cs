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
    /// Records an error that occurred when attempting to stop a specified job run.
    /// </summary>
    public partial class BatchStopJobRunError
    {
        private ErrorDetail _errorDetail;
        private string _jobName;
        private string _jobRunId;

        /// <summary>
        /// Gets and sets the property ErrorDetail. 
        /// <para>
        /// Specifies details about the error that was encountered.
        /// </para>
        /// </summary>
        public ErrorDetail ErrorDetail
        {
            get { return this._errorDetail; }
            set { this._errorDetail = value; }
        }

        // Check to see if ErrorDetail property is set
        internal bool IsSetErrorDetail()
        {
            return this._errorDetail != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job definition used in the job run in question.
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
        /// Gets and sets the property JobRunId. 
        /// <para>
        /// The JobRunId of the job run in question.
        /// </para>
        /// </summary>
        public string JobRunId
        {
            get { return this._jobRunId; }
            set { this._jobRunId = value; }
        }

        // Check to see if JobRunId property is set
        internal bool IsSetJobRunId()
        {
            return this._jobRunId != null;
        }

    }
}