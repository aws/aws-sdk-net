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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// This is the response object from the DescribeTestSetDiscrepancyReport operation.
    /// </summary>
    public partial class DescribeTestSetDiscrepancyReportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The time and date of creation for the test set discrepancy report.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// The failure report for the test set discrepancy report generation action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureReasons property is set.
        /// </summary>
        internal bool IsSetFailureReasons() => this.FailureReasons != null && (this.FailureReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdatedDataTime. 
        /// <para>
        /// The date and time of the last update for the test set discrepancy report.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDataTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDataTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDataTime() => this.LastUpdatedDataTime.HasValue;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target bot location for the test set discrepancy report.
        /// </para>
        /// </summary>
        public TestSetDiscrepancyReportResourceTarget Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property TestSetDiscrepancyRawOutputUrl. 
        /// <para>
        /// Pre-signed Amazon S3 URL to download the test set discrepancy report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string TestSetDiscrepancyRawOutputUrl { get; set; }

        /// <summary>
        /// Checks to see if the TestSetDiscrepancyRawOutputUrl property is set.
        /// </summary>
        internal bool IsSetTestSetDiscrepancyRawOutputUrl() => this.TestSetDiscrepancyRawOutputUrl != null;

        /// <summary>
        /// Gets and sets the property TestSetDiscrepancyReportId. 
        /// <para>
        /// The unique identifier of the test set discrepancy report to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string TestSetDiscrepancyReportId { get; set; }

        /// <summary>
        /// Checks to see if the TestSetDiscrepancyReportId property is set.
        /// </summary>
        internal bool IsSetTestSetDiscrepancyReportId() => this.TestSetDiscrepancyReportId != null;

        /// <summary>
        /// Gets and sets the property TestSetDiscrepancyReportStatus. 
        /// <para>
        /// The status for the test set discrepancy report.
        /// </para>
        /// </summary>
        public TestSetDiscrepancyReportStatus TestSetDiscrepancyReportStatus { get; set; }

        /// <summary>
        /// Checks to see if the TestSetDiscrepancyReportStatus property is set.
        /// </summary>
        internal bool IsSetTestSetDiscrepancyReportStatus() => this.TestSetDiscrepancyReportStatus != null;

        /// <summary>
        /// Gets and sets the property TestSetDiscrepancyTopErrors. 
        /// <para>
        /// The top 200 error results from the test set discrepancy report.
        /// </para>
        /// </summary>
        public TestSetDiscrepancyErrors TestSetDiscrepancyTopErrors { get; set; }

        /// <summary>
        /// Checks to see if the TestSetDiscrepancyTopErrors property is set.
        /// </summary>
        internal bool IsSetTestSetDiscrepancyTopErrors() => this.TestSetDiscrepancyTopErrors != null;

        /// <summary>
        /// Gets and sets the property TestSetId. 
        /// <para>
        /// The test set Id for the test set discrepancy report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string TestSetId { get; set; }

        /// <summary>
        /// Checks to see if the TestSetId property is set.
        /// </summary>
        internal bool IsSetTestSetId() => this.TestSetId != null;
    }
}
