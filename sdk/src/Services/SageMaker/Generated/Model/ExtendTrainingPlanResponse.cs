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
    /// This is the response object from the ExtendTrainingPlan operation.
    /// </summary>
    public partial class ExtendTrainingPlanResponse : AmazonWebServiceResponse
    {
        private List<TrainingPlanExtension> _trainingPlanExtensions = AWSConfigs.InitializeCollections ? new List<TrainingPlanExtension>() : null;

        /// <summary>
        /// Gets and sets the property TrainingPlanExtensions. 
        /// <para>
        /// The list of extensions for the training plan, including the newly created extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public List<TrainingPlanExtension> TrainingPlanExtensions
        {
            get { return this._trainingPlanExtensions; }
            set { this._trainingPlanExtensions = value; }
        }

        // Check to see if TrainingPlanExtensions property is set
        internal bool IsSetTrainingPlanExtensions()
        {
            return this._trainingPlanExtensions != null && (this._trainingPlanExtensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}