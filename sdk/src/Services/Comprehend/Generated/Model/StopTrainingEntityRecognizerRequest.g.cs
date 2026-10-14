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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the StopTrainingEntityRecognizer operation. Stops
    /// an entity recognizer training job while in progress. <para> If the training job state
    /// is <c>TRAINING</c>, the job is marked for termination and put into the <c>STOP_REQUESTED</c>
    /// state. If the training job completes before it can be stopped, it is put into the
    /// <c>TRAINED</c>; otherwise the training job is stopped and putted into the <c>STOPPED</c>
    /// state and the service sends back an HTTP 200 response with an empty HTTP body. </para>
    /// </summary>
    public partial class StopTrainingEntityRecognizerRequest : AmazonComprehendRequest
    {
        /// <summary>
        /// Gets and sets the property EntityRecognizerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the entity recognizer currently being
        /// trained.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string EntityRecognizerArn { get; set; }

        /// <summary>
        /// Checks to see if the EntityRecognizerArn property is set.
        /// </summary>
        internal bool IsSetEntityRecognizerArn() => this.EntityRecognizerArn != null;
    }
}
