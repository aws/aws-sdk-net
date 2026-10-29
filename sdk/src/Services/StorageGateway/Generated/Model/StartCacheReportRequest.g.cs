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
    /// Container for the parameters to the StartCacheReport operation. Starts generating
    /// a report of the file metadata currently cached by an S3 File Gateway for a specific
    /// file share. You can use this report to identify and resolve issues if you have files
    /// failing upload from your gateway to Amazon S3. The report is a CSV file containing
    /// a list of files which match the set of filter parameters you specify in the request.
    /// <note> <para> The <b>Files Failing Upload</b> flag is reset every 24 hours and during
    /// gateway reboot. If this report captures the files after the reset, but before they
    /// become flagged again, they will not be reported as <b>Files Failing Upload</b>. </para>
    /// </note> <para> The following requirements must be met to successfully generate a cache
    /// report: </para> <ul> <li> <para> You must have <c>s3:PutObject</c> and <c>s3:AbortMultipartUpload</c>
    /// permissions for the Amazon S3 bucket where you want to store the cache report. </para>
    /// </li> <li> <para> No other cache reports can currently be in-progress for the specified
    /// file share. </para> </li> <li> <para> There must be fewer than 10 existing cache reports
    /// for the specified file share. </para> </li> <li> <para> The gateway must be online
    /// and connected to Amazon Web Services. </para> </li> <li> <para> The root disk must
    /// have at least 20GB of free space when report generation starts. </para> </li> <li>
    /// <para> You must specify at least one value for <c>InclusionFilters</c> or <c>ExclusionFilters</c>
    /// in the request. </para> </li> </ul>
    /// </summary>
    public partial class StartCacheReportRequest : AmazonStorageGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property BucketRegion. 
        /// <para>
        /// The Amazon Web Services Region of the Amazon S3 bucket where you want to save the
        /// cache report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 25)]
        public string BucketRegion { get; set; }

        /// <summary>
        /// Checks to see if the BucketRegion property is set.
        /// </summary>
        internal bool IsSetBucketRegion() => this.BucketRegion != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier that you use to ensure idempotent report generation if you need
        /// to retry an unsuccessful <c>StartCacheReport</c> request. If you retry a request,
        /// use the same <c>ClientToken</c> you specified in the initial request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ExclusionFilters. 
        /// <para>
        /// The list of filters and parameters that determine which files are excluded from the
        /// report. You must specify at least one value for <c>InclusionFilters</c> or <c>ExclusionFilters</c>
        /// in a <c>StartCacheReport</c> request.
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
        [AWSProperty(Required = true, Min = 50, Max = 500)]
        public string FileShareARN { get; set; }

        /// <summary>
        /// Checks to see if the FileShareARN property is set.
        /// </summary>
        internal bool IsSetFileShareARN() => this.FileShareARN != null;

        /// <summary>
        /// Gets and sets the property InclusionFilters. 
        /// <para>
        /// The list of filters and parameters that determine which files are included in the
        /// report. You must specify at least one value for <c>InclusionFilters</c> or <c>ExclusionFilters</c>
        /// in a <c>StartCacheReport</c> request.
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
        /// The ARN of the Amazon S3 bucket where you want to save the cache report.
        /// </para>
        ///  <note> 
        /// <para>
        /// We do not recommend saving the cache report to the same Amazon S3 bucket for which
        /// you are generating the report.
        /// </para>
        ///  
        /// <para>
        /// This field does not accept access point ARNs.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 1400)]
        public string LocationARN { get; set; }

        /// <summary>
        /// Checks to see if the LocationARN property is set.
        /// </summary>
        internal bool IsSetLocationARN() => this.LocationARN != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The ARN of the IAM role used when saving the cache report to Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 key/value tags that you can assign to the cache report. Using tags
        /// can help you categorize your reports and more easily locate them in search results.
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

        /// <summary>
        /// Gets and sets the property VPCEndpointDNSName. 
        /// <para>
        /// The DNS name of the VPC endpoint associated with the Amazon S3 where you want to save
        /// the cache report. Optional.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string VPCEndpointDNSName { get; set; }

        /// <summary>
        /// Checks to see if the VPCEndpointDNSName property is set.
        /// </summary>
        internal bool IsSetVPCEndpointDNSName() => this.VPCEndpointDNSName != null;
    }
}
