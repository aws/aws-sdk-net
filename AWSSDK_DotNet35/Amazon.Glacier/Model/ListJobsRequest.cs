/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the ListJobs operation.
    /// This operation lists jobs for a vault, including jobs that are in-progress and jobs
    /// that have recently finished. 
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
    /// </note> 
    /// <para>
    /// To retrieve an archive or retrieve a vault inventory from Amazon Glacier, you first
    /// initiate a job, and after the job completes, you download the data. For an archive
    /// retrieval, the output is the archive data, and for an inventory retrieval, it is the
    /// inventory list. The List Job operation returns a list of these jobs sorted by job
    /// initiation time.
    /// </para>
    ///  
    /// <para>
    /// This List Jobs operation supports pagination. By default, this operation returns up
    /// to 1,000 jobs in the response. You should always check the response for a <code>marker</code>
    /// at which to continue the list; if there are no more items the <code>marker</code>
    /// is <code>null</code>. To return a list of jobs that begins at a specific job, set
    /// the <code>marker</code> request parameter to the value you obtained from a previous
    /// List Jobs request. You can also limit the number of jobs returned in the response
    /// by specifying the <code>limit</code> parameter in the request.
    /// </para>
    ///  
    /// <para>
    /// Additionally, you can filter the jobs list returned by specifying an optional <code>statuscode</code>
    /// (InProgress, Succeeded, or Failed) and <code>completed</code> (true, false) parameter.
    /// The <code>statuscode</code> allows you to specify that only jobs that match a specified
    /// status are returned. The <code>completed</code> parameter allows you to specify that
    /// only jobs in a specific completion state are returned.
    /// </para>
    ///  
    /// <para>
    /// An AWS account has full permission to perform all operations (actions). However, AWS
    /// Identity and Access Management (IAM) users don't have any permissions by default.
    /// You must grant them explicit permission to perform specific actions. For more information,
    /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
    /// Control Using AWS Identity and Access Management (IAM)</a>.
    /// </para>
    ///  
    /// <para>
    /// For the underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-jobs-get.html">List
    /// Jobs </a> 
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
        /// <param name="accountId">The <code>AccountId</code> is the AWS Account ID. You can specify either the AWS Account ID or optionally a '-', in which case Amazon Glacier uses the AWS Account ID associated with the credentials used to sign the request. If you specify your Account ID, do not include hyphens in it. </param>
        /// <param name="vaultName">The name of the vault.</param>
        public ListJobsRequest(string accountId, string vaultName)
        {
            _accountId = accountId;
            _vaultName = vaultName;
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <code>AccountId</code> is the AWS Account ID. You can specify either the AWS Account
        /// ID or optionally a '-', in which case Amazon Glacier uses the AWS Account ID associated
        /// with the credentials used to sign the request. If you specify your Account ID, do
        /// not include hyphens in it. 
        /// </para>
        /// </summary>
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
        /// Specifies the state of the jobs to return. You can specify <code>true</code> or <code>false</code>.
        /// </para>
        /// </summary>
        public bool Completed
        {
            get { return this._completed.GetValueOrDefault(); }
            set { this._completed = value; }
        }

        // Check to see if Completed property is set
        internal bool IsSetCompleted()
        {
            return this._completed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Specifies that the response be limited to the specified number of items or fewer.
        /// If not specified, the List Jobs operation returns up to 1,000 jobs.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An opaque string used for pagination. This value specifies the job at which the listing
        /// of jobs should begin. Get the marker value from a previous List Jobs response. You
        /// need only include the marker if you are continuing the pagination of results started
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
        /// Specifies the type of job status to return. You can specify the following values:
        /// "InProgress", "Succeeded", or "Failed".
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