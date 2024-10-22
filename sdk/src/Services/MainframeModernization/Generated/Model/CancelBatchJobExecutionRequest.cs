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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
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
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Container for the parameters to the CancelBatchJobExecution operation.
    /// Cancels the running of a specific batch job execution.
    /// </summary>
    public partial class CancelBatchJobExecutionRequest : AmazonMainframeModernizationRequest
    {
        private string _applicationId;
        private string _authSecretsManagerArn;
        private string _executionId;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AuthSecretsManagerArn. 
        /// <para>
        /// The Amazon Web Services Secrets Manager containing user's credentials for authentication
        /// and authorization for Cancel Batch Job Execution operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string AuthSecretsManagerArn
        {
            get { return this._authSecretsManagerArn; }
            set { this._authSecretsManagerArn = value; }
        }

        // Check to see if AuthSecretsManagerArn property is set
        internal bool IsSetAuthSecretsManagerArn()
        {
            return this._authSecretsManagerArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The unique identifier of the batch job execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

    }
}