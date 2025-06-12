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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Contains all informational fields associated with a cache report. Includes name, ARN,
    /// tags, status, progress, filters, start time, and end time.
    /// </summary>
    public partial class CacheReportInfo
    {
        private string _cacheReportARN;
        private CacheReportStatus _cacheReportStatus;
        private DateTime? _endTime;
        private List<CacheReportFilter> _exclusionFilters = AWSConfigs.InitializeCollections ? new List<CacheReportFilter>() : null;
        private string _fileShareARN;
        private List<CacheReportFilter> _inclusionFilters = AWSConfigs.InitializeCollections ? new List<CacheReportFilter>() : null;
        private string _locationARN;
        private int? _reportCompletionPercent;
        private string _reportName;
        private string _role;
        private DateTime? _startTime;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CacheReportARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cache report you want to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string CacheReportARN
        {
            get { return this._cacheReportARN; }
            set { this._cacheReportARN = value; }
        }

        // Check to see if CacheReportARN property is set
        internal bool IsSetCacheReportARN()
        {
            return this._cacheReportARN != null;
        }

        /// <summary>
        /// Gets and sets the property CacheReportStatus. 
        /// <para>
        /// The status of the specified cache report.
        /// </para>
        /// </summary>
        public CacheReportStatus CacheReportStatus
        {
            get { return this._cacheReportStatus; }
            set { this._cacheReportStatus = value; }
        }

        // Check to see if CacheReportStatus property is set
        internal bool IsSetCacheReportStatus()
        {
            return this._cacheReportStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the gateway stopped generating the cache report.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExclusionFilters. 
        /// <para>
        /// The list of filters and parameters that determine which files are excluded from the
        /// report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CacheReportFilter> ExclusionFilters
        {
            get { return this._exclusionFilters; }
            set { this._exclusionFilters = value; }
        }

        // Check to see if ExclusionFilters property is set
        internal bool IsSetExclusionFilters()
        {
            return this._exclusionFilters != null && (this._exclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FileShareARN.
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string FileShareARN
        {
            get { return this._fileShareARN; }
            set { this._fileShareARN = value; }
        }

        // Check to see if FileShareARN property is set
        internal bool IsSetFileShareARN()
        {
            return this._fileShareARN != null;
        }

        /// <summary>
        /// Gets and sets the property InclusionFilters. 
        /// <para>
        /// The list of filters and parameters that determine which files are included in the
        /// report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CacheReportFilter> InclusionFilters
        {
            get { return this._inclusionFilters; }
            set { this._inclusionFilters = value; }
        }

        // Check to see if InclusionFilters property is set
        internal bool IsSetInclusionFilters()
        {
            return this._inclusionFilters != null && (this._inclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LocationARN. 
        /// <para>
        /// The ARN of the Amazon S3 bucket location where the cache report is saved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=1400)]
        public string LocationARN
        {
            get { return this._locationARN; }
            set { this._locationARN = value; }
        }

        // Check to see if LocationARN property is set
        internal bool IsSetLocationARN()
        {
            return this._locationARN != null;
        }

        /// <summary>
        /// Gets and sets the property ReportCompletionPercent. 
        /// <para>
        /// The percentage of the report generation process that has been completed at time of
        /// inquiry.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? ReportCompletionPercent
        {
            get { return this._reportCompletionPercent; }
            set { this._reportCompletionPercent = value; }
        }

        // Check to see if ReportCompletionPercent property is set
        internal bool IsSetReportCompletionPercent()
        {
            return this._reportCompletionPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportName. 
        /// <para>
        /// The file name of the completed cache report object stored in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ReportName
        {
            get { return this._reportName; }
            set { this._reportName = value; }
        }

        // Check to see if ReportName property is set
        internal bool IsSetReportName()
        {
            return this._reportName != null;
        }

        /// <summary>
        /// Gets and sets the property Role.
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time at which the gateway started generating the cache report.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of key/value tags associated with the report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
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