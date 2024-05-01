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
    /// A summary of the export job that includes details of the job's configuration and its
    /// current status.
    /// </summary>
    public partial class AssetBundleExportJobSummary
    {
        private string _arn;
        private string _assetBundleExportJobId;
        private DateTime? _createdTime;
        private AssetBundleExportFormat _exportFormat;
        private bool? _includeAllDependencies;
        private bool? _includePermissions;
        private bool? _includeTags;
        private AssetBundleExportJobStatus _jobStatus;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the export job.
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
        /// The ID of the export job.
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
        /// Gets and sets the property ExportFormat. 
        /// <para>
        /// The format for the export job.
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
        /// The flag that determines the inclusion of resource dependencies in the returned asset
        /// bundle.
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
        /// Gets and sets the property IncludePermissions. 
        /// <para>
        /// The flag that determines the inclusion of permissions associated with each resource
        /// ARN.
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
        /// The flag that determines the inclusion of tags associated with each resource ARN.
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
        /// The current status of the export job.
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

    }
}