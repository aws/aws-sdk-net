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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
        private DateTime? _creationDateTime;
        private List<string> _failureReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastUpdatedDataTime;
        private TestSetDiscrepancyReportResourceTarget _target;
        private string _testSetDiscrepancyRawOutputUrl;
        private string _testSetDiscrepancyReportId;
        private TestSetDiscrepancyReportStatus _testSetDiscrepancyReportStatus;
        private TestSetDiscrepancyErrors _testSetDiscrepancyTopErrors;
        private string _testSetId;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The time and date of creation for the test set discrepancy report.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// The failure report for the test set discrepancy report generation action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureReasons
        {
            get { return this._failureReasons; }
            set { this._failureReasons = value; }
        }

        // Check to see if FailureReasons property is set
        internal bool IsSetFailureReasons()
        {
            return this._failureReasons != null && (this._failureReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDataTime. 
        /// <para>
        /// The date and time of the last update for the test set discrepancy report.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDataTime
        {
            get { return this._lastUpdatedDataTime; }
            set { this._lastUpdatedDataTime = value; }
        }

        // Check to see if LastUpdatedDataTime property is set
        internal bool IsSetLastUpdatedDataTime()
        {
            return this._lastUpdatedDataTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target bot location for the test set discrepancy report.
        /// </para>
        /// </summary>
        public TestSetDiscrepancyReportResourceTarget Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property TestSetDiscrepancyRawOutputUrl. 
        /// <para>
        /// Pre-signed Amazon S3 URL to download the test set discrepancy report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string TestSetDiscrepancyRawOutputUrl
        {
            get { return this._testSetDiscrepancyRawOutputUrl; }
            set { this._testSetDiscrepancyRawOutputUrl = value; }
        }

        // Check to see if TestSetDiscrepancyRawOutputUrl property is set
        internal bool IsSetTestSetDiscrepancyRawOutputUrl()
        {
            return this._testSetDiscrepancyRawOutputUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TestSetDiscrepancyReportId. 
        /// <para>
        /// The unique identifier of the test set discrepancy report to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string TestSetDiscrepancyReportId
        {
            get { return this._testSetDiscrepancyReportId; }
            set { this._testSetDiscrepancyReportId = value; }
        }

        // Check to see if TestSetDiscrepancyReportId property is set
        internal bool IsSetTestSetDiscrepancyReportId()
        {
            return this._testSetDiscrepancyReportId != null;
        }

        /// <summary>
        /// Gets and sets the property TestSetDiscrepancyReportStatus. 
        /// <para>
        /// The status for the test set discrepancy report.
        /// </para>
        /// </summary>
        public TestSetDiscrepancyReportStatus TestSetDiscrepancyReportStatus
        {
            get { return this._testSetDiscrepancyReportStatus; }
            set { this._testSetDiscrepancyReportStatus = value; }
        }

        // Check to see if TestSetDiscrepancyReportStatus property is set
        internal bool IsSetTestSetDiscrepancyReportStatus()
        {
            return this._testSetDiscrepancyReportStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TestSetDiscrepancyTopErrors. 
        /// <para>
        /// The top 200 error results from the test set discrepancy report.
        /// </para>
        /// </summary>
        public TestSetDiscrepancyErrors TestSetDiscrepancyTopErrors
        {
            get { return this._testSetDiscrepancyTopErrors; }
            set { this._testSetDiscrepancyTopErrors = value; }
        }

        // Check to see if TestSetDiscrepancyTopErrors property is set
        internal bool IsSetTestSetDiscrepancyTopErrors()
        {
            return this._testSetDiscrepancyTopErrors != null;
        }

        /// <summary>
        /// Gets and sets the property TestSetId. 
        /// <para>
        /// The test set Id for the test set discrepancy report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string TestSetId
        {
            get { return this._testSetId; }
            set { this._testSetId = value; }
        }

        // Check to see if TestSetId property is set
        internal bool IsSetTestSetId()
        {
            return this._testSetId != null;
        }

    }
}