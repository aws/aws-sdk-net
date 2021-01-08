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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Provides a summary of the predictor properties that are used in the <a>ListPredictors</a>
    /// operation. To get the complete set of properties, call the <a>DescribePredictor</a>
    /// operation, and provide the listed <code>PredictorArn</code>.
    /// </summary>
    public partial class PredictorSummary
    {
        private DateTime? _creationTime;
        private string _datasetGroupArn;
        private DateTime? _lastModificationTime;
        private string _message;
        private string _predictorArn;
        private string _predictorName;
        private string _status;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the model training task was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset group that contains the data used to
        /// train the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DatasetGroupArn
        {
            get { return this._datasetGroupArn; }
            set { this._datasetGroupArn = value; }
        }

        // Check to see if DatasetGroupArn property is set
        internal bool IsSetDatasetGroupArn()
        {
            return this._datasetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// Initially, the same as <code>CreationTime</code> (status is <code>CREATE_PENDING</code>).
        /// Updated when training starts (status changed to <code>CREATE_IN_PROGRESS</code>),
        /// and when training is complete (status changed to <code>ACTIVE</code>) or fails (status
        /// changed to <code>CREATE_FAILED</code>).
        /// </para>
        /// </summary>
        public DateTime LastModificationTime
        {
            get { return this._lastModificationTime.GetValueOrDefault(); }
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
        /// Gets and sets the property PredictorArn. 
        /// <para>
        /// The ARN of the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string PredictorArn
        {
            get { return this._predictorArn; }
            set { this._predictorArn = value; }
        }

        // Check to see if PredictorArn property is set
        internal bool IsSetPredictorArn()
        {
            return this._predictorArn != null;
        }

        /// <summary>
        /// Gets and sets the property PredictorName. 
        /// <para>
        /// The name of the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string PredictorName
        {
            get { return this._predictorName; }
            set { this._predictorName = value; }
        }

        // Check to see if PredictorName property is set
        internal bool IsSetPredictorName()
        {
            return this._predictorName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the predictor. States include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ACTIVE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_PENDING</code>, <code>CREATE_IN_PROGRESS</code>, <code>CREATE_FAILED</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE_PENDING</code>, <code>DELETE_IN_PROGRESS</code>, <code>DELETE_FAILED</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_PENDING</code>, <code>UPDATE_IN_PROGRESS</code>, <code>UPDATE_FAILED</code>
        /// 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>Status</code> of the predictor must be <code>ACTIVE</code> before you can
        /// use the predictor to create a forecast.
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

    }
}