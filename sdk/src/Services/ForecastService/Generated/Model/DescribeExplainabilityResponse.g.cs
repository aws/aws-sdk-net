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
    /// This is the response object from the DescribeExplainability operation.
    /// </summary>
    public partial class DescribeExplainabilityResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the Explainability resource was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataSource.
        /// </summary>
        public DataSource DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property EnableVisualization. 
        /// <para>
        /// Whether the visualization was enabled for the Explainability resource.
        /// </para>
        /// </summary>
        public bool? EnableVisualization { get; set; }

        /// <summary>
        /// Checks to see if the EnableVisualization property is set.
        /// </summary>
        internal bool IsSetEnableVisualization() => this.EnableVisualization.HasValue;

        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// If <c>TimePointGranularity</c> is set to <c>SPECIFIC</c>, the last time point in the
        /// Explainability.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 19)]
        public string EndDateTime { get; set; }

        /// <summary>
        /// Checks to see if the EndDateTime property is set.
        /// </summary>
        internal bool IsSetEndDateTime() => this.EndDateTime != null;

        /// <summary>
        /// Gets and sets the property EstimatedTimeRemainingInMinutes. 
        /// <para>
        /// The estimated time remaining in minutes for the <a>CreateExplainability</a> job to
        /// complete.
        /// </para>
        /// </summary>
        public long? EstimatedTimeRemainingInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedTimeRemainingInMinutes property is set.
        /// </summary>
        internal bool IsSetEstimatedTimeRemainingInMinutes() => this.EstimatedTimeRemainingInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property ExplainabilityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Explainability.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ExplainabilityArn { get; set; }

        /// <summary>
        /// Checks to see if the ExplainabilityArn property is set.
        /// </summary>
        internal bool IsSetExplainabilityArn() => this.ExplainabilityArn != null;

        /// <summary>
        /// Gets and sets the property ExplainabilityConfig. 
        /// <para>
        /// The configuration settings that define the granularity of time series and time points
        /// for the Explainability.
        /// </para>
        /// </summary>
        public ExplainabilityConfig ExplainabilityConfig { get; set; }

        /// <summary>
        /// Checks to see if the ExplainabilityConfig property is set.
        /// </summary>
        internal bool IsSetExplainabilityConfig() => this.ExplainabilityConfig != null;

        /// <summary>
        /// Gets and sets the property ExplainabilityName. 
        /// <para>
        /// The name of the Explainability.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ExplainabilityName { get; set; }

        /// <summary>
        /// Checks to see if the ExplainabilityName property is set.
        /// </summary>
        internal bool IsSetExplainabilityName() => this.ExplainabilityName != null;

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
        /// If an error occurred, a message about the error.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Predictor or Forecast used to create the Explainability
        /// resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property Schema.
        /// </summary>
        public Schema Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// If <c>TimePointGranularity</c> is set to <c>SPECIFIC</c>, the first time point in
        /// the Explainability.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 19)]
        public string StartDateTime { get; set; }

        /// <summary>
        /// Checks to see if the StartDateTime property is set.
        /// </summary>
        internal bool IsSetStartDateTime() => this.StartDateTime != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Explainability resource. States include: 
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
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
