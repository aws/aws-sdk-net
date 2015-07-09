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
    /// Container for the parameters to the GetThirdPartyJobDetails operation.
    /// Requests the details of a job for a third party action. Only used for partner actions.
    /// 
    ///  <important>
    /// <para>
    /// When this API is called, AWS CodePipeline returns temporary credentials for the Amazon
    /// S3 bucket used to store artifacts for the pipeline, if the action requires access
    /// to that Amazon S3 bucket for input or output artifacts. Additionally, this API returns
    /// any secret values defined for the action.
    /// </para>
    /// </important>
    /// </summary>
    public partial class GetThirdPartyJobDetailsRequest : AmazonCodePipelineRequest
    {
        private string _clientToken;
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
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique system-generated ID used for identifying the job.
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