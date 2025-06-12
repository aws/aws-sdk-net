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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetDeclarativePoliciesReportSummary operation.
    /// </summary>
    public partial class GetDeclarativePoliciesReportSummaryResponse : AmazonWebServiceResponse
    {
        private List<AttributeSummary> _attributeSummaries = AWSConfigs.InitializeCollections ? new List<AttributeSummary>() : null;
        private DateTime? _endTime;
        private int? _numberOfAccounts;
        private int? _numberOfFailedAccounts;
        private string _reportId;
        private string _s3Bucket;
        private string _s3Prefix;
        private DateTime? _startTime;
        private string _targetId;

        /// <summary>
        /// Gets and sets the property AttributeSummaries. 
        /// <para>
        /// The attributes described in the report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeSummary> AttributeSummaries
        {
            get { return this._attributeSummaries; }
            set { this._attributeSummaries = value; }
        }

        // Check to see if AttributeSummaries property is set
        internal bool IsSetAttributeSummaries()
        {
            return this._attributeSummaries != null && (this._attributeSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when the report generation ended.
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
        /// Gets and sets the property NumberOfAccounts. 
        /// <para>
        /// The total number of accounts associated with the specified <c>targetId</c>.
        /// </para>
        /// </summary>
        public int? NumberOfAccounts
        {
            get { return this._numberOfAccounts; }
            set { this._numberOfAccounts = value; }
        }

        // Check to see if NumberOfAccounts property is set
        internal bool IsSetNumberOfAccounts()
        {
            return this._numberOfAccounts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfFailedAccounts. 
        /// <para>
        /// The number of accounts where attributes could not be retrieved in any Region.
        /// </para>
        /// </summary>
        public int? NumberOfFailedAccounts
        {
            get { return this._numberOfFailedAccounts; }
            set { this._numberOfFailedAccounts = value; }
        }

        // Check to see if NumberOfFailedAccounts property is set
        internal bool IsSetNumberOfFailedAccounts()
        {
            return this._numberOfFailedAccounts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// The ID of the report.
        /// </para>
        /// </summary>
        public string ReportId
        {
            get { return this._reportId; }
            set { this._reportId = value; }
        }

        // Check to see if ReportId property is set
        internal bool IsSetReportId()
        {
            return this._reportId != null;
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket where the report is located.
        /// </para>
        /// </summary>
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The prefix for your S3 object.
        /// </para>
        /// </summary>
        public string S3Prefix
        {
            get { return this._s3Prefix; }
            set { this._s3Prefix = value; }
        }

        // Check to see if S3Prefix property is set
        internal bool IsSetS3Prefix()
        {
            return this._s3Prefix != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when the report generation started.
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
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The root ID, organizational unit ID, or account ID.
        /// </para>
        ///  
        /// <para>
        /// Format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For root: <c>r-ab12</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For OU: <c>ou-ab12-cdef1234</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For account: <c>123456789012</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

    }
}