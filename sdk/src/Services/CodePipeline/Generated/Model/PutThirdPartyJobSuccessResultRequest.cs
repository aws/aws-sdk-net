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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Container for the parameters to the PutThirdPartyJobSuccessResult operation.
    /// Represents the success of a third party job as returned to the pipeline by a job worker.
    /// Only used for partner actions.
    /// </summary>
    public partial class PutThirdPartyJobSuccessResultRequest : AmazonCodePipelineRequest
    {
        private string _clientToken;
        private string _continuationToken;
        private CurrentRevision _currentRevision;
        private ExecutionDetails _executionDetails;
        private string _jobId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The clientToken portion of the clientId and clientToken pair used to verify that the
        /// calling entity is allowed access to the job and its details.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        /// A system-generated token, such as a AWS CodeDeploy deployment ID, that a job uses
        /// in order to continue the job asynchronously.
        /// </para>
        /// </summary>
        public string ContinuationToken
        {
            get { return this._continuationToken; }
            set { this._continuationToken = value; }
        }

        // Check to see if ContinuationToken property is set
        internal bool IsSetContinuationToken()
        {
            return this._continuationToken != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentRevision.
        /// </summary>
        public CurrentRevision CurrentRevision
        {
            get { return this._currentRevision; }
            set { this._currentRevision = value; }
        }

        // Check to see if CurrentRevision property is set
        internal bool IsSetCurrentRevision()
        {
            return this._currentRevision != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionDetails.
        /// </summary>
        public ExecutionDetails ExecutionDetails
        {
            get { return this._executionDetails; }
            set { this._executionDetails = value; }
        }

        // Check to see if ExecutionDetails property is set
        internal bool IsSetExecutionDetails()
        {
            return this._executionDetails != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the job that successfully completed. This is the same ID returned from PollForThirdPartyJobs.
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

    }
}