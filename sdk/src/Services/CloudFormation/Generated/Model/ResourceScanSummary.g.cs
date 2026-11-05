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
    /// A summary of the resource scan. This is returned by the <c>ListResourceScan</c> API
    /// action.
    /// </summary>
    public partial class ResourceScanSummary
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
        /// The Amazon Resource Name (ARN) of the resource scan.
        /// </para>
        /// </summary>
        public string ResourceScanId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceScanId property is set.
        /// </summary>
        internal bool IsSetResourceScanId() => this.ResourceScanId != null;

        /// <summary>
        /// Gets and sets the property ScanType. 
        /// <para>
        /// The scan type that has been completed.
        /// </para>
        /// </summary>
        public ScanType ScanType { get; set; }

        /// <summary>
        /// Checks to see if the ScanType property is set.
        /// </summary>
        internal bool IsSetScanType() => this.ScanType != null;

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
