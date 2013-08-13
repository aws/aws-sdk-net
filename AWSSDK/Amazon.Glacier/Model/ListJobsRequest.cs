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
    /// Container for the parameters to the ListJobs operation.
    /// <para>This operation lists jobs for a vault, including jobs that are in-progress and jobs that have recently finished. </para>
    /// <para><b>NOTE:</b> Amazon Glacier retains recently completed jobs for a period before deleting them; however, it eventually removes
    /// completed jobs. The output of completed jobs can be retrieved. Retaining completed jobs for a period of time after they have completed
    /// enables you to get a job output in the event you miss the job completion notification or your first attempt to download it fails. For
    /// example, suppose you start an archive retrieval job to download an archive. After the job completes, you start to download the archive but
    /// encounter a network error. In this scenario, you can retry and download the archive while the job exists. </para> <para>To retrieve an
    /// archive or retrieve a vault inventory from Amazon Glacier, you first initiate a job, and after the job completes, you download the data. For
    /// an archive retrieval, the output is the archive data, and for an inventory retrieval, it is the inventory list. The List Job operation
    /// returns a list of these jobs sorted by job initiation time.</para> <para>This List Jobs operation supports pagination. By default, this
    /// operation returns up to 1,000 jobs in the response. You should always check the response for a <c>marker</c> at which to continue the list;
    /// if there are no more items the <c>marker</c> is <c>null</c> .
    /// To return a list of jobs that begins at a specific job, set the <c>marker</c> request parameter to the value you obtained from a
    /// previous List Jobs request. You can also limit the number of jobs returned in the response by specifying the <c>limit</c> parameter in the
    /// request.</para> <para>Additionally, you can filter the jobs list returned by specifying an optional <c>statuscode</c> (InProgress,
    /// Succeeded, or Failed) and <c>completed</c> (true, false) parameter. The <c>statuscode</c> allows you to specify that only jobs that match a
    /// specified status are returned. The <c>completed</c> parameter allows you to specify that only jobs in a specific completion state are
    /// returned.</para> <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and Access Management
    /// (IAM) users don't have any permissions by default. You must grant them explicit permission to perform specific actions. For more
    /// information, see Access Control Using AWS Identity and Access Management (IAM).</para> <para>For the underlying REST API, go to List Jobs
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.Glacier.AmazonGlacier.ListJobs"/>
    public class ListJobsRequest : AmazonWebServiceRequest
    {
        private string accountId;
        private string vaultName;
        private int? limit;
        private string marker;
        private string statuscode;
        private bool? completed;

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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListJobsRequest WithAccountId(string accountId)
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListJobsRequest WithVaultName(string vaultName)
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
        /// Specifies that the response be limited to the specified number of items or fewer. If not specified, the List Jobs operation returns up to
        /// 1,000 jobs.
        ///  
        /// </summary>
        public int Limit
        {
            get { return this.limit ?? default(int); }
            set { this.limit = value; }
        }

        /// <summary>
        /// Sets the Limit property
        /// </summary>
        /// <param name="limit">The value to set for the Limit property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListJobsRequest WithLimit(int limit)
        {
            this.limit = limit;
            return this;
        }
            

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.limit.HasValue;       
        }

        /// <summary>
        /// An opaque string used for pagination. This value specifies the job at which the listing of jobs should begin. Get the marker value from a
        /// previous List Jobs response. You need only include the marker if you are continuing the pagination of results started in a previous List
        /// Jobs request.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListJobsRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;       
        }

        /// <summary>
        /// Specifies the type of job status to return. You can specify the following values: "InProgress", "Succeeded", or "Failed".
        ///  
        /// </summary>
        public string Statuscode
        {
            get { return this.statuscode; }
            set { this.statuscode = value; }
        }

        /// <summary>
        /// Sets the Statuscode property
        /// </summary>
        /// <param name="statuscode">The value to set for the Statuscode property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListJobsRequest WithStatuscode(string statuscode)
        {
            this.statuscode = statuscode;
            return this;
        }
            

        // Check to see if Statuscode property is set
        internal bool IsSetStatuscode()
        {
            return this.statuscode != null;       
        }

        /// <summary>
        /// Specifies the state of the jobs to return. You can specify <c>true</c> or <c>false</c>.
        ///  
        /// </summary>
        public bool Completed
        {
            get { return this.completed ?? default(bool); }
            set { this.completed = value; }
        }

        /// <summary>
        /// Sets the Completed property
        /// </summary>
        /// <param name="completed">The value to set for the Completed property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListJobsRequest WithCompleted(bool completed)
        {
            this.completed = completed;
            return this;
        }
            

        // Check to see if Completed property is set
        internal bool IsSetCompleted()
        {
            return this.completed.HasValue;       
        }
    }
}
    
