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
    /// Container for the parameters to the DeleteTrainingSession operation. Deletes a training
    /// session. You must stop a running session before deleting it. Use the <c>StopTrainingSession</c>
    /// operation to stop the session first. <para> The following operations are related to
    /// <c>DeleteTrainingSession</c>: </para> <ul> <li> <para> <c>CreateTrainingSession</c>
    /// </para> </li> <li> <para> <c>DescribeTrainingSession</c> </para> </li> <li> <para>
    /// <c>StopTrainingSession</c> </para> </li> </ul>
    /// </summary>
    public partial class DeleteTrainingSessionRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property TrainingSessionName. 
        /// <para>
        /// The name of the training session to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string TrainingSessionName { get; set; }

        /// <summary>
        /// Checks to see if the TrainingSessionName property is set.
        /// </summary>
        internal bool IsSetTrainingSessionName() => this.TrainingSessionName != null;
    }
}
