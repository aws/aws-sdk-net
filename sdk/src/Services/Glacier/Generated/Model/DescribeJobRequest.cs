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
    /// Container for the parameters to the DescribeJob operation.
    /// This operation returns information about a job you previously initiated, including
    /// the job initiation date, the user who initiated the job, the job status code/message
    /// and the Amazon SNS topic to notify after Amazon S3 Glacier (Glacier) completes the
    /// job. For more information about initiating a job, see <a>InitiateJob</a>. 
    /// 
    ///  <note> 
    /// <para>
    /// This operation enables you to check the status of your job. However, it is strongly
    /// recommended that you set up an Amazon SNS topic and specify it in your initiate job
    /// request so that Glacier can notify the topic after it completes the job.
    /// </para>
    ///  </note> 
    /// <para>
    /// A job ID will not expire for at least 24 hours after Glacier completes the job.
    /// </para>
    ///  
    /// <para>
    /// An AWS account has full permission to perform all operations (actions). However, AWS
    /// Identity and Access Management (IAM) users don't have any permissions by default.
    /// You must grant them explicit permission to perform specific actions. For more information,
    /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
    /// Control Using AWS Identity and Access Management (IAM)</a>.
    /// </para>
    ///  
    /// <para>
    ///  For more information about using this operation, see the documentation for the underlying
    /// REST API <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-describe-job-get.html">Describe
    /// Job</a> in the <i>Amazon Glacier Developer Guide</i>. 
    /// </para>
    /// </summary>
    public partial class DescribeJobRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private string _jobId;
        private string _vaultName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeJobRequest() { }

        /// <summary>
        /// Instantiates DescribeJobRequest with the parameterized properties
        /// </summary>
        /// <param name="accountId">The <c>AccountId</c> value is the AWS account ID of the account that owns the vault. You can either specify an AWS account ID or optionally a single '<c>-</c>' (hyphen), in which case Amazon S3 Glacier uses the AWS account ID associated with the credentials used to sign the request. If you use an account ID, do not include any hyphens ('-') in the ID. </param>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="jobId">The ID of the job to describe.</param>
        public DescribeJobRequest(string accountId, string vaultName, string jobId)
        {
            _accountId = accountId;
            _vaultName = vaultName;
            _jobId = jobId;
        }

        /// <summary>
        /// Instantiates DescribeJobRequest with the parameterized properties
        /// </summary>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="jobId">The ID of the job to describe.</param>
        public DescribeJobRequest(string vaultName, string jobId)
        {
            _vaultName = vaultName;
            _jobId = jobId;
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
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the job to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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