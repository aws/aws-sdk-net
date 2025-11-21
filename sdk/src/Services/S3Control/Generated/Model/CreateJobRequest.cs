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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJob operation.
    /// This operation creates an S3 Batch Operations job.
    /// 
    ///  
    /// <para>
    /// You can use S3 Batch Operations to perform large-scale batch actions on Amazon S3
    /// objects. Batch Operations can run a single action on lists of Amazon S3 objects that
    /// you specify. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/batch-ops.html">S3
    /// Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// For information about permissions required to use the Batch Operations, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/batch-ops-iam-role-policies.html">Granting
    /// permissions for S3 Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </dd> </dl>  
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
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_JobOperation.html">JobOperation</a>
    /// 
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateJobRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _clientRequestToken;
        private bool? _confirmationRequired;
        private string _description;
        private JobManifest _manifest;
        private JobManifestGenerator _manifestGenerator;
        private JobOperation _operation;
        private int? _priority;
        private JobReport _report;
        private string _roleArn;
        private List<S3Tag> _tags = AWSConfigs.InitializeCollections ? new List<S3Tag>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID that creates the job.
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
        public bool? ConfirmationRequired
        {
            get { return this._confirmationRequired; }
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
        /// Gets and sets the property ManifestGenerator. 
        /// <para>
        /// The attribute container for the ManifestGenerator details. Jobs must be created with
        /// either a manifest file or a ManifestGenerator, but not both.
        /// </para>
        /// </summary>
        public JobManifestGenerator ManifestGenerator
        {
            get { return this._manifestGenerator; }
            set { this._manifestGenerator = value; }
        }

        // Check to see if ManifestGenerator property is set
        internal bool IsSetManifestGenerator()
        {
            return this._manifestGenerator != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The action that you want this job to perform on every object listed in the manifest.
        /// For more information about the available actions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-operations.html">Operations</a>
        /// in the <i>Amazon S3 User Guide</i>.
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
        public int? Priority
        {
            get { return this._priority; }
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
        /// The Amazon Resource Name (ARN) for the Identity and Access Management (IAM) role that
        /// Batch Operations will use to run this job's action on every object in the manifest.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}