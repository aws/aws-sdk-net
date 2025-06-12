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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
        private DateTime? _endTime;
        private double? _percentageCompleted;
        private string _resourceScanId;
        private int? _resourcesRead;
        private int? _resourcesScanned;
        private List<string> _resourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ScanFilter> _scanFilters = AWSConfigs.InitializeCollections ? new List<ScanFilter>() : null;
        private DateTime? _startTime;
        private ResourceScanStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time that the resource scan was finished.
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
        /// Gets and sets the property PercentageCompleted. 
        /// <para>
        /// The percentage of the resource scan that has been completed.
        /// </para>
        /// </summary>
        public double? PercentageCompleted
        {
            get { return this._percentageCompleted; }
            set { this._percentageCompleted = value; }
        }

        // Check to see if PercentageCompleted property is set
        internal bool IsSetPercentageCompleted()
        {
            return this._percentageCompleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceScanId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource scan. The format is <c>arn:${Partition}:cloudformation:${Region}:${Account}:resourceScan/${Id}</c>.
        /// An example is <c>arn:aws:cloudformation:<i>us-east-1</i>:<i>123456789012</i>:resourceScan/<i>f5b490f7-7ed4-428a-aa06-31ff25db0772</i>
        /// </c>.
        /// </para>
        /// </summary>
        public string ResourceScanId
        {
            get { return this._resourceScanId; }
            set { this._resourceScanId = value; }
        }

        // Check to see if ResourceScanId property is set
        internal bool IsSetResourceScanId()
        {
            return this._resourceScanId != null;
        }

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
        public int? ResourcesRead
        {
            get { return this._resourcesRead; }
            set { this._resourcesRead = value; }
        }

        // Check to see if ResourcesRead property is set
        internal bool IsSetResourcesRead()
        {
            return this._resourcesRead.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourcesScanned. 
        /// <para>
        /// The number of resources that were listed. This is only available for scans with a
        /// <c>Status</c> set to <c>COMPLETE</c>, <c>EXPIRED</c>, or <c>FAILED </c>.
        /// </para>
        /// </summary>
        public int? ResourcesScanned
        {
            get { return this._resourcesScanned; }
            set { this._resourcesScanned = value; }
        }

        // Check to see if ResourcesScanned property is set
        internal bool IsSetResourcesScanned()
        {
            return this._resourcesScanned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The list of resource types for the specified scan. Resource types are only available
        /// for scans with a <c>Status</c> set to <c>COMPLETE</c> or <c>FAILED </c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScanFilters. 
        /// <para>
        /// The scan filters that were used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<ScanFilter> ScanFilters
        {
            get { return this._scanFilters; }
            set { this._scanFilters = value; }
        }

        // Check to see if ScanFilters property is set
        internal bool IsSetScanFilters()
        {
            return this._scanFilters != null && (this._scanFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time that the resource scan was started.
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
        public ResourceScanStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the resource scan status, providing more information if a failure happened.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}