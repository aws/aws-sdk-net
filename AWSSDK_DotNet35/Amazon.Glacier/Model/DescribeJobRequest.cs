/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeJob operation.
    /// <para>This operation returns information about a job you previously initiated, including the job initiation date, the user who initiated the
    /// job, the job status code/message and the Amazon SNS topic to notify after Amazon Glacier completes the job. For more information about
    /// initiating a job, see InitiateJob. </para> <para><b>NOTE:</b> This operation enables you to check the status of your job. However, it is
    /// strongly recommended that you set up an Amazon SNS topic and specify it in your initiate job request so that Amazon Glacier can notify the
    /// topic after it completes the job. </para> <para>A job ID will not expire for at least 24 hours after Amazon Glacier completes the job.
    /// </para> <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and Access Management (IAM)
    /// users don't have any permissions by default. You must grant them explicit permission to perform specific actions. For more information, see
    /// <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html" >Access Control Using AWS Identity and
    /// Access Management (IAM)</a> .</para> <para> For information about the underlying REST API, go to <a
    /// href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-describe-job-get.html" >Working with Archives in Amazon Glacier</a> in the
    /// <i>Amazon Glacier Developer Guide</i> .
    /// </para>
    /// </summary>
    public partial class DescribeJobRequest : AmazonGlacierRequest
    {
        private string accountId;
        private string vaultName;
        private string jobId;


        /// <summary>
        /// The <c>AccountId</c> is the AWS Account ID. You can specify either the AWS Account ID or optionally a '-', in which case Amazon Glacier uses
        /// the AWS Account ID associated with the credentials used to sign the request. If you specify your Account ID, do not include hyphens in it.
        ///  
        /// </summary>
        public string AccountId
        {
            get { return this.accountId; }
            set { this.accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this.accountId != null;
        }

        /// <summary>
        /// The name of the vault.
        ///  
        /// </summary>
        public string VaultName
        {
            get { return this.vaultName; }
            set { this.vaultName = value; }
        }

        // Check to see if VaultName property is set
        internal bool IsSetVaultName()
        {
            return this.vaultName != null;
        }

        /// <summary>
        /// The ID of the job to describe.
        ///  
        /// </summary>
        public string JobId
        {
            get { return this.jobId; }
            set { this.jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this.jobId != null;
        }

    }
}
    
