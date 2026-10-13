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
    /// Container for the parameters to the DeleteExperiment operation. Deletes an SageMaker
    /// experiment. All trials associated with the experiment must be deleted first. Use the
    /// <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListTrials.html">ListTrials</a>
    /// API to get a list of the trials associated with the experiment.
    /// </summary>
    public partial class DeleteExperimentRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ExperimentName. 
        /// <para>
        /// The name of the experiment to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 120)]
        public string ExperimentName { get; set; }

        /// <summary>
        /// Checks to see if the ExperimentName property is set.
        /// </summary>
        internal bool IsSetExperimentName() => this.ExperimentName != null;
    }
}
