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
    /// This is the response object from the DescribeAssetBundleImportJob operation.
    /// </summary>
    public partial class DescribeAssetBundleImportJobResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _assetBundleImportJobId;
        private AssetBundleImportSourceDescription _assetBundleImportSource;
        private string _awsAccountId;
        private DateTime? _createdTime;
        private List<AssetBundleImportJobError> _errors = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobError>() : null;
        private AssetBundleImportFailureAction _failureAction;
        private AssetBundleImportJobStatus _jobStatus;
        private AssetBundleImportJobOverrideParameters _overrideParameters;
        private AssetBundleImportJobOverridePermissions _overridePermissions;
        private AssetBundleImportJobOverrideTags _overrideTags;
        private AssetBundleImportJobOverrideValidationStrategy _overrideValidationStrategy;
        private string _requestId;
        private List<AssetBundleImportJobError> _rollbackErrors = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobError>() : null;
        private int? _status;
        private List<AssetBundleImportJobWarning> _warnings = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobWarning>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the import job.
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
        /// Gets and sets the property AssetBundleImportJobId. 
        /// <para>
        /// The ID of the job. The job ID is set when you start a new job with a <c>StartAssetBundleImportJob</c>
        /// API call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string AssetBundleImportJobId
        {
            get { return this._assetBundleImportJobId; }
            set { this._assetBundleImportJobId = value; }
        }

        // Check to see if AssetBundleImportJobId property is set
        internal bool IsSetAssetBundleImportJobId()
        {
            return this._assetBundleImportJobId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetBundleImportSource. 
        /// <para>
        /// The source of the asset bundle zip file that contains the data that is imported by
        /// the job.
        /// </para>
        /// </summary>
        public AssetBundleImportSourceDescription AssetBundleImportSource
        {
            get { return this._assetBundleImportSource; }
            set { this._assetBundleImportSource = value; }
        }

        // Check to see if AssetBundleImportSource property is set
        internal bool IsSetAssetBundleImportSource()
        {
            return this._assetBundleImportSource != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account the import job was executed in. 
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that the import job was created.
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetBundleImportJobError> Errors
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
        /// Gets and sets the property FailureAction. 
        /// <para>
        /// The failure action for the import job.
        /// </para>
        /// </summary>
        public AssetBundleImportFailureAction FailureAction
        {
            get { return this._failureAction; }
            set { this._failureAction = value; }
        }

        // Check to see if FailureAction property is set
        internal bool IsSetFailureAction()
        {
            return this._failureAction != null;
        }

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
        public AssetBundleImportJobStatus JobStatus
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
        /// Gets and sets the property OverrideParameters. 
        /// <para>
        /// Optional overrides that are applied to the resource configuration before import.
        /// </para>
        /// </summary>
        public AssetBundleImportJobOverrideParameters OverrideParameters
        {
            get { return this._overrideParameters; }
            set { this._overrideParameters = value; }
        }

        // Check to see if OverrideParameters property is set
        internal bool IsSetOverrideParameters()
        {
            return this._overrideParameters != null;
        }

        /// <summary>
        /// Gets and sets the property OverridePermissions. 
        /// <para>
        /// Optional permission overrides that are applied to the resource configuration before
        /// import.
        /// </para>
        /// </summary>
        public AssetBundleImportJobOverridePermissions OverridePermissions
        {
            get { return this._overridePermissions; }
            set { this._overridePermissions = value; }
        }

        // Check to see if OverridePermissions property is set
        internal bool IsSetOverridePermissions()
        {
            return this._overridePermissions != null;
        }

        /// <summary>
        /// Gets and sets the property OverrideTags. 
        /// <para>
        /// Optional tag overrides that are applied to the resource configuration before import.
        /// </para>
        /// </summary>
        public AssetBundleImportJobOverrideTags OverrideTags
        {
            get { return this._overrideTags; }
            set { this._overrideTags = value; }
        }

        // Check to see if OverrideTags property is set
        internal bool IsSetOverrideTags()
        {
            return this._overrideTags != null;
        }

        /// <summary>
        /// Gets and sets the property OverrideValidationStrategy. 
        /// <para>
        /// An optional validation strategy override for all analyses and dashboards to be applied
        /// to the resource configuration before import.
        /// </para>
        /// </summary>
        public AssetBundleImportJobOverrideValidationStrategy OverrideValidationStrategy
        {
            get { return this._overrideValidationStrategy; }
            set { this._overrideValidationStrategy = value; }
        }

        // Check to see if OverrideValidationStrategy property is set
        internal bool IsSetOverrideValidationStrategy()
        {
            return this._overrideValidationStrategy != null;
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetBundleImportJobError> RollbackErrors
        {
            get { return this._rollbackErrors; }
            set { this._rollbackErrors = value; }
        }

        // Check to see if RollbackErrors property is set
        internal bool IsSetRollbackErrors()
        {
            return this._rollbackErrors != null && (this._rollbackErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property Warnings. 
        /// <para>
        /// An array of warning records that describe all permitted errors that are encountered
        /// during the import job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetBundleImportJobWarning> Warnings
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