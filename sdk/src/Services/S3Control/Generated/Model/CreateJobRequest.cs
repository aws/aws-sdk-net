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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJob operation.
    /// S3 Batch Operations performs large-scale Batch Operations on Amazon S3 objects. Batch
    /// Operations can run a single operation or action on lists of Amazon S3 objects that
    /// you specify. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-basics.html">S3
    /// Batch Operations</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// This operation creates an S3 Batch Operations job.
    /// </para>
    ///   
    /// <para>
    /// Related actions include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeJob.html">DescribeJob</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListJobs.html">ListJobs</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobPriority.html">UpdateJobPriority</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateJobRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _clientRequestToken;
        private bool? _confirmationRequired;
        private string _description;
        private JobManifest _manifest;
        private JobOperation _operation;
        private int? _priority;
        private JobReport _report;
        private string _roleArn;
        private List<S3Tag> _tags = new List<S3Tag>();

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID that creates the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
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
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// An idempotency token to ensure that you don't accidentally submit the same request
        /// twice. You can use any string up to the maximum length.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConfirmationRequired. 
        /// <para>
        /// Indicates whether confirmation is required before Amazon S3 runs the job. Confirmation
        /// is only required for jobs created through the Amazon S3 console.
        /// </para>
        /// </summary>
        public bool ConfirmationRequired
        {
            get { return this._confirmationRequired.GetValueOrDefault(); }
            set { this._confirmationRequired = value; }
        }

        // Check to see if ConfirmationRequired property is set
        internal bool IsSetConfirmationRequired()
        {
            return this._confirmationRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for this job. You can use any string within the permitted length. Descriptions
        /// don't need to be unique and can be used for multiple jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Manifest. 
        /// <para>
        /// Configuration parameters for the manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobManifest Manifest
        {
            get { return this._manifest; }
            set { this._manifest = value; }
        }

        // Check to see if Manifest property is set
        internal bool IsSetManifest()
        {
            return this._manifest != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The operation that you want this job to perform on every object listed in the manifest.
        /// For more information about the available operations, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-operations.html">Operations</a>
        /// in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobOperation Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The numerical priority for this job. Higher numbers indicate higher priority.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Report. 
        /// <para>
        /// Configuration parameters for the optional job-completion report.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobReport Report
        {
            get { return this._report; }
            set { this._report = value; }
        }

        // Check to see if Report property is set
        internal bool IsSetReport()
        {
            return this._report != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the AWS Identity and Access Management (IAM) role
        /// that Batch Operations will use to run this job's operation on every object in the
        /// manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags to associate with the S3 Batch Operations job. This is an optional parameter.
        /// 
        /// </para>
        /// </summary>
        public List<S3Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}