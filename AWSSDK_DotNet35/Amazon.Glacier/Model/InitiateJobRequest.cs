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
    /// Container for the parameters to the InitiateJob operation.
    /// <para>This operation initiates a job of the specified type. In this release, you can initiate a job to retrieve either an archive or a vault
    /// inventory (a list of archives in a vault). </para> <para>Retrieving data from Amazon Glacier is a two-step process: </para> <ol> <li>
    /// <para>Initiate a retrieval job.</para> </li>
    /// <li> <para>After the job completes, download the bytes.</para> </li>
    /// </ol> <para>The retrieval request is executed asynchronously. When you initiate a retrieval job, Amazon Glacier creates a job and returns a
    /// job ID in the response. When Amazon Glacier completes the job, you can get the job output (archive or inventory data). For information about
    /// getting job output, see GetJobOutput operation. </para> <para>The job must complete before you can get its output. To determine when a job
    /// is complete, you have the following options:</para>
    /// <ul>
    /// <li> <para> <b>Use Amazon SNS Notification</b> You can specify an Amazon Simple Notification Service (Amazon SNS) topic to which Amazon
    /// Glacier can post a notification after the job is completed. You can specify an SNS topic per job request. The notification is sent only
    /// after Amazon Glacier completes the job. In addition to specifying an SNS topic per job request, you can configure vault notifications for a
    /// vault so that job notifications are always sent. For more information, see SetVaultNotifications.</para> </li>
    /// <li> <para> <b>Get job details</b> You can make a DescribeJob request to obtain job status information while a job is in progress. However,
    /// it is more efficient to use an Amazon SNS notification to determine when a job is complete.</para> </li>
    /// 
    /// </ul>
    /// <para><b>NOTE:</b> The information you get via notification is same that you get by calling DescribeJob. </para> <para>If for a specific
    /// event, you add both the notification configuration on the vault and also specify an SNS topic in your initiate job request, Amazon Glacier
    /// sends both notifications. For more information, see SetVaultNotifications.</para> <para>An AWS account has full permission to perform all
    /// operations (actions). However, AWS Identity and Access Management (IAM) users don't have any permissions by default. You must grant them
    /// explicit permission to perform specific actions. For more information, see <a
    /// href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html" >Access Control Using AWS Identity and Access
    /// Management (IAM)</a> .</para> <para> <b>About the Vault Inventory</b> </para> <para>Amazon Glacier prepares an inventory for each vault
    /// periodically, every 24 hours. When you initiate a job for a vault inventory, Amazon Glacier returns the last inventory for the vault. The
    /// inventory data you get might be up to a day or two days old. Also, the initiate inventory job might take some time to complete before you
    /// can download the vault inventory. So you do not want to retrieve a vault inventory for each vault operation. However, in some scenarios, you
    /// might find the vault inventory useful. For example, when you upload an archive, you can provide an archive description but not an archive
    /// name. Amazon Glacier provides you a unique archive ID, an opaque string of characters. So, you might maintain your own database that maps
    /// archive names to their corresponding Amazon Glacier assigned archive IDs. You might find the vault inventory useful in the event you need to
    /// reconcile information in your database with the actual vault inventory. </para> <para> <b>Range Inventory Retrieval</b> </para> <para>You
    /// can limit the number of inventory items retrieved by filtering on the archive creation date or by setting a limit.</para> <para>
    /// <i>Filtering by Archive Creation Date</i> </para> <para>You can retrieve inventory items for archives created between <c>StartDate</c> and
    /// <c>EndDate</c> by specifying values for these parameters in the <b>InitiateJob</b> request. Archives created on or after the
    /// <c>StartDate</c> and before the <c>EndDate</c> will be returned. If you only provide the <c>StartDate</c> without the <c>EndDate</c> , you
    /// will retrieve the inventory for all archives created on or after the <c>StartDate</c> . If you only provide the <c>EndDate</c> without the
    /// <c>StartDate</c> , you will get back the inventory for all archives created before the <c>EndDate</c> .</para> <para> <i>Limiting Inventory
    /// Items per Retrieval</i> </para> <para>You can limit the number of inventory items returned by setting the <c>Limit</c> parameter in the
    /// <b>InitiateJob</b> request. The inventory job output will contain inventory items up to the specified <c>Limit</c> . If there are more
    /// inventory items available, the result is paginated. After a job is complete you can use the DescribeJob operation to get a marker that you
    /// use in a subsequent <b>InitiateJob</b> request. The marker will indicate the starting point to retrieve the next set of inventory items. You
    /// can page through your entire inventory by repeatedly making <b>InitiateJob</b> requests with the marker from the previous <b>DescribeJob</b>
    /// output, until you get a marker from <b>DescribeJob</b> that returns null, indicating that there are no more inventory items
    /// available.</para> <para>You can use the <c>Limit</c> parameter together with the date range parameters.</para> <para> <b>About Ranged
    /// Archive Retrieval</b> </para> <para> You can initiate an archive retrieval for the whole archive or a range of the archive. In the case of
    /// ranged archive retrieval, you specify a byte range to return or the whole archive. The range specified must be megabyte (MB) aligned, that
    /// is the range start value must be divisible by 1 MB and range end value plus 1 must be divisible by 1 MB or equal the end of the archive. If
    /// the ranged archive retrieval is not megabyte aligned, this operation returns a 400 response. Furthermore, to ensure you get checksum values
    /// for data you download using Get Job Output API, the range must be tree hash aligned. </para> <para>An AWS account has full permission to
    /// perform all operations (actions). However, AWS Identity and Access Management (IAM) users don't have any permissions by default. You must
    /// grant them explicit permission to perform specific actions. For more information, see <a
    /// href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html" >Access Control Using AWS Identity and Access
    /// Management (IAM)</a> .</para> <para>For conceptual information and the underlying REST API, go to <a
    /// href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-initiate-job-post.html" >Initiate a Job</a> and <a
    /// href="http://docs.aws.amazon.com/amazonglacier/latest/dev/vault-inventory.html" >Downloading a Vault Inventory</a> </para>
    /// </summary>
    public partial class InitiateJobRequest : AmazonGlacierRequest
    {
        private string accountId;
        private string vaultName;
        private JobParameters jobParameters;


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
        /// Provides options for specifying job information.
        ///  
        /// </summary>
        public JobParameters JobParameters
        {
            get { return this.jobParameters; }
            set { this.jobParameters = value; }
        }

        // Check to see if JobParameters property is set
        internal bool IsSetJobParameters()
        {
            return this.jobParameters != null;
        }

    }
}
    
