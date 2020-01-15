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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Provides information about when a transcription job should be executed.
    /// </summary>
    public partial class JobExecutionSettings
    {
        private bool? _allowDeferredExecution;
        private string _dataAccessRoleArn;

        /// <summary>
        /// Gets and sets the property AllowDeferredExecution. 
        /// <para>
        /// Indicates whether a job should be queued by Amazon Transcribe when the concurrent
        /// execution limit is exceeded. When the <code>AllowDeferredExecution</code> field is
        /// true, jobs are queued and will be executed when the number of executing jobs falls
        /// below the concurrent execution limit. If the field is false, Amazon Transcribe returns
        /// a <code>LimitExceededException</code> exception.
        /// </para>
        ///  
        /// <para>
        /// If you specify the <code>AllowDeferredExecution</code> field, you must specify the
        /// <code>DataAccessRoleArn</code> field.
        /// </para>
        /// </summary>
        public bool AllowDeferredExecution
        {
            get { return this._allowDeferredExecution.GetValueOrDefault(); }
            set { this._allowDeferredExecution = value; }
        }

        // Check to see if AllowDeferredExecution property is set
        internal bool IsSetAllowDeferredExecution()
        {
            return this._allowDeferredExecution.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a role that has access to the S3 bucket that contains
        /// the input files. Amazon Transcribe will assume this role to read queued media files.
        /// If you have specified an output S3 bucket for the transcription results, this role
        /// should have access to the output bucket as well.
        /// </para>
        ///  
        /// <para>
        /// If you specify the <code>AllowDeferredExecution</code> field, you must specify the
        /// <code>DataAccessRoleArn</code> field.
        /// </para>
        /// </summary>
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

    }
}