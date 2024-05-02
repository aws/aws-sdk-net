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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
    /// Container for the parameters to the DeleteExternalModel operation.
    /// Removes a SageMaker model from Amazon Fraud Detector.
    /// 
    ///  
    /// <para>
    /// You can remove an Amazon SageMaker model if it is not associated with a detector version.
    /// Removing a SageMaker model disconnects it from Amazon Fraud Detector, but the model
    /// remains available in SageMaker.
    /// </para>
    /// </summary>
    public partial class DeleteExternalModelRequest : AmazonFraudDetectorRequest
    {
        private string _modelEndpoint;

        /// <summary>
        /// Gets and sets the property ModelEndpoint. 
        /// <para>
        /// The endpoint of the Amazon Sagemaker model to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ModelEndpoint
        {
            get { return this._modelEndpoint; }
            set { this._modelEndpoint = value; }
        }

        // Check to see if ModelEndpoint property is set
        internal bool IsSetModelEndpoint()
        {
            return this._modelEndpoint != null;
        }

    }
}