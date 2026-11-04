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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the DescribeResourceScan operation.
    /// </summary>
    public partial class DescribeResourceScanResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time that the resource scan was finished.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property PercentageCompleted. 
        /// <para>
        /// The percentage of the resource scan that has been completed.
        /// </para>
        /// </summary>
        public double? PercentageCompleted { get; set; }

        /// <summary>
        /// Checks to see if the PercentageCompleted property is set.
        /// </summary>
        internal bool IsSetPercentageCompleted() => this.PercentageCompleted.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceScanId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource scan. The format is <c>arn:${Partition}:cloudformation:${Region}:${Account}:resourceScan/${Id}</c>.
        /// An example is <c>arn:aws:cloudformation:<i>us-east-1</i>:<i>123456789012</i>:resourceScan/<i>f5b490f7-7ed4-428a-aa06-31ff25db0772</i>
        /// </c>.
        /// </para>
        /// </summary>
        public string ResourceScanId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceScanId property is set.
        /// </summary>
        internal bool IsSetResourceScanId() => this.ResourceScanId != null;

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The list of resource types for the specified scan. Resource types are only available
        /// for scans with a <c>Status</c> set to <c>COMPLETE</c> or <c>FAILED </c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypes property is set.
        /// </summary>
        internal bool IsSetResourceTypes() => this.ResourceTypes != null && (this.ResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourcesRead. 
        /// <para>
        /// The number of resources that were read. This is only available for scans with a <c>Status</c>
        /// set to <c>COMPLETE</c>, <c>EXPIRED</c>, or <c>FAILED</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field may be 0 if the resource scan failed with a <c>ResourceScanLimitExceededException</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public int? ResourcesRead { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesRead property is set.
        /// </summary>
        internal bool IsSetResourcesRead() => this.ResourcesRead.HasValue;

        /// <summary>
        /// Gets and sets the property ResourcesScanned. 
        /// <para>
        /// The number of resources that were listed. This is only available for scans with a
        /// <c>Status</c> set to <c>COMPLETE</c>, <c>EXPIRED</c>, or <c>FAILED </c>.
        /// </para>
        /// </summary>
        public int? ResourcesScanned { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesScanned property is set.
        /// </summary>
        internal bool IsSetResourcesScanned() => this.ResourcesScanned.HasValue;

        /// <summary>
        /// Gets and sets the property ScanFilters. 
        /// <para>
        /// The scan filters that were used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<ScanFilter> ScanFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<ScanFilter>() : null;

        /// <summary>
        /// Checks to see if the ScanFilters property is set.
        /// </summary>
        internal bool IsSetScanFilters() => this.ScanFilters != null && (this.ScanFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time that the resource scan was started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the resource scan.
        /// </para>
        ///  <dl> <dt> IN_PROGRESS </dt> <dd> 
        /// <para>
        /// The resource scan is still in progress.
        /// </para>
        ///  </dd> <dt> COMPLETE </dt> <dd> 
        /// <para>
        /// The resource scan is complete.
        /// </para>
        ///  </dd> <dt> EXPIRED </dt> <dd> 
        /// <para>
        /// The resource scan has expired.
        /// </para>
        ///  </dd> <dt> FAILED </dt> <dd> 
        /// <para>
        /// The resource scan has failed.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public ResourceScanStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the resource scan status, providing more information if a failure happened.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
