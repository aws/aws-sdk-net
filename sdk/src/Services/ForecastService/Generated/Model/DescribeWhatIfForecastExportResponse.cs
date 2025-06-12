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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// This is the response object from the DescribeWhatIfForecastExport operation.
    /// </summary>
    public partial class DescribeWhatIfForecastExportResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private DataDestination _destination;
        private long? _estimatedTimeRemainingInMinutes;
        private string _format;
        private DateTime? _lastModificationTime;
        private string _message;
        private string _status;
        private List<string> _whatIfForecastArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _whatIfForecastExportArn;
        private string _whatIfForecastExportName;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the what-if forecast export was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Destination.
        /// </summary>
        public DataDestination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedTimeRemainingInMinutes. 
        /// <para>
        /// The approximate time remaining to complete the what-if forecast export, in minutes.
        /// </para>
        /// </summary>
        public long? EstimatedTimeRemainingInMinutes
        {
            get { return this._estimatedTimeRemainingInMinutes; }
            set { this._estimatedTimeRemainingInMinutes = value; }
        }

        // Check to see if EstimatedTimeRemainingInMinutes property is set
        internal bool IsSetEstimatedTimeRemainingInMinutes()
        {
            return this._estimatedTimeRemainingInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the exported data, CSV or PARQUET.
        /// </para>
        /// </summary>
        [AWSProperty(Max=7)]
        public string Format
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
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The last time the resource was modified. The timestamp depends on the status of the
        /// job:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_PENDING</c> - The <c>CreationTime</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_IN_PROGRESS</c> - The current timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPING</c> - The current timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPED</c> - When the job stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> or <c>CREATE_FAILED</c> - When the job finished or failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime? LastModificationTime
        {
            get { return this._lastModificationTime; }
            set { this._lastModificationTime = value; }
        }

        // Check to see if LastModificationTime property is set
        internal bool IsSetLastModificationTime()
        {
            return this._lastModificationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If an error occurred, an informational message about the error.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the what-if forecast. States include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_PENDING</c>, <c>CREATE_IN_PROGRESS</c>, <c>CREATE_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPING</c>, <c>CREATE_STOPPED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_PENDING</c>, <c>DELETE_IN_PROGRESS</c>, <c>DELETE_FAILED</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <c>Status</c> of the what-if forecast export must be <c>ACTIVE</c> before you
        /// can access the forecast export.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Status
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
        /// Gets and sets the property WhatIfForecastArns. 
        /// <para>
        /// An array of Amazon Resource Names (ARNs) that represent all of the what-if forecasts
        /// exported in this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> WhatIfForecastArns
        {
            get { return this._whatIfForecastArns; }
            set { this._whatIfForecastArns = value; }
        }

        // Check to see if WhatIfForecastArns property is set
        internal bool IsSetWhatIfForecastArns()
        {
            return this._whatIfForecastArns != null && (this._whatIfForecastArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WhatIfForecastExportArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the what-if forecast export.
        /// </para>
        /// </summary>
        [AWSProperty(Max=300)]
        public string WhatIfForecastExportArn
        {
            get { return this._whatIfForecastExportArn; }
            set { this._whatIfForecastExportArn = value; }
        }

        // Check to see if WhatIfForecastExportArn property is set
        internal bool IsSetWhatIfForecastExportArn()
        {
            return this._whatIfForecastExportArn != null;
        }

        /// <summary>
        /// Gets and sets the property WhatIfForecastExportName. 
        /// <para>
        /// The name of the what-if forecast export.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string WhatIfForecastExportName
        {
            get { return this._whatIfForecastExportName; }
            set { this._whatIfForecastExportName = value; }
        }

        // Check to see if WhatIfForecastExportName property is set
        internal bool IsSetWhatIfForecastExportName()
        {
            return this._whatIfForecastExportName != null;
        }

    }
}