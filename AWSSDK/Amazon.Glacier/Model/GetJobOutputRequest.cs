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
    /// Container for the parameters to the GetJobOutput operation.
    /// <para>This operation downloads the output of the job you initiated using InitiateJob. Depending on the job type you specified when you
    /// initiated the job, the output will be either the content of an archive or a vault inventory.</para> <para>A job ID will not expire for at
    /// least 24 hours after Amazon Glacier completes the job. That is, you can download the job output within the 24 hours period after Amazon
    /// Glacier completes the job.</para> <para>If the job output is large, then you can use the <c>Range</c> request header to retrieve a portion
    /// of the output. This allows you to download the entire output in smaller chunks of bytes. For example, suppose you have 1 GB of job output
    /// you want to download and you decide to download 128 MB chunks of data at a time, which is a total of eight Get Job Output requests. You use
    /// the following process to download the job output:</para> <ol> <li> <para>Download a 128 MB chunk of output by specifying the appropriate
    /// byte range using the <c>Range</c> header.</para> </li>
    /// <li> <para>Along with the data, the response includes a checksum of the payload. You compute the checksum of the payload on the client and
    /// compare it with the checksum you received in the response to ensure you received all the expected data.</para> </li>
    /// <li> <para>Repeat steps 1 and 2 for all the eight 128 MB chunks of output data, each time specifying the appropriate byte range.</para>
    /// </li>
    /// <li> <para>After downloading all the parts of the job output, you have a list of eight checksum values. Compute the tree hash of these
    /// values to find the checksum of the entire output. Using the Describe Job API, obtain job information of the job that provided you the
    /// output. The response includes the checksum of the entire archive stored in Amazon Glacier. You compare this value with the checksum you
    /// computed to ensure you have downloaded the entire archive content with no errors.</para> </li>
    /// </ol> <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and Access Management (IAM) users
    /// don't have any permissions by default. You must grant them explicit permission to perform specific actions. For more information, see Access
    /// Control Using AWS Identity and Access Management (IAM).</para> <para>For conceptual information and the underlying REST API, go to
    /// Downloading a Vault Inventory, Downloading an Archive, and Get Job Output </para>
    /// </summary>
    /// <seealso cref="Amazon.Glacier.AmazonGlacier.GetJobOutput"/>
    public class GetJobOutputRequest : AmazonWebServiceRequest
    {
        private string accountId;
        private string vaultName;
        private string jobId;
        private string range;

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

        /// <summary>
        /// Sets the AccountId property
        /// </summary>
        /// <param name="accountId">The value to set for the AccountId property </param>
        /// <returns>this instance</returns>
        public GetJobOutputRequest WithAccountId(string accountId)
        {
            this.accountId = accountId;
            return this;
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

        /// <summary>
        /// Sets the VaultName property
        /// </summary>
        /// <param name="vaultName">The value to set for the VaultName property </param>
        /// <returns>this instance</returns>
        public GetJobOutputRequest WithVaultName(string vaultName)
        {
            this.vaultName = vaultName;
            return this;
        }
            

        // Check to see if VaultName property is set
        internal bool IsSetVaultName()
        {
            return this.vaultName != null;       
        }

        /// <summary>
        /// The job ID whose data is downloaded.
        ///  
        /// </summary>
        public string JobId
        {
            get { return this.jobId; }
            set { this.jobId = value; }
        }

        /// <summary>
        /// Sets the JobId property
        /// </summary>
        /// <param name="jobId">The value to set for the JobId property </param>
        /// <returns>this instance</returns>
        public GetJobOutputRequest WithJobId(string jobId)
        {
            this.jobId = jobId;
            return this;
        }
            

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this.jobId != null;       
        }

        /// <summary>
        /// The range of bytes to retrieve from the output. For example, if you want to download the first 1,048,576 bytes, specify "Range:
        /// bytes=0-1048575". By default, this operation downloads the entire output.
        ///  
        /// </summary>
        public string Range
        {
            get { return this.range; }
            set { this.range = value; }
        }

        /// <summary>
        /// Sets the Range property
        /// </summary>
        /// <param name="range">The value to set for the Range property </param>
        /// <returns>this instance</returns>
        public GetJobOutputRequest WithRange(string range)
        {
            this.range = range;
            return this;
        }
            

        // Check to see if Range property is set
        internal bool IsSetRange()
        {
            return this.range != null;       
        }
    }
}
    
