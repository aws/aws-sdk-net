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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// This is the response object from the DescribeMetricsExport operation.
    /// </summary>
    public partial class DescribeMetricsExportResponse : AmazonWebServiceResponse
    {
        private string _errorMessage;
        private S3Location _exportLocation;
        private string _metricsExportId;
        private MetricsExportStatusType _status;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Explains the error that occurred while exporting the metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ExportLocation. 
        /// <para>
        /// Specifies the name of the Amazon S3 bucket where the exported metrics is stored.
        /// </para>
        /// </summary>
        public S3Location ExportLocation
        {
            get { return this._exportLocation; }
            set { this._exportLocation = value; }
        }

        // Check to see if ExportLocation property is set
        internal bool IsSetExportLocation()
        {
            return this._exportLocation != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsExportId. 
        /// <para>
        /// Identifier for the metrics export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string MetricsExportId
        {
            get { return this._metricsExportId; }
            set { this._metricsExportId = value; }
        }

        // Check to see if MetricsExportId property is set
        internal bool IsSetMetricsExportId()
        {
            return this._metricsExportId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of the metrics export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricsExportStatusType Status
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