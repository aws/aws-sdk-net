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
    /// Container for the parameters to the ListJobs operation.
    /// This operation lists jobs for a vault, including jobs that are in-progress and jobs
    /// that have recently finished. The List Job operation returns a list of these jobs sorted
    /// by job initiation time.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Glacier retains recently completed jobs for a period before deleting them;
    /// however, it eventually removes completed jobs. The output of completed jobs can be
    /// retrieved. Retaining completed jobs for a period of time after they have completed
    /// enables you to get a job output in the event you miss the job completion notification
    /// or your first attempt to download it fails. For example, suppose you start an archive
    /// retrieval job to download an archive. After the job completes, you start to download
    /// the archive but encounter a network error. In this scenario, you can retry and download
    /// the archive while the job exists.
    /// </para>
    ///  </note> 
    /// <para>
    /// The List Jobs operation supports pagination. You should always check the response
    /// <c>Marker</c> field. If there are no more jobs to list, the <c>Marker</c> field is
    /// set to <c>null</c>. If there are more jobs to list, the <c>Marker</c> field is set
    /// to a non-null value, which you can use to continue the pagination of the list. To
    /// return a list of jobs that begins at a specific job, set the marker request parameter
    /// to the <c>Marker</c> value for that job that you obtained from a previous List Jobs
    /// request.
    /// </para>
    ///  
    /// <para>
    /// You can set a maximum limit for the number of jobs returned in the response by specifying
    /// the <c>limit</c> parameter in the request. The default limit is 50. The number of
    /// jobs returned might be fewer than the limit, but the number of returned jobs never
    /// exceeds the limit.
    /// </para>
    ///  
    /// <para>
    /// Additionally, you can filter the jobs list returned by specifying the optional <c>statuscode</c>
    /// parameter or <c>completed</c> parameter, or both. Using the <c>statuscode</c> parameter,
    /// you can specify to return only jobs that match either the <c>InProgress</c>, <c>Succeeded</c>,
    /// or <c>Failed</c> status. Using the <c>completed</c> parameter, you can specify to
    /// return only jobs that were completed (<c>true</c>) or jobs that were not completed
    /// (<c>false</c>).
    /// </para>
    ///  
    /// <para>
    /// For more information about using this operation, see the documentation for the underlying
    /// REST API <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-jobs-get.html">List
    /// Jobs</a>. 
    /// </para>
    /// </summary>
    public partial class ListJobsRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private bool? _completed;
        private int? _limit;
        private string _marker;
        private string _statuscode;
        private string _vaultName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ListJobsRequest() { }

        /// <summary>
        /// Instantiates ListJobsRequest with the parameterized properties
        /// </summary>
        /// <param name="vaultName">The name of the vault.</param>
        public ListJobsRequest(string vaultName)
        {
            _vaultName = vaultName;
        }

        /// <summary>
        /// Instantiates ListJobsRequest with the parameterized properties
        /// </summary>
        /// <param name="accountId">The <c>AccountId</c> value is the AWS account ID of the account that owns the vault. You can either specify an AWS account ID or optionally a single '<c>-</c>' (hyphen), in which case Amazon S3 Glacier uses the AWS account ID associated with the credentials used to sign the request. If you use an account ID, do not include any hyphens ('-') in the ID. </param>
        /// <param name="vaultName">The name of the vault.</param>
        public ListJobsRequest(string accountId, string vaultName)
        {
            _accountId = accountId;
            _vaultName = vaultName;
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
        /// Gets and sets the property Completed. 
        /// <para>
        /// The state of the jobs to return. You can specify <c>true</c> or <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Completed
        {
            get { return this._completed; }
            set { this._completed = value; }
        }

        // Check to see if Completed property is set
        internal bool IsSetCompleted()
        {
            return this._completed != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of jobs to be returned. The default limit is 50. The number of
        /// jobs returned might be fewer than the specified limit, but the number of returned
        /// jobs never exceeds the limit.
        /// </para>
        /// </summary>
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An opaque string used for pagination. This value specifies the job at which the listing
        /// of jobs should begin. Get the marker value from a previous List Jobs response. You
        /// only need to include the marker if you are continuing the pagination of results started
        /// in a previous List Jobs request.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property Statuscode. 
        /// <para>
        /// The type of job status to return. You can specify the following values: <c>InProgress</c>,
        /// <c>Succeeded</c>, or <c>Failed</c>.
        /// </para>
        /// </summary>
        public string Statuscode
        {
            get { return this._statuscode; }
            set { this._statuscode = value; }
        }

        // Check to see if Statuscode property is set
        internal bool IsSetStatuscode()
        {
            return this._statuscode != null;
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