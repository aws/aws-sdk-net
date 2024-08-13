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
    /// A summary of the import job that includes details of the requested job's configuration
    /// and its current status.
    /// </summary>
    public partial class AssetBundleImportJobSummary
    {
        private string _arn;
        private string _assetBundleImportJobId;
        private DateTime? _createdTime;
        private AssetBundleImportFailureAction _failureAction;
        private AssetBundleImportJobStatus _jobStatus;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the import job.
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
        /// The ID of the job. This ID is unique while the job is running. After the job is completed,
        /// you can reuse this ID for another job.
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
        /// The current status of the import job.
        /// </para>
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

    }
}