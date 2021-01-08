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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteVariable operation.
    /// Deletes a variable.
    /// 
    ///  
    /// <para>
    /// You can't delete variables that are included in an event type in Amazon Fraud Detector.
    /// </para>
    ///  
    /// <para>
    /// Amazon Fraud Detector automatically deletes model output variables and SageMaker model
    /// output variables when you delete the model. You can't delete these variables manually.
    /// </para>
    ///  
    /// <para>
    /// When you delete a variable, Amazon Fraud Detector permanently deletes that variable
    /// from the evaluation history, and the data is no longer stored in Amazon Fraud Detector.
    /// </para>
    /// </summary>
    public partial class DeleteVariableRequest : AmazonFraudDetectorRequest
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the variable to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}