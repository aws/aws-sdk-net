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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the SearchTrainingPlanOfferings operation.
    /// </summary>
    public partial class SearchTrainingPlanOfferingsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property TrainingPlanExtensionOfferings. 
        /// <para>
        /// A list of extension offerings available for the specified training plan. These offerings
        /// can be used with the <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ExtendTrainingPlan.html">ExtendTrainingPlan</a>
        /// </c> API to extend an existing training plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0)]
        public List<TrainingPlanExtensionOffering> TrainingPlanExtensionOfferings { get; set; } = AWSConfigs.InitializeCollections ? new List<TrainingPlanExtensionOffering>() : null;

        /// <summary>
        /// Checks to see if the TrainingPlanExtensionOfferings property is set.
        /// </summary>
        internal bool IsSetTrainingPlanExtensionOfferings() => this.TrainingPlanExtensionOfferings != null && (this.TrainingPlanExtensionOfferings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrainingPlanOfferings. 
        /// <para>
        /// A list of training plan offerings that match the search criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public List<TrainingPlanOffering> TrainingPlanOfferings { get; set; } = AWSConfigs.InitializeCollections ? new List<TrainingPlanOffering>() : null;

        /// <summary>
        /// Checks to see if the TrainingPlanOfferings property is set.
        /// </summary>
        internal bool IsSetTrainingPlanOfferings() => this.TrainingPlanOfferings != null && (this.TrainingPlanOfferings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
