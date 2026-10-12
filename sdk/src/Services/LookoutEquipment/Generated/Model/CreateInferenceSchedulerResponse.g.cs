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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the CreateInferenceScheduler operation.
    /// </summary>
    public partial class CreateInferenceSchedulerResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property InferenceSchedulerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the inference scheduler being created. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string InferenceSchedulerArn { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSchedulerArn property is set.
        /// </summary>
        internal bool IsSetInferenceSchedulerArn() => this.InferenceSchedulerArn != null;

        /// <summary>
        /// Gets and sets the property InferenceSchedulerName. 
        /// <para>
        /// The name of inference scheduler being created. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string InferenceSchedulerName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSchedulerName property is set.
        /// </summary>
        internal bool IsSetInferenceSchedulerName() => this.InferenceSchedulerName != null;

        /// <summary>
        /// Gets and sets the property ModelQuality. 
        /// <para>
        /// Provides a quality assessment for a model that uses labels. If Lookout for Equipment
        /// determines that the model quality is poor based on training metrics, the value is
        /// <c>POOR_QUALITY_DETECTED</c>. Otherwise, the value is <c>QUALITY_THRESHOLD_MET</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the model is unlabeled, the model quality can't be assessed and the value of <c>ModelQuality</c>
        /// is <c>CANNOT_DETERMINE_QUALITY</c>. In this situation, you can get a model quality
        /// assessment by adding labels to the input dataset and retraining the model.
        /// </para>
        ///  
        /// <para>
        /// For information about using labels with your models, see <a href="https://docs.aws.amazon.com/lookout-for-equipment/latest/ug/understanding-labeling.html">Understanding
        /// labeling</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about improving the quality of a model, see <a href="https://docs.aws.amazon.com/lookout-for-equipment/latest/ug/best-practices.html">Best
        /// practices with Amazon Lookout for Equipment</a>.
        /// </para>
        /// </summary>
        public ModelQuality ModelQuality { get; set; }

        /// <summary>
        /// Checks to see if the ModelQuality property is set.
        /// </summary>
        internal bool IsSetModelQuality() => this.ModelQuality != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of the <c>CreateInferenceScheduler</c> operation. 
        /// </para>
        /// </summary>
        public InferenceSchedulerStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
