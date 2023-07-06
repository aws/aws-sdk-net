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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the DescribeAssetBundleExportJob operation.
    /// </summary>
    public partial class DescribeAssetBundleExportJobResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _assetBundleExportJobId;
        private string _awsAccountId;
        private AssetBundleCloudFormationOverridePropertyConfiguration _cloudFormationOverridePropertyConfiguration;
        private DateTime? _createdTime;
        private string _downloadUrl;
        private List<AssetBundleExportJobError> _errors = new List<AssetBundleExportJobError>();
        private AssetBundleExportFormat _exportFormat;
        private bool? _includeAllDependencies;
        private AssetBundleExportJobStatus _jobStatus;
        private string _requestId;
        private List<string> _resourceArns = new List<string>();
        private int? _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the export job.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssetBundleExportJobId. 
        /// <para>
        /// The ID of the job. The job ID is set when you start a new job with a <code>StartAssetBundleExportJob</code>
        /// API call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string AssetBundleExportJobId
        {
            get { return this._assetBundleExportJobId; }
            set { this._assetBundleExportJobId = value; }
        }

        // Check to see if AssetBundleExportJobId property is set
        internal bool IsSetAssetBundleExportJobId()
        {
            return this._assetBundleExportJobId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that the export job was executed in. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CloudFormationOverridePropertyConfiguration. 
        /// <para>
        /// The CloudFormation override property configuration for the export job.
        /// </para>
        /// </summary>
        public AssetBundleCloudFormationOverridePropertyConfiguration CloudFormationOverridePropertyConfiguration
        {
            get { return this._cloudFormationOverridePropertyConfiguration; }
            set { this._cloudFormationOverridePropertyConfiguration = value; }
        }

        // Check to see if CloudFormationOverridePropertyConfiguration property is set
        internal bool IsSetCloudFormationOverridePropertyConfiguration()
        {
            return this._cloudFormationOverridePropertyConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that the export job was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DownloadUrl. 
        /// <para>
        /// The URL to download the exported asset bundle data from.
        /// </para>
        ///  
        /// <para>
        /// This URL is available only after the job has succeeded. This URL is valid for 5 minutes
        /// after issuance. Call <code>DescribeAssetBundleExportJob</code> again for a fresh URL
        /// if needed.
        /// </para>
        ///  
        /// <para>
        /// The downloaded asset bundle is a zip file named <code>assetbundle-{jobId}.qs</code>.
        /// The file has a <code>.qs</code> extension.
        /// </para>
        ///  
        /// <para>
        /// This URL can't be used in a <code>StartAssetBundleImportJob</code> API call and should
        /// only be used for download purposes.
        /// </para>
        /// </summary>
        public string DownloadUrl
        {
            get { return this._downloadUrl; }
            set { this._downloadUrl = value; }
        }

        // Check to see if DownloadUrl property is set
        internal bool IsSetDownloadUrl()
        {
            return this._downloadUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// An array of error records that describes any failures that occurred during the export
        /// job processing.
        /// </para>
        ///  
        /// <para>
        /// Error records accumulate while the job runs. The complete set of error records is
        /// available after the job has completed and failed.
        /// </para>
        /// </summary>
        public List<AssetBundleExportJobError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExportFormat. 
        /// <para>
        /// The format of the exported asset bundle. A <code>QUICKSIGHT_JSON</code> formatted
        /// file can be used to make a <code>StartAssetBundleImportJob</code> API call. A <code>CLOUDFORMATION_JSON</code>
        /// formatted file can be used in the CloudFormation console and with the CloudFormation
        /// APIs.
        /// </para>
        /// </summary>
        public AssetBundleExportFormat ExportFormat
        {
            get { return this._exportFormat; }
            set { this._exportFormat = value; }
        }

        // Check to see if ExportFormat property is set
        internal bool IsSetExportFormat()
        {
            return this._exportFormat != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeAllDependencies. 
        /// <para>
        /// The include dependencies flag.
        /// </para>
        /// </summary>
        public bool IncludeAllDependencies
        {
            get { return this._includeAllDependencies.GetValueOrDefault(); }
            set { this._includeAllDependencies = value; }
        }

        // Check to see if IncludeAllDependencies property is set
        internal bool IsSetIncludeAllDependencies()
        {
            return this._includeAllDependencies.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// Indicates the status of a job through its queuing and execution.
        /// </para>
        ///  
        /// <para>
        /// Poll this <code>DescribeAssetBundleExportApi</code> until <code>JobStatus</code> is
        /// either <code>SUCCESSFUL</code> or <code>FAILED</code>.
        /// </para>
        /// </summary>
        public AssetBundleExportJobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// A list of resource ARNs that exported with the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> ResourceArns
        {
            get { return this._resourceArns; }
            set { this._resourceArns = value; }
        }

        // Check to see if ResourceArns property is set
        internal bool IsSetResourceArns()
        {
            return this._resourceArns != null && this._resourceArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the response.
        /// </para>
        /// </summary>
        public int Status
        {
            get { return this._status.GetValueOrDefault(); }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

    }
}