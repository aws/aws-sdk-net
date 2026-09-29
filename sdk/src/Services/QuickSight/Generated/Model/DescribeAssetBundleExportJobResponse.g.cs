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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the export job.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssetBundleExportJobId. 
        /// <para>
        /// The ID of the job. The job ID is set when you start a new job with a <c>StartAssetBundleExportJob</c>
        /// API call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string AssetBundleExportJobId { get; set; }

        /// <summary>
        /// Checks to see if the AssetBundleExportJobId property is set.
        /// </summary>
        internal bool IsSetAssetBundleExportJobId() => this.AssetBundleExportJobId != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that the export job was executed in. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property CloudFormationOverridePropertyConfiguration. 
        /// <para>
        /// The CloudFormation override property configuration for the export job.
        /// </para>
        /// </summary>
        public AssetBundleCloudFormationOverridePropertyConfiguration CloudFormationOverridePropertyConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CloudFormationOverridePropertyConfiguration property is set.
        /// </summary>
        internal bool IsSetCloudFormationOverridePropertyConfiguration() => this.CloudFormationOverridePropertyConfiguration != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that the export job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

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
        [AWSProperty(Sensitive = true)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Checks to see if the DownloadUrl property is set.
        /// </summary>
        internal bool IsSetDownloadUrl() => this.DownloadUrl != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetBundleExportJobError> Errors { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobError>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExportFormat. 
        /// <para>
        /// The format of the exported asset bundle. A <c>QUICKSIGHT_JSON</c> formatted file can
        /// be used to make a <c>StartAssetBundleImportJob</c> API call. A <c>CLOUDFORMATION_JSON</c>
        /// formatted file can be used in the CloudFormation console and with the CloudFormation
        /// APIs.
        /// </para>
        /// </summary>
        public AssetBundleExportFormat ExportFormat { get; set; }

        /// <summary>
        /// Checks to see if the ExportFormat property is set.
        /// </summary>
        internal bool IsSetExportFormat() => this.ExportFormat != null;

        /// <summary>
        /// Gets and sets the property IncludeAllDependencies. 
        /// <para>
        /// The include dependencies flag.
        /// </para>
        /// </summary>
        public bool? IncludeAllDependencies { get; set; }

        /// <summary>
        /// Checks to see if the IncludeAllDependencies property is set.
        /// </summary>
        internal bool IsSetIncludeAllDependencies() => this.IncludeAllDependencies.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeFolderMembers. 
        /// <para>
        /// A setting that determines whether folder members are included.
        /// </para>
        /// </summary>
        public IncludeFolderMembers IncludeFolderMembers { get; set; }

        /// <summary>
        /// Checks to see if the IncludeFolderMembers property is set.
        /// </summary>
        internal bool IsSetIncludeFolderMembers() => this.IncludeFolderMembers != null;

        /// <summary>
        /// Gets and sets the property IncludeFolderMemberships. 
        /// <para>
        /// The include folder memberships flag.
        /// </para>
        /// </summary>
        public bool? IncludeFolderMemberships { get; set; }

        /// <summary>
        /// Checks to see if the IncludeFolderMemberships property is set.
        /// </summary>
        internal bool IsSetIncludeFolderMemberships() => this.IncludeFolderMemberships.HasValue;

        /// <summary>
        /// Gets and sets the property IncludePermissions. 
        /// <para>
        /// The include permissions flag.
        /// </para>
        /// </summary>
        public bool? IncludePermissions { get; set; }

        /// <summary>
        /// Checks to see if the IncludePermissions property is set.
        /// </summary>
        internal bool IsSetIncludePermissions() => this.IncludePermissions.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeTags. 
        /// <para>
        /// The include tags flag.
        /// </para>
        /// </summary>
        public bool? IncludeTags { get; set; }

        /// <summary>
        /// Checks to see if the IncludeTags property is set.
        /// </summary>
        internal bool IsSetIncludeTags() => this.IncludeTags.HasValue;

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
        public AssetBundleExportJobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// A list of resource ARNs that exported with the job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> ResourceArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceArns property is set.
        /// </summary>
        internal bool IsSetResourceArns() => this.ResourceArns != null && (this.ResourceArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the response.
        /// </para>
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status.HasValue;

        /// <summary>
        /// Gets and sets the property ValidationStrategy. 
        /// <para>
        /// The validation strategy that is used to export the analysis or dashboard.
        /// </para>
        /// </summary>
        public AssetBundleExportJobValidationStrategy ValidationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStrategy property is set.
        /// </summary>
        internal bool IsSetValidationStrategy() => this.ValidationStrategy != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetBundleExportJobWarning> Warnings { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobWarning>() : null;

        /// <summary>
        /// Checks to see if the Warnings property is set.
        /// </summary>
        internal bool IsSetWarnings() => this.Warnings != null && (this.Warnings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
