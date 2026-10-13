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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// The source of the data the monitor used during the evaluation.
    /// </summary>
    public partial class MonitorDataSource
    {
        /// <summary>
        /// Gets and sets the property DatasetImportJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset import job used to import the data that
        /// initiated the monitor evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DatasetImportJobArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetImportJobArn property is set.
        /// </summary>
        internal bool IsSetDatasetImportJobArn() => this.DatasetImportJobArn != null;

        /// <summary>
        /// Gets and sets the property ForecastArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the forecast the monitor used during the evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ForecastArn { get; set; }

        /// <summary>
        /// Checks to see if the ForecastArn property is set.
        /// </summary>
        internal bool IsSetForecastArn() => this.ForecastArn != null;

        /// <summary>
        /// Gets and sets the property PredictorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the predictor resource you are monitoring.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string PredictorArn { get; set; }

        /// <summary>
        /// Checks to see if the PredictorArn property is set.
        /// </summary>
        internal bool IsSetPredictorArn() => this.PredictorArn != null;
    }
}
