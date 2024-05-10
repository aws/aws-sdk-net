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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Makes it possible to control how your transcription job is processed. Currently, the
    /// only <c>JobExecutionSettings</c> modification you can choose is enabling job queueing
    /// using the <c>AllowDeferredExecution</c> sub-parameter.
    /// 
    ///  
    /// <para>
    /// If you include <c>JobExecutionSettings</c> in your request, you must also include
    /// the sub-parameters: <c>AllowDeferredExecution</c> and <c>DataAccessRoleArn</c>.
    /// </para>
    /// </summary>
    public partial class JobExecutionSettings
    {
        private bool? _allowDeferredExecution;
        private string _dataAccessRoleArn;

        /// <summary>
        /// Gets and sets the property AllowDeferredExecution. 
        /// <para>
        /// Makes it possible to enable job queuing when your concurrent request limit is exceeded.
        /// When <c>AllowDeferredExecution</c> is set to <c>true</c>, transcription job requests
        /// are placed in a queue until the number of jobs falls below the concurrent request
        /// limit. If <c>AllowDeferredExecution</c> is set to <c>false</c> and the number of transcription
        /// job requests exceed the concurrent request limit, you get a <c>LimitExceededException</c>
        /// error.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>AllowDeferredExecution</c> in your request, you must also include
        /// <c>DataAccessRoleArn</c>.
        /// </para>
        /// </summary>
        public bool? AllowDeferredExecution
        {
            get { return this._allowDeferredExecution; }
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
        /// The Amazon Resource Name (ARN) of an IAM role that has permissions to access the Amazon
        /// S3 bucket that contains your input files. If the role that you specify doesn’t have
        /// the appropriate permissions to access the specified Amazon S3 location, your request
        /// fails.
        /// </para>
        ///  
        /// <para>
        /// IAM role ARNs have the format <c>arn:partition:iam::account:role/role-name-with-path</c>.
        /// For example: <c>arn:aws:iam::111122223333:role/Admin</c>. For more information, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns">IAM
        /// ARNs</a>.
        /// </para>
        ///  
        /// <para>
        /// Note that if you include <c>DataAccessRoleArn</c> in your request, you must also include
        /// <c>AllowDeferredExecution</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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