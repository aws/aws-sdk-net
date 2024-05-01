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
    /// The source of the data the monitor used during the evaluation.
    /// </summary>
    public partial class MonitorDataSource
    {
        private string _datasetImportJobArn;
        private string _forecastArn;
        private string _predictorArn;

        /// <summary>
        /// Gets and sets the property DatasetImportJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset import job used to import the data that
        /// initiated the monitor evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DatasetImportJobArn
        {
            get { return this._datasetImportJobArn; }
            set { this._datasetImportJobArn = value; }
        }

        // Check to see if DatasetImportJobArn property is set
        internal bool IsSetDatasetImportJobArn()
        {
            return this._datasetImportJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property ForecastArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the forecast the monitor used during the evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ForecastArn
        {
            get { return this._forecastArn; }
            set { this._forecastArn = value; }
        }

        // Check to see if ForecastArn property is set
        internal bool IsSetForecastArn()
        {
            return this._forecastArn != null;
        }

        /// <summary>
        /// Gets and sets the property PredictorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the predictor resource you are monitoring.
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

    }
}