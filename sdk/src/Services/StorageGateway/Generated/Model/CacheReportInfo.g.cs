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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Contains all informational fields associated with a cache report. Includes name, ARN,
    /// tags, status, progress, filters, start time, and end time.
    /// </summary>
    public partial class CacheReportInfo
    {
        /// <summary>
        /// Gets and sets the property CacheReportARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cache report you want to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string CacheReportARN { get; set; }

        /// <summary>
        /// Checks to see if the CacheReportARN property is set.
        /// </summary>
        internal bool IsSetCacheReportARN() => this.CacheReportARN != null;

        /// <summary>
        /// Gets and sets the property CacheReportStatus. 
        /// <para>
        /// The status of the specified cache report.
        /// </para>
        /// </summary>
        public CacheReportStatus CacheReportStatus { get; set; }

        /// <summary>
        /// Checks to see if the CacheReportStatus property is set.
        /// </summary>
        internal bool IsSetCacheReportStatus() => this.CacheReportStatus != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the gateway stopped generating the cache report.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExclusionFilters. 
        /// <para>
        /// The list of filters and parameters that determine which files are excluded from the
        /// report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CacheReportFilter> ExclusionFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CacheReportFilter>() : null;

        /// <summary>
        /// Checks to see if the ExclusionFilters property is set.
        /// </summary>
        internal bool IsSetExclusionFilters() => this.ExclusionFilters != null && (this.ExclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FileShareARN.
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string FileShareARN { get; set; }

        /// <summary>
        /// Checks to see if the FileShareARN property is set.
        /// </summary>
        internal bool IsSetFileShareARN() => this.FileShareARN != null;

        /// <summary>
        /// Gets and sets the property InclusionFilters. 
        /// <para>
        /// The list of filters and parameters that determine which files are included in the
        /// report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CacheReportFilter> InclusionFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CacheReportFilter>() : null;

        /// <summary>
        /// Checks to see if the InclusionFilters property is set.
        /// </summary>
        internal bool IsSetInclusionFilters() => this.InclusionFilters != null && (this.InclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LocationARN. 
        /// <para>
        /// The ARN of the Amazon S3 bucket location where the cache report is saved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 1400)]
        public string LocationARN { get; set; }

        /// <summary>
        /// Checks to see if the LocationARN property is set.
        /// </summary>
        internal bool IsSetLocationARN() => this.LocationARN != null;

        /// <summary>
        /// Gets and sets the property ReportCompletionPercent. 
        /// <para>
        /// The percentage of the report generation process that has been completed at time of
        /// inquiry.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? ReportCompletionPercent { get; set; }

        /// <summary>
        /// Checks to see if the ReportCompletionPercent property is set.
        /// </summary>
        internal bool IsSetReportCompletionPercent() => this.ReportCompletionPercent.HasValue;

        /// <summary>
        /// Gets and sets the property ReportName. 
        /// <para>
        /// The file name of the completed cache report object stored in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ReportName { get; set; }

        /// <summary>
        /// Checks to see if the ReportName property is set.
        /// </summary>
        internal bool IsSetReportName() => this.ReportName != null;

        /// <summary>
        /// Gets and sets the property Role.
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time at which the gateway started generating the cache report.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of key/value tags associated with the report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
