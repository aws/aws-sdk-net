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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// This is the response object from the GetModelVersion operation.
    /// </summary>
    public partial class GetModelVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The model version ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ExternalEventsDetail. 
        /// <para>
        /// The details of the external events data used for training the model version. This
        /// will be populated if the <c>trainingDataSource</c> is <c>EXTERNAL_EVENTS</c> 
        /// </para>
        /// </summary>
        public ExternalEventsDetail ExternalEventsDetail { get; set; }

        /// <summary>
        /// Checks to see if the ExternalEventsDetail property is set.
        /// </summary>
        internal bool IsSetExternalEventsDetail() => this.ExternalEventsDetail != null;

        /// <summary>
        /// Gets and sets the property IngestedEventsDetail. 
        /// <para>
        /// The details of the ingested events data used for training the model version. This
        /// will be populated if the <c>trainingDataSource</c> is <c>INGESTED_EVENTS</c>.
        /// </para>
        /// </summary>
        public IngestedEventsDetail IngestedEventsDetail { get; set; }

        /// <summary>
        /// Checks to see if the IngestedEventsDetail property is set.
        /// </summary>
        internal bool IsSetIngestedEventsDetail() => this.IngestedEventsDetail != null;

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The model ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ModelId { get; set; }

        /// <summary>
        /// Checks to see if the ModelId property is set.
        /// </summary>
        internal bool IsSetModelId() => this.ModelId != null;

        /// <summary>
        /// Gets and sets the property ModelType. 
        /// <para>
        /// The model type.
        /// </para>
        /// </summary>
        public ModelTypeEnum ModelType { get; set; }

        /// <summary>
        /// Checks to see if the ModelType property is set.
        /// </summary>
        internal bool IsSetModelType() => this.ModelType != null;

        /// <summary>
        /// Gets and sets the property ModelVersionNumber. 
        /// <para>
        /// The model version number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 7)]
        public string ModelVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the ModelVersionNumber property is set.
        /// </summary>
        internal bool IsSetModelVersionNumber() => this.ModelVersionNumber != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The model version status.
        /// </para>
        ///  
        /// <para>
        /// Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TRAINING_IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRAINING_COMPLETE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVATE_REQUESTED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVATE_IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVATE_REQUESTED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVATE_IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TrainingDataSchema. 
        /// <para>
        /// The training data schema.
        /// </para>
        /// </summary>
        public TrainingDataSchema TrainingDataSchema { get; set; }

        /// <summary>
        /// Checks to see if the TrainingDataSchema property is set.
        /// </summary>
        internal bool IsSetTrainingDataSchema() => this.TrainingDataSchema != null;

        /// <summary>
        /// Gets and sets the property TrainingDataSource. 
        /// <para>
        /// The training data source.
        /// </para>
        /// </summary>
        public TrainingDataSourceEnum TrainingDataSource { get; set; }

        /// <summary>
        /// Checks to see if the TrainingDataSource property is set.
        /// </summary>
        internal bool IsSetTrainingDataSource() => this.TrainingDataSource != null;
    }
}
