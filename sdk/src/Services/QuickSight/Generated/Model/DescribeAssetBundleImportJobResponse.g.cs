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
    /// This is the response object from the DescribeAssetBundleImportJob operation.
    /// </summary>
    public partial class DescribeAssetBundleImportJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the import job.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssetBundleImportJobId. 
        /// <para>
        /// The ID of the job. The job ID is set when you start a new job with a <c>StartAssetBundleImportJob</c>
        /// API call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string AssetBundleImportJobId { get; set; }

        /// <summary>
        /// Checks to see if the AssetBundleImportJobId property is set.
        /// </summary>
        internal bool IsSetAssetBundleImportJobId() => this.AssetBundleImportJobId != null;

        /// <summary>
        /// Gets and sets the property AssetBundleImportSource. 
        /// <para>
        /// The source of the asset bundle zip file that contains the data that is imported by
        /// the job.
        /// </para>
        /// </summary>
        public AssetBundleImportSourceDescription AssetBundleImportSource { get; set; }

        /// <summary>
        /// Checks to see if the AssetBundleImportSource property is set.
        /// </summary>
        internal bool IsSetAssetBundleImportSource() => this.AssetBundleImportSource != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account the import job was executed in. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that the import job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// An array of error records that describes any failures that occurred during the export
        /// job processing.
        /// </para>
        ///  
        /// <para>
        /// Error records accumulate while the job is still running. The complete set of error
        /// records is available after the job has completed and failed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetBundleImportJobError> Errors { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobError>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailureAction. 
        /// <para>
        /// The failure action for the import job.
        /// </para>
        /// </summary>
        public AssetBundleImportFailureAction FailureAction { get; set; }

        /// <summary>
        /// Checks to see if the FailureAction property is set.
        /// </summary>
        internal bool IsSetFailureAction() => this.FailureAction != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// Indicates the status of a job through its queuing and execution.
        /// </para>
        ///  
        /// <para>
        /// Poll the <c>DescribeAssetBundleImport</c> API until <c>JobStatus</c> returns one of
        /// the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SUCCESSFUL</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED_ROLLBACK_COMPLETED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED_ROLLBACK_ERROR</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AssetBundleImportJobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property OverrideParameters. 
        /// <para>
        /// Optional overrides that are applied to the resource configuration before import.
        /// </para>
        /// </summary>
        public AssetBundleImportJobOverrideParameters OverrideParameters { get; set; }

        /// <summary>
        /// Checks to see if the OverrideParameters property is set.
        /// </summary>
        internal bool IsSetOverrideParameters() => this.OverrideParameters != null;

        /// <summary>
        /// Gets and sets the property OverridePermissions. 
        /// <para>
        /// Optional permission overrides that are applied to the resource configuration before
        /// import.
        /// </para>
        /// </summary>
        public AssetBundleImportJobOverridePermissions OverridePermissions { get; set; }

        /// <summary>
        /// Checks to see if the OverridePermissions property is set.
        /// </summary>
        internal bool IsSetOverridePermissions() => this.OverridePermissions != null;

        /// <summary>
        /// Gets and sets the property OverrideTags. 
        /// <para>
        /// Optional tag overrides that are applied to the resource configuration before import.
        /// </para>
        /// </summary>
        public AssetBundleImportJobOverrideTags OverrideTags { get; set; }

        /// <summary>
        /// Checks to see if the OverrideTags property is set.
        /// </summary>
        internal bool IsSetOverrideTags() => this.OverrideTags != null;

        /// <summary>
        /// Gets and sets the property OverrideValidationStrategy. 
        /// <para>
        /// An optional validation strategy override for all analyses and dashboards to be applied
        /// to the resource configuration before import.
        /// </para>
        /// </summary>
        public AssetBundleImportJobOverrideValidationStrategy OverrideValidationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the OverrideValidationStrategy property is set.
        /// </summary>
        internal bool IsSetOverrideValidationStrategy() => this.OverrideValidationStrategy != null;

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
        /// Gets and sets the property RollbackErrors. 
        /// <para>
        /// An array of error records that describes any failures that occurred while an import
        /// job was attempting a rollback.
        /// </para>
        ///  
        /// <para>
        /// Error records accumulate while the job is still running. The complete set of error
        /// records is available after the job has completed and failed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetBundleImportJobError> RollbackErrors { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobError>() : null;

        /// <summary>
        /// Checks to see if the RollbackErrors property is set.
        /// </summary>
        internal bool IsSetRollbackErrors() => this.RollbackErrors != null && (this.RollbackErrors.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property Warnings. 
        /// <para>
        /// An array of warning records that describe all permitted errors that are encountered
        /// during the import job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetBundleImportJobWarning> Warnings { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobWarning>() : null;

        /// <summary>
        /// Checks to see if the Warnings property is set.
        /// </summary>
        internal bool IsSetWarnings() => this.Warnings != null && (this.Warnings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
