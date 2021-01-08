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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBusinessReportSchedule operation.
    /// Updates the configuration of the report delivery schedule with the specified schedule
    /// ARN.
    /// </summary>
    public partial class UpdateBusinessReportScheduleRequest : AmazonAlexaForBusinessRequest
    {
        private BusinessReportFormat _format;
        private BusinessReportRecurrence _recurrence;
        private string _s3BucketName;
        private string _s3KeyPrefix;
        private string _scheduleArn;
        private string _scheduleName;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the generated report (individual CSV files or zipped files of individual
        /// files).
        /// </para>
        /// </summary>
        public BusinessReportFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Recurrence. 
        /// <para>
        /// The recurrence of the reports.
        /// </para>
        /// </summary>
        public BusinessReportRecurrence Recurrence
        {
            get { return this._recurrence; }
            set { this._recurrence = value; }
        }

        // Check to see if Recurrence property is set
        internal bool IsSetRecurrence()
        {
            return this._recurrence != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The S3 location of the output reports.
        /// </para>
        /// </summary>
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// The S3 key where the report is delivered.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string S3KeyPrefix
        {
            get { return this._s3KeyPrefix; }
            set { this._s3KeyPrefix = value; }
        }

        // Check to see if S3KeyPrefix property is set
        internal bool IsSetS3KeyPrefix()
        {
            return this._s3KeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleArn. 
        /// <para>
        /// The ARN of the business report schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScheduleArn
        {
            get { return this._scheduleArn; }
            set { this._scheduleArn = value; }
        }

        // Check to see if ScheduleArn property is set
        internal bool IsSetScheduleArn()
        {
            return this._scheduleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleName. 
        /// <para>
        /// The name identifier of the schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string ScheduleName
        {
            get { return this._scheduleName; }
            set { this._scheduleName = value; }
        }

        // Check to see if ScheduleName property is set
        internal bool IsSetScheduleName()
        {
            return this._scheduleName != null;
        }

    }
}