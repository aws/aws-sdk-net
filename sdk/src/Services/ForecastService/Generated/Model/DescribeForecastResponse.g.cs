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
    /// This is the response object from the DescribeForecast operation.
    /// </summary>
    public partial class DescribeForecastResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the forecast creation task was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The ARN of the dataset group that provided the data used to train the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DatasetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetGroupArn property is set.
        /// </summary>
        internal bool IsSetDatasetGroupArn() => this.DatasetGroupArn != null;

        /// <summary>
        /// Gets and sets the property EstimatedTimeRemainingInMinutes. 
        /// <para>
        /// The estimated time remaining in minutes for the forecast job to complete.
        /// </para>
        /// </summary>
        public long? EstimatedTimeRemainingInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedTimeRemainingInMinutes property is set.
        /// </summary>
        internal bool IsSetEstimatedTimeRemainingInMinutes() => this.EstimatedTimeRemainingInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property ForecastArn. 
        /// <para>
        /// The forecast ARN as specified in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ForecastArn { get; set; }

        /// <summary>
        /// Checks to see if the ForecastArn property is set.
        /// </summary>
        internal bool IsSetForecastArn() => this.ForecastArn != null;

        /// <summary>
        /// Gets and sets the property ForecastName. 
        /// <para>
        /// The name of the forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ForecastName { get; set; }

        /// <summary>
        /// Checks to see if the ForecastName property is set.
        /// </summary>
        internal bool IsSetForecastName() => this.ForecastName != null;

        /// <summary>
        /// Gets and sets the property ForecastTypes. 
        /// <para>
        /// The quantiles at which probabilistic forecasts were generated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> ForecastTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ForecastTypes property is set.
        /// </summary>
        internal bool IsSetForecastTypes() => this.ForecastTypes != null && (this.ForecastTypes.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModificationTime property is set.
        /// </summary>
        internal bool IsSetLastModificationTime() => this.LastModificationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If an error occurred, an informational message about the error.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property PredictorArn. 
        /// <para>
        /// The ARN of the predictor used to generate the forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string PredictorArn { get; set; }

        /// <summary>
        /// Checks to see if the PredictorArn property is set.
        /// </summary>
        internal bool IsSetPredictorArn() => this.PredictorArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the forecast. States include:
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
        /// The <c>Status</c> of the forecast must be <c>ACTIVE</c> before you can query or export
        /// the forecast.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TimeSeriesSelector. 
        /// <para>
        /// The time series to include in the forecast.
        /// </para>
        /// </summary>
        public TimeSeriesSelector TimeSeriesSelector { get; set; }

        /// <summary>
        /// Checks to see if the TimeSeriesSelector property is set.
        /// </summary>
        internal bool IsSetTimeSeriesSelector() => this.TimeSeriesSelector != null;
    }
}
