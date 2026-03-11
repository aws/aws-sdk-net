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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ExtendTrainingPlan operation.
    /// Extends an existing training plan by purchasing an extension offering. This allows
    /// you to add additional compute capacity time to your training plan without creating
    /// a new plan or reconfiguring your workloads.
    /// 
    ///  
    /// <para>
    /// To find available extension offerings, use the <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_SearchTrainingPlanOfferings.html">SearchTrainingPlanOfferings</a>
    /// </c> API with the <c>TrainingPlanArn</c> parameter.
    /// </para>
    ///  
    /// <para>
    /// To view the history of extensions for a training plan, use the <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeTrainingPlanExtensionHistory.html">DescribeTrainingPlanExtensionHistory</a>
    /// </c> API.
    /// </para>
    /// </summary>
    public partial class ExtendTrainingPlanRequest : AmazonSageMakerRequest
    {
        private string _trainingPlanExtensionOfferingId;

        /// <summary>
        /// Gets and sets the property TrainingPlanExtensionOfferingId. 
        /// <para>
        /// The unique identifier of the extension offering to purchase. You can retrieve this
        /// ID from the <c>TrainingPlanExtensionOfferings</c> in the response of the <c>SearchTrainingPlanOfferings</c>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrainingPlanExtensionOfferingId
        {
            get { return this._trainingPlanExtensionOfferingId; }
            set { this._trainingPlanExtensionOfferingId = value; }
        }

        // Check to see if TrainingPlanExtensionOfferingId property is set
        internal bool IsSetTrainingPlanExtensionOfferingId()
        {
            return this._trainingPlanExtensionOfferingId != null;
        }

    }
}