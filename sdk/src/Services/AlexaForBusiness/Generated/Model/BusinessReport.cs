/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Usage report with specified parameters.
    /// </summary>
    public partial class BusinessReport
    {
        private DateTime? _deliveryTime;
        private string _downloadUrl;
        private BusinessReportFailureCode _failureCode;
        private BusinessReportS3Location _s3Location;
        private BusinessReportStatus _status;

        /// <summary>
        /// Gets and sets the property DeliveryTime. 
        /// <para>
        /// The time of report delivery.
        /// </para>
        /// </summary>
        public DateTime DeliveryTime
        {
            get { return this._deliveryTime.GetValueOrDefault(); }
            set { this._deliveryTime = value; }
        }

        // Check to see if DeliveryTime property is set
        internal bool IsSetDeliveryTime()
        {
            return this._deliveryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DownloadUrl. 
        /// <para>
        /// The download link where a user can download the report.
        /// </para>
        /// </summary>
        public string DownloadUrl
        {
            get { return this._downloadUrl; }
            set { this._downloadUrl = value; }
        }

        // Check to see if DownloadUrl property is set
        internal bool IsSetDownloadUrl()
        {
            return this._downloadUrl != null;
        }

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The failure code.
        /// </para>
        /// </summary>
        public BusinessReportFailureCode FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property S3Location. 
        /// <para>
        /// The S3 location of the output reports.
        /// </para>
        /// </summary>
        public BusinessReportS3Location S3Location
        {
            get { return this._s3Location; }
            set { this._s3Location = value; }
        }

        // Check to see if S3Location property is set
        internal bool IsSetS3Location()
        {
            return this._s3Location != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the report generation execution (RUNNING, SUCCEEDED, or FAILED).
        /// </para>
        /// </summary>
        public BusinessReportStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}