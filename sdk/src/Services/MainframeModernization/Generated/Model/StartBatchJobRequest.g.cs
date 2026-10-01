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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the StartBatchJob operation. Starts a batch job and
    /// returns the unique identifier of this execution of the batch job. The associated application
    /// must be running in order to start the batch job.
    /// </summary>
    public partial class StartBatchJobRequest : AmazonMainframeModernizationRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the application associated with this batch job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property AuthSecretsManagerArn. 
        /// <para>
        /// The Amazon Web Services Secrets Manager containing user's credentials for authentication
        /// and authorization for Start Batch Job execution operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string AuthSecretsManagerArn { get; set; }

        /// <summary>
        /// Checks to see if the AuthSecretsManagerArn property is set.
        /// </summary>
        internal bool IsSetAuthSecretsManagerArn() => this.AuthSecretsManagerArn != null;

        /// <summary>
        /// Gets and sets the property BatchJobIdentifier. 
        /// <para>
        /// The unique identifier of the batch job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BatchJobIdentifier BatchJobIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the BatchJobIdentifier property is set.
        /// </summary>
        internal bool IsSetBatchJobIdentifier() => this.BatchJobIdentifier != null;

        /// <summary>
        /// Gets and sets the property JobParams. 
        /// <para>
        /// The collection of batch job parameters. For details about limits for keys and values,
        /// see <a href="https://www.ibm.com/docs/en/workload-automation/9.3.0?topic=zos-coding-variables-in-jcl">Coding
        /// variables in JCL</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public Dictionary<string, string> JobParams { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the JobParams property is set.
        /// </summary>
        internal bool IsSetJobParams() => this.JobParams != null && (this.JobParams.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
