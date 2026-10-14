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
    /// Provides a summary of the predictor properties that are used in the <a>ListPredictors</a>
    /// operation. To get the complete set of properties, call the <a>DescribePredictor</a>
    /// operation, and provide the listed <c>PredictorArn</c>.
    /// </summary>
    public partial class PredictorSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the model training task was created.
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
        /// The Amazon Resource Name (ARN) of the dataset group that contains the data used to
        /// train the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DatasetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetGroupArn property is set.
        /// </summary>
        internal bool IsSetDatasetGroupArn() => this.DatasetGroupArn != null;

        /// <summary>
        /// Gets and sets the property IsAutoPredictor. 
        /// <para>
        /// Whether AutoPredictor was used to create the predictor.
        /// </para>
        /// </summary>
        public bool? IsAutoPredictor { get; set; }

        /// <summary>
        /// Checks to see if the IsAutoPredictor property is set.
        /// </summary>
        internal bool IsSetIsAutoPredictor() => this.IsAutoPredictor.HasValue;

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
        /// The ARN of the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string PredictorArn { get; set; }

        /// <summary>
        /// Checks to see if the PredictorArn property is set.
        /// </summary>
        internal bool IsSetPredictorArn() => this.PredictorArn != null;

        /// <summary>
        /// Gets and sets the property PredictorName. 
        /// <para>
        /// The name of the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string PredictorName { get; set; }

        /// <summary>
        /// Checks to see if the PredictorName property is set.
        /// </summary>
        internal bool IsSetPredictorName() => this.PredictorName != null;

        /// <summary>
        /// Gets and sets the property ReferencePredictorSummary. 
        /// <para>
        /// A summary of the reference predictor used if the predictor was retrained or upgraded.
        /// </para>
        /// </summary>
        public ReferencePredictorSummary ReferencePredictorSummary { get; set; }

        /// <summary>
        /// Checks to see if the ReferencePredictorSummary property is set.
        /// </summary>
        internal bool IsSetReferencePredictorSummary() => this.ReferencePredictorSummary != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the predictor. States include:
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
        ///  <c>DELETE_PENDING</c>, <c>DELETE_IN_PROGRESS</c>, <c>DELETE_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPING</c>, <c>CREATE_STOPPED</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <c>Status</c> of the predictor must be <c>ACTIVE</c> before you can use the predictor
        /// to create a forecast.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
