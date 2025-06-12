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

#pragma warning disable CS0612,CS0618,CS1570
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
        private List<AssetBundleExportJobError> _errors = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobError>() : null;
        private AssetBundleExportFormat _exportFormat;
        private bool? _includeAllDependencies;
        private IncludeFolderMembers _includeFolderMembers;
        private bool? _includeFolderMemberships;
        private bool? _includePermissions;
        private bool? _includeTags;
        private AssetBundleExportJobStatus _jobStatus;
        private string _requestId;
        private List<string> _resourceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _status;
        private AssetBundleExportJobValidationStrategy _validationStrategy;
        private List<AssetBundleExportJobWarning> _warnings = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobWarning>() : null;

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
        /// The ID of the job. The job ID is set when you start a new job with a <c>StartAssetBundleExportJob</c>
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
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
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
        /// after issuance. Call <c>DescribeAssetBundleExportJob</c> again for a fresh URL if
        /// needed.
        /// </para>
        ///  
        /// <para>
        /// The downloaded asset bundle is a zip file named <c>assetbundle-{jobId}.qs</c>. The
        /// file has a <c>.qs</c> extension.
        /// </para>
        ///  
        /// <para>
        /// This URL can't be used in a <c>StartAssetBundleImportJob</c> API call and should only
        /// be used for download purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetBundleExportJobError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExportFormat. 
        /// <para>
        /// The format of the exported asset bundle. A <c>QUICKSIGHT_JSON</c> formatted file can
        /// be used to make a <c>StartAssetBundleImportJob</c> API call. A <c>CLOUDFORMATION_JSON</c>
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
        public bool? IncludeAllDependencies
        {
            get { return this._includeAllDependencies; }
            set { this._includeAllDependencies = value; }
        }

        // Check to see if IncludeAllDependencies property is set
        internal bool IsSetIncludeAllDependencies()
        {
            return this._includeAllDependencies.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeFolderMembers. 
        /// <para>
        /// A setting that determines whether folder members are included.
        /// </para>
        /// </summary>
        public IncludeFolderMembers IncludeFolderMembers
        {
            get { return this._includeFolderMembers; }
            set { this._includeFolderMembers = value; }
        }

        // Check to see if IncludeFolderMembers property is set
        internal bool IsSetIncludeFolderMembers()
        {
            return this._includeFolderMembers != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeFolderMemberships. 
        /// <para>
        /// The include folder memberships flag.
        /// </para>
        /// </summary>
        public bool? IncludeFolderMemberships
        {
            get { return this._includeFolderMemberships; }
            set { this._includeFolderMemberships = value; }
        }

        // Check to see if IncludeFolderMemberships property is set
        internal bool IsSetIncludeFolderMemberships()
        {
            return this._includeFolderMemberships.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludePermissions. 
        /// <para>
        /// The include permissions flag.
        /// </para>
        /// </summary>
        public bool? IncludePermissions
        {
            get { return this._includePermissions; }
            set { this._includePermissions = value; }
        }

        // Check to see if IncludePermissions property is set
        internal bool IsSetIncludePermissions()
        {
            return this._includePermissions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeTags. 
        /// <para>
        /// The include tags flag.
        /// </para>
        /// </summary>
        public bool? IncludeTags
        {
            get { return this._includeTags; }
            set { this._includeTags = value; }
        }

        // Check to see if IncludeTags property is set
        internal bool IsSetIncludeTags()
        {
            return this._includeTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// Indicates the status of a job through its queuing and execution.
        /// </para>
        ///  
        /// <para>
        /// Poll this <c>DescribeAssetBundleExportApi</c> until <c>JobStatus</c> is either <c>SUCCESSFUL</c>
        /// or <c>FAILED</c>.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._resourceArns != null && (this._resourceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the response.
        /// </para>
        /// </summary>
        public int? Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidationStrategy. 
        /// <para>
        /// The validation strategy that is used to export the analysis or dashboard.
        /// </para>
        /// </summary>
        public AssetBundleExportJobValidationStrategy ValidationStrategy
        {
            get { return this._validationStrategy; }
            set { this._validationStrategy = value; }
        }

        // Check to see if ValidationStrategy property is set
        internal bool IsSetValidationStrategy()
        {
            return this._validationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// An array of warning records that describe the analysis or dashboard that is exported.
        /// This array includes UI errors that can be skipped during the validation process.
        /// </para>
        ///  
        /// <para>
        /// This property only appears if <c>StrictModeForAllResources</c> in <c>ValidationStrategy</c>
        /// is set to <c>FALSE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetBundleExportJobWarning> Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null && (this._warnings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}