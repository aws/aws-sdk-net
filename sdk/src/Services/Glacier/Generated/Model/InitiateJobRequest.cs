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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
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
namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the InitiateJob operation.
    /// This operation initiates a job of the specified type, which can be a select, an archival
    /// retrieval, or a vault retrieval. For more information about using this operation,
    /// see the documentation for the underlying REST API <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-initiate-job-post.html">Initiate
    /// a Job</a>.
    /// </summary>
    public partial class InitiateJobRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private JobParameters _jobParameters;
        private string _vaultName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public InitiateJobRequest() { }

        /// <summary>
        /// Instantiates InitiateJobRequest with the parameterized properties
        /// </summary>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="jobParameters">Provides options for specifying job information.</param>
        public InitiateJobRequest(string vaultName, JobParameters jobParameters)
        {
            _vaultName = vaultName;
            _jobParameters = jobParameters;
        }

        /// <summary>
        /// Instantiates InitiateJobRequest with the parameterized properties
        /// </summary>
        /// <param name="accountId">The <c>AccountId</c> value is the AWS account ID of the account that owns the vault. You can either specify an AWS account ID or optionally a single '<c>-</c>' (hyphen), in which case Amazon S3 Glacier uses the AWS account ID associated with the credentials used to sign the request. If you use an account ID, do not include any hyphens ('-') in the ID.</param>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="jobParameters">Provides options for specifying job information.</param>
        public InitiateJobRequest(string accountId, string vaultName, JobParameters jobParameters)
        {
            _accountId = accountId;
            _vaultName = vaultName;
            _jobParameters = jobParameters;
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <c>AccountId</c> value is the AWS account ID of the account that owns the vault.
        /// You can either specify an AWS account ID or optionally a single '<c>-</c>' (hyphen),
        /// in which case Amazon S3 Glacier uses the AWS account ID associated with the credentials
        /// used to sign the request. If you use an account ID, do not include any hyphens ('-')
        /// in the ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property JobParameters. 
        /// <para>
        /// Provides options for specifying job information.
        /// </para>
        /// </summary>
        public JobParameters JobParameters
        {
            get { return this._jobParameters; }
            set { this._jobParameters = value; }
        }

        // Check to see if JobParameters property is set
        internal bool IsSetJobParameters()
        {
            return this._jobParameters != null;
        }

        /// <summary>
        /// Gets and sets the property VaultName. 
        /// <para>
        /// The name of the vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VaultName
        {
            get { return this._vaultName; }
            set { this._vaultName = value; }
        }

        // Check to see if VaultName property is set
        internal bool IsSetVaultName()
        {
            return this._vaultName != null;
        }

    }
}