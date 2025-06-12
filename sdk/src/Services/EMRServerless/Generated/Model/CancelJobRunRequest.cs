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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// Container for the parameters to the CancelJobRun operation.
    /// Cancels a job run.
    /// </summary>
    public partial class CancelJobRunRequest : AmazonEMRServerlessRequest
    {
        private string _applicationId;
        private string _jobRunId;
        private int? _shutdownGracePeriodInSeconds;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application on which the job run will be canceled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property JobRunId. 
        /// <para>
        /// The ID of the job run to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

        /// <summary>
        /// Gets and sets the property ShutdownGracePeriodInSeconds. 
        /// <para>
        /// The duration in seconds to wait before forcefully terminating the job after cancellation
        /// is requested.
        /// </para>
        /// </summary>
        public int? ShutdownGracePeriodInSeconds
        {
            get { return this._shutdownGracePeriodInSeconds; }
            set { this._shutdownGracePeriodInSeconds = value; }
        }

        // Check to see if ShutdownGracePeriodInSeconds property is set
        internal bool IsSetShutdownGracePeriodInSeconds()
        {
            return this._shutdownGracePeriodInSeconds.HasValue; 
        }

    }
}