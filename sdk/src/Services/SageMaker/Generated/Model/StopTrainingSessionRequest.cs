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
    /// Container for the parameters to the StopTrainingSession operation.
    /// Stops a running training session and sets the session status to <c>Stopping</c>. After
    /// the session stops, the status changes to <c>Stopped</c>. To delete a stopped session,
    /// use the <c>DeleteTrainingSession</c> operation.
    /// 
    ///  
    /// <para>
    /// The following operations are related to <c>StopTrainingSession</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>CreateTrainingSession</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribeTrainingSession</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeleteTrainingSession</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StopTrainingSessionRequest : AmazonSageMakerRequest
    {
        private string _trainingSessionName;

        /// <summary>
        /// Gets and sets the property TrainingSessionName. 
        /// <para>
        /// The name of the training session to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string TrainingSessionName
        {
            get { return this._trainingSessionName; }
            set { this._trainingSessionName = value; }
        }

        // Check to see if TrainingSessionName property is set
        internal bool IsSetTrainingSessionName()
        {
            return this._trainingSessionName != null;
        }

    }
}