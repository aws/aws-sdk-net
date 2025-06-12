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
    /// Container for the parameters to the StartBatchJob operation.
    /// Starts a batch job and returns the unique identifier of this execution of the batch
    /// job. The associated application must be running in order to start the batch job.
    /// </summary>
    public partial class StartBatchJobRequest : AmazonMainframeModernizationRequest
    {
        private string _applicationId;
        private string _authSecretsManagerArn;
        private BatchJobIdentifier _batchJobIdentifier;
        private Dictionary<string, string> _jobParams = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the application associated with this batch job.
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
        /// and authorization for Start Batch Job execution operation.
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
        /// Gets and sets the property BatchJobIdentifier. 
        /// <para>
        /// The unique identifier of the batch job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BatchJobIdentifier BatchJobIdentifier
        {
            get { return this._batchJobIdentifier; }
            set { this._batchJobIdentifier = value; }
        }

        // Check to see if BatchJobIdentifier property is set
        internal bool IsSetBatchJobIdentifier()
        {
            return this._batchJobIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property JobParams. 
        /// <para>
        /// The collection of batch job parameters. For details about limits for keys and values,
        /// see <a href="https://www.ibm.com/docs/en/workload-automation/9.3.0?topic=zos-coding-variables-in-jcl">Coding
        /// variables in JCL</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public Dictionary<string, string> JobParams
        {
            get { return this._jobParams; }
            set { this._jobParams = value; }
        }

        // Check to see if JobParams property is set
        internal bool IsSetJobParams()
        {
            return this._jobParams != null && (this._jobParams.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}