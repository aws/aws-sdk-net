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
    /// Container for the parameters to the GetJobOutput operation.
    /// This operation downloads the output of the job you initiated using <a>InitiateJob</a>.
    /// Depending on the job type you specified when you initiated the job, the output will
    /// be either the content of an archive or a vault inventory.
    /// 
    ///  
    /// <para>
    /// You can download all the job output or download a portion of the output by specifying
    /// a byte range. In the case of an archive retrieval job, depending on the byte range
    /// you specify, Amazon S3 Glacier (Glacier) returns the checksum for the portion of the
    /// data. You can compute the checksum on the client and verify that the values match
    /// to ensure the portion you downloaded is the correct data.
    /// </para>
    ///  
    /// <para>
    /// A job ID will not expire for at least 24 hours after Glacier completes the job. That
    /// a byte range. For both archive and inventory retrieval jobs, you should verify the
    /// downloaded size against the size returned in the headers from the <b>Get Job Output</b>
    /// response.
    /// </para>
    ///  
    /// <para>
    /// For archive retrieval jobs, you should also verify that the size is what you expected.
    /// If you download a portion of the output, the expected size is based on the range of
    /// bytes you specified. For example, if you specify a range of <c>bytes=0-1048575</c>,
    /// you should verify your download size is 1,048,576 bytes. If you download an entire
    /// archive, the expected size is the size of the archive when you uploaded it to Amazon
    /// S3 Glacier The expected size is also returned in the headers from the <b>Get Job Output</b>
    /// response.
    /// </para>
    ///  
    /// <para>
    /// In the case of an archive retrieval job, depending on the byte range you specify,
    /// Glacier returns the checksum for the portion of the data. To ensure the portion you
    /// downloaded is the correct data, compute the checksum on the client, verify that the
    /// values match, and verify that the size is what you expected.
    /// </para>
    ///  
    /// <para>
    /// A job ID does not expire for at least 24 hours after Glacier completes the job. That
    /// is, you can download the job output within the 24 hours period after Amazon Glacier
    /// completes the job.
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
    /// For conceptual information and the underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-inventory.html">Downloading
    /// a Vault Inventory</a>, <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/downloading-an-archive.html">Downloading
    /// an Archive</a>, and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-job-output-get.html">Get
    /// Job Output </a> 
    /// </para>
    /// </summary>
    public partial class GetJobOutputRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private string _jobId;
        private string _range;
        private string _vaultName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetJobOutputRequest() { }

        /// <summary>
        /// Instantiates GetJobOutputRequest with the parameterized properties
        /// </summary>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="jobId">The job ID whose data is downloaded.</param>
        /// <param name="range">The range of bytes to retrieve from the output. For example, if you want to download the first 1,048,576 bytes, specify the range as <c>bytes=0-1048575</c>. By default, this operation downloads the entire output. If the job output is large, then you can use a range to retrieve a portion of the output. This allows you to download the entire output in smaller chunks of bytes. For example, suppose you have 1 GB of job output you want to download and you decide to download 128 MB chunks of data at a time, which is a total of eight Get Job Output requests. You use the following process to download the job output: <ol> <li> Download a 128 MB chunk of output by specifying the appropriate byte range. Verify that all 128 MB of data was received. </li> <li> Along with the data, the response includes a SHA256 tree hash of the payload. You compute the checksum of the payload on the client and compare it with the checksum you received in the response to ensure you received all the expected data. </li> <li> Repeat steps 1 and 2 for all the eight 128 MB chunks of output data, each time specifying the appropriate byte range. </li> <li> After downloading all the parts of the job output, you have a list of eight checksum values. Compute the tree hash of these values to find the checksum of the entire output. Using the <a>DescribeJob</a> API, obtain job information of the job that provided you the output. The response includes the checksum of the entire archive stored in Amazon S3 Glacier. You compare this value with the checksum you computed to ensure you have downloaded the entire archive content with no errors. <p/> </li> </ol></param>
        public GetJobOutputRequest(string vaultName, string jobId, string range)
        {
            _vaultName = vaultName;
            _jobId = jobId;
            _range = range;
        }

        /// <summary>
        /// Instantiates GetJobOutputRequest with the parameterized properties
        /// </summary>
        /// <param name="accountId">The <c>AccountId</c> value is the AWS account ID of the account that owns the vault. You can either specify an AWS account ID or optionally a single '<c>-</c>' (hyphen), in which case Amazon S3 Glacier uses the AWS account ID associated with the credentials used to sign the request. If you use an account ID, do not include any hyphens ('-') in the ID.</param>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="jobId">The job ID whose data is downloaded.</param>
        /// <param name="range">The range of bytes to retrieve from the output. For example, if you want to download the first 1,048,576 bytes, specify the range as <c>bytes=0-1048575</c>. By default, this operation downloads the entire output. If the job output is large, then you can use a range to retrieve a portion of the output. This allows you to download the entire output in smaller chunks of bytes. For example, suppose you have 1 GB of job output you want to download and you decide to download 128 MB chunks of data at a time, which is a total of eight Get Job Output requests. You use the following process to download the job output: <ol> <li> Download a 128 MB chunk of output by specifying the appropriate byte range. Verify that all 128 MB of data was received. </li> <li> Along with the data, the response includes a SHA256 tree hash of the payload. You compute the checksum of the payload on the client and compare it with the checksum you received in the response to ensure you received all the expected data. </li> <li> Repeat steps 1 and 2 for all the eight 128 MB chunks of output data, each time specifying the appropriate byte range. </li> <li> After downloading all the parts of the job output, you have a list of eight checksum values. Compute the tree hash of these values to find the checksum of the entire output. Using the <a>DescribeJob</a> API, obtain job information of the job that provided you the output. The response includes the checksum of the entire archive stored in Amazon S3 Glacier. You compare this value with the checksum you computed to ensure you have downloaded the entire archive content with no errors. <p/> </li> </ol></param>
        public GetJobOutputRequest(string accountId, string vaultName, string jobId, string range)
        {
            _accountId = accountId;
            _vaultName = vaultName;
            _jobId = jobId;
            _range = range;
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
        /// The job ID whose data is downloaded.
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
        /// Gets and sets the property Range. 
        /// <para>
        /// The range of bytes to retrieve from the output. For example, if you want to download
        /// the first 1,048,576 bytes, specify the range as <c>bytes=0-1048575</c>. By default,
        /// this operation downloads the entire output.
        /// </para>
        ///  
        /// <para>
        /// If the job output is large, then you can use a range to retrieve a portion of the
        /// output. This allows you to download the entire output in smaller chunks of bytes.
        /// For example, suppose you have 1 GB of job output you want to download and you decide
        /// to download 128 MB chunks of data at a time, which is a total of eight Get Job Output
        /// requests. You use the following process to download the job output:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Download a 128 MB chunk of output by specifying the appropriate byte range. Verify
        /// that all 128 MB of data was received.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Along with the data, the response includes a SHA256 tree hash of the payload. You
        /// compute the checksum of the payload on the client and compare it with the checksum
        /// you received in the response to ensure you received all the expected data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Repeat steps 1 and 2 for all the eight 128 MB chunks of output data, each time specifying
        /// the appropriate byte range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After downloading all the parts of the job output, you have a list of eight checksum
        /// values. Compute the tree hash of these values to find the checksum of the entire output.
        /// Using the <a>DescribeJob</a> API, obtain job information of the job that provided
        /// you the output. The response includes the checksum of the entire archive stored in
        /// Amazon S3 Glacier. You compare this value with the checksum you computed to ensure
        /// you have downloaded the entire archive content with no errors.
        /// </para>
        ///   </li> </ol>
        /// </summary>
        public string Range
        {
            get { return this._range; }
            set { this._range = value; }
        }

        // Check to see if Range property is set
        internal bool IsSetRange()
        {
            return this._range != null;
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