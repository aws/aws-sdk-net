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
    /// Provides a summary of the predictor backtest export job properties used in the <a>ListPredictorBacktestExportJobs</a>
    /// operation. To get a complete set of properties, call the <a>DescribePredictorBacktestExportJob</a>
    /// operation, and provide the listed <c>PredictorBacktestExportJobArn</c>.
    /// </summary>
    public partial class PredictorBacktestExportJobSummary
    {
        private DateTime? _creationTime;
        private DataDestination _destination;
        private DateTime? _lastModificationTime;
        private string _message;
        private string _predictorBacktestExportJobArn;
        private string _predictorBacktestExportJobName;
        private string _status;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the predictor backtest export job was created.
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
        /// Information about any errors that may have occurred during the backtest export.
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
        /// Gets and sets the property PredictorBacktestExportJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the predictor backtest export job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string PredictorBacktestExportJobArn
        {
            get { return this._predictorBacktestExportJobArn; }
            set { this._predictorBacktestExportJobArn = value; }
        }

        // Check to see if PredictorBacktestExportJobArn property is set
        internal bool IsSetPredictorBacktestExportJobArn()
        {
            return this._predictorBacktestExportJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property PredictorBacktestExportJobName. 
        /// <para>
        /// The name of the predictor backtest export job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string PredictorBacktestExportJobName
        {
            get { return this._predictorBacktestExportJobName; }
            set { this._predictorBacktestExportJobName = value; }
        }

        // Check to see if PredictorBacktestExportJobName property is set
        internal bool IsSetPredictorBacktestExportJobName()
        {
            return this._predictorBacktestExportJobName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the predictor backtest export job. States include: 
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
        ///  </li> </ul>
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

    }
}